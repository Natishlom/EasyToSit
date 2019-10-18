using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyToSit.Classes;

namespace EasyToSit
{
    public partial class Details : Form
    {
         User userName;
        List<User> listUsers;
        private List<TextBox> sapakim = new List<TextBox>();
        public TextBox TxtDate { get => TxtDate; set => TxtDate = value; }
        public TextBox TxtNameHall { get => TxtNameHall; set => TxtNameHall = value; }
        public TextBox TxtCountOfGuest { get => TxtCountOfGuest; set => TxtCountOfGuest = value; }
        public TextBox TxtDose { get => TxtDose; set => TxtDose = value; }
        public TextBox TxtLighting { get => TxtLighting; set => TxtLighting = value; }
        public TextBox TxtDesign { get => TxtDesign; set => TxtDesign = value; }
        public TextBox TxtDj { get => TxtDj; set => TxtDj = value; }
        public TextBox TxtBar { get => TxtBar; set => TxtBar = value; }
        public TextBox TxtSpak1 { get => TxtSpak1; set => TxtSpak1 = value; }
        public TextBox TxtSpak2 { get => TxtSpak2; set => TxtSpak2 = value; }
        public TextBox TxtSpak3 { get => TxtSpak3; set => TxtSpak3 = value; }
        public TextBox TxtSpak4 { get => TxtSpak4; set => TxtSpak4 = value; }
        public TextBox TxtSpak5 { get => TxtSpak5; set => TxtSpak5 = value; }
        public TextBox TxtSpak6 { get => TxtSpak6; set => TxtSpak6 = value; }
        public TextBox TxtSpak7 { get => TxtSpak7; set => TxtSpak7 = value; }
        public TextBox TxtSpak8 { get => TxtSpak8; set => TxtSpak8 = value; }
        public TextBox TxtSpak9 { get => TxtSpak9; set => TxtSpak9 = value; }
        public TextBox TxtSpak10 { get => TxtSpak10; set => TxtSpak10 = value; }

        public Details(int id)
        {
            InitializeComponent();
            AddSapakim();
            LoginPage login=new LoginPage();
            login.GetDatabaseList();
            listUsers = login.ListUsers;
            foreach (User u in listUsers)
            {
                if(id.Equals(u.Id))
                {
                    userName = new User();
                    userName = u;
                    break;
                }
            }
        }

       

        /// <summary>
        /// הוספת כל הספקים השונים לרשימה
        /// </summary>
        private void AddSapakim()
        {
            this.sapakim.Add(txtLighting);
            this.sapakim.Add(txtDesign);
            this.sapakim.Add(txtPhotography);
            this.sapakim.Add(txtDj);
            this.sapakim.Add(txtBar);
            this.sapakim.Add(txtSpak1);
            this.sapakim.Add(txtSpak2);
            this.sapakim.Add(txtSpak3);
            this.sapakim.Add(txtSpak4);
            this.sapakim.Add(txtSpak5);
            this.sapakim.Add(txtSpak6);
            this.sapakim.Add(txtSpak7);
            this.sapakim.Add(txtSpak8);
            this.sapakim.Add(txtSpak9);
            this.sapakim.Add(txtSpak10);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            textTakin();
            txtExpenses.Text = SumOfExpenses();
            if (txtExpenses.Text.Length == 0)
                txtExpenses.Text = "0";
            if (txtRevenue.Text.Length == 0)
                txtRevenue.Text = "0";
            txtProfitOrLoss.Text = (Int32.Parse(txtRevenue.Text) - Int32.Parse(txtExpenses.Text)).ToString();
            if ((Int32.Parse(txtRevenue.Text) - Int32.Parse(txtExpenses.Text)) < 0)
                lblProfitOrLoss.Text = "הפסד";
            else
            if ((Int32.Parse(txtRevenue.Text) - Int32.Parse(txtExpenses.Text)) > 0)
                lblProfitOrLoss.Text = "רווח";
            else
                lblProfitOrLoss.Text = "רווח/הפסד";
        }

        #region הודעה עם ריחוף בעכבר לשינוי שם הספק
        private void lblSpak1_MouseHover(object sender, EventArgs e)
        {
            showToolTip("אם ברצונך לשנות את שם הספק נא עליו דאבל קליק", lblSpak1);
        }

        public void showToolTip(string s, IWin32Window w)
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

        #region שינוי שם ספקים ומחירים
        private void lblSpak1_DoubleClick(object sender, EventArgs e)
        {
            ChangeName(lblSpak1, txtSpak1);
        }

        public void ChangeName(Label l, TextBox t)
        {
            UpdateName updateName = new UpdateName();
            updateName.ShowDialog();
            //בדיקה אם הוזנו נתונים
            if (updateName.Netunim.Equals(true))
            {
                l.Text = updateName.Name1.ToString();
                t.Text = updateName.Price.ToString();
            }
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
        #endregion

        private string SumOfExpenses()
        {
            int sum;
            Tkinut(txtCountOfGuest);
            Tkinut(txtDose);
            foreach (TextBox t in sapakim)
            {
                Tkinut(t);
            }
            sum = Int32.Parse(txtCountOfGuest.Text) * Int32.Parse(txtDose.Text) + Int32.Parse(txtLighting.Text) +
                Int32.Parse(txtDesign.Text) + Int32.Parse(txtPhotography.Text) +
                Int32.Parse(txtDj.Text) + Int32.Parse(txtBar.Text) + Int32.Parse(txtSpak1.Text) + Int32.Parse(txtSpak2.Text) +
                Int32.Parse(txtSpak3.Text) + Int32.Parse(txtSpak4.Text) + Int32.Parse(txtSpak5.Text) + Int32.Parse(txtSpak6.Text) +
                Int32.Parse(txtSpak7.Text) + Int32.Parse(txtSpak8.Text) + Int32.Parse(txtSpak9.Text) + Int32.Parse(txtSpak10.Text);
            ReturnMode(txtCountOfGuest);
            ReturnMode(txtDose);
            foreach (TextBox t in sapakim)
            {
                ReturnMode(t);
            }
            return sum.ToString();
        }


        private void Tkinut(TextBox t)
        {
            if (t.Text.Length == 0)
                t.Text = "0";
        }

        private void ReturnMode(TextBox t)
        {
            if (t.Text.Equals("0"))
            {
                t.Clear();
            }
        }

        private void textTakin()
        {
            try
            {
                //בדיקה אם הוכנס שדה תאריך
                if (txtDate.Text.Length > 0)
                    //בדיקת תקינות קלט עבור שדה תאריך
                    if (!IsDateTime(txtDate.Text))
                    {
                        new LoginPage().messageBox("תאריך האירוע לא נשרם כראוי", "שגיאה");
                        txtDate.SelectAll();
                        txtDate.Focus();
                    }


            }
            catch (Exception e)
            {

            }
        }

        /// <summary>
        /// תקינות קלט עבור שדה תאריך
        /// </summary>
        /// <param name="txtDate"></param>
        /// <returns></returns>
        public static bool IsDateTime(string txtDate)
        {
            DateTime tempDate;
            return DateTime.TryParse(txtDate, out tempDate);
        }

        #region מעבר בין הזנת פרטים
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void NextTextBox(TextBox t, object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //SendKeys.Send(Keys.Tab.ToString());
            }
        }

        private void cboTaype_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBox(txtDate, sender, e);
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
           NextTextBox(txtNameHall, sender, e);
        }

        private void txtNameHall_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBox(txtCountOfGuest, sender, e);
        }

        private void txtCountOfGuest_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBox(txtDose, sender, e);
        }

        private void txtDose_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBox(txtLighting, sender, e);
        }

        private void NextTextBoxAndSum(TextBox t, object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtExpenses.Text.Equals("0"))
                    txtExpenses.Text = "0";
                txtExpenses.Text=(Int32.Parse(txtExpenses.Text) + Int32.Parse(t.Text)).ToString();
                t.Focus();
            }
        }

        private void txtLighting_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtDesign, sender, e);
        }

        private void txtDesign_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtPhotography, sender, e);
        }

        private void txtPhotography_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtDj, sender, e); 
        }

        private void txtDj_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtBar, sender, e);
        }

        private void txtBar_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtSpak1, sender, e);
        }

        private void txtSpak1_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtSpak2, sender, e);
        }

        private void txtSpak2_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtSpak3, sender, e);
        }

        private void txtSpak3_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtSpak4, sender, e);
        }

        private void txtSpak4_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtSpak5, sender, e);
        }

        private void txtSpak5_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtSpak6, sender, e);
        }

        private void txtSpak6_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtSpak7, sender, e);
        }

        private void txtSpak7_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtSpak8, sender, e);
        }

        private void txtSpak8_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtSpak9, sender, e);
        }

        private void txtSpak9_KeyDown(object sender, KeyEventArgs e)
        {
            NextTextBoxAndSum(txtSpak10, sender, e);
        }

        private void txtSpak10_KeyDown(object sender, KeyEventArgs e)
        {

        }
        #endregion

        private void Details_Load(object sender, EventArgs e)
        {
            txtUserName.Text = userName.NameHusband + " ו" + userName.NameWife+" "+userName.LaseName;
            cboTaype.SelectedIndex = cboTaype.FindString(userName.TaypeEvent);
            txtDate.Text = userName.DateEvent.Date.ToString("MM/dd/yyyy");
            txtNameHall.Text = userName.NameHall;
        }
    }
}
