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
                NewRowNeeded = false;
                new LoginPage().messageBox("new row", "");
            }
        }
    }
}
