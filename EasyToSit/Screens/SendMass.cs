using EasyToSit.Properties;
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
        User userName;
        List<User> listUsers;
        string newLine = Environment.NewLine;

        public SendMass()
        {
            InitializeComponent();
        }

        public SendMass(int id)
        {
            InitializeComponent();
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

        private void SendMass_Load(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-O0DARQB\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Guests", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGuests.AutoGenerateColumns = false;
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

        private void cboTaypeMassege_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTaypeMassege.SelectedIndex)
            {
                case 0:
                    {
                        txtMassege.Text = string.Format("אורח יקר," + newLine + "הנך מוזמן לחתונה של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{3} בשעה 20:00." +
                            "באולמי {4}." +
                            "לאישור הגעה נא לחץ על הקישור הבא:" + newLine +
                            "www.EasyToSit.co.il", userName.NameHusband, userName.NameWife, userName.LaseName, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                    }
                    break;
                case 1:
                    {

                    }break;
                case 2:
                    {

                    }
                    break;
                case 3:
                    {

                    }
                    break;
                case 4:
                    {

                    }
                    break;
                default:
                    {

                    }
                    break;
            }
        }
    }
}
