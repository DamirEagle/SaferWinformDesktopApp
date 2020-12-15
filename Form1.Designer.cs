namespace SaferAlg
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCFB = new System.Windows.Forms.Button();
            this.buttonCBC = new System.Windows.Forms.Button();
            this.buttonECB = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelMode = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.buttonCFB);
            this.panelMenu.Controls.Add(this.buttonCBC);
            this.panelMenu.Controls.Add(this.buttonECB);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(251, 603);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonCFB
            // 
            this.buttonCFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCFB.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCFB.FlatAppearance.BorderSize = 0;
            this.buttonCFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCFB.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCFB.Image = ((System.Drawing.Image)(resources.GetObject("buttonCFB.Image")));
            this.buttonCFB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCFB.Location = new System.Drawing.Point(0, 200);
            this.buttonCFB.Name = "buttonCFB";
            this.buttonCFB.Size = new System.Drawing.Size(251, 60);
            this.buttonCFB.TabIndex = 4;
            this.buttonCFB.Text = "PROFILE";
            this.buttonCFB.UseVisualStyleBackColor = true;
            this.buttonCFB.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonCBC
            // 
            this.buttonCBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCBC.FlatAppearance.BorderSize = 0;
            this.buttonCBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCBC.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCBC.Image = ((System.Drawing.Image)(resources.GetObject("buttonCBC.Image")));
            this.buttonCBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCBC.Location = new System.Drawing.Point(0, 140);
            this.buttonCBC.Name = "buttonCBC";
            this.buttonCBC.Size = new System.Drawing.Size(251, 60);
            this.buttonCBC.TabIndex = 3;
            this.buttonCBC.Text = "THEORY";
            this.buttonCBC.UseVisualStyleBackColor = true;
            this.buttonCBC.Click += new System.EventHandler(this.buttonTheory_Click);
            // 
            // buttonECB
            // 
            this.buttonECB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonECB.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonECB.FlatAppearance.BorderSize = 0;
            this.buttonECB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonECB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.buttonECB.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonECB.Image = ((System.Drawing.Image)(resources.GetObject("buttonECB.Image")));
            this.buttonECB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonECB.Location = new System.Drawing.Point(0, 80);
            this.buttonECB.Name = "buttonECB";
            this.buttonECB.Padding = new System.Windows.Forms.Padding(1, 10, 0, 0);
            this.buttonECB.Size = new System.Drawing.Size(251, 60);
            this.buttonECB.TabIndex = 2;
            this.buttonECB.Text = "SAFER";
            this.buttonECB.UseVisualStyleBackColor = true;
            this.buttonECB.Click += new System.EventHandler(this.buttonSafer_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 80);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkCyan;
            this.panelTitleBar.Controls.Add(this.labelMode);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(251, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(981, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelMode
            // 
            this.labelMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMode.AutoSize = true;
            this.labelMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMode.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMode.Location = new System.Drawing.Point(419, 23);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(128, 31);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "Safer-k-64";
            this.labelMode.Click += new System.EventHandler(this.LabelMode_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContainer.BackgroundImage")));
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(251, 80);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(981, 523);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 603);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Safer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonECB;
        private System.Windows.Forms.Button buttonCFB;
        private System.Windows.Forms.Button buttonCBC;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Panel panelContainer;
    }
}

