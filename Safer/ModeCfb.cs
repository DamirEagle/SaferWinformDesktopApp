using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SaferAlg.Safer
{
    class ModeCfb: ModeBase, IMode
    {
        public string Decrypt(Safer sfr, IProgress<int> progress, CancellationToken token, string iv = "12345678", int n = 8)
        {
            List<byte[]> listOfArraysOfEncryptedBytes = GetListOfArraysOfEncryptedBytesFromText(sfr.Text);
            string decryptedText = "";
            byte[] ivСipherBytes = new byte[n];
            byte[] tempBytes = new byte[n];

            for (int i = 0; i < listOfArraysOfEncryptedBytes.Count; i++)
            {
                if (i == 0)
                {
                    sfr.Text = iv;
                    ivСipherBytes = sfr.encrypt();
                }
                else
                {
                    sfr.Text = System.Text.Encoding.Default.GetString(listOfArraysOfEncryptedBytes[i - 1]);
                    tempBytes = sfr.encrypt();
                }
                var sourceBlock = listOfArraysOfEncryptedBytes[i];

                for (int j = 0; j < tempBytes.Length; j++)
                {
                    if (i == 0)
                    {
                        tempBytes[j] = XOR(sourceBlock[j], ivСipherBytes[j]);
                    }
                    else
                    {
                        tempBytes[j] = XOR(sourceBlock[j], tempBytes[j]);
                    }
                }
                decryptedText += System.Text.Encoding.Default.GetString(tempBytes).Replace("\0", "");
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
            }
            return decryptedText;
        }

        public string Encrypt(Safer sfr, IProgress<int> progress, CancellationToken token, string iv = "12345678", int n = 8)
        {
            var encryptedText = "";
            var listOfArraysOfEncryptedBytes = new List<byte[]>();
            var ivСipherBytes = new byte[n];
            string source = sfr.Text;
            int sourceLength = GetTextBlockLength(sfr.Text, n);
            byte[] tempBytes = new byte[n];

            for (int i = 0; i < sourceLength; i++)
            {
                if (i == 0)
                {
                    sfr.Text = iv;
                    ivСipherBytes = sfr.encrypt();
                }
                else
                {
                    sfr.Text = System.Text.Encoding.Default.GetString(listOfArraysOfEncryptedBytes[i - 1]);
                    tempBytes = sfr.encrypt();
                }
                var sourceBlock = GetTextBlockNByte(source, i, n);

                for (int j = 0; j < sourceBlock.Length; j++)
                {
                    if (i == 0)
                    {
                        tempBytes[j] = XOR(sourceBlock[j], ivСipherBytes[j]);
                    }
                    else
                    {
                        tempBytes[j] = XOR(sourceBlock[j], tempBytes[j]);
                    }
                }
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
                listOfArraysOfEncryptedBytes.Add(tempBytes);
            }
            encryptedText = GetStringFromListOfArrays(listOfArraysOfEncryptedBytes);

            return encryptedText;
        }
    }
}
