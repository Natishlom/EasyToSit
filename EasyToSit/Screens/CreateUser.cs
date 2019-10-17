using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyToSit
{
    public partial class CreateUser : Form
    {
        User user;
        List<TextBox> textBoxs;

        internal User User { get => user; set => user = value; }

        public CreateUser(int id)
        {
            InitializeComponent();
            user = new User();
            user.Id = id;
        }


        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.SelectAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ITextBoxOk())
            {
                if (CheckItem())
                {
                    if (IsDateTime(txtDate.Text))
                    {
                        if (IsValidEmail(txtMail.Text))
                        {
                            user.UserName = txtUserName.Text;
                            user.Password = txtPassword.Text;
                            user.Phone = txtPhone.Text;
                            user.NameHusband = txtxHusband.Text;
                            user.NameWife = txtWife.Text;
                            user.LaseName = txtLastName.Text;
                            user.TaypeEvent = txtTaype.Text;
                            user.DateEvent = DateTime.Parse(txtDate.Text);
                            user.NameHall = txtHall.Text;
                            user.EMail = txtMail.Text;
                            this.Close();
                        }
                        else
                        {
                            new LoginPage().messageBox("המייל שהזנת אינו קיים", "Error");
                        }
                    }
                    else
                    {
                        new LoginPage().messageBox("אופס, התאריך לא נרשם נכון ", "Error");
                    }
                }
                else
                {
                    new LoginPage().messageBox("אופס, סוג האירוע אינו מוגדר במערכת", "Error");
                }
            }
        }

        public bool ITextBoxOk()
        {
            foreach (TextBox t in textBoxs)
            {
                if (!IsValue(t))
                {
                    new LoginPage().messageBox("בשדה: " + t.Name.ToString() + "לא הוזן ערך", "Error");
                    return false;
                }
            }
            return true;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void DatTakin()
        {
            try
            {
                //בדיקה אם הוכנס שדה תאריך
                if (txtDate.Text.Length > 0)
                    //בדיקת תקינות קלט עבור שדה תאריך
                    if (!IsDateTime(txtDate.Text))
                    {
                        new LoginPage().messageBox("תאריך האירוע לא נשרם כראוי", "שגיאה");
                        txtDate.SelectAll();
                        txtDate.Focus();
                    }


            }
            catch (Exception e)
            {

            }
        }
        public static bool IsDateTime(string txtDate)
        {
            DateTime tempDate;
            return DateTime.TryParse(txtDate, out tempDate);
        }

        public bool CheckItem()
        {
            switch (txtTaype.Text)
            {
                case "חתונה":
                    {
                        return true;
                    }
                case "בר מצוה":
                    {
                        return true;
                    }
                case "חינה":
                    {
                        return true;
                    }
                case "בת מצוה":
                    {
                        return true;
                    }
                case "ברית":
                    {
                        return true;
                    }
                case "אירוסין":
                    {
                        return true;
                    }
                default: return false;
            }
        }

        private bool IsValue(TextBox t)
        {
            if (t.Text.Length > 0)
                return true;
            else
                return false;
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            textBoxs = new List<TextBox>();
            textBoxs.Add(txtUserName);
            textBoxs.Add(txtPassword);
            textBoxs.Add(txtPhone);
            textBoxs.Add(txtxHusband);
            textBoxs.Add(txtWife);
            textBoxs.Add(txtLastName);
            textBoxs.Add(txtTaype);
            textBoxs.Add(txtDate);
            textBoxs.Add(txtHall);
            textBoxs.Add(txtMail);
        }
    }
}
