namespace SaferAlg.Forms
{
    partial class saferForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.key = new System.Windows.Forms.Label();
            this.saferkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRounds = new System.Windows.Forms.ComboBox();
            this.textBoxBlockSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFileToFileDecrypt = new System.Windows.Forms.Button();
            this.buttonFileToFileEncrypt = new System.Windows.Forms.Button();
            this.textBoxInitialVector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxModes = new System.Windows.Forms.GroupBox();
            this.radioButtonOfb = new System.Windows.Forms.RadioButton();
            this.radioButtonCfb = new System.Windows.Forms.RadioButton();
            this.radioButtonCbc = new System.Windows.Forms.RadioButton();
            this.radioButtonEcb = new System.Windows.Forms.RadioButton();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenFileExplorer = new System.Windows.Forms.Button();
            this.groupBoxModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.key.Location = new System.Drawing.Point(51, 114);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(42, 20);
            this.key.TabIndex = 0;
            this.key.Text = "Key:";
            // 
            // saferkey
            // 
            this.saferkey.Location = new System.Drawing.Point(99, 112);
            this.saferkey.MaxLength = 8;
            this.saferkey.Name = "saferkey";
            this.saferkey.Size = new System.Drawing.Size(124, 22);
            this.saferkey.TabIndex = 5;
            this.saferkey.Text = "saferkey";
            this.saferkey.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rounds:";
            // 
            // comboBoxRounds
            // 
            this.comboBoxRounds.DisplayMember = "1";
            this.comboBoxRounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRounds.FormatString = "N2";
            this.comboBoxRounds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxRounds.Location = new System.Drawing.Point(333, 178);
            this.comboBoxRounds.Name = "comboBoxRounds";
            this.comboBoxRounds.Size = new System.Drawing.Size(119, 24);
            this.comboBoxRounds.TabIndex = 27;
            this.comboBoxRounds.ValueMember = "1";
            // 
            // textBoxBlockSize
            // 
            this.textBoxBlockSize.Location = new System.Drawing.Point(330, 112);
            this.textBoxBlockSize.Name = "textBoxBlockSize";
            this.textBoxBlockSize.Size = new System.Drawing.Size(119, 22);
            this.textBoxBlockSize.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Block size:";
            // 
            // buttonFileToFileDecrypt
            // 
            this.buttonFileToFileDecrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFileToFileDecrypt.Location = new System.Drawing.Point(509, 421);
            this.buttonFileToFileDecrypt.Name = "buttonFileToFileDecrypt";
            this.buttonFileToFileDecrypt.Size = new System.Drawing.Size(137, 30);
            this.buttonFileToFileDecrypt.TabIndex = 42;
            this.buttonFileToFileDecrypt.Text = "Decrypt";
            this.buttonFileToFileDecrypt.UseVisualStyleBackColor = true;
            this.buttonFileToFileDecrypt.Click += new System.EventHandler(this.buttonFileToFileDecrypt_Click);
            // 
            // buttonFileToFileEncrypt
            // 
            this.buttonFileToFileEncrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFileToFileEncrypt.Location = new System.Drawing.Point(330, 421);
            this.buttonFileToFileEncrypt.Name = "buttonFileToFileEncrypt";
            this.buttonFileToFileEncrypt.Size = new System.Drawing.Size(132, 30);
            this.buttonFileToFileEncrypt.TabIndex = 41;
            this.buttonFileToFileEncrypt.Text = "Encrypt";
            this.buttonFileToFileEncrypt.UseVisualStyleBackColor = true;
            this.buttonFileToFileEncrypt.Click += new System.EventHandler(this.buttonFileToFileEncrypt_Click);
            // 
            // textBoxInitialVector
            // 
            this.textBoxInitialVector.Location = new System.Drawing.Point(99, 178);
            this.textBoxInitialVector.MaxLength = 8;
            this.textBoxInitialVector.Name = "textBoxInitialVector";
            this.textBoxInitialVector.Size = new System.Drawing.Size(124, 22);
            this.textBoxInitialVector.TabIndex = 44;
            this.textBoxInitialVector.Text = "12345678";
            this.textBoxInitialVector.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Initial Vector:";
            // 
            // groupBoxModes
            // 
            this.groupBoxModes.Controls.Add(this.radioButtonOfb);
            this.groupBoxModes.Controls.Add(this.radioButtonCfb);
            this.groupBoxModes.Controls.Add(this.radioButtonCbc);
            this.groupBoxModes.Controls.Add(this.radioButtonEcb);
            this.groupBoxModes.Location = new System.Drawing.Point(534, 125);
            this.groupBoxModes.Name = "groupBoxModes";
            this.groupBoxModes.Size = new System.Drawing.Size(424, 64);
            this.groupBoxModes.TabIndex = 46;
            this.groupBoxModes.TabStop = false;
            this.groupBoxModes.Text = "modes:";
            // 
            // radioButtonOfb
            // 
            this.radioButtonOfb.AutoSize = true;
            this.radioButtonOfb.Location = new System.Drawing.Point(323, 21);
            this.radioButtonOfb.Name = "radioButtonOfb";
            this.radioButtonOfb.Size = new System.Drawing.Size(57, 21);
            this.radioButtonOfb.TabIndex = 3;
            this.radioButtonOfb.TabStop = true;
            this.radioButtonOfb.Text = "OFB";
            this.radioButtonOfb.UseVisualStyleBackColor = true;
            // 
            // radioButtonCfb
            // 
            this.radioButtonCfb.AutoSize = true;
            this.radioButtonCfb.Location = new System.Drawing.Point(237, 21);
            this.radioButtonCfb.Name = "radioButtonCfb";
            this.radioButtonCfb.Size = new System.Drawing.Size(55, 21);
            this.radioButtonCfb.TabIndex = 2;
            this.radioButtonCfb.TabStop = true;
            this.radioButtonCfb.Text = "CFB";
            this.radioButtonCfb.UseVisualStyleBackColor = true;
            // 
            // radioButtonCbc
            // 
            this.radioButtonCbc.AutoSize = true;
            this.radioButtonCbc.Location = new System.Drawing.Point(143, 21);
            this.radioButtonCbc.Name = "radioButtonCbc";
            this.radioButtonCbc.Size = new System.Drawing.Size(56, 21);
            this.radioButtonCbc.TabIndex = 1;
            this.radioButtonCbc.TabStop = true;
            this.radioButtonCbc.Text = "CBC";
            this.radioButtonCbc.UseVisualStyleBackColor = true;
            // 
            // radioButtonEcb
            // 
            this.radioButtonEcb.AutoSize = true;
            this.radioButtonEcb.Location = new System.Drawing.Point(56, 21);
            this.radioButtonEcb.Name = "radioButtonEcb";
            this.radioButtonEcb.Size = new System.Drawing.Size(56, 21);
            this.radioButtonEcb.TabIndex = 0;
            this.radioButtonEcb.TabStop = true;
            this.radioButtonEcb.Text = "ECB";
            this.radioButtonEcb.UseVisualStyleBackColor = true;
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(122, 297);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(764, 22);
            this.textBoxFilePath.TabIndex = 47;
            this.textBoxFilePath.Text = "C:\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Path:";
            // 
            // buttonOpenFileExplorer
            // 
            this.buttonOpenFileExplorer.Location = new System.Drawing.Point(888, 297);
            this.buttonOpenFileExplorer.Name = "buttonOpenFileExplorer";
            this.buttonOpenFileExplorer.Size = new System.Drawing.Size(37, 23);
            this.buttonOpenFileExplorer.TabIndex = 49;
            this.buttonOpenFileExplorer.Text = "...";
            this.buttonOpenFileExplorer.UseVisualStyleBackColor = true;
            this.buttonOpenFileExplorer.Click += new System.EventHandler(this.buttonOpenFileExplorer_Click);
            // 
            // saferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1007, 523);
            this.Controls.Add(this.buttonOpenFileExplorer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.groupBoxModes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxInitialVector);
            this.Controls.Add(this.buttonFileToFileDecrypt);
            this.Controls.Add(this.buttonFileToFileEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBlockSize);
            this.Controls.Add(this.comboBoxRounds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saferkey);
            this.Controls.Add(this.key);
            this.DoubleBuffered = true;
            this.Name = "saferForm";
            this.Text = "Safer";
            this.Load += new System.EventHandler(this.saferForm_Load);
            this.groupBoxModes.ResumeLayout(false);
            this.groupBoxModes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label key;
        private System.Windows.Forms.TextBox saferkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRounds;
        private System.Windows.Forms.TextBox textBoxBlockSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFileToFileDecrypt;
        private System.Windows.Forms.Button buttonFileToFileEncrypt;
        private System.Windows.Forms.TextBox textBoxInitialVector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxModes;
        private System.Windows.Forms.RadioButton radioButtonOfb;
        private System.Windows.Forms.RadioButton radioButtonCfb;
        private System.Windows.Forms.RadioButton radioButtonCbc;
        private System.Windows.Forms.RadioButton radioButtonEcb;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOpenFileExplorer;
    }
}