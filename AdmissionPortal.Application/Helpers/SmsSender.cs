using AdmissionPortal.Application.Interface;
using AdmissionPortal.Domain.Dto;
using Newtonsoft.Json;
using System.Text;

namespace AdmissionPortal.Application.Helpers
{
    public class SmsSender : ISMSSender
    {
        private readonly SmsConfiguration _smsConfig;

        public SmsSender(SmsConfiguration smsConfig)
        {
            _smsConfig = smsConfig;
        }

        public async Task<bool> SendSmsAsync()
        {
            //reference : https://github.com/4jawalycom/4jawaly.com_bulk_sms/blob/main/mvc/Controllers/HomeController.cs
            //https://github.com/4jawalycom/4jawaly.com_bulk_sms/blob/main/C%23/example/send.cs


            using (var httpClient = new HttpClient())
            {
                try
                {
                    string url=_smsConfig.Url;
                    var credentials = _smsConfig.Apikey + ":" + _smsConfig.Apisecret;

                    string no = "+917736938788" ;
                    List<string> numberList = no.Split(',').ToList();

                    List<message> messages = new List<message>();
                    message messageSend = new message();
                    messageSend.text = "hhhhjihkjjhkjkjkjk";
                    messageSend.numbers = numberList;
                    messages.Add(messageSend);

                    var sendData = new SendData
                    {
                        messages = messages,
                        globals = new Globals
                        {
                            number_iso = "SA",
                            sender = "test"
                        }
                    };

                    //var message = new
                    //{
                    //    text = "test",
                    //    numbers = new string[] { "7736938788" },
                    //    sender="test"
                    //};
                    var content = new StringContent(JsonConvert.SerializeObject(sendData), Encoding.UTF8, "application/json");
                    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials)));
                    var response = await httpClient.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch
                {
                    //log an error message or throw an exception or both.
                    throw;
                }
                
            }
        }

       
    }
}


