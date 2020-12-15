using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SaferAlg.Safer
{
    public interface IMode
    {
        string Encrypt(Safer sfr, IProgress<int> progress, CancellationToken token, string iv = "12345678", int n = 8);
        string Decrypt(Safer sfr, IProgress<int> progress, CancellationToken token, string iv = "12345678", int n = 8);
    }
}
