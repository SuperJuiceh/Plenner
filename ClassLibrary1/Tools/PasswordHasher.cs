using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace DataLab.Tools
{
    public static class PasswordHasher
    {

        public static string hashPassword(string password)
        {
            IBuffer cryptBuffer = CryptographicBuffer.ConvertStringToBinary(password, BinaryStringEncoding.Utf8);

            HashAlgorithmProvider hap = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Sha256);

            IBuffer hashBuffer = hap.HashData(cryptBuffer);

            if (hap.HashLength != hashBuffer.Length)
            {
                Debug.WriteLine("Cannot hash");
                throw new CannotHashPasswordException();
            }

            return CryptographicBuffer.EncodeToBase64String(hashBuffer);

        }

        

    }

    public class CannotHashPasswordException: Exception {
        public CannotHashPasswordException()
        {
        }


    }
}
