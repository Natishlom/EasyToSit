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

namespace EasyToSit
{
    public partial class SendMass : Form
    {

        private List<Guest> guestsList = new List<Guest>();
        Guest guest;
        public SendMass()
        {
            InitializeComponent();
        }

        private void SendMass_Load(object sender, EventArgs e)
        {
            insertGuest();
        }

      public void insertGuest()
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
                            guest.FirsNames = dr.GetString(1);
                            guest.LastName = dr.GetString(2);
                            guest.Quantity = dr.GetInt32(3);
                            guest.NumberPhone = dr.GetString(4);
                            guest.Invitation = dr.IsDBNull(5) ? false : dr.GetBoolean(5);
                            guest.IsComing = dr.IsDBNull(6) ? false : dr.GetBoolean(6);
                            guestsList.Add(guest);
                        }
                    }
                }
            }
        }

        private void cboTapeMessange_SelectedIndexChanged(object sender, EventArgs e)
        {
           // switch(cboTapeMessange.SelectedIndexChanged.)
        }
    }
}
