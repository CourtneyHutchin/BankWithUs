﻿namespace BankWithUs
{
    partial class RegisterForm
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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.FirstDepositTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.PhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Home Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "First Deposit:";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(670, 530);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(202, 53);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(321, 41);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(895, 38);
            this.FirstNameTxt.TabIndex = 0;
            // 
            // FirstDepositTxt
            // 
            this.FirstDepositTxt.Location = new System.Drawing.Point(321, 447);
            this.FirstDepositTxt.Name = "FirstDepositTxt";
            this.FirstDepositTxt.Size = new System.Drawing.Size(895, 38);
            this.FirstDepositTxt.TabIndex = 5;
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(321, 367);
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(895, 38);
            this.AddressTxt.TabIndex = 4;
            // 
            // PhoneNumberTxt
            // 
            this.PhoneNumberTxt.Location = new System.Drawing.Point(321, 284);
            this.PhoneNumberTxt.Name = "PhoneNumberTxt";
            this.PhoneNumberTxt.Size = new System.Drawing.Size(895, 38);
            this.PhoneNumberTxt.TabIndex = 3;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(321, 200);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(895, 38);
            this.EmailTxt.TabIndex = 2;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(321, 123);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(895, 38);
            this.LastNameTxt.TabIndex = 1;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 618);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.PhoneNumberTxt);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.FirstDepositTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Register";
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
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.TextBox FirstDepositTxt;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox PhoneNumberTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
    }
}