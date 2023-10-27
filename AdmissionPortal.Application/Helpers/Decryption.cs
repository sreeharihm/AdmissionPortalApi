using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionPortal.Application.Helpers
{
    public class Decryption
    {        public static string Base64Decode(string encodedInput)
        {
            byte[] decodedBytes = Convert.FromBase64String(encodedInput);
            return Encoding.UTF8.GetString(decodedBytes);
        }
    }
}
