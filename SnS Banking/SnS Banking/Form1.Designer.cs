
namespace SnS_Banking
{
    partial class FormBankMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlAccount = new System.Windows.Forms.TabControl();
            this.tabPageStatements = new System.Windows.Forms.TabPage();
            this.totalBal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxVeiwStatements = new System.Windows.Forms.ListBox();
            this.listBoxShowTransactions = new System.Windows.Forms.ListBox();
            this.tabPageTransfers = new System.Windows.Forms.TabPage();
            this.groupBoxBankTransfer = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBankTrans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAcct = new System.Windows.Forms.ComboBox();
            this.tbAcct = new System.Windows.Forms.MaskedTextBox();
            this.tbRoute = new System.Windows.Forms.MaskedTextBox();
            this.buttonTransferBanks = new System.Windows.Forms.Button();
            this.labelRoutingNum = new System.Windows.Forms.Label();
            this.labeBankNum = new System.Windows.Forms.Label();
            this.labelChooseBank = new System.Windows.Forms.Label();
            this.comboBoxChooseBank = new System.Windows.Forms.ComboBox();
            this.buttonTransferActs = new System.Windows.Forms.Button();
            this.labelActTransTo = new System.Windows.Forms.Label();
            this.comboBoxTransferTo = new System.Windows.Forms.ComboBox();
            this.labelActtransFrom = new System.Windows.Forms.Label();
            this.comboBoxTransferFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAmtTransfer = new System.Windows.Forms.Label();
            this.tbtamt = new System.Windows.Forms.TextBox();
            this.tabPageWithDep = new System.Windows.Forms.TabPage();
            this.buttonAcceptDepWith = new System.Windows.Forms.Button();
            this.labelChooseAcct = new System.Windows.Forms.Label();
            this.labelChooseType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWithDepAmount = new System.Windows.Forms.Label();
            this.textBoxWithDepAmt = new System.Windows.Forms.TextBox();
            this.comboBoxWithDepAccount = new System.Windows.Forms.ComboBox();
            this.radioButtonDeposit = new System.Windows.Forms.RadioButton();
            this.radioButtonWithdraw = new System.Windows.Forms.RadioButton();
            this.bLogout = new System.Windows.Forms.Button();
            this.lLoggedin = new System.Windows.Forms.Label();
            this.tabControlAccount.SuspendLayout();
            this.tabPageStatements.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageTransfers.SuspendLayout();
            this.groupBoxBankTransfer.SuspendLayout();
            this.tabPageWithDep.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAccount
            // 
            this.tabControlAccount.Controls.Add(this.tabPageStatements);
            this.tabControlAccount.Controls.Add(this.tabPageTransfers);
            this.tabControlAccount.Controls.Add(this.tabPageWithDep);
            this.tabControlAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControlAccount.Location = new System.Drawing.Point(12, 12);
            this.tabControlAccount.Name = "tabControlAccount";
            this.tabControlAccount.SelectedIndex = 0;
            this.tabControlAccount.Size = new System.Drawing.Size(776, 426);
            this.tabControlAccount.TabIndex = 0;
            // 
            // tabPageStatements
            // 
            this.tabPageStatements.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tabPageStatements.Controls.Add(this.totalBal);
            this.tabPageStatements.Controls.Add(this.groupBox1);
            this.tabPageStatements.Controls.Add(this.listBoxShowTransactions);
            this.tabPageStatements.Location = new System.Drawing.Point(4, 25);
            this.tabPageStatements.Name = "tabPageStatements";
            this.tabPageStatements.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatements.Size = new System.Drawing.Size(768, 397);
            this.tabPageStatements.TabIndex = 0;
            this.tabPageStatements.Text = "Statements";
            // 
            // totalBal
            // 
            this.totalBal.Location = new System.Drawing.Point(306, 323);
            this.totalBal.Name = "totalBal";
            this.totalBal.Size = new System.Drawing.Size(456, 28);
            this.totalBal.TabIndex = 3;
            this.totalBal.Text = "Total Balance:";
            this.totalBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxVeiwStatements);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 372);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statements";
            // 
            // listBoxVeiwStatements
            // 
            this.listBoxVeiwStatements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxVeiwStatements.FormattingEnabled = true;
            this.listBoxVeiwStatements.ItemHeight = 16;
            this.listBoxVeiwStatements.Location = new System.Drawing.Point(6, 22);
            this.listBoxVeiwStatements.Name = "listBoxVeiwStatements";
            this.listBoxVeiwStatements.Size = new System.Drawing.Size(281, 340);
            this.listBoxVeiwStatements.TabIndex = 0;
            this.listBoxVeiwStatements.SelectedIndexChanged += new System.EventHandler(this.listBoxVeiwStatements_SelectedIndexChanged);
            this.listBoxVeiwStatements.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxVeiwStatements_MouseDown);
            // 
            // listBoxShowTransactions
            // 
            this.listBoxShowTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxShowTransactions.FormattingEnabled = true;
            this.listBoxShowTransactions.ItemHeight = 16;
            this.listBoxShowTransactions.Location = new System.Drawing.Point(305, 6);
            this.listBoxShowTransactions.Name = "listBoxShowTransactions";
            this.listBoxShowTransactions.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxShowTransactions.Size = new System.Drawing.Size(457, 292);
            this.listBoxShowTransactions.TabIndex = 1;
            this.listBoxShowTransactions.SelectedIndexChanged += new System.EventHandler(this.listBoxShowTransactions_SelectedIndexChanged);
            // 
            // tabPageTransfers
            // 
            this.tabPageTransfers.BackColor = System.Drawing.Color.Silver;
            this.tabPageTransfers.Controls.Add(this.groupBoxBankTransfer);
            this.tabPageTransfers.Controls.Add(this.buttonTransferActs);
            this.tabPageTransfers.Controls.Add(this.labelActTransTo);
            this.tabPageTransfers.Controls.Add(this.comboBoxTransferTo);
            this.tabPageTransfers.Controls.Add(this.labelActtransFrom);
            this.tabPageTransfers.Controls.Add(this.comboBoxTransferFrom);
            this.tabPageTransfers.Controls.Add(this.label2);
            this.tabPageTransfers.Controls.Add(this.labelAmtTransfer);
            this.tabPageTransfers.Controls.Add(this.tbtamt);
            this.tabPageTransfers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageTransfers.Location = new System.Drawing.Point(4, 25);
            this.tabPageTransfers.Name = "tabPageTransfers";
            this.tabPageTransfers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransfers.Size = new System.Drawing.Size(768, 397);
            this.tabPageTransfers.TabIndex = 1;
            this.tabPageTransfers.Text = "Transfers";
            this.tabPageTransfers.Click += new System.EventHandler(this.tabPageTransfers_Click);
            // 
            // groupBoxBankTransfer
            // 
            this.groupBoxBankTransfer.Controls.Add(this.label5);
            this.groupBoxBankTransfer.Controls.Add(this.label3);
            this.groupBoxBankTransfer.Controls.Add(this.tbBankTrans);
            this.groupBoxBankTransfer.Controls.Add(this.label1);
            this.groupBoxBankTransfer.Controls.Add(this.cbAcct);
            this.groupBoxBankTransfer.Controls.Add(this.tbAcct);
            this.groupBoxBankTransfer.Controls.Add(this.tbRoute);
            this.groupBoxBankTransfer.Controls.Add(this.buttonTransferBanks);
            this.groupBoxBankTransfer.Controls.Add(this.labelRoutingNum);
            this.groupBoxBankTransfer.Controls.Add(this.labeBankNum);
            this.groupBoxBankTransfer.Controls.Add(this.labelChooseBank);
            this.groupBoxBankTransfer.Controls.Add(this.comboBoxChooseBank);
            this.groupBoxBankTransfer.Location = new System.Drawing.Point(49, 179);
            this.groupBoxBankTransfer.Name = "groupBoxBankTransfer";
            this.groupBoxBankTransfer.Size = new System.Drawing.Size(242, 215);
            this.groupBoxBankTransfer.TabIndex = 8;
            this.groupBoxBankTransfer.TabStop = false;
            this.groupBoxBankTransfer.Text = "or choose to transfer to another bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "$";
            // 
            // tbBankTrans
            // 
            this.tbBankTrans.Location = new System.Drawing.Point(125, 29);
            this.tbBankTrans.Name = "tbBankTrans";
            this.tbBankTrans.Size = new System.Drawing.Size(100, 22);
            this.tbBankTrans.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose Account";
            // 
            // cbAcct
            // 
            this.cbAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcct.FormattingEnabled = true;
            this.cbAcct.Items.AddRange(new object[] {
            "Checkings",
            "Savings"});
            this.cbAcct.Location = new System.Drawing.Point(115, 88);
            this.cbAcct.Name = "cbAcct";
            this.cbAcct.Size = new System.Drawing.Size(121, 24);
            this.cbAcct.TabIndex = 9;
            // 
            // tbAcct
            // 
            this.tbAcct.Location = new System.Drawing.Point(125, 152);
            this.tbAcct.Mask = "000000000000";
            this.tbAcct.Name = "tbAcct";
            this.tbAcct.Size = new System.Drawing.Size(100, 22);
            this.tbAcct.TabIndex = 10;
            this.tbAcct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAcct.ValidatingType = typeof(int);
            // 
            // tbRoute
            // 
            this.tbRoute.Location = new System.Drawing.Point(125, 121);
            this.tbRoute.Mask = "000000000";
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.Size = new System.Drawing.Size(100, 22);
            this.tbRoute.TabIndex = 9;
            this.tbRoute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRoute.ValidatingType = typeof(int);
            // 
            // buttonTransferBanks
            // 
            this.buttonTransferBanks.Location = new System.Drawing.Point(61, 188);
            this.buttonTransferBanks.Name = "buttonTransferBanks";
            this.buttonTransferBanks.Size = new System.Drawing.Size(110, 23);
            this.buttonTransferBanks.TabIndex = 9;
            this.buttonTransferBanks.Text = "Transfer";
            this.buttonTransferBanks.UseVisualStyleBackColor = true;
            this.buttonTransferBanks.Click += new System.EventHandler(this.buttonTransferBanks_Click);
            // 
            // labelRoutingNum
            // 
            this.labelRoutingNum.AutoSize = true;
            this.labelRoutingNum.Location = new System.Drawing.Point(4, 155);
            this.labelRoutingNum.Name = "labelRoutingNum";
            this.labelRoutingNum.Size = new System.Drawing.Size(106, 16);
            this.labelRoutingNum.TabIndex = 5;
            this.labelRoutingNum.Text = "Account Number";
            // 
            // labeBankNum
            // 
            this.labeBankNum.AutoSize = true;
            this.labeBankNum.Location = new System.Drawing.Point(4, 119);
            this.labeBankNum.Name = "labeBankNum";
            this.labeBankNum.Size = new System.Drawing.Size(104, 16);
            this.labeBankNum.TabIndex = 4;
            this.labeBankNum.Text = "Routing Number";
            // 
            // labelChooseBank
            // 
            this.labelChooseBank.AutoSize = true;
            this.labelChooseBank.Location = new System.Drawing.Point(6, 61);
            this.labelChooseBank.Name = "labelChooseBank";
            this.labelChooseBank.Size = new System.Drawing.Size(88, 16);
            this.labelChooseBank.TabIndex = 1;
            this.labelChooseBank.Text = "Choose Bank";
            // 
            // comboBoxChooseBank
            // 
            this.comboBoxChooseBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseBank.FormattingEnabled = true;
            this.comboBoxChooseBank.Items.AddRange(new object[] {
            "Chase",
            "Webster",
            "Bank of America",
            "Wells Fargo",
            "TD Bank",
            "Capital One"});
            this.comboBoxChooseBank.Location = new System.Drawing.Point(115, 58);
            this.comboBoxChooseBank.Name = "comboBoxChooseBank";
            this.comboBoxChooseBank.Size = new System.Drawing.Size(121, 24);
            this.comboBoxChooseBank.TabIndex = 0;
            // 
            // buttonTransferActs
            // 
            this.buttonTransferActs.Location = new System.Drawing.Point(110, 134);
            this.buttonTransferActs.Name = "buttonTransferActs";
            this.buttonTransferActs.Size = new System.Drawing.Size(110, 23);
            this.buttonTransferActs.TabIndex = 7;
            this.buttonTransferActs.Text = "Transfer";
            this.buttonTransferActs.UseVisualStyleBackColor = true;
            this.buttonTransferActs.Click += new System.EventHandler(this.buttonTransferActs_Click);
            // 
            // labelActTransTo
            // 
            this.labelActTransTo.AutoSize = true;
            this.labelActTransTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelActTransTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActTransTo.Location = new System.Drawing.Point(453, 183);
            this.labelActTransTo.Name = "labelActTransTo";
            this.labelActTransTo.Size = new System.Drawing.Size(165, 22);
            this.labelActTransTo.TabIndex = 6;
            this.labelActTransTo.Text = "Account to transfer to";
            // 
            // comboBoxTransferTo
            // 
            this.comboBoxTransferTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransferTo.FormattingEnabled = true;
            this.comboBoxTransferTo.Items.AddRange(new object[] {
            "Checkings",
            "Savings"});
            this.comboBoxTransferTo.Location = new System.Drawing.Point(473, 208);
            this.comboBoxTransferTo.Name = "comboBoxTransferTo";
            this.comboBoxTransferTo.Size = new System.Drawing.Size(124, 24);
            this.comboBoxTransferTo.TabIndex = 5;
            // 
            // labelActtransFrom
            // 
            this.labelActtransFrom.AutoSize = true;
            this.labelActtransFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelActtransFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActtransFrom.Location = new System.Drawing.Point(444, 79);
            this.labelActtransFrom.Name = "labelActtransFrom";
            this.labelActtransFrom.Size = new System.Drawing.Size(183, 22);
            this.labelActtransFrom.TabIndex = 4;
            this.labelActtransFrom.Text = "Account to transfer from";
            // 
            // comboBoxTransferFrom
            // 
            this.comboBoxTransferFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransferFrom.FormattingEnabled = true;
            this.comboBoxTransferFrom.Items.AddRange(new object[] {
            "Checkings",
            "Savings"});
            this.comboBoxTransferFrom.Location = new System.Drawing.Point(473, 104);
            this.comboBoxTransferFrom.Name = "comboBoxTransferFrom";
            this.comboBoxTransferFrom.Size = new System.Drawing.Size(124, 24);
            this.comboBoxTransferFrom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            // 
            // labelAmtTransfer
            // 
            this.labelAmtTransfer.AutoSize = true;
            this.labelAmtTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAmtTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmtTransfer.Location = new System.Drawing.Point(91, 79);
            this.labelAmtTransfer.Name = "labelAmtTransfer";
            this.labelAmtTransfer.Size = new System.Drawing.Size(144, 22);
            this.labelAmtTransfer.TabIndex = 1;
            this.labelAmtTransfer.Text = "Amount to transfer";
            // 
            // tbtamt
            // 
            this.tbtamt.Location = new System.Drawing.Point(110, 104);
            this.tbtamt.Name = "tbtamt";
            this.tbtamt.Size = new System.Drawing.Size(110, 22);
            this.tbtamt.TabIndex = 0;
            this.tbtamt.TextChanged += new System.EventHandler(this.textBoxTransferAmt_TextChanged);
            // 
            // tabPageWithDep
            // 
            this.tabPageWithDep.BackColor = System.Drawing.Color.Silver;
            this.tabPageWithDep.Controls.Add(this.buttonAcceptDepWith);
            this.tabPageWithDep.Controls.Add(this.labelChooseAcct);
            this.tabPageWithDep.Controls.Add(this.labelChooseType);
            this.tabPageWithDep.Controls.Add(this.label4);
            this.tabPageWithDep.Controls.Add(this.labelWithDepAmount);
            this.tabPageWithDep.Controls.Add(this.textBoxWithDepAmt);
            this.tabPageWithDep.Controls.Add(this.comboBoxWithDepAccount);
            this.tabPageWithDep.Controls.Add(this.radioButtonDeposit);
            this.tabPageWithDep.Controls.Add(this.radioButtonWithdraw);
            this.tabPageWithDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageWithDep.Location = new System.Drawing.Point(4, 25);
            this.tabPageWithDep.Name = "tabPageWithDep";
            this.tabPageWithDep.Size = new System.Drawing.Size(768, 397);
            this.tabPageWithDep.TabIndex = 2;
            this.tabPageWithDep.Text = "Withdrawl/Deposit";
            // 
            // buttonAcceptDepWith
            // 
            this.buttonAcceptDepWith.Location = new System.Drawing.Point(560, 109);
            this.buttonAcceptDepWith.Name = "buttonAcceptDepWith";
            this.buttonAcceptDepWith.Size = new System.Drawing.Size(121, 25);
            this.buttonAcceptDepWith.TabIndex = 8;
            this.buttonAcceptDepWith.Text = "Accept";
            this.buttonAcceptDepWith.UseVisualStyleBackColor = true;
            this.buttonAcceptDepWith.Click += new System.EventHandler(this.buttonAcceptDepWith_Click);
            // 
            // labelChooseAcct
            // 
            this.labelChooseAcct.AutoSize = true;
            this.labelChooseAcct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelChooseAcct.Location = new System.Drawing.Point(207, 72);
            this.labelChooseAcct.Name = "labelChooseAcct";
            this.labelChooseAcct.Size = new System.Drawing.Size(170, 25);
            this.labelChooseAcct.TabIndex = 7;
            this.labelChooseAcct.Text = "Choose Account";
            // 
            // labelChooseType
            // 
            this.labelChooseType.AutoSize = true;
            this.labelChooseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelChooseType.Location = new System.Drawing.Point(51, 72);
            this.labelChooseType.Name = "labelChooseType";
            this.labelChooseType.Size = new System.Drawing.Size(140, 25);
            this.labelChooseType.TabIndex = 6;
            this.labelChooseType.Text = "Choose Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(379, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "$";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelWithDepAmount
            // 
            this.labelWithDepAmount.AutoSize = true;
            this.labelWithDepAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelWithDepAmount.Location = new System.Drawing.Point(412, 72);
            this.labelWithDepAmount.Name = "labelWithDepAmount";
            this.labelWithDepAmount.Size = new System.Drawing.Size(85, 25);
            this.labelWithDepAmount.TabIndex = 4;
            this.labelWithDepAmount.Text = "Amount";
            // 
            // textBoxWithDepAmt
            // 
            this.textBoxWithDepAmt.Location = new System.Drawing.Point(397, 109);
            this.textBoxWithDepAmt.Name = "textBoxWithDepAmt";
            this.textBoxWithDepAmt.Size = new System.Drawing.Size(121, 22);
            this.textBoxWithDepAmt.TabIndex = 3;
            // 
            // comboBoxWithDepAccount
            // 
            this.comboBoxWithDepAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWithDepAccount.FormattingEnabled = true;
            this.comboBoxWithDepAccount.Items.AddRange(new object[] {
            "Checkings",
            "Savings"});
            this.comboBoxWithDepAccount.Location = new System.Drawing.Point(222, 110);
            this.comboBoxWithDepAccount.Name = "comboBoxWithDepAccount";
            this.comboBoxWithDepAccount.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWithDepAccount.TabIndex = 2;
            // 
            // radioButtonDeposit
            // 
            this.radioButtonDeposit.AutoSize = true;
            this.radioButtonDeposit.Location = new System.Drawing.Point(51, 143);
            this.radioButtonDeposit.Name = "radioButtonDeposit";
            this.radioButtonDeposit.Size = new System.Drawing.Size(72, 20);
            this.radioButtonDeposit.TabIndex = 1;
            this.radioButtonDeposit.Text = "Deposit";
            this.radioButtonDeposit.UseVisualStyleBackColor = true;
            // 
            // radioButtonWithdraw
            // 
            this.radioButtonWithdraw.AutoSize = true;
            this.radioButtonWithdraw.Location = new System.Drawing.Point(51, 111);
            this.radioButtonWithdraw.Name = "radioButtonWithdraw";
            this.radioButtonWithdraw.Size = new System.Drawing.Size(83, 20);
            this.radioButtonWithdraw.TabIndex = 0;
            this.radioButtonWithdraw.Text = "Withdrawl";
            this.radioButtonWithdraw.UseVisualStyleBackColor = true;
            // 
            // bLogout
            // 
            this.bLogout.Location = new System.Drawing.Point(683, 8);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(95, 23);
            this.bLogout.TabIndex = 1;
            this.bLogout.Text = "Logout";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // lLoggedin
            // 
            this.lLoggedin.Location = new System.Drawing.Point(520, 8);
            this.lLoggedin.Name = "lLoggedin";
            this.lLoggedin.Size = new System.Drawing.Size(157, 23);
            this.lLoggedin.TabIndex = 2;
            this.lLoggedin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lLoggedin.Click += new System.EventHandler(this.label6_Click);
            // 
            // FormBankMain
            // 
            this.AcceptButton = this.buttonAcceptDepWith;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lLoggedin);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.tabControlAccount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBankMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S&S Banking";
            this.Load += new System.EventHandler(this.FormBankMain_Load);
            this.tabControlAccount.ResumeLayout(false);
            this.tabPageStatements.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPageTransfers.ResumeLayout(false);
            this.tabPageTransfers.PerformLayout();
            this.groupBoxBankTransfer.ResumeLayout(false);
            this.groupBoxBankTransfer.PerformLayout();
            this.tabPageWithDep.ResumeLayout(false);
            this.tabPageWithDep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAccount;
        private System.Windows.Forms.TabPage tabPageStatements;
        private System.Windows.Forms.ListBox listBoxVeiwStatements;
        private System.Windows.Forms.TabPage tabPageTransfers;
        private System.Windows.Forms.TabPage tabPageWithDep;
        private System.Windows.Forms.RadioButton radioButtonDeposit;
        private System.Windows.Forms.RadioButton radioButtonWithdraw;
        private System.Windows.Forms.ListBox listBoxShowTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAmtTransfer;
        private System.Windows.Forms.TextBox tbtamt;
        private System.Windows.Forms.Label labelChooseAcct;
        private System.Windows.Forms.Label labelChooseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWithDepAmount;
        private System.Windows.Forms.TextBox textBoxWithDepAmt;
        private System.Windows.Forms.ComboBox comboBoxWithDepAccount;
        private System.Windows.Forms.GroupBox groupBoxBankTransfer;
        private System.Windows.Forms.Button buttonTransferBanks;
        private System.Windows.Forms.Label labelRoutingNum;
        private System.Windows.Forms.Label labeBankNum;
        private System.Windows.Forms.Label labelChooseBank;
        private System.Windows.Forms.ComboBox comboBoxChooseBank;
        private System.Windows.Forms.Button buttonTransferActs;
        private System.Windows.Forms.Label labelActTransTo;
        private System.Windows.Forms.ComboBox comboBoxTransferTo;
        private System.Windows.Forms.Label labelActtransFrom;
        private System.Windows.Forms.ComboBox comboBoxTransferFrom;
        private System.Windows.Forms.Button buttonAcceptDepWith;
        private System.Windows.Forms.MaskedTextBox tbAcct;
        private System.Windows.Forms.MaskedTextBox tbRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAcct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBankTrans;
        private System.Windows.Forms.Button bLogout;
        public System.Windows.Forms.Label lLoggedin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalBal;
    }
}

