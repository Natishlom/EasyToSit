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
using Nexmo.Api;
using EasyToSit.Classes;
using System.Net;
using System.IO;

namespace EasyToSit
{
    public partial class SendMass : Form
    {
        private List<Guest> guestsList= new List<Guest>();
        List<Guest> guestsListSend ;
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

        private void checkNetunim()
        {
            txtMass.Visible = true;
            txtMassege.Visible = true;
            pictureBox1.Visible = true;
            pictureMass.Visible = true;
        }

        private void cboTaypeMassege_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTaypeMassege.SelectedIndex)
            {
                case 0:
                    {
                        checkNetunim();
                        txtMassege.Text = string.Format("אורח יקר," + newLine + "הנך מוזמן ל{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            "לאישור הגעה נא לחץ על הקישור הבא:" + newLine +
                            "www.EasyToSit.co.il", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                        txtMass.Text = string.Format("אורח יקר," + newLine + "הנך מוזמן ל{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            "לאישור הגעה נא לחץ על הקישור הבא:" + newLine +
                            "www.EasyToSit.co.il", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                    }
                    break;
                case 1:
                    {
                        checkNetunim();
                        txtMassege.Text = string.Format("אורח יקר," + newLine + "טרם אישרת הגעה ל{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            "לאישור הגעה נא לחץ על הקישור הבא:" + newLine +
                            "www.EasyToSit.co.il", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                        txtMass.Text = string.Format("אורח יקר," + newLine + "טרם אישרת הגעה ל{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            "לאישור הגעה נא לחץ על הקישור הבא:" + newLine +
                            "www.EasyToSit.co.il", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                    }
                    break;
                case 2:
                    {
                        checkNetunim();
                        txtMassege.Text = string.Format("אורח יקר," + newLine + "טרם הושבת עצמך באולם ב{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            " כדי להושיב עצמך באולם, נא לחץ על הקישור הבא:" + newLine +
                            "www.EasyToSit.co.il", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                        txtMass.Text = string.Format("אורח יקר," + newLine + "טרם הושבת עצמך באולם ב{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            " כדי להושיב עצמך באולם, נא לחץ על הקישור הבא:" + newLine +
                            "www.EasyToSit.co.il", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                    }
                    break;
                case 3:
                    {
                        checkNetunim();
                        txtMassege.Text = string.Format("אורח יקר," + newLine + "להזכירך  היום תערך ה{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            " כדי להושיב עצמך באולם, נא לחץ על הקישור הבא:" + newLine +
                            "www.EasyToSit.co.il", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                        txtMass.Text = string.Format("אורח יקר," + newLine + "להזכירך  היום תערך ה{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            " כדי להושיב עצמך באולם, נא לחץ על הקישור הבא:" + newLine +
                            "www.EasyToSit.co.il", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                    }
                    break;
                case 4:
                    {
                        checkNetunim();
                        txtMassege.Text = string.Format("אורח יקר," + newLine + "תודה על השתתפותך ב{3} חתונה של {0} ו{1} {2}," + newLine +
                            "שמחנו לראותך בין אורחינו."
                             , userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent);
                        txtMass.Text = string.Format("אורח יקר," + newLine + "תודה על השתתפותך ב{3} חתונה של {0} ו{1} {2}," + newLine +
                            "שמחנו לראותך בין אורחינו."
                             , userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent);
                    }
                    break;
                default:
                    {
                        txtMass.Visible = false;
                        txtMass.Visible = false;
                        pictureMass.Visible = false;
                        pictureBox1.Visible = false;
                    }
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            guestsListSend = new List<Guest>();
            for (int i = 0; i < dataGuests.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dataGuests.Rows[i].Cells["CheckGuest"].Value).Equals(true))
                {
                    guest = new Guest();
                    guest.FirsNames = dataGuests.Rows[i].Cells["FristName"].Value.ToString();
                    guest.LastName = dataGuests.Rows[i].Cells["lastName"].Value.ToString();
                    guest.NumberPhone = dataGuests.Rows[i].Cells["phone"].Value.ToString();

                    guestsListSend.Add(guest);
                }
            }
            LBGuest.Items.Clear();
            foreach (Guest g in guestsListSend)
            {
                LBGuest.Items.Add((g.FirsNames.ToString() + " " + g.LastName.ToString()));
            }
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked)
            {
                foreach (DataGridViewRow Row in dataGuests.Rows)
                {
                    ((DataGridViewCheckBoxCell)Row.Cells["CheckGuest"]).Value = true;
                    dataGuests.RefreshEdit();
                }
            }
            else
               if (!checkAll.Checked)
            {
                foreach (DataGridViewRow Row in dataGuests.Rows)
                {
                    ((DataGridViewCheckBoxCell)Row.Cells["CheckGuest"]).Value = false;
                    dataGuests.RefreshEdit();
                }
            }
        }

        public void sendSms()
        {
            try
            {
                WebClient client = new WebClient();
                Stream s = client.OpenRead("");
                StreamReader reader = new StreamReader(s);
                string result = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendSms();
        }
    }
}
