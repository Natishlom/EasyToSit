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
        string conString = "Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True;";
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
            foreach (DataGridViewRow row in dataGuests.Rows)
            {
               //if (row.IsNewRow.Equals(true))
                    foreach (Guest g in guestsList)
                    {
                        if (dataGuests.Rows[row.Index].Cells["phone"].Value.ToString().Equals(g.NumberPhone))
                            MessageBox.Show("ערך זה קיים "+ row.Cells["FristName"].Value.ToString() + row.Cells["lastName"].Value.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            guestsList.Add(new Guest(Int32.Parse(row.Cells["rowNumber"].Value.ToString()),
                               row.Cells["FristName"].Value.ToString(), row.Cells["lastName"].Value.ToString(),
                               Int32.Parse(row.Cells["count"].Value.ToString()), row.Cells["phone"].Value.ToString(),
                               Convert.ToBoolean(row.Cells["CheckHzmana"].Value), Convert.ToBoolean(row.Cells["isComing"].Value), Int32.Parse(row.Cells["Gift"].Value.ToString())));
                    }
            }
        }

        private void dataGuests_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGuests.Rows[e.RowIndex].Cells["rowNumber"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==7)
                if(DialogResult.OK.Equals(MessageBox.Show("האם ברצוך למחוק שורה זו?")))
                {

                }
        }
    }
}
