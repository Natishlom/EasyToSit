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

        public string path = System.Windows.Forms.Application.StartupPath;
        private string phone;
        private int kodeReastart;
        List<User> listUsers;
        User user;

        public string Phone { get => phone; set => phone = value; }
        public int KodeReastart { get => kodeReastart; set => kodeReastart = value; }
        internal List<User> ListUsers { get => listUsers; set => listUsers = value; }
        internal User User { get => user; set => user = value; }

        public LoginPage()
        {
            InitializeComponent();
            panelBody.Show();
        }

        public void GetDatabaseList()
        {
            listUsers = new List<User>();
            string conString = "Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM EasyUsersDB", con))
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
        }

        public void GetUser(string userName)
        {
            foreach (User user in listUsers)
            {
                if (user.UserName.ToString().Equals(userName))
                    User = user;
            }
        }


        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtPass.Text = "";
                //txtPass.UseSystemPasswordChar = true;
                txtPass.Focus();
            }
        }

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
                            foreach (User u in listUsers)
                            {
                                maxId = Math.Max(maxId, u.Id);
                            }
                            CreateUser newUser = new CreateUser(maxId + 1);
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

        private void LoginPage_Load(object sender, EventArgs e)
        {
            panelForgot.Hide();


        }

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

        private void txtPhone_Click(object sender, EventArgs e)
        {
            selectText(txtPhone);
        }

        private void SendRestartPassword()
        {
            phone = txtPhone.Text;
            CreateKode();
        }

        public void CreateKode()
        {
            try
            {
                string temp = phone.Substring(0, 4);
                kodeReastart = Int32.Parse(temp);
                temp = phone.Substring(4, 3);
                kodeReastart += Int32.Parse(temp);
                temp = phone.Substring(7);
                kodeReastart += Int32.Parse(temp);
            }
            catch (Exception e)
            {

            }
        }

        public void selectText(TextBox t)
        {
            t.SelectAll();
        }

        private void txtPasswordForgot_Click(object sender, EventArgs e)
        {
            selectText(txtPasswordForgot);
        }


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
    }
}
