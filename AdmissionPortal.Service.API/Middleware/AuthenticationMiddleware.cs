using AdmissionPortal.Application.Extensions;
using AdmissionPortal.Application.Feature.Login.Commands;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Service.API;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace AdmissionPortal.Service.API
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;
        public AuthenticationMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;

        }
        public async Task Invoke(HttpContext httpContext, IApplicationUserRepository applicationUserRepository)
        {

            if (httpContext.Request.Path == "/api/login" && httpContext.Request.Method == HttpMethods.Post)
            {
                var jsonData = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();
                LoginCommand loginDetails = JsonConvert.DeserializeObject<LoginCommand>(jsonData);
                if (string.IsNullOrEmpty(loginDetails.Username) && string.IsNullOrEmpty(loginDetails.Password))
                {
                    httpContext.Response.StatusCode = 401;
                }
                else
                {
                    if (await IsValidUser(loginDetails.Username, loginDetails.Password, applicationUserRepository))
                    {
                        var token = GenerateJwtToken(loginDetails.Username);
                        httpContext.Request.Headers.Add("Authorization", $"Bearer {token}");
                    }
                    else
                    {
                        httpContext.Response.StatusCode = 401;
                    }
                }
            }
            else
            {
                await _next(httpContext);
            }
        }

        private async Task<bool> IsValidUser(string username, string password, IApplicationUserRepository applicationUserRepository)
        {
            bool isValidUser = await applicationUserRepository.IsValidUserName(username);
            string dbPassword = await applicationUserRepository.GetPassword(username);
            bool isValidpassword = dbPassword.Base64Decode() == password;
            return isValidUser && isValidpassword;
        }

        private string GenerateJwtToken(string username)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _configuration["JwtSettings:Issuer"],
                _configuration["JwtSettings:Audience"],
                new[]
                {
                new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Name, username),
                },
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
// Extension method used to add the middleware to the HTTP request pipeline.
public static class AuthenticationMiddlewareExtensions
{
    public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<AuthenticationMiddleware>();
    }
}

