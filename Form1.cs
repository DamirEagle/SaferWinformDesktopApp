using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaferAlg.Forms;

namespace SaferAlg
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Color activationColor = Color.FromArgb(13, 93, 142);
        private Form activeForm;
        private Form mainPage;
        private Form theoryForm;
        private Form profileForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Activate_Button(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = activationColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(4, 41, 68);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Hide();
            }
            Activate_Button(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelMode.Text = childForm.Text;
        }


        private void buttonSafer_Click(object sender, EventArgs e)
        {
            mainPage = new Forms.saferForm();
            OpenChildForm(mainPage, sender);
        }

        private void buttonTheory_Click(object sender, EventArgs e)
        {
            theoryForm = new Forms.theoryForm();
            OpenChildForm(theoryForm, sender);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            profileForm = new Forms.profileForm();
            OpenChildForm(profileForm, sender);
        }

        private void LabelMode_Click(object sender, EventArgs e)
        {
            foreach (Control form in panelContainer.Controls)
            {
                form.Hide();
            }
            labelMode.Text = "Safer-k-64";
            DisableButton();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
