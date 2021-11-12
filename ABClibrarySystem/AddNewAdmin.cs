﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace ABClibrarySystem
{
    public partial class AddNewAdmin : Form
    {
        public AddNewAdmin()
        {
            InitializeComponent();
        }
        String Gender;
        private void textBoxConfirmpassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirmpassword.Text)
            {
                labelpasswordmaching.ForeColor = Color.Green;
                labelpasswordmaching.Text = "Matched";

            }
            else
            {
                labelpasswordmaching.ForeColor = Color.Red;
                labelpasswordmaching.Text = "Not matching";
            }
        }

        private void textBoxPhonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButtonFeMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "FeMale";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNICNumber.Text == "")
            {
                MessageBox.Show("Insert NIC Number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (textBoxFristName.Text == "")
            {
                MessageBox.Show("Insert Frist Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxLastName.Text == "")
            {
                MessageBox.Show("Insert Last Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Insert Email", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Insert password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxConfirmpassword.Text == "")
            {
                MessageBox.Show("Insert Confirm Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (richTextBoxAdress.Text == "")
            {
                MessageBox.Show("Insert Adress", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPhonenumber.Text == "")
            {
                MessageBox.Show("Insert PhoneNumber", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                try
                {
                    AdminDB objt = new AdminDB();
                    //obj.NICNumber1 = textBoxNICNumber.Text;
                    SqlDataReader DR = objt.SearchDuplicatevalues(textBoxNICNumber.Text);
                    SqlCommand cmd = new SqlCommand();
                    int count = 0;
                    while (DR.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("This ID is Alradey in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {//inserting data
                        AdminDB obj = new AdminDB();

                        obj.NICNumber1 = textBoxNICNumber.Text;
                        obj.FristName1 = textBoxFristName.Text;
                        obj.LastName1 = textBoxLastName.Text;
                        obj.Email1 = textBoxEmail.Text;
                        obj.Password = textBoxConfirmpassword.Text;
                        obj.Gender1 = Gender;
                        obj.Address1 = richTextBoxAdress.Text;
                        obj.Phonenumber1 = Convert.ToInt32(textBoxPhonenumber.Text);
                        obj.Regdate = DateTime.Now;
                        obj.addNewAdmin(obj);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // sending user password via gmail
                try
                {
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("yourmail@gmail.com", "");
                    MailMessage mail = new MailMessage("yourmail@gmail.com", textBoxEmail.Text, "You Register as admin !Your loinid is  Your NIC Number and password given bellow ", textBoxConfirmpassword.Text);
                    mail.Priority = MailPriority.High;
                    smtp.Send(mail);
                    MessageBox.Show("Mail Send");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // clear text fileds
                textBoxNICNumber.Text = "";
                textBoxFristName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
                textBoxConfirmpassword.Text = "";
                richTextBoxAdress.Text = "";
                textBoxPhonenumber.Text = "";
                //textBoxRegistraionFee.Text = "";
            }
            }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
            this.Hide();
        }

        private void AddNewAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
