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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.checkGuests = new System.Windows.Forms.TabPage();
            this.dataGuests = new System.Windows.Forms.DataGridView();
            this.CheckGuest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FristName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chekHazmna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isComing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bodyMessage = new System.Windows.Forms.TabPage();
            this.pictureMass = new System.Windows.Forms.PictureBox();
            this.cboTaypeMassege = new System.Windows.Forms.ComboBox();
            this.lblTaype = new System.Windows.Forms.Label();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.txtMassege = new System.Windows.Forms.TextBox();
            this.panelBody.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.checkGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGuests)).BeginInit();
            this.bodyMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMass)).BeginInit();
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
            // dataGuests
            // 
            this.dataGuests.AllowUserToAddRows = false;
            this.dataGuests.AllowUserToDeleteRows = false;
            this.dataGuests.AllowUserToOrderColumns = true;
            this.dataGuests.AllowUserToResizeColumns = false;
            this.dataGuests.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            this.dataGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGuests.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckGuest,
            this.FristName,
            this.lastName,
            this.count,
            this.phone,
            this.chekHazmna,
            this.isComing});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGuests.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGuests.EnableHeadersVisualStyles = false;
            this.dataGuests.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGuests.Location = new System.Drawing.Point(3, 3);
            this.dataGuests.Name = "dataGuests";
            this.dataGuests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = "0";
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGuests.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGuests.RowHeadersWidth = 20;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGuests.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGuests.Size = new System.Drawing.Size(766, 390);
            this.dataGuests.TabIndex = 1;
            // 
            // CheckGuest
            // 
            this.CheckGuest.FillWeight = 28.48562F;
            this.CheckGuest.HeaderText = "בחירת אורח";
            this.CheckGuest.Name = "CheckGuest";
            // 
            // FristName
            // 
            this.FristName.DataPropertyName = "FirstName";
            this.FristName.FillWeight = 81.38748F;
            this.FristName.HeaderText = "שם פרטי:";
            this.FristName.Name = "FristName";
            this.FristName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.FillWeight = 81.38748F;
            this.lastName.HeaderText = "שם משפחה:";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "Count";
            this.count.FillWeight = 40.69374F;
            this.count.HeaderText = "כמות:";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "PhoneNumber";
            this.phone.FillWeight = 81.38748F;
            this.phone.HeaderText = "מספר נייד:";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // chekHazmna
            // 
            this.chekHazmna.DataPropertyName = "ChekHazmna";
            this.chekHazmna.FalseValue = "0";
            this.chekHazmna.FillWeight = 28.48562F;
            this.chekHazmna.HeaderText = "קיבל הזמנה:";
            this.chekHazmna.Name = "chekHazmna";
            this.chekHazmna.ReadOnly = true;
            this.chekHazmna.TrueValue = "1";
            // 
            // isComing
            // 
            this.isComing.DataPropertyName = "IsComing";
            this.isComing.FalseValue = "0";
            this.isComing.FillWeight = 28.48562F;
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
            this.bodyMessage.Controls.Add(this.txtMassege);
            this.bodyMessage.Controls.Add(this.pictureMass);
            this.bodyMessage.Controls.Add(this.cboTaypeMassege);
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
            // pictureMass
            // 
            this.pictureMass.Image = global::EasyToSit.Properties.Resources.Invitation;
            this.pictureMass.Location = new System.Drawing.Point(174, 39);
            this.pictureMass.Name = "pictureMass";
            this.pictureMass.Size = new System.Drawing.Size(434, 349);
            this.pictureMass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMass.TabIndex = 3;
            this.pictureMass.TabStop = false;
            // 
            // cboTaypeMassege
            // 
            this.cboTaypeMassege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.cboTaypeMassege.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cboTaypeMassege.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cboTaypeMassege.FormattingEnabled = true;
            this.cboTaypeMassege.Items.AddRange(new object[] {
            "הודעת אישור הגעה",
            "הודעת תזכורת על אישור הגעה",
            "הודעת תזכורת להושבה",
            "הודעת תזכורת ביום האירוע",
            "הודעת תודה על ההשתתפות"});
            this.cboTaypeMassege.Location = new System.Drawing.Point(223, 6);
            this.cboTaypeMassege.Name = "cboTaypeMassege";
            this.cboTaypeMassege.Size = new System.Drawing.Size(334, 27);
            this.cboTaypeMassege.TabIndex = 2;
            this.cboTaypeMassege.SelectedIndexChanged += new System.EventHandler(this.cboTaypeMassege_SelectedIndexChanged);
            // 
            // lblTaype
            // 
            this.lblTaype.AutoSize = true;
            this.lblTaype.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTaype.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTaype.Location = new System.Drawing.Point(603, 10);
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
            this.tabSend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabSend.Location = new System.Drawing.Point(4, 22);
            this.tabSend.Name = "tabSend";
            this.tabSend.Size = new System.Drawing.Size(772, 396);
            this.tabSend.TabIndex = 2;
            this.tabSend.Text = "סיכום ושליחה";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGuests)).EndInit();
            this.bodyMessage.ResumeLayout(false);
            this.bodyMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage checkGuests;
        private System.Windows.Forms.TabPage bodyMessage;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.DataGridView dataGuests;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn FristName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chekHazmna;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isComing;
        private System.Windows.Forms.PictureBox pictureMass;
        private System.Windows.Forms.ComboBox cboTaypeMassege;
        private System.Windows.Forms.Label lblTaype;
        private System.Windows.Forms.TextBox txtMassege;
    }
}