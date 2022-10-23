using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SnS_Banking
{
    public partial class FormBankMain : Form
    {

        string cap = "S&S Banking";

        //statement vars

        double tbalC = 1000;
        double tbalS = 2500;
        double totalC=1000,totalS=2500;
        double sub;


        public FormBankMain()
        {
            InitializeComponent();
        }

        private void writeCheck()
        {
            StreamWriter check;

            string fname = "C.txt";

            if (File.Exists(fname))
            {
                check = File.CreateText(fname);
            }
            else
            {
                check = File.CreateText(fname);
            }

            int itemcount = listBoxShowTransactions.Items.Count;

            for (int count = 0; count <= itemcount - 1; count++)
            {
                string item = listBoxShowTransactions.Items[count].ToString();

                check.WriteLine(item);
            }

            check.Close();
        }

        private void writeSav()
        {
            StreamWriter sav;

            string sfname = "S.txt";

            if(File.Exists(sfname))
            {
                sav = File.CreateText(sfname);
            }
            else
            {
                sav = File.CreateText(sfname);
            }

            int sintcount = listBoxShowTransactions.Items.Count;

            for (int count = 0; count <= sintcount - 1; count++)
            {
                string sitem = listBoxShowTransactions.Items[count].ToString();

                sav.WriteLine(sitem);
            }

            sav.Close();
        }

        private void readCheck()
        {
            StreamReader rCheck;

            string rfname = "C.txt";

            rCheck = File.OpenText(@"C.txt");

            while(!rCheck.EndOfStream)
            {
                listBoxShowTransactions.Items.Add(rCheck.ReadLine());
            }

            rCheck.Close();
        }

        private void readSav()
        {
            StreamReader rSav;

            rSav = File.OpenText(@"S.txt");

            while(!rSav.EndOfStream)
            {
                listBoxShowTransactions.Items.Add(rSav.ReadLine());
            }

            rSav.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBoxVeiwStatements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTransferAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTransferActs_Click(object sender, EventArgs e)
        {

            double transferamt;

            try
            {
                transferamt = double.Parse(tbtamt.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbtamt.Clear();
                tbtamt.Focus();
                return;
            }

            if (transferamt < 0)
            {
                MessageBox.Show("Please enter an amount greater than 0.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbtamt.Clear();
                tbtamt.Focus();
                return;
            }

            if (comboBoxTransferFrom.SelectedIndex == -1 || comboBoxTransferTo.SelectedIndex == -1)
            {
                MessageBox.Show("Unable to complete action. You must select an account to transfer from and to.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxTransferFrom.Focus();
                return;
            }

            if (totalC == 0 && transferamt > totalC)
            {
                MessageBox.Show("You have no balance in your account." + "\n\n" + "Total Balance - " + totalC.ToString("c2"),cap,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tbtamt.Clear();
                return;
            }

            if (totalS == 0 && transferamt > totalS)
            {
                MessageBox.Show("You have no balance in your account." + "\n\n" + "Total Balance - " + totalS.ToString("c2"), cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbtamt.Clear();
                return;
            }

            if (comboBoxTransferFrom.SelectedIndex==0)
            {
                if (transferamt > totalC)
                {
                    MessageBox.Show("Please enter an amount lower than your current balance of  " + totalC.ToString("c2") + ".", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbtamt.Clear();
                    tbtamt.Focus();
                    return;
                }
            }

            if (comboBoxTransferFrom.SelectedIndex == 1)
            {
                if (transferamt > totalS)
                {
                    MessageBox.Show("Please enter an amount lower than your current balance of  " + totalS.ToString("c2") + ".", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbtamt.Clear();
                    tbtamt.Focus();
                    return;
                }
            }
            MessageBox.Show("Transfer Complete. " + transferamt.ToString("c2") + " has been successfully transfered." + "\n\n" + "From: " + comboBoxTransferFrom.SelectedItem.ToString() + " - - - - " + "To: " + comboBoxTransferTo.SelectedItem.ToString(),cap,MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            if(comboBoxTransferFrom.SelectedIndex==0)
            {
                listBoxShowTransactions.Items.Add(DateTime.Now.ToString("M") + " Transfer - " + transferamt.ToString("c2") + " (" + comboBoxTransferFrom.SelectedItem.ToString() + " -> " + comboBoxTransferTo.SelectedItem.ToString() + ")");
                totalC = totalC - transferamt;
                totalBal.Text = "Total Balance: " + totalC.ToString("c2");
                writeCheck();

            }
            else
            { }

            if(comboBoxTransferFrom.SelectedIndex==1)
            {
                listBoxShowTransactions.Items.Add(DateTime.Now.ToString("M") + " Transfer - " + transferamt.ToString("c2") + " (" + comboBoxTransferFrom.SelectedItem.ToString() + " -> " + comboBoxTransferTo.SelectedItem.ToString() + ")");
                totalS = totalS - transferamt;
                totalBal.Text = "Total Balance: " + totalS.ToString("c2");
                writeSav();
            }
            

        }

        private void tabPageTransfers_Click(object sender, EventArgs e)
        {
 
        }

        private void FormBankMain_Load(object sender, EventArgs e)
        {
            listBoxVeiwStatements.Items.Add("Select a month to view a statement.");
            listBoxVeiwStatements.Items.Add("");
            listBoxVeiwStatements.Items.Add(DateTime.Now.ToString("MMMM") + " - Checkings");
            listBoxVeiwStatements.Items.Add("");
            listBoxVeiwStatements.Items.Add(DateTime.Now.ToString("MMMM") + " - Savings");
        }

        private void listBoxVeiwStatements_MouseDown(object sender, MouseEventArgs e)
        {
            int index =-1;



            if (e.Button==MouseButtons.Left)
            {
                index = listBoxVeiwStatements.SelectedIndex;
            }

            if(index==2)
            {
                listBoxShowTransactions.Items.Clear();
                totalBal.Text = "Total Balance: " + totalC.ToString("c2");
                readCheck();
            }

            if (index == 4)
            {
                listBoxShowTransactions.Items.Clear();
                totalBal.Text = "Total Balance: " + totalS.ToString("c2");
                readSav();
            }


        }

        private void listBoxShowTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAcceptDepWith_Click(object sender, EventArgs e)
        {
            double wdamt;
            try
            {
                wdamt = double.Parse(textBoxWithDepAmt.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxWithDepAmt.Clear();
                textBoxWithDepAmt.Focus();
                return;
            }

            if (totalC == 0 && wdamt > totalC)
            {
                MessageBox.Show("You have no balance in your account." + "\n\n" + "Total Balance - " + totalC.ToString("c2"), cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBankTrans.Clear();
                return;
            }

            if (totalS == 0 && wdamt > totalS)
            {
                MessageBox.Show("You have no balance in your account." + "\n\n" + "Total Balance - " + totalS.ToString("c2"), cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBankTrans.Clear();
                return;
            }

            if (wdamt < 0)
            {
                MessageBox.Show("Please enter an amount greater than 0.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxWithDepAmt.Clear();
                textBoxWithDepAmt.Focus();
                return;
            }

            if(radioButtonWithdraw.Checked==false && radioButtonDeposit.Checked==false)
            {
                MessageBox.Show("Please select whether you are Withdrawing or Despositing.", cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(comboBoxWithDepAccount.SelectedIndex==-1)
            {
                MessageBox.Show("Please choose an account to use.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(comboBoxWithDepAccount.SelectedIndex==0)
            {
                if(wdamt > totalC)
                {
                    MessageBox.Show("Please enter an amount lower than your current balance of  " + totalC.ToString("c2") + ".", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxWithDepAmt.Clear();
                    textBoxWithDepAmt.Focus();
                    return;
                }
            }





            MessageBox.Show("Action complete. Please view your " + comboBoxWithDepAccount.SelectedItem.ToString() + " statement.", cap, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(comboBoxWithDepAccount.SelectedIndex==0 && radioButtonWithdraw.Checked==true)
            {
                listBoxShowTransactions.Items.Add(DateTime.Now.ToString("M") + " " + radioButtonWithdraw.Text + " - " + wdamt.ToString("c2") + " (" + comboBoxWithDepAccount.SelectedItem.ToString() + ")");
                totalC = totalC - wdamt;
                totalBal.Text = "Total Balance: " + totalC.ToString("c2");
                radioButtonWithdraw.Checked = false;
                writeCheck();
            }
            else if (comboBoxWithDepAccount.SelectedIndex == 0 && radioButtonDeposit.Checked == true)
            {
                listBoxShowTransactions.Items.Add(DateTime.Now.ToString("M") + " " + radioButtonDeposit.Text + " - " + wdamt.ToString("c2") + " (" + comboBoxWithDepAccount.SelectedItem.ToString() + ")");
                totalC = totalC + wdamt;
                totalBal.Text = "Total Balance: " + totalC.ToString("c2");
                radioButtonDeposit.Checked = false;
                writeCheck();
            }
            else if (comboBoxWithDepAccount.SelectedIndex == 1 && radioButtonWithdraw.Checked == true)
            {
                listBoxShowTransactions.Items.Add(DateTime.Now.ToString("M") + " " + radioButtonWithdraw.Text + " - " + wdamt.ToString("c2") + " (" + comboBoxWithDepAccount.SelectedItem.ToString() + ")");
                totalS = totalS - wdamt;
                totalBal.Text = "Total Balance: " + totalS.ToString("c2");
                radioButtonWithdraw.Checked = false;
                writeSav();
            }
            else if(comboBoxWithDepAccount.SelectedIndex == 1 && radioButtonDeposit.Checked == true)
            {
                listBoxShowTransactions.Items.Add(DateTime.Now.ToString("M") + " " + radioButtonDeposit.Text + " - " + wdamt.ToString("c2") + " (" + comboBoxWithDepAccount.SelectedItem.ToString() + ")");
                totalS = totalS + wdamt;
                totalBal.Text = "Total Balance: " + totalS.ToString("c2");
                radioButtonDeposit.Checked = false;
                writeSav();
            }

        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            DialogResult lo = new DialogResult();

            lo = MessageBox.Show("Are you sure you want to log out?", cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            Form2 login = new Form2();

            if (lo==DialogResult.Yes)
            {
                this.Hide();
                login.ShowDialog();
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonTransferBanks_Click(object sender, EventArgs e)
        {
            double transferam;

            try
            {
                transferam = double.Parse(tbBankTrans.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBankTrans.Clear();
                tbBankTrans.Focus();
                return;
            }

            if (transferam < 0)
            {
                MessageBox.Show("Please enter an amount greater than 0.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBankTrans.Clear();
                tbBankTrans.Focus();
                return;
            }

            if(cbAcct.SelectedIndex==0)
            {
                if (transferam > totalC)
                {
                    MessageBox.Show("Please enter an amount lower than your current balance of  " + totalC.ToString("c2") + ".", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbBankTrans.Clear();
                    tbBankTrans.Focus();
                    return;
                }

            }

            if (cbAcct.SelectedIndex == 1)
            {
                if (transferam > totalS)
                {
                    MessageBox.Show("Please enter an amount lower than your current balance of  " + totalS.ToString("c2") + ".", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbBankTrans.Clear();
                    tbBankTrans.Focus();
                    return;
                }

            }

            if (totalC == 0 && transferam > totalC)
            {
                MessageBox.Show("You have no balance in your account." + "\n\n" + "Total Balance - " + totalC.ToString("c2"), cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBankTrans.Clear();
                return;
            }

            if (totalS == 0 && transferam > totalS)
            {
                MessageBox.Show("You have no balance in your account." + "\n\n" + "Total Balance - " + totalS.ToString("c2"), cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBankTrans.Clear();
                return;
            }

            if (comboBoxChooseBank.SelectedIndex==-1)
            {
                MessageBox.Show("You must choose a bank before making a transfer.", cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(cbAcct.SelectedIndex==-1)
            {
                MessageBox.Show("You must choose the account you want to use to make the transfer.", cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(tbRoute.Text.Length < 9)
            {
                MessageBox.Show("The routing number must be 9 digits long.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbRoute.SelectAll();
                tbRoute.Focus();
                return;
            }

            if(tbAcct.Text.Length < 12)
            {
                MessageBox.Show("The account number must be 12 digits long.", cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAcct.SelectAll();
                tbAcct.Focus();
                return;
            }

            MessageBox.Show("Transfer Complete. " + transferam.ToString("c2") + " has been successfully transfered." + "\n\n" + "From: " + cbAcct.SelectedItem.ToString() + " - - - - " + "To: " + comboBoxChooseBank.SelectedItem.ToString(), cap, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (cbAcct.SelectedIndex == 0)
            {
                listBoxShowTransactions.Items.Add(DateTime.Now.ToString("M") + " Transfer - " + transferam.ToString("c2") + " (" + cbAcct.SelectedItem.ToString() + " -> " + comboBoxChooseBank.SelectedItem.ToString() + ")");
                totalC = totalC - transferam;
                writeCheck();
            }
            else
            { }

            if (cbAcct.SelectedIndex == 1)
            {
                listBoxShowTransactions.Items.Add(DateTime.Now.ToString("M") + " Transfer - " + transferam.ToString("c2") + " (" + cbAcct.SelectedItem.ToString() + " -> " + comboBoxChooseBank.SelectedItem.ToString() + ")");
                totalS = totalS - transferam;
                writeSav();
            }

        }
    }
}
