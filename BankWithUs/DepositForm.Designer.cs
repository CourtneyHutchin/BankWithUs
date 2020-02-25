namespace BankWithUs
{
    partial class DepositForm
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
            this.ConfirmDepositBtn = new System.Windows.Forms.Button();
            this.DepositAmountTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DepositToCBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ConfirmDepositBtn
            // 
            this.ConfirmDepositBtn.Location = new System.Drawing.Point(240, 207);
            this.ConfirmDepositBtn.Name = "ConfirmDepositBtn";
            this.ConfirmDepositBtn.Size = new System.Drawing.Size(272, 44);
            this.ConfirmDepositBtn.TabIndex = 9;
            this.ConfirmDepositBtn.Text = "Confirm Deposit";
            this.ConfirmDepositBtn.UseVisualStyleBackColor = true;
            // 
            // DepositAmountTxt
            // 
            this.DepositAmountTxt.Location = new System.Drawing.Point(240, 125);
            this.DepositAmountTxt.Name = "DepositAmountTxt";
            this.DepositAmountTxt.Size = new System.Drawing.Size(272, 38);
            this.DepositAmountTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Deposit To:";
            // 
            // DepositToCBox
            // 
            this.DepositToCBox.FormattingEnabled = true;
            this.DepositToCBox.Location = new System.Drawing.Point(240, 47);
            this.DepositToCBox.Name = "DepositToCBox";
            this.DepositToCBox.Size = new System.Drawing.Size(272, 39);
            this.DepositToCBox.TabIndex = 5;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 291);
            this.Controls.Add(this.ConfirmDepositBtn);
            this.Controls.Add(this.DepositAmountTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepositToCBox);
            this.Name = "DepositForm";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmDepositBtn;
        private System.Windows.Forms.TextBox DepositAmountTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DepositToCBox;
    }
}