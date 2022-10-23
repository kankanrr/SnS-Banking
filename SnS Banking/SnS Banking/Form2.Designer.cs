
namespace SnS_Banking
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.bLog = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelContactUs = new System.Windows.Forms.LinkLabel();
            this.bGen = new System.Windows.Forms.Button();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(127, 63);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(149, 23);
            this.tbUser.TabIndex = 2;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // tbPass
            // 
            this.tbPass.Enabled = false;
            this.tbPass.Location = new System.Drawing.Point(127, 103);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(149, 23);
            this.tbPass.TabIndex = 3;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // bLog
            // 
            this.bLog.Location = new System.Drawing.Point(343, 63);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(75, 23);
            this.bLog.TabIndex = 4;
            this.bLog.Text = "Login";
            this.bLog.UseVisualStyleBackColor = true;
            this.bLog.Click += new System.EventHandler(this.Login_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(343, 103);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(127, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 51);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(189, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Banking";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabelContactUs
            // 
            this.linkLabelContactUs.AutoSize = true;
            this.linkLabelContactUs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelContactUs.Location = new System.Drawing.Point(349, 142);
            this.linkLabelContactUs.Name = "linkLabelContactUs";
            this.linkLabelContactUs.Size = new System.Drawing.Size(63, 13);
            this.linkLabelContactUs.TabIndex = 9;
            this.linkLabelContactUs.TabStop = true;
            this.linkLabelContactUs.Text = "Contact Us";
            this.linkLabelContactUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContactUs_LinkClicked);
            // 
            // bGen
            // 
            this.bGen.Enabled = false;
            this.bGen.Location = new System.Drawing.Point(164, 132);
            this.bGen.Name = "bGen";
            this.bGen.Size = new System.Drawing.Size(75, 23);
            this.bGen.TabIndex = 11;
            this.bGen.Text = "Generate";
            this.bGen.UseVisualStyleBackColor = true;
            this.bGen.Click += new System.EventHandler(this.bGen_Click);
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(283, 106);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(55, 19);
            this.cbShow.TabIndex = 12;
            this.cbShow.Text = "Show";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // Form2
            // 
            this.AcceptButton = this.bLog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bExit;
            this.ClientSize = new System.Drawing.Size(430, 161);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.bGen);
            this.Controls.Add(this.linkLabelContactUs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bLog);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S&S Banking Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button bLog;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelContactUs;
        private System.Windows.Forms.Button bGen;
        private System.Windows.Forms.CheckBox cbShow;
    }
}