using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private List<TextBox> sapakimTxt = new List<TextBox>();
        private List<Label> sapakimlbl = new List<Label>();
        List<Sapak> sapakim;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        private int sapakId= 1;

        public Details(int id)
        {
            InitializeComponent();
            AddSapakim();
            LoginPage login = new LoginPage();
            login.GetDatabaseList();
            listUsers = login.ListUsers;
            foreach (User u in listUsers)
            {
                if (id.Equals(u.Id))
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
            this.sapakimTxt.Add(txtLighting);
            this.sapakimlbl.Add(lblLighting);
            this.sapakimTxt.Add(txtDesign);
            this.sapakimlbl.Add(lblDesign);
            this.sapakimTxt.Add(txtPhotography);
            this.sapakimlbl.Add(lblPhotography);
            this.sapakimTxt.Add(txtDj);
            this.sapakimlbl.Add(lblDj);
            this.sapakimTxt.Add(txtBar);
            this.sapakimlbl.Add(lblBar);
            this.sapakimTxt.Add(txtSpak1);
            this.sapakimlbl.Add(lblSpak1);
            this.sapakimTxt.Add(txtSpak2);
            this.sapakimlbl.Add(lblSpak2);
            this.sapakimTxt.Add(txtSpak3);
            this.sapakimlbl.Add(lblSpak3);
            this.sapakimTxt.Add(txtSpak4);
            this.sapakimlbl.Add(lblSpak4);
            this.sapakimTxt.Add(txtSpak5);
            this.sapakimlbl.Add(lblSpak5);
            this.sapakimTxt.Add(txtSpak6);
            this.sapakimlbl.Add(lblSpak6);
            this.sapakimTxt.Add(txtSpak7);
            this.sapakimlbl.Add(lblSpak7);
            this.sapakimTxt.Add(txtSpak8);
            this.sapakimlbl.Add(lblSpak8);
            this.sapakimTxt.Add(txtSpak9);
            this.sapakimlbl.Add(lblSpak9);
            this.sapakimTxt.Add(txtSpak10);
            this.sapakimlbl.Add(lblSpak10);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { 
            con = new SqlConnection("Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True;");
            con.Open();
            cmd = new SqlCommand("DELETE EasySapakimData", con);
            cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textTakin();
            sapakim = new List<Sapak>();
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
            int price;
            if (txtDose.Text.Equals(""))
                price = 0;
                    else
                price = Int32.Parse(txtDose.Text);

            Sapak s = new Sapak(sapakId,"מחיר מנה",price);
            sapakId++;
            sapakim.Add(s);
            try
            {
            con = new SqlConnection("Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True;");
            con.Open();
            cmd = new SqlCommand("INSERT INTO EasySapakimData (id,name,price) VALUES ('" + s.Id + "','" + s.Name + "','" + s.Price + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void CreatSapak(TextBox t)
        {
            Sapak sapak = new Sapak();
            string s = t.Name.Substring(3);


            foreach (Label lbl in sapakimlbl)
            {
                if (lbl.Name.Equals("lbl" + s))
                {
                    sapak.Name = lbl.Text;
                    break;
                }
            }
            sapak.Price = Int32.Parse(t.Text);
            sapak.Id = sapakId;
            sapakId++;
            sapakim.Add(sapak);
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True;");
                con.Open();
                cmd = new SqlCommand("INSERT INTO EasySapakimData (id,name,price) VALUES ('" + sapak.Id + "','" + sapak.Name + "','" + sapak.Price + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private string SumOfExpenses()
        {
            int sum;
            Tkinut(txtCountOfGuest);
            Tkinut(txtDose);
            foreach (TextBox t in sapakimTxt)
            {
                Tkinut(t);
                CreatSapak(t);
            }
            sum = Int32.Parse(txtCountOfGuest.Text) * Int32.Parse(txtDose.Text) + Int32.Parse(txtLighting.Text) +
                Int32.Parse(txtDesign.Text) + Int32.Parse(txtPhotography.Text) +
                Int32.Parse(txtDj.Text) + Int32.Parse(txtBar.Text) + Int32.Parse(txtSpak1.Text) + Int32.Parse(txtSpak2.Text) +
                Int32.Parse(txtSpak3.Text) + Int32.Parse(txtSpak4.Text) + Int32.Parse(txtSpak5.Text) + Int32.Parse(txtSpak6.Text) +
                Int32.Parse(txtSpak7.Text) + Int32.Parse(txtSpak8.Text) + Int32.Parse(txtSpak9.Text) + Int32.Parse(txtSpak10.Text);
            ReturnMode(txtCountOfGuest);
            ReturnMode(txtDose);
            foreach (TextBox t in sapakimTxt)
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
        public bool IsDateTime(string txtDate)
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
                SendKeys.Send(Keys.Tab.ToString());
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
                txtExpenses.Text = (Int32.Parse(txtExpenses.Text) + Int32.Parse(t.Text)).ToString();
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

        private string returnNumber(int price)
        {
            if (price.Equals(0))
                return "";
            else
                return price.ToString();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True;";
            int guset=0, gifts = 0;
            string countGuest,strGift;

           
            txtUserName.Text = userName.NameHusband + " ו" + userName.NameWife + " " + userName.LaseName;
            cboTaype.SelectedIndex = cboTaype.FindString(userName.TaypeEvent);
            txtDate.Text = userName.DateEvent.Date.ToString("MM/dd/yyyy");
            txtNameHall.Text = userName.NameHall;
            sapakim = new List<Sapak>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM EasySapakimData", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Sapak s = new Sapak();
                                s.Id = dr.GetInt32(0);
                                s.Name = dr.GetString(1);
                                s.Price = dr.GetInt32(2);
                                sapakim.Add(s);
                            }
                        }

                        
                        try
                        {
                        SqlCommand cm = new SqlCommand("SELECT Count,Gift FROM EasyGusetData", con);
                        IDataReader rd = cm.ExecuteReader();
                        while (rd.Read())
                            {
                            guset += rd.GetInt32(0);
                                gifts += rd.GetInt32(1);
                            }
                                countGuest = returnNumber(guset);
                            strGift = returnNumber(gifts);

                            txtRevenue.Text = strGift;
                        txtCountOfGuest.Text = countGuest;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + Environment.NewLine + "לא הוכנסו במסך קליטת אורחים נתונים.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw;
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (Sapak s in sapakim)
                {
                    switch (s.Id)
                    {
                        case 1:
                            {
                                txtLighting.Text = returnNumber(s.Price);
                            }
                            break;
                            case 2:
                            {
                                txtDesign.Text= returnNumber(s.Price);
                            }
                            break;
                        case 3:
                            {
                                txtPhotography.Text = returnNumber(s.Price);
                            }
                            break;
                        case 4:
                            {
                                txtDj.Text = returnNumber(s.Price);
                            }
                            break;
                        case 5:
                            {
                                txtBar.Text = returnNumber(s.Price);
                            }
                            break;
                        case 6:
                            {
                                txtSpak1.Text = returnNumber(s.Price);
                                lblSpak1.Text = s.Name;
                            }
                            break;
                        case 7:
                            {
                                txtSpak2.Text = returnNumber(s.Price);
                                lblSpak2.Text = s.Name;
                            }
                            break;
                        case 8:
                            {
                                txtSpak3.Text = returnNumber(s.Price);
                                lblSpak3.Text = s.Name;
                            }
                            break;
                        case 9:
                            {
                                txtSpak4.Text = returnNumber(s.Price);
                                lblSpak4.Text = s.Name;
                            }
                            break;
                        case 10:
                            {
                                txtSpak5.Text = returnNumber(s.Price);
                                lblSpak5.Text = s.Name;
                            }
                            break;
                        case 11:
                            {
                                txtSpak6.Text = returnNumber(s.Price);
                                lblSpak6.Text = s.Name;
                            }
                            break;
                        case 12:
                            {
                                txtSpak7.Text = returnNumber(s.Price);
                                lblSpak7.Text = s.Name;
                            }
                            break;
                        case 13:
                            {
                                txtSpak8.Text = returnNumber(s.Price);
                                lblSpak8.Text = s.Name;
                            }
                            break;
                        case 14:
                            {
                                txtSpak9.Text = returnNumber(s.Price);
                                lblSpak9.Text = s.Name;
                            }
                            break;
                        case 15:
                            {
                                txtSpak10.Text = returnNumber(s.Price);
                                lblSpak10.Text = s.Name;
                            }
                            break;
                        case 16:
                            {
                                txtDose.Text = returnNumber(s.Price);
                            }
                            break;
                        default: continue;
                    }
                }

                
            }
        }
    }
}
