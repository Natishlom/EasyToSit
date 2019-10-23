using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using EasyToSit.Classes;

namespace EasyToSit
{
    public partial class Guests : Form
    {
        private List<Guest> guestsList = new List<Guest>();
        private bool newrowNeeded;
        Guest guest;
        string conString = "Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Guests()
        {
            InitializeComponent();
        }

        public bool NewRowNeeded { get => newrowNeeded; set => newrowNeeded = value; }


        private void dataGuests_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NewRowNeeded = true;
            if (NewRowNeeded)
            {
                guest = new Guest();
                NewRowNeeded = false;
            }

        }

        private void Guests_Load(object sender, EventArgs e)
        {
            int count = 0;

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT GuestId,FirstName,LastName,Count,GuestPhone,CheckHzmana,IsComing,Gift FROM EasyGusetData", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGuests.DataSource = dtbl;

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM EasyGusetData", con))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Guest guest = new Guest();
                            guest.GuestId = dr.GetInt32(0);
                            guest.FirsNames = dr.GetString(1);
                            guest.LastName = dr.GetString(2);
                            guest.Quantity = dr.GetInt32(3);
                            count += dr.GetInt32(3);
                            guest.NumberPhone = dr.GetString(4);
                            guest.Invitation = dr.IsDBNull(5) ? false : dr.GetBoolean(5);
                            guest.IsComing = dr.IsDBNull(6) ? false : dr.GetBoolean(6);
                            guest.Gift = dr.GetInt32(7);
                            //guest.UserNamer = dr.GetString(8);
                            //guest.TableNumber = Int32.Parse(dr.GetString(9));
                            guestsList.Add(guest);
                        }
                    }
                }
            }
            if (count != 0)
                txtCount.Text = count.ToString();

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // משתנה להחזקת רשימה זמנית של אורחית
            List<Guest> lstTempGuests = new List<Guest>();
            // משתנה להחזקת מיקומי אינדקס של כפילויות
            List<int> lstIndexKfilut = new List<int>();
            // משתנה בוליאני לבדיקה אם יש כפילות בשורה הנוכחית
            bool IsExist = false;

            foreach (DataGridViewRow row in dataGuests.Rows)
            {
                // כל עוד מדובר בשורה עד הלפני אחרונה בטבלה
                if (row.Index < dataGuests.RowCount - 1)
                {
                    // ריצה על כל שורות הטבלה מלבד השורה הנוכחית ולבדוק כפילות מספר הטלפון
                    for (int i = row.Index + 1; i < dataGuests.RowCount - 1; i++)
                    {
                        // השוואה בין מספרי הטלפון לבדוק אם זהים
                        if (row.Cells["phone"].Value.ToString() == dataGuests.Rows[i].Cells["phone"].Value.ToString())
                        {
                            IsExist = true;
                            lstIndexKfilut.Add(i);
                            // לצבוע את השדה של הטלפון בטבלה בצבע אחר.
                            dataGuests.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                        }

                    }

                    // אם לא מצאנו כפילות מספר טלפון עבור השורה הנוכחית - הוספה לרשימה זמנית
                    if (!IsExist)
                    {
                        Guest g = new Guest();
                        g.FirsNames = row.Cells["FirstName"].Value.ToString();
                        g.LastName = row.Cells["lastName"].Value.ToString();
                        g.Quantity = row.Cells["count"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["count"].Value.ToString());
                        g.NumberPhone = row.Cells["phone"].Value.ToString();
                        g.Invitation = row.Cells["CheckHzmana"].Value == DBNull.Value ? false : Convert.ToBoolean(row.Cells["CheckHzmana"].Value.ToString());
                        g.IsComing = row.Cells["isComing"].Value == DBNull.Value ? false : Convert.ToBoolean(row.Cells["isComing"].Value.ToString());
                        g.Gift = row.Cells["Gift"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["Gift"].Value.ToString());
                        lstTempGuests.Add(g);
                    }

                    IsExist = false;
                }
            }

            int cntTemp = 0;
            foreach (Guest g in lstTempGuests)
            {
                cntTemp += g.Quantity;
            }
            txtCount.Text = cntTemp.ToString();

            // בסיום, לבדוק אם יש כפילויות
            //lstIndexKfilut.Count > 0
            // אם יש כפילות - להציג הודעה למשתמש שנמצאו כפילויות
            // ושהם לא נשמרו. ועליו לטפל בשורות הללו - יש להם צבע אחר.
            // לאחר מכן להקליק שוב על "עדכן".
            //if (lstIndexKfilut.Count > 0)
            //{
                //DialogResult result = MessageBox.Show("נמצאו שורות בהן ככל הנראה יש אורחים פעמים" + Environment.NewLine +
                //    "שורות אילו נצבעו באדום האם ברצונך בכל זאת להמשיך?", "רגע חכה", MessageBoxButtons.YesNo);
                //if (result.Equals(DialogResult.Yes))
                //{
                //    MessageBox.Show("לאחר התיקון נא ללחוץ שוב על כפתור עדכון לפני שמירה", "עצור", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //}
                //else if (result.Equals(DialogResult.No))
                //{
                    //foreach (int row in lstIndexKfilut)
                    //{
                    //    if (dataGuests.Rows[row].DefaultCellStyle.BackColor.Equals(Color.LightSkyBlue))
                    //        dataGuests.Rows[row].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                    //    else
                    //        dataGuests.Rows[row].DefaultCellStyle.ForeColor = Color.LightSkyBlue;
                    //}
                    guestsList = new List<Guest>();
                    guestsList = lstTempGuests;
                //}
                //lstIndexKfilut = new List<int>();
           // }

            // אחרי שאין כפילויות - שומר ל DB

        }

        private void dataGuests_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGuests.Rows[e.RowIndex].Cells["rowNumber"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                cmd = new SqlCommand("DELETE EasyGusetData", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                foreach (Guest guest in guestsList)
                {
                con = new SqlConnection(conString);
                con.Open();
                cmd = new SqlCommand("INSERT INTO EasyGusetData (FirstName,LastName,Count,GuestPhone,CheckHzmana,IsComing,Gift) VALUES ('"  + guest.FirsNames + "','" + guest.LastName + "','" + guest.Quantity+ "','" + guest.NumberPhone + "','" + guest.Invitation + "','" + guest.IsComing + "','" + guest.Gift + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                }
                MessageBox.Show("האורחים שהוספת עודכנו בהצלחה", "נשמר בהצלחה",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
