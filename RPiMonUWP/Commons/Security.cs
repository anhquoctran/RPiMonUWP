﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;


namespace RPiMonUWP.Commons
{
    public class Security
    {
        private string AES_Key = "Y+3xQDLPWalRKK3U/JuabsJNnuEO91zRiOH5gjgOqck=";
        private string AES_IV = "15CV1/ZOnVI3rY4wk4INBg==";
        private IBuffer m_iv = null;
        private CryptographicKey m_key;

        public Security()
        {
            IBuffer key = Convert.FromBase64String(AES_Key).AsBuffer();
            m_iv = Convert.FromBase64String(AES_IV).AsBuffer();
            SymmetricKeyAlgorithmProvider provider = SymmetricKeyAlgorithmProvider.OpenAlgorithm(SymmetricAlgorithmNames.AesCbcPkcs7);
            m_key = provider.CreateSymmetricKey(key);
        }

        public byte[] Encrypt(byte[] input)
        {

            IBuffer bufferMsg = CryptographicBuffer.ConvertStringToBinary(Encoding.ASCII.GetString(input), BinaryStringEncoding.Utf8);
            IBuffer bufferEncrypt = CryptographicEngine.Encrypt(m_key, bufferMsg, m_iv);
            return bufferEncrypt.ToArray();
        }

        public byte[] Decrypt(byte[] input)
        {
            IBuffer bufferDecrypt = CryptographicEngine.Decrypt(m_key, input.AsBuffer(), m_iv);
            return bufferDecrypt.ToArray();
        }
    }
}
