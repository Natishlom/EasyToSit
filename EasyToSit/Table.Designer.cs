namespace EasyToSit
{
    partial class Table
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
            this.components = new System.ComponentModel.Container();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNumOfTable = new System.Windows.Forms.TextBox();
            this.txtCountGuests = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
            //this.panelDetails.BackgroundImage = global::EasyToSit.Properties.Resources.EasyToSit;
            this.panelDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDetails.Controls.Add(this.lblExit);
            this.panelDetails.Controls.Add(this.btnSave);
            this.panelDetails.Controls.Add(this.txtNumOfTable);
            this.panelDetails.Controls.Add(this.txtCountGuests);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(363, 279);
            this.panelDetails.TabIndex = 1;
            this.panelDetails.TabStop = true;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.lblExit.Location = new System.Drawing.Point(6, 6);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 22);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(69, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(97, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNumOfTable
            // 
            this.txtNumOfTable.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumOfTable.ForeColor = System.Drawing.Color.Silver;
            this.txtNumOfTable.Location = new System.Drawing.Point(69, 132);
            this.txtNumOfTable.Name = "txtNumOfTable";
            this.txtNumOfTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumOfTable.Size = new System.Drawing.Size(224, 29);
            this.txtNumOfTable.TabIndex = 2;
            this.txtNumOfTable.Text = "מספר שולחן:";
            this.txtNumOfTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumOfTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumOfTable_KeyDown);
            // 
            // txtCountGuests
            // 
            this.txtCountGuests.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCountGuests.ForeColor = System.Drawing.Color.Silver;
            this.txtCountGuests.Location = new System.Drawing.Point(69, 47);
            this.txtCountGuests.Name = "txtCountGuests";
            this.txtCountGuests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCountGuests.Size = new System.Drawing.Size(224, 29);
            this.txtCountGuests.TabIndex = 1;
            this.txtCountGuests.Text = "כמות סועדים:";
            this.txtCountGuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCountGuests.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCountGuests_KeyDown);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(363, 279);
            this.Controls.Add(this.panelDetails);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Table";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNumOfTable;
        private System.Windows.Forms.TextBox txtCountGuests;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}