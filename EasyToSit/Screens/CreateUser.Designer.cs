namespace EasyToSit
{
    partial class CreateUser
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
            this.lblExit = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelSave = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtxHusband = new System.Windows.Forms.TextBox();
            this.txtWife = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTaype = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelSave.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.lblExit.Location = new System.Drawing.Point(5, 5);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 22);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.Location = new System.Drawing.Point(3, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(264, 29);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "שם משתמש:";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(5, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(62, 28);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "שמור";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.lblExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(270, 36);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.TabStop = true;
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.btnUpdate);
            this.panelSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSave.Location = new System.Drawing.Point(0, 454);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(270, 36);
            this.panelSave.TabIndex = 7;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.tableLayoutPanel1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 36);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(270, 418);
            this.panelBody.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtTaype, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtMail, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtHall, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtDate, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtWife, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtxHusband, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPhone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(3, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(264, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "סיסמה:";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPhone.ForeColor = System.Drawing.Color.Silver;
            this.txtPhone.Location = new System.Drawing.Point(3, 85);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(264, 29);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "מספר נייד:";
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtxHusband
            // 
            this.txtxHusband.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtxHusband.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtxHusband.ForeColor = System.Drawing.Color.Silver;
            this.txtxHusband.Location = new System.Drawing.Point(3, 126);
            this.txtxHusband.Name = "txtxHusband";
            this.txtxHusband.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtxHusband.Size = new System.Drawing.Size(264, 29);
            this.txtxHusband.TabIndex = 4;
            this.txtxHusband.Text = "שם החתן:";
            this.txtxHusband.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtxHusband.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtWife
            // 
            this.txtWife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWife.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtWife.ForeColor = System.Drawing.Color.Silver;
            this.txtWife.Location = new System.Drawing.Point(3, 167);
            this.txtWife.Name = "txtWife";
            this.txtWife.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWife.Size = new System.Drawing.Size(264, 29);
            this.txtWife.TabIndex = 5;
            this.txtWife.Text = "שם הכלה:";
            this.txtWife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWife.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLastName.ForeColor = System.Drawing.Color.Silver;
            this.txtLastName.Location = new System.Drawing.Point(3, 208);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(264, 29);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.Text = "שם משפחה:";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLastName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtDate
            // 
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDate.ForeColor = System.Drawing.Color.Silver;
            this.txtDate.Location = new System.Drawing.Point(3, 290);
            this.txtDate.Name = "txtDate";
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate.Size = new System.Drawing.Size(264, 29);
            this.txtDate.TabIndex = 8;
            this.txtDate.Tag = "Date";
            this.txtDate.Text = "תאריך האירוע:";
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtHall
            // 
            this.txtHall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHall.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtHall.ForeColor = System.Drawing.Color.Silver;
            this.txtHall.Location = new System.Drawing.Point(3, 331);
            this.txtHall.Name = "txtHall";
            this.txtHall.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHall.Size = new System.Drawing.Size(264, 29);
            this.txtHall.TabIndex = 9;
            this.txtHall.Text = "שם האולם:";
            this.txtHall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHall.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtMail
            // 
            this.txtMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMail.ForeColor = System.Drawing.Color.Silver;
            this.txtMail.Location = new System.Drawing.Point(3, 372);
            this.txtMail.Name = "txtMail";
            this.txtMail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMail.Size = new System.Drawing.Size(264, 29);
            this.txtMail.TabIndex = 10;
            this.txtMail.Tag = "Email";
            this.txtMail.Text = "אימייל:";
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMail.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtTaype
            // 
            this.txtTaype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTaype.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtTaype.ForeColor = System.Drawing.Color.Silver;
            this.txtTaype.Location = new System.Drawing.Point(3, 249);
            this.txtTaype.Name = "txtTaype";
            this.txtTaype.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTaype.Size = new System.Drawing.Size(264, 29);
            this.txtTaype.TabIndex = 7;
            this.txtTaype.Tag = "Taype";
            this.txtTaype.Text = "סוג האירוע:";
            this.txtTaype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTaype.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(68, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(135, 18);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "יצירת משתמש חדש:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 490);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.panelTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUser";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelSave.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtHall;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtWife;
        private System.Windows.Forms.TextBox txtxHusband;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTaype;
        private System.Windows.Forms.Label lblTitle;
    }
}