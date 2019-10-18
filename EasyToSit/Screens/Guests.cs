using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using EasyToSit.Classes;

namespace EasyToSit
{
    public partial class Guests : Form
    {
        private List<Guest> guestsList = new List<Guest>();
        private bool newRowNeeded;
        Guest guest;
        public Guests()
        {
            InitializeComponent();
        }

        public bool NewRowNeeded { get => newRowNeeded; set => newRowNeeded = value; }


        private void dataGuests_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NewRowNeeded = true;
            if (NewRowNeeded)
            {
                Guest guest = new Guest();
                NewRowNeeded = false;
                int maxValue = 0;
                foreach (Guest g in guestsList)
                {
                    maxValue = Math.Max(maxValue, g.GuestId);
                }
                //int col = dataGuests.Columns["rowNumber"].Index;
                //int row = dataGuests.RowCount - 1;
                //int num = maxValue + 1;
                //dataGuests.Rows[dataGuests.RowCount-1].Cells[8].Value = num;
            }
            txtCount.Text = dataGuests.Rows.Count + 1.ToString();
        }

        private void Guests_Load(object sender, EventArgs e)
        {

            string conString = "Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Guests", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGuests.DataSource = dtbl;

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Guests", con))
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
                            guest.NumberPhone = dr.GetString(4);
                            guest.Invitation = dr.IsDBNull(5)?false: dr.GetBoolean(5);
                            guest.IsComing = dr.IsDBNull(6)?false: dr.GetBoolean(6);
                            guest.Gift = dr.GetInt32(7);
                            guestsList.Add(guest);
                        }
                    }
                }
            }

        }
    }
}
