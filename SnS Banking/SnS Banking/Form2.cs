using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SnS_Banking
{
    public partial class Form2 : Form
    {

        string cap = "S&S Banking";

        FormBankMain BankMain = new FormBankMain();

        // rndm gen token vars
        int max = 26;
        int min = 1;
        int gen = 0;
        string a1 = "";

        Random rndL = new Random();


        // wick1 gens random num
        private void wick()
        {
            for (int i = 1; i <= max; i++)
            { }

            gen = rndL.Next(1, max);
        }

        // wick2 converts random num to letter
        private void wick2()
        {
            if (gen == 1)
            {
                a1 = "a";
            }
            else if (gen == 2)
            {
                a1 = "b";
            }
            else if (gen == 3)
            {
                a1 = "c";
            }
            else if (gen == 4)
            {
                a1 = "d";
            }
            else if (gen == 5)
            {
                a1 = "e";
            }
            else if (gen == 6)
            {
                a1 = "f";
            }
            else if (gen == 7)
            {
                a1 = "g";
            }
            else if (gen == 8)
            {
                a1 = "h";
            }
            else if (gen == 9)
            {
                a1 = "i";
            }
            else if (gen == 10)
            {
                a1 = "j";
            }
            else if (gen == 11)
            {
                a1 = "k";
            }
            else if (gen == 12)
            {
                a1 = "l";
            }
            else if (gen == 13)
            {
                a1 = "m";
            }
            else if (gen == 14)
            {
                a1 = "n";
            }
            else if (gen == 15)
            {
                a1 = "o";
            }
            else if (gen == 16)
            {
                a1 = "p";
            }
            else if (gen == 17)
            {
                a1 = "q";
            }
            else if (gen == 18)
            {
                a1 = "r";
            }
            else if (gen == 19)
            {
                a1 = "s";
            }
            else if (gen == 20)
            {
                a1 = "t";
            }
            else if (gen == 21)
            {
                a1 = "u";
            }
            else if (gen == 22)
            {
                a1 = "v";
            }
            else if (gen == 23)
            {
                a1 = "w";
            }
            else if (gen == 24)
            {
                a1 = "x";
            }
            else if (gen == 25)
            {
                a1 = "y";
            }
            else if (gen == 26)
            {
                a1 = "z";
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelForogtLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3ResetLogin ResetLogin = new Form3ResetLogin();
            this.Hide();
            ResetLogin.ShowDialog();
            this.Show();
        }

        private void linkLabelContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBoxContactus ContactUs = new AboutBoxContactus();
            this.Hide();
            ContactUs.ShowDialog();
            this.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(tbUser.Text))
            {
                MessageBox.Show("Please enter your username", cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

            }

            if (Regex.IsMatch(tbUser.Text, @"^[a-zA-Z0-9_]+$"))
            { }
            else
            {
                MessageBox.Show("Username cannot contain special characters ex: !, @, #, $, %", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUser.SelectAll();
                tbUser.Focus();
                tbPass.Clear();
                return;
            }

            if (tbUser.Text.Length < 6)
            {
                MessageBox.Show("Username must be greater than 6 characters.", cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPass.Clear();
                tbUser.SelectAll();
                tbUser.Focus();
                return;
            }

            if (tbPass.Text.Length == 0)
            {
                MessageBox.Show("Failed to login. Password token not generated.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            
            this.Hide();
            BankMain.lLoggedin.Text = "Logged in as: " + tbUser.Text;
            BankMain.ShowDialog();
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            if(tbUser.TextLength>0)
            {
                bGen.Enabled = true;
            }
            else
            {
                bGen.Enabled = false;
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        // rndm pass token gen
        private void bGen_Click(object sender, EventArgs e)
        {

            wick();

            int g1 = gen;
            wick2();
            string l1 = a1;

            wick();

            int g2 = gen;
            wick2();
            string l2 = a1;

            wick();

            int g3 = gen;
            wick2();
            string l3 = a1;

            wick();

            int g4 = gen;
            wick2();
            string l4 = a1;

            wick();

            int g5 = gen;
            wick2();
            string l5 = a1;

            wick();

            int g6 = gen;
            wick2();
            string l6 = a1;

            wick();

            int g7 = gen;
            wick2();
            string l7 = a1;

            wick();

            int g8 = gen;
            wick2();
            string l8 = a1;



            string allgen = l1 + l2 + l3 + l4 + l5 + l6 + l7 + l8;

            // MessageBox.Show(allgen);

            tbPass.Text = allgen;
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {


            if(cbShow.Checked==false)
            {
                tbPass.UseSystemPasswordChar = true;
            }
            else
            {
                tbPass.UseSystemPasswordChar = false;
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
