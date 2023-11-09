using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionPortal.Infra.Data
{
    public static class StringExtensions
    {
        public static string GetLastFourCharacters(this string data)
        {
            int length = data.Length;
            int offset = Math.Max(0, length - 4); ;
            return data.Substring(offset);
        }
        public static string Base64Decode(this string encodedInput)
        {
            byte[] decodedBytes = Convert.FromBase64String(encodedInput);
            return Encoding.UTF8.GetString(decodedBytes);
        }
        public static string Base64Encode(this string input)
        {
            byte[] bytesToEncode = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(bytesToEncode);
        }
    }
}
