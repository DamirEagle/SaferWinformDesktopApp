using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaferAlg.Safer
{
    public class ModeBase
    {
        public static void SetProgress(IProgress<int> progressReporter, decimal progress)
        {
            decimal i = 0.05m;
            switch (progress)
            {
                case var _ when (Math.Abs(progress - 0.1m) < i):
                    progressReporter.Report((int)(progress*100));
                    break;
                case var _ when (Math.Abs(progress - 0.2m) < i):
                    progressReporter.Report((int)(progress * 100));
                    break;
                case var _ when (Math.Abs(progress - 0.3m) < i):
                    progressReporter.Report((int)(progress * 100));

                    break;
                case var _ when (Math.Abs(progress - 0.4m) < i):
                    progressReporter.Report((int)(progress * 100));

                    break;
                case var _ when (Math.Abs(progress - 0.5m) < i):
                    progressReporter.Report((int)(progress * 100));

                    break;
                case var _ when (Math.Abs(progress - 0.6m) < i):
                    progressReporter.Report((int)(progress * 100));
                    break;
                case var _ when (Math.Abs(progress - 0.7m) < i):
                    progressReporter.Report((int)(progress * 100));

                    break;
                case var _ when (Math.Abs(progress - 0.8m) < i):
                    progressReporter.Report((int)(progress * 100));

                    break;
                case var _ when (Math.Abs(progress - 0.9m) < i):
                    progressReporter.Report((int)(progress * 100));

                    break;
                default:
                    //some code
                    break;
            }
        }
        public static List<byte[]> GetListOfArraysOfEncryptedBytesFromText(string text, int blockSize = 8)
        {
            List<byte[]> listOfArraysOfEncryptedBytes = new List<byte[]>();
            for (int i = 0; i < GetTextBlockLength(text, blockSize); i++)
            {
                listOfArraysOfEncryptedBytes.Add(GetTextBlockNByte(text, i, blockSize));
            }

            return listOfArraysOfEncryptedBytes;
        }

        public static int GetTextBlockLength(string source, int n = 8)
        {
            byte[] b = Encoding.Default.GetBytes(source);
            if (b.Length % n == 0)
                return b.Length / n;
            else
                return b.Length / n + 1;
        }
        // XOR
        public static byte XOR(byte text, byte key)
        {
            var test1 = Convert.ToInt32(text);
            var test2 = Convert.ToInt32(key);
            return Convert.ToByte(Convert.ToInt32(text) ^ Convert.ToInt32(key));
        }

        // get 8 byte ration unencrypted data
        public static byte[] GetTextBlockNByte(string source, int blockNumber, int n = 8)
        {
            byte[] b = Encoding.Default.GetBytes(source);
            byte[] resultBlock = new byte[n];
            int firstByte = blockNumber * n;
            int j = 0;
            for (int i = firstByte; i < firstByte + n; i++)
            {
                if (i < b.Length)
                {
                    resultBlock[j] = b[i];
                    j++;
                }
                else
                {
                    break;
                }
            }
            return resultBlock;
        }
        public static string GetStringFromListOfArrays(IEnumerable<byte[]> ListOfArrays)
        {
            var text = "";
            foreach (var array in ListOfArrays)
            {
                text += System.Text.Encoding.Default.GetString(array);
            }
            return text;
        }

    }
}
