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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int sum = Int32.Parse(txtDose.Text) * Int32.Parse(txtCountOfGuest.Text);

            txtExpenses.Text = sum.ToString();
        }

        #region הודעה עם ריחוף בעכבר לשינוי שם הספק
        private void lblSpak1_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak1);
        }

        public void showToolTip(string s,IWin32Window w)
        {
            toolTip.Show(s, w);
            toolTip.OwnerDraw = true;
        }

        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void lblSpak2_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak2);
        }

        private void lblSpak3_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak3);
        }

        private void lblSpak4_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak4);
        }

        private void lblSpak5_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak5);
        }

        private void lblSpak6_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak6);
        }

        private void lblSpak7_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak7);
        }

        private void lblSpak8_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak8);
        }

        private void lblSpak9_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak9);
        }

        private void lblSpak10_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak10);
        }
        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            showToolTip("לרענון הנתונים נא ללחוץ על כפתור שמור", btnSave);
        }
        #endregion

        private void lblSpak1_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak1,txtSpak1);
        }

        public void ChangeName(Label l, TextBox t)
        {
            UpdateName updateName = new UpdateName();
            updateName.ShowDialog();
            l.Text = updateName.Name1.ToString();
            t.Text = updateName.Price.ToString();
        }

        private void lblSpak2_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak2, txtSpak2);
        }

        private void lblSpak3_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak3, txtSpak3);
        }

        private void lblSpak4_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak4, txtSpak4);
        }

        private void lblSpak5_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak5, txtSpak5);
        }

        private void lblSpak6_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak6, txtSpak6);
        }

        private void lblSpak7_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak7, txtSpak7);
        }

        private void lblSpak8_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak8, txtSpak8);
        }

        private void lblSpak9_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak9, txtSpak9);
        }

        private void lblSpak10_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak10, txtSpak10);
        }
    }
}
