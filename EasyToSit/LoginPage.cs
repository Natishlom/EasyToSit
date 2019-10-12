﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EasyToSit
{
    public partial class LoginPage : Form
    {

        private const string userName = "nati";
        private const string password = "1234";
        public string path= System.Windows.Forms.Application.StartupPath;
        public LoginPage()
        {
            InitializeComponent();
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
            //בדיקה האם הוכנס שם משתמש
            if (txtUserName.Text.Length > 0 && !txtUserName.Text.Equals("שם משתמש"))
            {
                if (txtUserName.Text.Equals(userName))
                {
                    if (txtPass.Text.Equals(password))
                    {
                        this.Close();
                    }
                    else
                        messageBox("הסיסמה שהזנת שגויה, נא הזן סיסמה שנית", "שגיאה");
                }
                else
                    messageBox("שם המשתמש שהזנת אינו קיים, נא הזן שם המשתמש שנית", "שגיאה");
            }
            else
                messageBox("נתי ש לו מאי","שגיאה");
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
            
        }
    }
}
