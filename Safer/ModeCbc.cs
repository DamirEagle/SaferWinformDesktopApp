using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SaferAlg.Safer
{
    class ModeCbc : ModeBase, IMode
    {
        public string Encrypt(Safer sfr, IProgress<int> progress, CancellationToken token, string iv = "12345678", int n = 8)
        {
            var encryptedText = "";
            var listOfArraysOfEncryptedBytes = new List<byte[]>();
            byte[] ivBytes = Encoding.Default.GetBytes(iv);
            string source = sfr.Text;
            byte[] tempBytes = new byte[n];
            for (int i = 0; i < GetTextBlockLength(source, n); i++)
            {
                var sourceBlock = GetTextBlockNByte(source, i, n);
                for (int j = 0; j < sourceBlock.Length; j++)
                {
                    if (i == 0)
                    {
                        tempBytes[j] = XOR(ivBytes[j], sourceBlock[j]);
                    }
                    else
                    {
                        tempBytes[j] = XOR(listOfArraysOfEncryptedBytes[i - 1][j], sourceBlock[j]);
                    }
                }
                sfr.Text = System.Text.Encoding.Default.GetString(tempBytes);
                listOfArraysOfEncryptedBytes.Add(sfr.encrypt());
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
            }

            encryptedText = GetStringFromListOfArrays(listOfArraysOfEncryptedBytes);
            return encryptedText;
        }

        public string Decrypt(Safer sfr, IProgress<int> progress, CancellationToken token, string iv = "12345678", int n = 8)
        {
            List<byte[]> listOfArraysOfEncryptedBytes = GetListOfArraysOfEncryptedBytesFromText(sfr.Text);
            string decryptedText = "";
            byte[] ivBytes = Encoding.Default.GetBytes(iv);
            for (int i = 0; i < listOfArraysOfEncryptedBytes.Count; i++)
            {
                sfr.Text = System.Text.Encoding.Default.GetString(listOfArraysOfEncryptedBytes[i]);
                var tempBytes = sfr.decrypt();

                for (int j = 0; j < tempBytes.Length; j++)
                {
                    if (i == 0)
                    {
                        tempBytes[j] = XOR(ivBytes[j], tempBytes[j]);
                    }
                    else
                    {
                        tempBytes[j] = XOR(listOfArraysOfEncryptedBytes[i - 1][j], tempBytes[j]);
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
    }
}
