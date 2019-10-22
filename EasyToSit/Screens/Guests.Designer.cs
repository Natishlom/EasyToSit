namespace EasyToSit
{
    partial class Guests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBody = new System.Windows.Forms.Panel();
            this.dataGuests = new System.Windows.Forms.DataGridView();
            this.panelSave = new System.Windows.Forms.Panel();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FristName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckHzmana = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isComing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGuests)).BeginInit();
            this.panelSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dataGuests);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(796, 461);
            this.panelBody.TabIndex = 1;
            // 
            // dataGuests
            // 
            this.dataGuests.AllowUserToDeleteRows = false;
            this.dataGuests.AllowUserToOrderColumns = true;
            this.dataGuests.AllowUserToResizeColumns = false;
            this.dataGuests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGuests.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNumber,
            this.FristName,
            this.lastName,
            this.count,
            this.phone,
            this.CheckHzmana,
            this.isComing,
            this.Gift,
            this.delet});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGuests.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGuests.EnableHeadersVisualStyles = false;
            this.dataGuests.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGuests.Location = new System.Drawing.Point(0, 0);
            this.dataGuests.Name = "dataGuests";
            this.dataGuests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGuests.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGuests.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGuests.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGuests.Size = new System.Drawing.Size(796, 461);
            this.dataGuests.TabIndex = 0;
            this.dataGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGuests_CellClick);
            this.dataGuests.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGuests_RowPostPaint);
            this.dataGuests.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGuests_RowsAdded);
            // 
            // panelSave
            // 
            this.panelSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelSave.Controls.Add(this.txtCount);
            this.panelSave.Controls.Add(this.lblCount);
            this.panelSave.Controls.Add(this.btnUpdate);
            this.panelSave.Controls.Add(this.btnSave);
            this.panelSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSave.Location = new System.Drawing.Point(0, 418);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(796, 43);
            this.panelSave.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.White;
            this.txtCount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCount.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtCount.Location = new System.Drawing.Point(531, 8);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCount.Size = new System.Drawing.Size(165, 29);
            this.txtCount.TabIndex = 25;
            this.txtCount.TabStop = false;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCount.Location = new System.Drawing.Point(702, 14);
            this.lblCount.Name = "lblCount";
            this.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCount.Size = new System.Drawing.Size(82, 16);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "כמות אורחים:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(12, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(87, 35);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(105, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(98, 35);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rowNumber
            // 
            this.rowNumber.DataPropertyName = "GuestId";
            this.rowNumber.FillWeight = 35F;
            this.rowNumber.HeaderText = "מס שורה";
            this.rowNumber.Name = "rowNumber";
            // 
            // FristName
            // 
            this.FristName.DataPropertyName = "FirstName";
            this.FristName.HeaderText = "שם פרטי:";
            this.FristName.Name = "FristName";
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.HeaderText = "שם משפחה:";
            this.lastName.Name = "lastName";
            // 
            // count
            // 
            this.count.DataPropertyName = "Count";
            this.count.FillWeight = 50F;
            this.count.HeaderText = "כמות:";
            this.count.Name = "count";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "GuestPhone";
            this.phone.HeaderText = "מספר נייד:";
            this.phone.Name = "phone";
            // 
            // CheckHzmana
            // 
            this.CheckHzmana.DataPropertyName = "CheckHzmana";
            this.CheckHzmana.FalseValue = "false";
            this.CheckHzmana.FillWeight = 35F;
            this.CheckHzmana.HeaderText = "קיבל הזמנה:";
            this.CheckHzmana.IndeterminateValue = "false";
            this.CheckHzmana.Name = "CheckHzmana";
            this.CheckHzmana.TrueValue = "true";
            // 
            // isComing
            // 
            this.isComing.DataPropertyName = "IsComing";
            this.isComing.FalseValue = "false";
            this.isComing.FillWeight = 35F;
            this.isComing.HeaderText = "אישר הגעה";
            this.isComing.IndeterminateValue = "false";
            this.isComing.Name = "isComing";
            this.isComing.TrueValue = "true";
            // 
            // Gift
            // 
            this.Gift.DataPropertyName = "Gift";
            this.Gift.FillWeight = 35F;
            this.Gift.HeaderText = "מתנה";
            this.Gift.Name = "Gift";
            // 
            // delet
            // 
            this.delet.FillWeight = 35F;
            this.delet.HeaderText = "מחק שורה";
            this.delet.Name = "delet";
            this.delet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Guests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(796, 461);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.panelBody);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Guests";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guests";
            this.Load += new System.EventHandler(this.Guests_Load);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGuests)).EndInit();
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.DataGridView dataGuests;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FristName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckHzmana;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isComing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gift;
        private System.Windows.Forms.DataGridViewButtonColumn delet;
    }
}