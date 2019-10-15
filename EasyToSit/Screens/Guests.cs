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
        public Guests()
        {
            InitializeComponent();
        }

        public bool NewRowNeeded { get => newRowNeeded; set => newRowNeeded = value; }

        private void dataGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGuests_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            new LoginPage().messageBox("ertrh", "");
        }

        private void dataGuests_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NewRowNeeded = true;
            if (NewRowNeeded)
            {
                Guest guest = new Guest();
                NewRowNeeded = false;
                new LoginPage().messageBox("new row", "");
            }
        }

        private void Guests_Load(object sender, EventArgs e)
        {

            DbClass.openConnection();

            DbClass.sql = new SqlCommand("SELECT [GuestId],[FirstName],[LastName],[Count],[PhoneNumber],[CheckHazmna],[IsComing],[Gift] FROM Guests;",cmd);

            DbClass.cmd.CommandType = CommandType.Text;
            DbClass.cmd.CommandText = DbClass.sql;

            DbClass.da = new SqlDataAdapter(DbClass.cmd);
            DbClass.dt = new DataTable();
            DbClass.da.Fill(DbClass.dt);

            dataGuests.DataSource = DbClass.dt.DefaultView;

            DbClass.closeConnection();
        }
    }
}
