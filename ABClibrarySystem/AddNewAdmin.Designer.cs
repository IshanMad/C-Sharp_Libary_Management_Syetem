﻿namespace ABClibrarySystem
{
    partial class AddNewAdmin
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhonenumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelpasswordmaching = new System.Windows.Forms.Label();
            this.richTextBoxAdress = new System.Windows.Forms.RichTextBox();
            this.radioButtonFeMale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxConfirmpassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFristName = new System.Windows.Forms.TextBox();
            this.textBoxNICNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(62, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 45);
            this.label3.TabIndex = 33;
            this.label3.Text = "Add New Admin";
            // 
            // textBoxPhonenumber
            // 
            this.textBoxPhonenumber.Location = new System.Drawing.Point(129, 460);
            this.textBoxPhonenumber.Name = "textBoxPhonenumber";
            this.textBoxPhonenumber.Size = new System.Drawing.Size(250, 20);
            this.textBoxPhonenumber.TabIndex = 121;
            this.textBoxPhonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhonenumber_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 120;
            this.label9.Text = "Phone Number";
            // 
            // labelpasswordmaching
            // 
            this.labelpasswordmaching.AutoSize = true;
            this.labelpasswordmaching.Location = new System.Drawing.Point(410, 248);
            this.labelpasswordmaching.Name = "labelpasswordmaching";
            this.labelpasswordmaching.Size = new System.Drawing.Size(0, 13);
            this.labelpasswordmaching.TabIndex = 119;
            // 
            // richTextBoxAdress
            // 
            this.richTextBoxAdress.Location = new System.Drawing.Point(129, 329);
            this.richTextBoxAdress.Name = "richTextBoxAdress";
            this.richTextBoxAdress.Size = new System.Drawing.Size(368, 110);
            this.richTextBoxAdress.TabIndex = 118;
            this.richTextBoxAdress.Text = "";
            // 
            // radioButtonFeMale
            // 
            this.radioButtonFeMale.AutoSize = true;
            this.radioButtonFeMale.Location = new System.Drawing.Point(253, 279);
            this.radioButtonFeMale.Name = "radioButtonFeMale";
            this.radioButtonFeMale.Size = new System.Drawing.Size(63, 17);
            this.radioButtonFeMale.TabIndex = 117;
            this.radioButtonFeMale.TabStop = true;
            this.radioButtonFeMale.Text = "Fe-Male";
            this.radioButtonFeMale.UseVisualStyleBackColor = true;
            this.radioButtonFeMale.CheckedChanged += new System.EventHandler(this.radioButtonFeMale_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(129, 279);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 116;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // textBoxConfirmpassword
            // 
            this.textBoxConfirmpassword.Location = new System.Drawing.Point(129, 241);
            this.textBoxConfirmpassword.Name = "textBoxConfirmpassword";
            this.textBoxConfirmpassword.PasswordChar = '*';
            this.textBoxConfirmpassword.Size = new System.Drawing.Size(264, 20);
            this.textBoxConfirmpassword.TabIndex = 115;
            this.textBoxConfirmpassword.TextChanged += new System.EventHandler(this.textBoxConfirmpassword_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(129, 204);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(264, 20);
            this.textBoxPassword.TabIndex = 114;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(129, 170);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(264, 20);
            this.textBoxEmail.TabIndex = 113;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(129, 135);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(264, 20);
            this.textBoxLastName.TabIndex = 112;
            // 
            // textBoxFristName
            // 
            this.textBoxFristName.Location = new System.Drawing.Point(129, 102);
            this.textBoxFristName.Name = "textBoxFristName";
            this.textBoxFristName.Size = new System.Drawing.Size(264, 20);
            this.textBoxFristName.TabIndex = 111;
            // 
            // textBoxNICNumber
            // 
            this.textBoxNICNumber.Location = new System.Drawing.Point(129, 68);
            this.textBoxNICNumber.Name = "textBoxNICNumber";
            this.textBoxNICNumber.Size = new System.Drawing.Size(264, 20);
            this.textBoxNICNumber.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 109;
            this.label10.Text = "Confirm Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 108;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Frist Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "NIC Number";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(536, 374);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 122;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Back.Location = new System.Drawing.Point(12, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(47, 50);
            this.Back.TabIndex = 123;
            this.Back.Text = "<";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddNewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 513);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxPhonenumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelpasswordmaching);
            this.Controls.Add(this.richTextBoxAdress);
            this.Controls.Add(this.radioButtonFeMale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textBoxConfirmpassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFristName);
            this.Controls.Add(this.textBoxNICNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Name = "AddNewAdmin";
            this.Text = "AddNewAdmin";
            this.Load += new System.EventHandler(this.AddNewAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhonenumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelpasswordmaching;
        private System.Windows.Forms.RichTextBox richTextBoxAdress;
        private System.Windows.Forms.RadioButton radioButtonFeMale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox textBoxConfirmpassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFristName;
        private System.Windows.Forms.TextBox textBoxNICNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label Back;
    }
}