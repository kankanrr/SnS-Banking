
namespace SnS_Banking
{
    partial class Form3ResetLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3ResetLogin));
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonActResetCancel = new System.Windows.Forms.Button();
            this.buttonActResetSend = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(13, 56);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(298, 22);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Enter Account Email to Reset Login";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // buttonActResetCancel
            // 
            this.buttonActResetCancel.Location = new System.Drawing.Point(317, 96);
            this.buttonActResetCancel.Name = "buttonActResetCancel";
            this.buttonActResetCancel.Size = new System.Drawing.Size(107, 32);
            this.buttonActResetCancel.TabIndex = 2;
            this.buttonActResetCancel.Text = "Cancel";
            this.buttonActResetCancel.UseVisualStyleBackColor = true;
            // 
            // buttonActResetSend
            // 
            this.buttonActResetSend.Location = new System.Drawing.Point(455, 96);
            this.buttonActResetSend.Name = "buttonActResetSend";
            this.buttonActResetSend.Size = new System.Drawing.Size(107, 32);
            this.buttonActResetSend.TabIndex = 3;
            this.buttonActResetSend.Text = "Send Email";
            this.buttonActResetSend.UseVisualStyleBackColor = true;
            this.buttonActResetSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(317, 55);
            this.maskedTextBox1.Mask = "___________@________.______";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(245, 23);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // Form3ResetLogin
            // 
            this.AcceptButton = this.buttonActResetSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonActResetCancel;
            this.ClientSize = new System.Drawing.Size(586, 184);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.buttonActResetSend);
            this.Controls.Add(this.buttonActResetCancel);
            this.Controls.Add(this.labelEmail);
            this.DoubleBuffered = true;
            this.Name = "Form3ResetLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Login";
            this.Load += new System.EventHandler(this.Form3ResetLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonActResetCancel;
        private System.Windows.Forms.Button buttonActResetSend;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}