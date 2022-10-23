using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnS_Banking
{
    public partial class Form3ResetLogin : Form
    {
        public Form3ResetLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3ResetLogin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Caution, only enter email if you wish to reset login information", "S&S Banking", MessageBoxButtons.OK);

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
