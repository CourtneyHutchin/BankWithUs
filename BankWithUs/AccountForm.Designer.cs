namespace BankWithUs
{
    partial class AccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.AccountHolderInfoLbl = new System.Windows.Forms.Label();
            this.AccountNumLbl = new System.Windows.Forms.Label();
            this.TotalBalanceLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckingBalanceLbl = new System.Windows.Forms.Label();
            this.SavingsBalanceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Holder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Four Digits Of Account Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Checking Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Savings Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(427, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Accounts:";
            // 
            // TransferBtn
            // 
            this.TransferBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TransferBtn.Location = new System.Drawing.Point(432, 213);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(251, 39);
            this.TransferBtn.TabIndex = 6;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // DepositBtn
            // 
            this.DepositBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DepositBtn.Location = new System.Drawing.Point(432, 159);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(251, 39);
            this.DepositBtn.TabIndex = 7;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = true;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogoutBtn.Location = new System.Drawing.Point(49, 213);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(81, 39);
            this.LogoutBtn.TabIndex = 8;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // AccountHolderInfoLbl
            // 
            this.AccountHolderInfoLbl.AutoSize = true;
            this.AccountHolderInfoLbl.Location = new System.Drawing.Point(268, 72);
            this.AccountHolderInfoLbl.Name = "AccountHolderInfoLbl";
            this.AccountHolderInfoLbl.Size = new System.Drawing.Size(59, 13);
            this.AccountHolderInfoLbl.TabIndex = 9;
            this.AccountHolderInfoLbl.Text = "John Smith";
            // 
            // AccountNumLbl
            // 
            this.AccountNumLbl.AutoSize = true;
            this.AccountNumLbl.Location = new System.Drawing.Point(268, 107);
            this.AccountNumLbl.Name = "AccountNumLbl";
            this.AccountNumLbl.Size = new System.Drawing.Size(31, 13);
            this.AccountNumLbl.TabIndex = 10;
            this.AccountNumLbl.Text = "1111";
            // 
            // TotalBalanceLbl
            // 
            this.TotalBalanceLbl.AutoSize = true;
            this.TotalBalanceLbl.Location = new System.Drawing.Point(268, 144);
            this.TotalBalanceLbl.Name = "TotalBalanceLbl";
            this.TotalBalanceLbl.Size = new System.Drawing.Size(40, 13);
            this.TotalBalanceLbl.TabIndex = 11;
            this.TotalBalanceLbl.Text = "$10.10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(44, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Account Info:";
            // 
            // CheckingBalanceLbl
            // 
            this.CheckingBalanceLbl.AutoSize = true;
            this.CheckingBalanceLbl.Location = new System.Drawing.Point(564, 72);
            this.CheckingBalanceLbl.Name = "CheckingBalanceLbl";
            this.CheckingBalanceLbl.Size = new System.Drawing.Size(28, 13);
            this.CheckingBalanceLbl.TabIndex = 13;
            this.CheckingBalanceLbl.Text = "5.05";
            // 
            // SavingsBalanceLbl
            // 
            this.SavingsBalanceLbl.AutoSize = true;
            this.SavingsBalanceLbl.Location = new System.Drawing.Point(564, 107);
            this.SavingsBalanceLbl.Name = "SavingsBalanceLbl";
            this.SavingsBalanceLbl.Size = new System.Drawing.Size(28, 13);
            this.SavingsBalanceLbl.TabIndex = 14;
            this.SavingsBalanceLbl.Text = "5.05";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 289);
            this.Controls.Add(this.SavingsBalanceLbl);
            this.Controls.Add(this.CheckingBalanceLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalBalanceLbl);
            this.Controls.Add(this.AccountNumLbl);
            this.Controls.Add(this.AccountHolderInfoLbl);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountForm";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label AccountHolderInfoLbl;
        private System.Windows.Forms.Label AccountNumLbl;
        private System.Windows.Forms.Label TotalBalanceLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CheckingBalanceLbl;
        private System.Windows.Forms.Label SavingsBalanceLbl;
    }
}