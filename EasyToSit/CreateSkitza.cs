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
    public partial class CreateSkitza : Form
    {
        private Panel panelTemp;
        string exePath =
    System.IO.Path.GetDirectoryName(
        System.Reflection.Assembly.GetEntryAssembly().Location);

        public Panel PanelTemp { get => panelTemp; set => panelTemp = value; }

        public CreateSkitza()
        {
            InitializeComponent();
        }

        private void CreateSkitza_Load(object sender, EventArgs e)
        {

        }

        public void AddItem(Panel p)
        {
            menuStrip.Show(this, p.Location.X, p.Location.Y);
        }

        private void CreateTable()
        {
            Table table = new Table();
            table.ShowDialog();
            //בדיקה אם הוזנו נתונים.
            if (table.Netunim.Equals(true))
            {
                PictureBox picture = new PictureBox
                {
                    Name = "pictureTable",
                    Size = new Size(33, 14),
                    Dock = DockStyle.Fill,
                    Location = new Point(panelTemp.Location.X, panelTemp.Location.Y)
                };
                panelTemp.Controls.Add(picture);
                picture.ImageLocation =exePath+ @"table.png";
            }
        }


        private void p0000_MouseClick(object sender, MouseEventArgs e)
        {
            panelTemp = p0000;
            AddItem(p0000);
        }

        private void toolTable_Click(object sender, EventArgs e)
        {
            CreateTable();
        }
    }
}
