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
        private List<Object> objects = new List<Object>();
        private PictureBox tempPic;
        private List<PictureBox> pictures;



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
                objectTemp.Id = "table";
            }
        }

        private void toolStage_Click(object sender, EventArgs e)
        {
            objectTemp.Picture.Image = Resources.stage;
            objectTemp.Id = "stage";
        }

        private void toolDoor_Click(object sender, EventArgs e)
        {
            objectTemp.Picture.Image = Resources.door;
            objectTemp.Id = "door";
        }

        private void toolKitchen_Click(object sender, EventArgs e)
        {
            objectTemp.Picture.Image = Resources.kitchen;
            objectTemp.Id = "kitchen";
        }

        private void toolBar_Click(object sender, EventArgs e)
        {
            objectTemp.Picture.Image = Resources.bar;
            objectTemp.Id = "bar";
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
            objectTemp.Point = tempPic.Location;
            objectTemp.Name = tempPic.Name;
            ShowMenuStrip(e, objectTemp.Picture);
            objectTemp.Netunim = true;
            objects.Add(objectTemp);
        }

        private void picture1_MouseClick(object sender, MouseEventArgs e)
        {
            tempPic = (PictureBox)sender;
            pictureObject(e);
        }

       private void insertPictures()
        {
            //pictures.Add(picture1);
            //pictures.Add(picture2);
            //pictures.Add(picture3);
            //pictures.Add(picture4);
            //pictures.Add(picture5);
            //pictures.Add(picture6);
            //pictures.Add(picture7);
            //pictures.Add(picture8);
            //pictures.Add(picture9);
            //pictures.Add(picture10);
            //pictures.Add(picture11);
            //pictures.Add(picture12);
            //pictures.Add(picture13);
            //pictures.Add(picture14);
            //pictures.Add(picture15);
            //pictures.Add(picture16);
            //pictures.Add(picture17);
            //pictures.Add(picture18);
            //pictures.Add(picture19);
            //pictures.Add(picture20);
            //pictures.Add(picture21);
            //pictures.Add(picture22);
            //pictures.Add(picture23);
            //pictures.Add(picture24);
            //pictures.Add(picture25);
            //pictures.Add(picture26);
            //pictures.Add(picture27);
            //pictures.Add(picture28);
            //pictures.Add(picture29);
            //pictures.Add(picture30);
            //pictures.Add(picture31);
            //pictures.Add(picture32);
            //pictures.Add(picture33);
            //pictures.Add(picture34);
            //pictures.Add(picture35);
            //pictures.Add(picture36);
            //pictures.Add(picture37);
            //pictures.Add(picture38);
            //pictures.Add(picture39);
            //pictures.Add(picture40);
            //pictures.Add(picture41);
            //pictures.Add(picture42);
            //pictures.Add(picture43);
            //pictures.Add(picture44);
            //pictures.Add(picture45);
            //pictures.Add(picture46);
            //pictures.Add(picture47);
            //pictures.Add(picture48);
            //pictures.Add(picture49);
            //pictures.Add(picture50);
            //pictures.Add(picture51);
            //pictures.Add(picture52);
            //pictures.Add(picture53);
            //pictures.Add(picture54);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);
            //pictures.Add(picture1);

            foreach (PictureBox picture in this.Controls.OfType<PictureBox>())
            {
                
            }
        }
    }
}
