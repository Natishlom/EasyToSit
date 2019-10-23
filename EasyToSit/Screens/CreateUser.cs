using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        string conString = "Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True";

        internal User User { get => user; set => user = value; }

        public CreateUser()
        {
            InitializeComponent();
        }

        //סגירת החלון
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //סימון הטקסט
        private void txtUserName_Click(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.SelectAll();
        }

        //בדיקות ועדכון הפרטים
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ITextBoxOk())
            {
                if (CheckItem())
                {
                        if (IsValidEmail(txtMail.Text))
                        {
                        //user.UserName = txtUserName.Text;
                        //user.Password = txtPassword.Text;
                        //user.Phone = txtPhone.Text;
                        //user.NameHusband = txtxHusband.Text;
                        //user.NameWife = txtWife.Text;
                        //user.LaseName = txtLastName.Text;
                        //user.TaypeEvent = txtTaype.Text;
                        //user.DateEvent = DateTime.Parse(txtDate.Text);
                        //user.NameHall = txtHall.Text;
                        //user.EMail = txtMail.Text;
                        DateTime date = new DateTime();
                        date = DateTime.ParseExact(mskDate.Text, "dd/MM/yyyy",null);

                            try
                            {
                                con = new SqlConnection(conString);
                                con.Open();
                                cmd = new SqlCommand("INSERT INTO EasyUsersData (userName,password,phone,nameHusband,nameWife,lastName,taypeEvent,dataEvent,nameHall,eMail) VALUES ('"+txtUserName.Text+ "','" + txtPassword.Text + "','" + txtPhone.Text + "','" + txtxHusband.Text + "','" + txtWife.Text + "','" + txtLastName.Text + "','" + txtTaype.Text + "'," + "'" + date + "','" + txtHall.Text + "','" + txtMail.Text + "')", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("המשתמש נוסף בהצלחה", "Save",MessageBoxButtons.OK,MessageBoxIcon.Information);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                throw;
                            }
                            this.Close();
                        }
                        else
                        {
                            new LoginPage().messageBox("המייל שהזנת אינו קיים", "Error");
                        }
                    }
                else
                {
                    new LoginPage().messageBox("אופס, סוג האירוע אינו מוגדר במערכת", "Error");
                }
            }
        }

        //מתן הודעת שגיאה בעט הצורך באיזה טקסט בוקסים לא הוזן ערך
        public bool ITextBoxOk()
        {
            foreach (TextBox t in textBoxs)
            {
                if (!IsValue(t))
                {
                    new LoginPage().messageBox("בשדה: " + t.Name.ToString() + "לא הוזן ערך"+Environment.NewLine, "Error");
                    return false;
                }
            }
            if (!mskDate.MaskFull)
                return false;
            return true;
        }

        //בדיקת תקינות קלט של האימייל
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


        //בדיקה האם הוזן ערך נכון בשדה סוג האירוע
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

        //בדיקה האם הוזן ערך בטקסט בוקס
        private bool IsValue(TextBox t)
        {
            if (t.Text.Length > 0)
                return true;
            else
                return false;
        }

        //הוספת כל הטקסטבוקסים לרשימה 
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
            textBoxs.Add(txtHall);
            textBoxs.Add(txtMail);
        }
    }
}
