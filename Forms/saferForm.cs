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
    public partial class saferForm : Form
    {
        private Safer.Safer sfr;
        private ModeEcb modeEcb;
        private ModeCbc modeCbc;
        private ModeCfb modeCfb;
        private ModeOfb modeOfb;
        private IMode currentMode;
        private Form currentForm;
        private OpenFileDialog ofd;
        private string encrypt = "encrypt";
        private string decrypt = "decrypt";

        private string IV;
        private int N;


        public saferForm()
        {
            InitializeComponent();
            sfr = new Safer.Safer();
            modeEcb = new ModeEcb();
            modeCbc = new ModeCbc();
            modeCfb = new ModeCfb();
            modeOfb = new ModeOfb();
            ofd = new OpenFileDialog();
        }

        private void saferForm_Load(object sender, EventArgs e)
        {
            comboBoxRounds.SelectedIndex = 0;
            textBoxBlockSize.Text = "8";
            radioButtonEcb.Checked = true;
            Text = "Main Page";
        }

        private void CheckCurrentMode()
        {
            if (radioButtonEcb.Checked) currentMode = modeEcb;
            if (radioButtonCbc.Checked) currentMode = modeCbc;
            if (radioButtonCfb.Checked) currentMode = modeCfb;
            if (radioButtonOfb.Checked) currentMode = modeOfb;
        }
        private bool Init()
        {
            sfr.Key = saferkey.Text;
            if (sfr.Key.Length < 8)
            {
                MessageBox.Show("Key must be 8 symbols");
                return true;
            }

            sfr.Round = int.Parse(comboBoxRounds.SelectedItem.ToString());

            if (textBoxInitialVector.Text.Length < 8)
            {
                textBoxInitialVector.Text = "12345678";
                IV = "12345678";
                MessageBox.Show("Initial Vector is set to default value 12345678");
            }
            else
            {
                IV = textBoxInitialVector.Text;
            }

            if (String.IsNullOrEmpty(textBoxBlockSize.Text))
            {
                MessageBox.Show("Block size is required");
                return true;
            }
            N = int.Parse(textBoxBlockSize.Text);

            CheckCurrentMode();

            return false;
        }


        

        private void buttonFileToFileEncrypt_Click(object sender, EventArgs e)
        {
            if (Init())
            {
                return;
            }
            if (!File.Exists(textBoxFilePath.Text))
            {
                MessageBox.Show("File does not exist");
                return;
            }
            sfr.Text = ReadFromFile(textBoxFilePath.Text);

            currentForm = new Forms.loadingForm(sfr, IV, N, currentMode, textBoxFilePath.Text, encrypt);
            currentForm.Show();
        }

        private void buttonFileToFileDecrypt_Click(object sender, EventArgs e)
        {
            if (Init())
            {
                return;
            }
            if (!File.Exists(textBoxFilePath.Text))
            {
                MessageBox.Show("File does not exist");
                return;
            }

            sfr.Text = ReadFromFile(textBoxFilePath.Text);

            currentForm = new Forms.loadingForm(sfr, IV, N, currentMode, textBoxFilePath.Text, decrypt);
            currentForm.Show();
        }

        private string ReadFromFile(string filePath)
        {
            byte[] source = System.IO.File.ReadAllBytes(filePath);

            //StreamReader my_file = new StreamReader(filePath, Encoding.UTF8);
            //string source = my_file.ReadToEnd();
            //my_file.Close();
            return Encoding.Default.GetString(source);
        }


        private void buttonOpenFileExplorer_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            textBoxFilePath.Text = ofd.FileName;

        }
    }
}
