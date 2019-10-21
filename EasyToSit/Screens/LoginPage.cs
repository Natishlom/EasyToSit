using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using System.Data;
using System.Data.SqlClient;
using EasyToSit.Classes;


namespace EasyToSit
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            panelBody.Show();
        }

        public string path = System.Windows.Forms.Application.StartupPath;
        private string phone;
        private int kodeReastart;
        List<User> listUsers;
        User user;


        public string Phone { get => phone; set => phone = value; }
        public int KodeReastart { get => kodeReastart; set => kodeReastart = value; }
        internal List<User> ListUsers { get => listUsers; set => listUsers = value; }
        internal User User { get => user; set => user = value; }


        //שליפת יוזרים מהדתא בייס
        public void GetDatabaseList()
        {
            listUsers = new List<User>();
            string conString = "Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM EasyUsersData", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                User user = new User();
                                user.Id = dr.GetInt32(0);
                                user.UserName = dr.GetString(1);
                                user.Password = dr.GetString(2);
                                user.Phone = dr.GetString(3);
                                user.NameHusband = dr.GetString(4);
                                user.NameWife = dr.GetString(5);
                                user.LaseName = dr.GetString(6);
                                user.TaypeEvent = dr.GetString(7);
                                user.DateEvent = dr.GetDateTime(8);
                                user.NameHall = dr.GetString(9);
                                user.EMail = dr.GetString(10);
                                listUsers.Add(user);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    messageBox(e.Message + "", "");
                }
            }
        }

        //קיבוע היוזר שהתחבר
        public void GetUser(string userName)
        {
            foreach (User user in listUsers)
            {
                if (user.UserName.ToString().Equals(userName))
                    User = user;
            }
        }

        //במעבר ע"י לחיצה על הנטר שדה טקסט בוקס התווים שבו יהפכו לסיסמה
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtPass.Text = "";
                //txtPass.UseSystemPasswordChar = true;
                txtPass.Focus();
                txtPass.Clear();
                txtPass.UseSystemPasswordChar = true;
            }
        }

        //לחיצה על חיבור 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetDatabaseList();
            int maxId = 0;
            //בדיקה האם הוכנס שם משתמש
            if (txtUserName.Text.Length > 0 && !txtUserName.Text.Equals("שם משתמש"))
            {
                GetUser(txtUserName.Text);
                if (txtUserName.Text.Equals(user.UserName.ToString()))
                {
                    if (txtPass.Text.Equals(user.Password.ToString()))
                    {
                        this.Close();
                        if (user.UserName.Equals("Easy"))
                        {
                            CreateUser newUser = new CreateUser();
                            newUser.Show();
                        }
                    }
                    else
                        messageBox("הסיסמה שהזנת שגויה, נא הזן סיסמה שנית", "שגיאה");
                }
                else
                    messageBox("שם המשתמש שהזנת אינו קיים, נא הזן שם המשתמש שנית", "שגיאה");
            }
            else
                messageBox("שם המשתמש אינו תקין", "שגיאה");
        }

        //מעבר ע"י לחיצה על הנטר לכפתור התחברות
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }


        private void txtPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "סיסמה")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;

            }
            else
            if (txtPass.Text == "")
            {
                txtPass.Text = "סיסמה";
                txtPass.UseSystemPasswordChar = false;

            }
        }

        #region מתודת הודעת טקסט
        /// <summary>
        /// הודעה
        /// </summary>
        /// <param name="content"></param>
        /// <param name="title"></param>
        public void messageBox(string content, string title)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }
        #endregion

        //בלחיצה על שגכחתי סיסמה יפתח חלון לשחזור נתונים ויצירת סיסמה חדשה
        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            panelBody.Hide();


            panelForgot.Show();
            panelForgot.Location = new System.Drawing.Point(30, 131);
            lblFogot.Hide();
            txtPasswordForgot.Hide();
            btnChangePass.Hide();
            txtNewPass.Hide();
            txtNewPassAgian.Hide();
            btnSavePass.Hide();
        }

        //בטעינת העמוד יוצג הפאנל הראשי של ההתחברות
        private void LoginPage_Load(object sender, EventArgs e)
        {
            panelForgot.Hide();
        }

        //שליחת הודעת קוד לאיפוס הסיסמה
        private void btnSend_Click(object sender, EventArgs e)
        {
            GetDatabaseList();
            GetUser(txtUserName.Text);
            if (txtUserName.Text.Length > 0)
            {
                if (!txtPhone.Text.Equals("מספר נייד לאיפוס סיסמה:") && txtPhone.Text.Length.Equals(10) && txtPhone.Text.Equals(user.Phone.ToString()))
                {
                    lblFogot.Show();
                    txtPasswordForgot.Show();
                    btnChangePass.Show();
                    SendRestartPassword();
                }
                else
                {
                    messageBox("מספר נייד אינו תקין", "שגיאה");
                }
            }
            else
                messageBox("נא להזין את שם המשתמש", "Error");
        }


        //סימון הטקסט
        private void txtPhone_Click(object sender, EventArgs e)
        {
            selectText(txtPhone);
        }

        //יצירת סיסמה המורכבת מחיבור ה-4 ספרות הראשונות עם 3 אחריהן + השלוש שאחריהן 
        //לדוג: 0526647172 - 0526+647+712=1885
        private void SendRestartPassword()
        {
            phone = txtPhone.Text;
            string temp = phone.Substring(0, 4);
            kodeReastart = Int32.Parse(temp);
            temp = phone.Substring(4, 3);
            kodeReastart += Int32.Parse(temp);
            temp = phone.Substring(7);
            kodeReastart += Int32.Parse(temp);
        }

        //מתודה לסימון הטקסט בטקסט בוקס
        public void selectText(TextBox t)
        {
            t.SelectAll();
        }

        private void txtPasswordForgot_Click(object sender, EventArgs e)
        {
            selectText(txtPasswordForgot);
        }

        //בדיקה האם הקוד שנשלח זהה לקוד שנוצר
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtPasswordForgot.Text.Equals(kodeReastart.ToString()))
            {
                txtNewPass.Show();
                txtNewPassAgian.Show();
                btnSavePass.Show();
            }
            else
            {
                messageBox("הקוד שהזנת אינו חוקי", "שגיאה");
                txtPasswordForgot.Focus();
                txtPasswordForgot.SelectAll();
            }
        }

        //אחרי יצירת הסיסמה החדשה איפוס פנל המשני והצגת הפאנל הראשי
        private void btnSavePass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Equals(txtNewPassAgian.Text))
            {
                panelForgot.Hide();
                phone = "";
                kodeReastart = 0;
                txtPhone.Text = "מספר נייד לאיפוס סיסמה:";
                txtPasswordForgot.Text = "סיסמת איפוס:";
                txtNewPass.UseSystemPasswordChar = false;
                txtNewPass.Text = "הזן סיסמה חדשה:";
                txtNewPassAgian.UseSystemPasswordChar = false;
                txtNewPassAgian.Text = "הזן סיסמה חדשה שוב:";
                messageBox("הסיסמה אופסה בהצלחה.", "הודעה");
                txtUserName.Text = "שם משתמש";
                txtPass.Text = "סיסמה";
                panelBody.Show();
            }
            else
            {
                messageBox("הסיסמאות שהזנת אינן תואמות, אנא הזן שנית", "שגיאה");
            }
        }

        //
        private void txtNewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Equals("הזן סיסמה חדשה:"))
            {
                txtNewPass.UseSystemPasswordChar = true;
                txtNewPass.Text = "";
            }
            else
                if (txtNewPass.Text.Equals(""))
            {
                txtNewPass.UseSystemPasswordChar = false;
                txtNewPass.Text = "הזן סיסמה חדשה:";
            }
            else
                txtNewPass.SelectAll();
        }

        //
        private void txtNewPassAgian_Click(object sender, EventArgs e)
        {
            if (txtNewPassAgian.Text.Equals("הזן סיסמה חדשה שוב:"))
            {
                txtNewPassAgian.UseSystemPasswordChar = true;
                txtNewPassAgian.Text = "";
            }
            else
                if (txtNewPassAgian.Text.Equals("הזן סיסמה חדשה שוב:"))
            {
                txtNewPassAgian.UseSystemPasswordChar = false;
                txtNewPassAgian.Text = "הזן סיסמה חדשה:";
            }
            else
                txtNewPassAgian.SelectAll();

        }

        //
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "סיסמה";
            }
        }
    }
}
