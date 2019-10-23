namespace EasyToSit
{
    partial class SendMass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.checkGuests = new System.Windows.Forms.TabPage();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.dataGuests = new System.Windows.Forms.DataGridView();
            this.CheckGuest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chekHazmna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isComing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bodyMessage = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMassege = new System.Windows.Forms.TextBox();
            this.pictureMass = new System.Windows.Forms.PictureBox();
            this.cboTaypeMessage = new System.Windows.Forms.ComboBox();
            this.lblTaype = new System.Windows.Forms.Label();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.LBGuest = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListGest = new System.Windows.Forms.Label();
            this.panelBody.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.checkGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGuests)).BeginInit();
            this.bodyMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMass)).BeginInit();
            this.tabSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.tabControl);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(780, 422);
            this.panelBody.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.checkGuests);
            this.tabControl.Controls.Add(this.bodyMessage);
            this.tabControl.Controls.Add(this.tabSend);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(780, 422);
            this.tabControl.TabIndex = 0;
            // 
            // checkGuests
            // 
            this.checkGuests.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.checkGuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.checkGuests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkGuests.Controls.Add(this.checkAll);
            this.checkGuests.Controls.Add(this.dataGuests);
            this.checkGuests.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkGuests.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkGuests.Location = new System.Drawing.Point(4, 22);
            this.checkGuests.Name = "checkGuests";
            this.checkGuests.Padding = new System.Windows.Forms.Padding(3);
            this.checkGuests.Size = new System.Drawing.Size(772, 396);
            this.checkGuests.TabIndex = 0;
            this.checkGuests.Text = "בחירת אורחים";
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(631, 0);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(135, 20);
            this.checkAll.TabIndex = 2;
            this.checkAll.Text = "סמן את כל האורחים";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // dataGuests
            // 
            this.dataGuests.AllowUserToAddRows = false;
            this.dataGuests.AllowUserToDeleteRows = false;
            this.dataGuests.AllowUserToOrderColumns = true;
            this.dataGuests.AllowUserToResizeColumns = false;
            this.dataGuests.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGuests.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckGuest,
            this.FirstName,
            this.lastName,
            this.count,
            this.phone,
            this.chekHazmna,
            this.isComing});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGuests.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGuests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGuests.EnableHeadersVisualStyles = false;
            this.dataGuests.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGuests.Location = new System.Drawing.Point(3, 0);
            this.dataGuests.Name = "dataGuests";
            this.dataGuests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGuests.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGuests.RowHeadersWidth = 20;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGuests.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGuests.Size = new System.Drawing.Size(766, 393);
            this.dataGuests.TabIndex = 1;
            // 
            // CheckGuest
            // 
            this.CheckGuest.FillWeight = 33.9742F;
            this.CheckGuest.HeaderText = "בחירת אורח";
            this.CheckGuest.Name = "CheckGuest";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.FillWeight = 97.06913F;
            this.FirstName.HeaderText = "שם פרטי:";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.FillWeight = 97.06913F;
            this.lastName.HeaderText = "שם משפחה:";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "Count";
            this.count.FillWeight = 48.53456F;
            this.count.HeaderText = "כמות:";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "GuestPhone";
            this.phone.FillWeight = 97.06913F;
            this.phone.HeaderText = "מספר נייד:";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // chekHazmna
            // 
            this.chekHazmna.DataPropertyName = "ChekHazmna";
            this.chekHazmna.FalseValue = "0";
            this.chekHazmna.FillWeight = 33.9742F;
            this.chekHazmna.HeaderText = "קיבל הזמנה:";
            this.chekHazmna.Name = "chekHazmna";
            this.chekHazmna.ReadOnly = true;
            this.chekHazmna.TrueValue = "1";
            // 
            // isComing
            // 
            this.isComing.DataPropertyName = "IsComing";
            this.isComing.FalseValue = "0";
            this.isComing.FillWeight = 33.9742F;
            this.isComing.HeaderText = "אישר הגעה";
            this.isComing.Name = "isComing";
            this.isComing.ReadOnly = true;
            this.isComing.TrueValue = "1";
            // 
            // bodyMessage
            // 
            this.bodyMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bodyMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.bodyMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bodyMessage.Controls.Add(this.btnSave);
            this.bodyMessage.Controls.Add(this.txtMassege);
            this.bodyMessage.Controls.Add(this.pictureMass);
            this.bodyMessage.Controls.Add(this.cboTaypeMessage);
            this.bodyMessage.Controls.Add(this.lblTaype);
            this.bodyMessage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bodyMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bodyMessage.Location = new System.Drawing.Point(4, 22);
            this.bodyMessage.Name = "bodyMessage";
            this.bodyMessage.Padding = new System.Windows.Forms.Padding(3);
            this.bodyMessage.Size = new System.Drawing.Size(772, 396);
            this.bodyMessage.TabIndex = 1;
            this.bodyMessage.Text = "תוכן הודעה";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnSave.Location = new System.Drawing.Point(8, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMassege
            // 
            this.txtMassege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.txtMassege.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMassege.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMassege.Location = new System.Drawing.Point(207, 220);
            this.txtMassege.Multiline = true;
            this.txtMassege.Name = "txtMassege";
            this.txtMassege.ReadOnly = true;
            this.txtMassege.Size = new System.Drawing.Size(293, 143);
            this.txtMassege.TabIndex = 4;
            this.txtMassege.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMassege.Visible = false;
            // 
            // pictureMass
            // 
            this.pictureMass.Image = global::EasyToSit.Properties.Resources.Invitation;
            this.pictureMass.Location = new System.Drawing.Point(174, 39);
            this.pictureMass.Name = "pictureMass";
            this.pictureMass.Size = new System.Drawing.Size(434, 349);
            this.pictureMass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMass.TabIndex = 3;
            this.pictureMass.TabStop = false;
            this.pictureMass.Visible = false;
            // 
            // cboTaypeMessage
            // 
            this.cboTaypeMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.cboTaypeMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cboTaypeMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cboTaypeMessage.FormattingEnabled = true;
            this.cboTaypeMessage.Items.AddRange(new object[] {
            "הודעת אישור הגעה",
            "הודעת תזכורת על אישור הגעה",
            "הודעת תזכורת להושבה",
            "הודעת תזכורת ביום האירוע",
            "הודעת תודה על ההשתתפות"});
            this.cboTaypeMessage.Location = new System.Drawing.Point(223, 6);
            this.cboTaypeMessage.Name = "cboTaypeMessage";
            this.cboTaypeMessage.Size = new System.Drawing.Size(334, 27);
            this.cboTaypeMessage.TabIndex = 2;
            this.cboTaypeMessage.SelectedIndexChanged += new System.EventHandler(this.cboTaypeMessage_SelectedIndexChanged);
            // 
            // lblTaype
            // 
            this.lblTaype.AutoSize = true;
            this.lblTaype.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTaype.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTaype.Location = new System.Drawing.Point(638, 10);
            this.lblTaype.Name = "lblTaype";
            this.lblTaype.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTaype.Size = new System.Drawing.Size(82, 19);
            this.lblTaype.TabIndex = 1;
            this.lblTaype.Text = "סוג הודעה:";
            // 
            // tabSend
            // 
            this.tabSend.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tabSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.tabSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabSend.Controls.Add(this.LBGuest);
            this.tabSend.Controls.Add(this.btnSend);
            this.tabSend.Controls.Add(this.txtMass);
            this.tabSend.Controls.Add(this.pictureBox1);
            this.tabSend.Controls.Add(this.label1);
            this.tabSend.Controls.Add(this.lblListGest);
            this.tabSend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabSend.Location = new System.Drawing.Point(4, 22);
            this.tabSend.Name = "tabSend";
            this.tabSend.Size = new System.Drawing.Size(772, 396);
            this.tabSend.TabIndex = 2;
            this.tabSend.Text = "סיכום ושליחה";
            // 
            // LBGuest
            // 
            this.LBGuest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LBGuest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LBGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.LBGuest.FormattingEnabled = true;
            this.LBGuest.ItemHeight = 19;
            this.LBGuest.Location = new System.Drawing.Point(566, 61);
            this.LBGuest.Name = "LBGuest";
            this.LBGuest.Size = new System.Drawing.Size(181, 308);
            this.LBGuest.TabIndex = 25;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnSend.Location = new System.Drawing.Point(18, 353);
            this.btnSend.Name = "btnSend";
            this.btnSend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSend.Size = new System.Drawing.Size(98, 35);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "שלח";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMass
            // 
            this.txtMass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.txtMass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMass.Location = new System.Drawing.Point(204, 219);
            this.txtMass.Multiline = true;
            this.txtMass.Name = "txtMass";
            this.txtMass.ReadOnly = true;
            this.txtMass.Size = new System.Drawing.Size(229, 152);
            this.txtMass.TabIndex = 6;
            this.txtMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMass.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyToSit.Properties.Resources.Invitation;
            this.pictureBox1.Location = new System.Drawing.Point(180, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(296, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "תוכן ההודעה :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListGest
            // 
            this.lblListGest.AutoSize = true;
            this.lblListGest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblListGest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListGest.Location = new System.Drawing.Point(594, 10);
            this.lblListGest.Name = "lblListGest";
            this.lblListGest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblListGest.Size = new System.Drawing.Size(157, 38);
            this.lblListGest.TabIndex = 2;
            this.lblListGest.Text = "רשימת אורחים\r\nאליהם תשלח ההודעה:";
            this.lblListGest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendMass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 422);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendMass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendMass";
            this.Load += new System.EventHandler(this.SendMass_Load);
            this.panelBody.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.checkGuests.ResumeLayout(false);
            this.checkGuests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGuests)).EndInit();
            this.bodyMessage.ResumeLayout(false);
            this.bodyMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMass)).EndInit();
            this.tabSend.ResumeLayout(false);
            this.tabSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage checkGuests;
        private System.Windows.Forms.TabPage bodyMessage;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.DataGridView dataGuests;
        private System.Windows.Forms.PictureBox pictureMass;
        private System.Windows.Forms.ComboBox cboTaypeMessage;
        private System.Windows.Forms.Label lblTaype;
        private System.Windows.Forms.TextBox txtMassege;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListGest;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.ListBox LBGuest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chekHazmna;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isComing;
    }
}