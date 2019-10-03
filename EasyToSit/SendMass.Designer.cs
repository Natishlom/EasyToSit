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
            this.panelBody = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.checkGuests = new System.Windows.Forms.TabPage();
            this.bodyMessage = new System.Windows.Forms.TabPage();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.panelBody.SuspendLayout();
            this.tabControl.SuspendLayout();
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
            this.checkGuests.BackColor = System.Drawing.Color.Transparent;
            this.checkGuests.BackgroundImage = global::EasyToSit.Properties.Resources.EasyToSit;
            this.checkGuests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkGuests.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkGuests.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkGuests.Location = new System.Drawing.Point(4, 22);
            this.checkGuests.Name = "checkGuests";
            this.checkGuests.Padding = new System.Windows.Forms.Padding(3);
            this.checkGuests.Size = new System.Drawing.Size(772, 396);
            this.checkGuests.TabIndex = 0;
            this.checkGuests.Text = "בחירת אורחים";
            // 
            // bodyMessage
            // 
            this.bodyMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bodyMessage.BackColor = System.Drawing.Color.Transparent;
            this.bodyMessage.BackgroundImage = global::EasyToSit.Properties.Resources.EasyToSit;
            this.bodyMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bodyMessage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bodyMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bodyMessage.Location = new System.Drawing.Point(4, 22);
            this.bodyMessage.Name = "bodyMessage";
            this.bodyMessage.Padding = new System.Windows.Forms.Padding(3);
            this.bodyMessage.Size = new System.Drawing.Size(772, 396);
            this.bodyMessage.TabIndex = 1;
            this.bodyMessage.Text = "תוכן הודעה";
            // 
            // tabSend
            // 
            this.tabSend.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tabSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabSend.BackgroundImage = global::EasyToSit.Properties.Resources.EasyToSit;
            this.tabSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabSend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabSend.Location = new System.Drawing.Point(4, 22);
            this.tabSend.Name = "tabSend";
            this.tabSend.Size = new System.Drawing.Size(772, 396);
            this.tabSend.TabIndex = 2;
            this.tabSend.Text = "סיכום ושליחה";
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
            this.panelBody.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage checkGuests;
        private System.Windows.Forms.TabPage bodyMessage;
        private System.Windows.Forms.TabPage tabSend;
    }
}