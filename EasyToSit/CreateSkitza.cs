using EasyToSit.Properties;
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
        private List<Table> Tables=new List<Table>();
        private PictureBox picture= new PictureBox {
            SizeMode = PictureBoxSizeMode.StretchImage,
        Dock = DockStyle.Fill
        };
        


        public CreateSkitza()
        {
            InitializeComponent();
        }

        private void CreateSkitza_Load(object sender, EventArgs e)
        {

        }

        //הצגת חלון בלחיצה על קליק ימני
        public void AddItem(MouseEventArgs e)
        {
           
        }

        //יצירת אובייקט שולחן והוספת התמונה
        private void CreateTable()
        {
            
        }


        private void toolTable_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            //הצגת חלון להוספת פרטים על השולחן
            table.ShowDialog();
            table.Panel = panelTemp;
            //הוספת השולחן לרשימה של שולחנות
            Tables.Add(table);
            //בדיקה אם הוזנו נתונים.
            if (table.Netunim.Equals(true))
            {
                //הוספת תמונה של שולחן
                picture.Image = Resources.table;
                picture.Refresh();
                picture.Visible = true;
            }
        }


        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

       

        public void ShowToolTip( IWin32Window w,int numOfTable,int numOfGuest)
        {
            string s = string.Format("מספר השולחן: {0}",numOfTable + Environment.NewLine+ "מספר הסועדים: {1}",numOfTable);
            toolTip.Show(s, w);
            toolTip.OwnerDraw = true;
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuStrip.Show();
            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuStrip.Show();
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuStrip.Show();
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuStrip.Show();
            }
        }
    }
}
