﻿namespace BankWithUs
{
    partial class TransferForm
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
            this.ConfirmDepositBtn.Location = new System.Drawing.Point(100, 82);
            this.ConfirmDepositBtn.Margin = new System.Windows.Forms.Padding(1);
            this.ConfirmDepositBtn.Name = "ConfirmDepositBtn";
            this.ConfirmDepositBtn.Size = new System.Drawing.Size(102, 22);
            this.ConfirmDepositBtn.TabIndex = 14;
            this.ConfirmDepositBtn.Text = "Confirm Transfer";
            this.ConfirmDepositBtn.UseVisualStyleBackColor = true;
            // 
            // DepositAmountTxt
            // 
            this.DepositAmountTxt.Location = new System.Drawing.Point(100, 47);
            this.DepositAmountTxt.Margin = new System.Windows.Forms.Padding(1);
            this.DepositAmountTxt.Name = "DepositAmountTxt";
            this.DepositAmountTxt.Size = new System.Drawing.Size(104, 20);
            this.DepositAmountTxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Transfer From:";
            // 
            // DepositToCBox
            // 
            this.DepositToCBox.FormattingEnabled = true;
            this.DepositToCBox.Location = new System.Drawing.Point(100, 15);
            this.DepositToCBox.Margin = new System.Windows.Forms.Padding(1);
            this.DepositToCBox.Name = "DepositToCBox";
            this.DepositToCBox.Size = new System.Drawing.Size(104, 21);
            this.DepositToCBox.TabIndex = 10;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 131);
            this.Controls.Add(this.ConfirmDepositBtn);
            this.Controls.Add(this.DepositAmountTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepositToCBox);
            this.Name = "TransferForm";
            this.Text = "Transfer";
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