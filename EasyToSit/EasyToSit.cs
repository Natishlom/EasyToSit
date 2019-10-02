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


    public partial class EasyToSit : Form
    {
       

        public EasyToSit()
        {
            InitializeComponent();
        }


        #region הגדרות עבור תפריט ראשי
        private void lblDetails_Click(object sender, EventArgs e)
        {
            CheckIt(lblDetails, pitemDetails, lblGuests, pitemGuests, lblCreateSkitza, pitemCreateSkitza, lblSendMass, pitemSendMass, lblSit, pitemSit);
            panelSecond.Width = 0;
            lblMenu.Text = "תפריט";
            Details detailsPage = new Details();
            detailsPage.MdiParent = this;
            detailsPage.Dock = DockStyle.Fill;
            detailsPage.Show();
        }

        private void lblGuests_Click(object sender, EventArgs e)
        {
            CheckIt(lblGuests, pitemGuests, lblSit, pitemSit, lblCreateSkitza, pitemCreateSkitza, lblSendMass, pitemSendMass, lblDetails, pitemDetails);
            panelSecond.Width = 0;
            lblMenu.Text = "תפריט";
            Guests guestsPage = new Guests();
            guestsPage.MdiParent = this;
            guestsPage.Dock = DockStyle.Fill;
            guestsPage.Show();
        }

        private void lblCreateSkitza_Click(object sender, EventArgs e)
        {
            CheckIt(lblCreateSkitza, pitemCreateSkitza, lblGuests, pitemGuests, lblSit, pitemSit, lblSendMass, pitemSendMass, lblDetails, pitemDetails);
            panelSecond.Width = 0;
            lblMenu.Text = "תפריט";
            CreateSkitza createSkitzaPage = new CreateSkitza();
            createSkitzaPage.MdiParent = this;
            createSkitzaPage.Dock = DockStyle.Fill;
            createSkitzaPage.Show();
        }

        private void lblSendMass_Click(object sender, EventArgs e)
        {
            CheckIt(lblSendMass, pitemSendMass, lblGuests, pitemGuests, lblCreateSkitza, pitemCreateSkitza, lblSit, pitemSit, lblDetails, pitemDetails);
            panelSecond.Width = 0;
            lblMenu.Text = "תפריט";
            SendMass sendMassPage = new SendMass();
            sendMassPage.MdiParent = this;
            sendMassPage.Dock = DockStyle.Fill;
            sendMassPage.Show();
        }

        private void lblSit_Click(object sender, EventArgs e)
        {
            CheckIt(lblSit, pitemSit, lblGuests, pitemGuests, lblCreateSkitza, pitemCreateSkitza, lblSendMass, pitemSendMass, lblDetails, pitemDetails);
            panelSecond.Width = 0;
            lblMenu.Text = "תפריט";
            Sit sitPage = new Sit();
            sitPage.MdiParent = this;
            sitPage.Dock = DockStyle.Fill;
            sitPage.Show();
        }

        public void CheckIt(Label l, Panel p, Label l1, Panel p1, Label l2, Panel p2, Label l3, Panel p3, Label l4, Panel p4)
        {
            l.BackColor = Color.FromArgb(53, 184, 188);
            p.BackColor = Color.FromArgb(53, 184, 188);
            l1.BackColor = Color.FromArgb(4, 63, 155);
            p1.BackColor = Color.FromArgb(4, 63, 155);
            l2.BackColor = Color.FromArgb(4, 63, 155);
            p2.BackColor = Color.FromArgb(4, 63, 155);
            l3.BackColor = Color.FromArgb(4, 63, 155);
            p3.BackColor = Color.FromArgb(4, 63, 155);
            l4.BackColor = Color.FromArgb(4, 63, 155);
            p4.BackColor = Color.FromArgb(4, 63, 155);

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureMenu_Click(object sender, EventArgs e)
        {
            if (lblMenu.Text == "תפריט")
            {
                panelSecond.Width = 120;
                //panelMain.Enabled = false;
                lblMenu.Text = "חזור";
            }
            else if (lblMenu.Text == "חזור")
            {
                CloseMenu();
            }
        }
        #endregion

        public void CloseMenu()
        {
            panelSecond.Width = 0;
            // panelMain.Enabled = true;
            lblMenu.Text = "תפריט";
            lblSit.BackColor = Color.Transparent;
            pitemSit.BackColor = Color.Transparent;
            lblGuests.BackColor = Color.Transparent;
            pitemGuests.BackColor = Color.Transparent;
            lblCreateSkitza.BackColor = Color.Transparent;
            pitemCreateSkitza.BackColor = Color.Transparent;
            lblSendMass.BackColor = Color.Transparent;
            pitemSendMass.BackColor = Color.Transparent;
            lblDetails.BackColor = Color.Transparent;
            pitemDetails.BackColor = Color.Transparent;
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyToSit));
            this.panelSecond = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pitemDetails = new System.Windows.Forms.Panel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pitemGuests = new System.Windows.Forms.Panel();
            this.lblGuests = new System.Windows.Forms.Label();
            this.pitemCreateSkitza = new System.Windows.Forms.Panel();
            this.lblCreateSkitza = new System.Windows.Forms.Label();
            this.pitemSendMass = new System.Windows.Forms.Panel();
            this.lblSendMass = new System.Windows.Forms.Label();
            this.pitemSit = new System.Windows.Forms.Panel();
            this.lblSit = new System.Windows.Forms.Label();
            this.pictureMenu = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelSecond.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pitemDetails.SuspendLayout();
            this.pitemGuests.SuspendLayout();
            this.pitemCreateSkitza.SuspendLayout();
            this.pitemSendMass.SuspendLayout();
            this.pitemSit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSecond
            // 
            this.panelSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.panelSecond.Controls.Add(this.tableLayoutPanel1);
            this.panelSecond.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSecond.Location = new System.Drawing.Point(800, 39);
            this.panelSecond.Name = "panelSecond";
            this.panelSecond.Size = new System.Drawing.Size(0, 461);
            this.panelSecond.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pitemDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pitemGuests, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pitemCreateSkitza, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pitemSendMass, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pitemSit, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pitemDetails
            // 
            this.pitemDetails.BackColor = System.Drawing.Color.Transparent;
            this.pitemDetails.Controls.Add(this.lblDetails);
            this.pitemDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pitemDetails.Location = new System.Drawing.Point(3, 3);
            this.pitemDetails.Name = "pitemDetails";
            this.pitemDetails.Size = new System.Drawing.Size(1, 75);
            this.pitemDetails.TabIndex = 0;
            this.pitemDetails.Click += new System.EventHandler(this.lblDetails_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDetails.Location = new System.Drawing.Point(12, 21);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(71, 38);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Tag = "1";
            this.lblDetails.Text = "פרטים על\r\nהאירוע";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDetails.Click += new System.EventHandler(this.lblDetails_Click);
            // 
            // pitemGuests
            // 
            this.pitemGuests.BackColor = System.Drawing.Color.Transparent;
            this.pitemGuests.Controls.Add(this.lblGuests);
            this.pitemGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pitemGuests.Location = new System.Drawing.Point(3, 84);
            this.pitemGuests.Name = "pitemGuests";
            this.pitemGuests.Size = new System.Drawing.Size(1, 75);
            this.pitemGuests.TabIndex = 1;
            this.pitemGuests.Click += new System.EventHandler(this.lblGuests_Click);
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.BackColor = System.Drawing.Color.Transparent;
            this.lblGuests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGuests.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGuests.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGuests.Location = new System.Drawing.Point(-4, 13);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(103, 38);
            this.lblGuests.TabIndex = 0;
            this.lblGuests.Tag = "2";
            this.lblGuests.Text = "הזנת\r\nרשימת אורחים";
            this.lblGuests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuests.Click += new System.EventHandler(this.lblGuests_Click);
            // 
            // pitemCreateSkitza
            // 
            this.pitemCreateSkitza.BackColor = System.Drawing.Color.Transparent;
            this.pitemCreateSkitza.Controls.Add(this.lblCreateSkitza);
            this.pitemCreateSkitza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pitemCreateSkitza.Location = new System.Drawing.Point(3, 165);
            this.pitemCreateSkitza.Name = "pitemCreateSkitza";
            this.pitemCreateSkitza.Size = new System.Drawing.Size(1, 75);
            this.pitemCreateSkitza.TabIndex = 2;
            this.pitemCreateSkitza.Click += new System.EventHandler(this.lblCreateSkitza_Click);
            // 
            // lblCreateSkitza
            // 
            this.lblCreateSkitza.AutoSize = true;
            this.lblCreateSkitza.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateSkitza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreateSkitza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCreateSkitza.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCreateSkitza.Location = new System.Drawing.Point(4, 16);
            this.lblCreateSkitza.Name = "lblCreateSkitza";
            this.lblCreateSkitza.Size = new System.Drawing.Size(86, 38);
            this.lblCreateSkitza.TabIndex = 0;
            this.lblCreateSkitza.Tag = "3";
            this.lblCreateSkitza.Text = "בניית\r\nסקיצת אולם";
            this.lblCreateSkitza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateSkitza.Click += new System.EventHandler(this.lblCreateSkitza_Click);
            // 
            // pitemSendMass
            // 
            this.pitemSendMass.BackColor = System.Drawing.Color.Transparent;
            this.pitemSendMass.Controls.Add(this.lblSendMass);
            this.pitemSendMass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pitemSendMass.Location = new System.Drawing.Point(3, 246);
            this.pitemSendMass.Name = "pitemSendMass";
            this.pitemSendMass.Size = new System.Drawing.Size(1, 75);
            this.pitemSendMass.TabIndex = 3;
            this.pitemSendMass.Click += new System.EventHandler(this.lblSendMass_Click);
            // 
            // lblSendMass
            // 
            this.lblSendMass.AutoSize = true;
            this.lblSendMass.BackColor = System.Drawing.Color.Transparent;
            this.lblSendMass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSendMass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSendMass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSendMass.Location = new System.Drawing.Point(19, 17);
            this.lblSendMass.Name = "lblSendMass";
            this.lblSendMass.Size = new System.Drawing.Size(56, 38);
            this.lblSendMass.TabIndex = 0;
            this.lblSendMass.Tag = "4";
            this.lblSendMass.Text = "שליחת\r\nהודעות";
            this.lblSendMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSendMass.Click += new System.EventHandler(this.lblSendMass_Click);
            // 
            // pitemSit
            // 
            this.pitemSit.BackColor = System.Drawing.Color.Transparent;
            this.pitemSit.Controls.Add(this.lblSit);
            this.pitemSit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pitemSit.Location = new System.Drawing.Point(3, 327);
            this.pitemSit.Name = "pitemSit";
            this.pitemSit.Size = new System.Drawing.Size(1, 76);
            this.pitemSit.TabIndex = 4;
            this.pitemSit.Click += new System.EventHandler(this.lblSit_Click);
            // 
            // lblSit
            // 
            this.lblSit.AutoSize = true;
            this.lblSit.BackColor = System.Drawing.Color.Transparent;
            this.lblSit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSit.Location = new System.Drawing.Point(14, 11);
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(67, 57);
            this.lblSit.TabIndex = 0;
            this.lblSit.Tag = "5";
            this.lblSit.Text = "מסך\r\nלהושבת \r\nאורחים";
            this.lblSit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSit.Click += new System.EventHandler(this.lblSit_Click);
            // 
            // pictureMenu
            // 
            this.pictureMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureMenu.Image")));
            this.pictureMenu.Location = new System.Drawing.Point(760, 0);
            this.pictureMenu.Name = "pictureMenu";
            this.pictureMenu.Size = new System.Drawing.Size(40, 39);
            this.pictureMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMenu.TabIndex = 0;
            this.pictureMenu.TabStop = false;
            this.pictureMenu.Click += new System.EventHandler(this.pictureMenu_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMenu.Location = new System.Drawing.Point(693, 7);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(65, 24);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "תפריט";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblExit.Location = new System.Drawing.Point(12, 7);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 22);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.panelTitle.Controls.Add(this.lblExit);
            this.panelTitle.Controls.Add(this.lblMenu);
            this.panelTitle.Controls.Add(this.pictureMenu);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 39);
            this.panelTitle.TabIndex = 0;
            // 
            // EasyToSit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelSecond);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EasyToSit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyTosit";
            this.Load += new System.EventHandler(this.EasyToSit_Load);
            this.panelSecond.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pitemDetails.ResumeLayout(false);
            this.pitemDetails.PerformLayout();
            this.pitemGuests.ResumeLayout(false);
            this.pitemGuests.PerformLayout();
            this.pitemCreateSkitza.ResumeLayout(false);
            this.pitemCreateSkitza.PerformLayout();
            this.pitemSendMass.ResumeLayout(false);
            this.pitemSendMass.PerformLayout();
            this.pitemSit.ResumeLayout(false);
            this.pitemSit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        private void EasyToSit_Load(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.MdiParent = this;
            loginPage.Dock = DockStyle.Fill;
            loginPage.Show();
        }

    }
}
