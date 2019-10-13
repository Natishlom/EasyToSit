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
        Object objectTemp;
        private Panel panelTemp;
        private List<Object> objects = new List<Object>();
        private PictureBox tempPic;



        public CreateSkitza()
        {
            InitializeComponent();
        }

        private void toolTable_Click(object sender, EventArgs e)
        {
            objectTemp.ShowDialog();
            if (objectTemp.Netunim.Equals(true))
            {
                objects.Add(objectTemp);
                objectTemp.Picture.Image = Resources.table;
                objectTemp.Picture.Visible = true;
            
            }
        }

        private void toolStage_Click(object sender, EventArgs e)
        {
            objectTemp.Picture.Image = Resources.stage;
        }

        private void toolDoor_Click(object sender, EventArgs e)
        {
            objectTemp.Picture.Image = Resources.door;
        }

        private void toolKitchen_Click(object sender, EventArgs e)
        {
            objectTemp.Picture.Image = Resources.kitchen;
        }

        private void toolBar_Click(object sender, EventArgs e)
        {
            objectTemp.Picture.Image = Resources.bar;
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            objectTemp.Picture.Image = null;
        }

        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }


        public void ShowToolTip(IWin32Window w, int numOfTable, int numOfGuest)
        {
            string s = string.Format("מספר השולחן: {0}", numOfTable + Environment.NewLine + "מספר הסועדים: {1}", numOfTable);
            toolTip.Show(s, w);
            toolTip.OwnerDraw = true;
        }

        private void ShowMenuStrip(MouseEventArgs e, PictureBox p)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuStrip.Show(this, p.Location);
            }
        }

        private void pictureObject(MouseEventArgs e)
        {
            objectTemp = new Object();
            objectTemp.Picture = tempPic;
            ShowMenuStrip(e, objectTemp.Picture);
        }

        private void picture1_MouseClick(object sender, MouseEventArgs e)
        {
            tempPic = (PictureBox)sender;
            pictureObject(e);
        }
    }
}
