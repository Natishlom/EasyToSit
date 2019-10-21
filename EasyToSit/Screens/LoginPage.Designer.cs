namespace EasyToSit
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.lblLoginPage = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnForgotPass = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForgot = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.txtNewPassAgian = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtPasswordForgot = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblFogot = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelForgot.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginPage
            // 
            this.lblLoginPage.AutoSize = true;
            this.lblLoginPage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLoginPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.lblLoginPage.Location = new System.Drawing.Point(282, 27);
            this.lblLoginPage.Name = "lblLoginPage";
            this.lblLoginPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoginPage.Size = new System.Drawing.Size(142, 24);
            this.lblLoginPage.TabIndex = 0;
            this.lblLoginPage.Text = "מסך התחברות:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.Location = new System.Drawing.Point(206, 83);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(282, 29);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "שם משתמש";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPass.ForeColor = System.Drawing.Color.Silver;
            this.txtPass.Location = new System.Drawing.Point(208, 143);
            this.txtPass.Name = "txtPass";
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPass.Size = new System.Drawing.Size(282, 29);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "סיסמה";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnForgotPass.Location = new System.Drawing.Point(208, 210);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnForgotPass.Size = new System.Drawing.Size(98, 35);
            this.btnForgotPass.TabIndex = 4;
            this.btnForgotPass.Text = "שכחתי סיסמה";
            this.btnForgotPass.UseVisualStyleBackColor = false;
            this.btnForgotPass.Click += new System.EventHandler(this.btnForgotPass_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(392, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLogin.Size = new System.Drawing.Size(98, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "התחבר";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(310, 16);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(184, 109);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 7;
            this.pictureLogo.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.panelForgot);
            this.panelMain.Controls.Add(this.panelBody);
            this.panelMain.Controls.Add(this.pictureLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(796, 461);
            this.panelMain.TabIndex = 2;
            // 
            // panelForgot
            // 
            this.panelForgot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelForgot.Controls.Add(this.btnSend);
            this.panelForgot.Controls.Add(this.btnSavePass);
            this.panelForgot.Controls.Add(this.txtNewPassAgian);
            this.panelForgot.Controls.Add(this.txtNewPass);
            this.panelForgot.Controls.Add(this.btnChangePass);
            this.panelForgot.Controls.Add(this.txtPasswordForgot);
            this.panelForgot.Controls.Add(this.txtPhone);
            this.panelForgot.Controls.Add(this.lblFogot);
            this.panelForgot.Location = new System.Drawing.Point(32, 131);
            this.panelForgot.Name = "panelForgot";
            this.panelForgot.Size = new System.Drawing.Size(731, 325);
            this.panelForgot.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Location = new System.Drawing.Point(257, 36);
            this.btnSend.Name = "btnSend";
            this.btnSend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSend.Size = new System.Drawing.Size(83, 29);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "שלח";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSavePass
            // 
            this.btnSavePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnSavePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSavePass.Location = new System.Drawing.Point(257, 284);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSavePass.Size = new System.Drawing.Size(83, 29);
            this.btnSavePass.TabIndex = 7;
            this.btnSavePass.Text = "שמור סימה";
            this.btnSavePass.UseVisualStyleBackColor = false;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // txtNewPassAgian
            // 
            this.txtNewPassAgian.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNewPassAgian.ForeColor = System.Drawing.Color.Silver;
            this.txtNewPassAgian.Location = new System.Drawing.Point(346, 249);
            this.txtNewPassAgian.Name = "txtNewPassAgian";
            this.txtNewPassAgian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNewPassAgian.Size = new System.Drawing.Size(193, 29);
            this.txtNewPassAgian.TabIndex = 6;
            this.txtNewPassAgian.Text = "הזן סיסמה חדשה שוב:";
            this.txtNewPassAgian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPassAgian.Click += new System.EventHandler(this.txtNewPassAgian_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNewPass.ForeColor = System.Drawing.Color.Silver;
            this.txtNewPass.Location = new System.Drawing.Point(346, 204);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNewPass.Size = new System.Drawing.Size(193, 29);
            this.txtNewPass.TabIndex = 5;
            this.txtNewPass.Text = "הזן סיסמה חדשה:";
            this.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPass.Click += new System.EventHandler(this.txtNewPass_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangePass.Location = new System.Drawing.Point(257, 152);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangePass.Size = new System.Drawing.Size(83, 29);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "אפס";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtPasswordForgot
            // 
            this.txtPasswordForgot.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPasswordForgot.ForeColor = System.Drawing.Color.Silver;
            this.txtPasswordForgot.Location = new System.Drawing.Point(346, 152);
            this.txtPasswordForgot.Name = "txtPasswordForgot";
            this.txtPasswordForgot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPasswordForgot.Size = new System.Drawing.Size(193, 29);
            this.txtPasswordForgot.TabIndex = 3;
            this.txtPasswordForgot.Text = "סיסמת איפוס:";
            this.txtPasswordForgot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswordForgot.Click += new System.EventHandler(this.txtPasswordForgot_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPhone.ForeColor = System.Drawing.Color.Silver;
            this.txtPhone.Location = new System.Drawing.Point(346, 36);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(193, 29);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Text = "מספר נייד לאיפוס סיסמה:";
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.Click += new System.EventHandler(this.txtPhone_Click);
            // 
            // lblFogot
            // 
            this.lblFogot.AutoSize = true;
            this.lblFogot.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFogot.Location = new System.Drawing.Point(244, 89);
            this.lblFogot.Name = "lblFogot";
            this.lblFogot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFogot.Size = new System.Drawing.Size(317, 44);
            this.lblFogot.TabIndex = 0;
            this.lblFogot.Text = "ברגעים אלו תקבל סיסמת איפוס לנייד.\r\nנא הזן סיסמה זו על מנת לאפס סיסמתך.";
            this.lblFogot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.btnLogin);
            this.panelBody.Controls.Add(this.btnForgotPass);
            this.panelBody.Controls.Add(this.txtPass);
            this.panelBody.Controls.Add(this.txtUserName);
            this.panelBody.Controls.Add(this.lblLoginPage);
            this.panelBody.Location = new System.Drawing.Point(35, 131);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(718, 294);
            this.panelBody.TabIndex = 0;
            this.panelBody.TabStop = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 461);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelForgot.ResumeLayout(false);
            this.panelForgot.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoginPage;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnForgotPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelForgot;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.TextBox txtNewPassAgian;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox txtPasswordForgot;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblFogot;
    }
}