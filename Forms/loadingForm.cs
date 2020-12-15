using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaferAlg.Safer;

namespace SaferAlg.Forms
{
    public partial class loadingForm : Form
    {
        private readonly Safer.Safer _sfr;
        private readonly string _iv;
        private readonly int _n;
        private readonly IMode _currentMode;
        private readonly string _path;
        private readonly string _action;
        private readonly CancellationTokenSource _token;

        public loadingForm(Safer.Safer sfr, string IV, int N, IMode currentMode, string path, string action)
        {
            _sfr = sfr;
            _iv = IV;
            _n = N;
            _currentMode = currentMode;
            _path = path;
            _action = action;
            _token = new CancellationTokenSource();
            InitializeComponent();
        }

        private void loadingForm_Load(object sender, EventArgs e)
        {
            try
            {
                circularProgressBar1.Value = 0;
                if (_action == "encrypt")
                {
                    labelFrom.Text = "From: " + Path.GetFileName(_path);
                    labelTo.Text = "To: " + Path.GetFileName(_path) + ".safer";
                    Encrypt();
                }
                else
                {
                    labelFrom.Text = "From: " + Path.GetFileName(_path);
                    labelTo.Text = "To: " + Path.GetFileName(_path)?.Replace(".safer", "");
                    Decrypt();
                }
            }
            catch
            {
                _token.Dispose();
                MessageBox.Show("Error");
                this.Close();
            }
        }

        private async void Encrypt()
        {
            try
            {
                var token = _token.Token;
                System.Diagnostics.Stopwatch objStopwatch = new System.Diagnostics.Stopwatch();
                objStopwatch.Start();
                var progress = new Progress<int>(s =>
                {
                    circularProgressBar1.Value = s;
                    circularProgressBar1.Text = s.ToString() + "%";
                });
                string encryptedText = await Task.Factory.StartNew<string>(
                    () => _currentMode.Encrypt(_sfr, progress, token, _iv, _n),
                    TaskCreationOptions.LongRunning);

                WriteToFile(_path + ".safer", encryptedText);
                circularProgressBar1.Value = 100;
                circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";
                objStopwatch.Stop();
                labelTime.Text = "Time: " + objStopwatch.Elapsed;
                buttonCancel.Enabled = false;
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Cancelled");
            }

        }
        private async void Decrypt()
        {
            try
            {
                var token = _token.Token;
                System.Diagnostics.Stopwatch objStopwatch = new System.Diagnostics.Stopwatch();
                objStopwatch.Start();
                var progress = new Progress<int>(s =>
                {
                    circularProgressBar1.Value = s;
                    circularProgressBar1.Text = s.ToString() + "%";
                });
                string encryptedText = await Task.Factory.StartNew<string>(
                    () => _currentMode.Decrypt(_sfr, progress, token, _iv, _n),
                    TaskCreationOptions.LongRunning);

                WriteToFile(_path.Replace(".safer", ""), encryptedText);
                circularProgressBar1.Value = 100;
                circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";
                objStopwatch.Stop();
                labelTime.Text = "Time: " + objStopwatch.Elapsed;
                buttonCancel.Enabled = false;
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Cancelled");
            }

        }
        private void WriteToFile(string filePath, string text)
        {
            StreamWriter str_wr = new StreamWriter(filePath, false, System.Text.Encoding.GetEncoding(1251));
            str_wr.Write(text);
            str_wr.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _token.Cancel();
            buttonCancel.Enabled = false;
        }

        private void loadingForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
