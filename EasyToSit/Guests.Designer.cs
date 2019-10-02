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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.dataGuests = new System.Windows.Forms.DataGridView();
            this.FristName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chekHazmna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isComing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.delet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelSave = new System.Windows.Forms.Panel();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(796, 37);
            this.panelTitle.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dataGuests);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 37);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(796, 424);
            this.panelBody.TabIndex = 1;
            // 
            // dataGuests
            // 
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
            this.FristName,
            this.lastName,
            this.count,
            this.phone,
            this.chekHazmna,
            this.isComing,
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGuests.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGuests.Size = new System.Drawing.Size(796, 424);
            this.dataGuests.TabIndex = 0;
            // 
            // FristName
            // 
            this.FristName.HeaderText = "שם פרטי:";
            this.FristName.Name = "FristName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "שם משפחה:";
            this.lastName.Name = "lastName";
            // 
            // count
            // 
            this.count.FillWeight = 50F;
            this.count.HeaderText = "כמות:";
            this.count.Name = "count";
            // 
            // phone
            // 
            this.phone.HeaderText = "מספר נייד:";
            this.phone.Name = "phone";
            // 
            // chekHazmna
            // 
            this.chekHazmna.FillWeight = 35F;
            this.chekHazmna.HeaderText = "קיבל הזמנה:";
            this.chekHazmna.Name = "chekHazmna";
            // 
            // isComing
            // 
            this.isComing.FillWeight = 35F;
            this.isComing.HeaderText = "אישר הגעה";
            this.isComing.Name = "isComing";
            // 
            // delet
            // 
            this.delet.FillWeight = 35F;
            this.delet.HeaderText = "מחק שורה";
            this.delet.Name = "delet";
            this.delet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panelSave
            // 
            this.panelSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSave.Location = new System.Drawing.Point(0, 418);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(796, 43);
            this.panelSave.TabIndex = 2;
            // 
            // Guests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 461);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Guests";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guests";
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.DataGridView dataGuests;
        private System.Windows.Forms.DataGridViewTextBoxColumn FristName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chekHazmna;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isComing;
        private System.Windows.Forms.DataGridViewButtonColumn delet;
    }
}