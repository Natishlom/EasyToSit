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
        string conString = "Data Source=NATI\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True;";
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
                            guest.UserNamer = dr.GetString(8);
                            guest.TableNumber = Int32.Parse(dr.GetString(9));
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
                if (row.Index < dataGuests.RowCount-1)
                {
                    //if(guestsList.Count.Equals(0))
                    //    IsExist = true;
                    //foreach (Guest g in guestsList)

                    // ריצה על כל שורות הטבלה מלבד השורה הנוכחית ולבדוק כפילות מספר הטלפון
                    for (int i = row.Index+1; i < dataGuests.RowCount - 1; i++)
                    {
                        // השוואה בין מספרי הטלפון לבדוק אם זהים
                        if (row.Cells["phone"].Value.ToString() == dataGuests.Rows[i].Cells["phone"].Value.ToString())
                        {
                            IsExist = true;
                            lstIndexKfilut.Add(i);
                            // לצבוע את השדה של הטלפון בטבלה בצבע אחר.
                        }
                        
                    }
                       
                    // אם לא מצאנו כפילות מספר טלפון עבור השורה הנוכחית - הוספה לרשימה זמנית
                    if (!IsExist)
                    {
                        lstTempGuests.Add(new Guest(Int32.Parse(row.Cells["rowNumber"].Value.ToString()),
                           row.Cells["FristName"].Value.ToString(), row.Cells["lastName"].Value.ToString(),
                           Int32.Parse(row.Cells["count"].Value.ToString()), row.Cells["phone"].Value.ToString(),
                           Convert.ToBoolean(row.Cells["CheckHzmana"].Value), Convert.ToBoolean(row.Cells["isComing"].Value), Int32.Parse(row.Cells["Gift"].Value.ToString())));
                        
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


            // אחרי שאין כפילויות - שומר ל DB

        }

        private void dataGuests_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGuests.Rows[e.RowIndex].Cells["rowNumber"].Value = (e.RowIndex + 1).ToString();
        }

    }
}
