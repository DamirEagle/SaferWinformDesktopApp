using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SaferAlg.Safer
{
    public class ModeEcb : ModeBase, IMode
    {

        public string Decrypt(Safer sfr, IProgress<int> progress, CancellationToken token, string iv = "12345678", int n = 8)
        {
            List<byte[]> listOfArraysOfEncryptedBytes = GetListOfArraysOfEncryptedBytesFromText(sfr.Text, 8);
            string decryptedText = "";
            for (int i = 0; i < listOfArraysOfEncryptedBytes.Count; i++)
            {
                sfr.Text = System.Text.Encoding.Default.GetString(listOfArraysOfEncryptedBytes[i]);
                var tempBytes = sfr.decrypt();
                decryptedText += System.Text.Encoding.Default.GetString(tempBytes).Replace("\0", "");
                SetProgress(progress, (decimal)i / (decimal)listOfArraysOfEncryptedBytes.Count);
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
            var source = sfr.Text;
            var sourceLength = GetTextBlockLength(source, n);
            for (var i = 0; i < sourceLength; i++)
            {
                var sourceBlock = GetTextBlockNByte(source, i, n);
                sfr.Text = System.Text.Encoding.Default.GetString(sourceBlock);
                var tempRes = sfr.encrypt();
                encryptedText += System.Text.Encoding.Default.GetString(tempRes);
                SetProgress(progress, (decimal)i / (decimal)sourceLength);
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
            }
            return encryptedText;
        }
    }
}
