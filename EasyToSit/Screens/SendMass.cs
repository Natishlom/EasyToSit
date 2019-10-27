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
        List<Guest> guestsListSend ;
        Guest guest;
        User userName;
        List<User> listUsers;
        string newLine = Environment.NewLine;
        string nameCpu = System.IO.File.ReadAllText(@"C:\Temp\conString.txt");
        string conString;

        public SendMass()
        {
            InitializeComponent();
            conString = string.Format("Data Source={0}\\EASYTOSIT;Initial Catalog=EasyToSit;Integrated Security=True", nameCpu);
        }

        //קבלת מספר המשתמש כדי לאסוף נתונים על האירוע
        public SendMass(int id)
        {
            InitializeComponent();
            //הכרזה על המס
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

        //טעינת רשימת אורחים 
        private void SendMass_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT GuestId,FirstName,LastName,Count,GuestPhone,CheckHzmana,IsComing,Gift FROM EasyGusetData", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGuests.AutoGenerateColumns = false;
                dataGuests.DataSource = dtbl;
            }
        }

        //הצגת תמונה לאחר בחירת סוג ההודעה
        private void checkNetunim()
        {
            txtMass.Visible = true;
            txtMassege.Visible = true;
            pictureBox1.Visible = true;
            pictureMass.Visible = true;
        }

        //מאזין לבחירת סוג ההודעה
        private void cboTaypeMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTaypeMessage.SelectedIndex)
            {
                case 0:
                    {
                        checkNetunim();
                        string text= string.Format("אורח יקר," + newLine + "הנך מוזמן ל{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            "לאישור הגעה נא לחץ על הקישור הבא:" + newLine +
                            "https://firebasestorage.googleapis.com/v0/b/easytosit-a4f7c.appspot.com/o/phone%2FPhoneCredentials.html?alt=media&token=21255627-d130-466c-9719-3698818f3580", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);

                        txtMassege.Text = text;
                        txtMass.Text = text;
                    }
                    break;
                case 1:
                    {
                        checkNetunim();
                        string text = string.Format("אורח יקר," + newLine + "טרם אישרת הגעה ל{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            "לאישור הגעה נא לחץ על הקישור הבא:" + newLine +
                            "https://firebasestorage.googleapis.com/v0/b/easytosit-a4f7c.appspot.com/o/phone%2FPhoneCredentials.html?alt=media&token=21255627-d130-466c-9719-3698818f3580", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                        txtMassege.Text = text;
                        txtMass.Text = text;
                    }
                    break;
                case 2:
                    {
                        checkNetunim();
                        string text = string.Format("אורח יקר," + newLine + "טרם הושבת עצמך באולם ב{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            " כדי להושיב עצמך באולם, נא לחץ על הקישור הבא:" + newLine +
                            "https://firebasestorage.googleapis.com/v0/b/easytosit-a4f7c.appspot.com/o/phone%2FPhoneCredentials.html?alt=media&token=21255627-d130-466c-9719-3698818f3580", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                        txtMassege.Text = text;
                        txtMass.Text = text;
                    }
                    break;
                case 3:
                    {
                        checkNetunim();
                       string text = string.Format("אורח יקר," + newLine + "להזכירך  היום תערך ה{3} של {0} ו{1} {2}," + newLine + "שתתקיים בתאריך " +
                            "{4} בשעה 20:00." +
                            "באולמי {5}." +
                            " כדי להושיב עצמך באולם, נא לחץ על הקישור הבא:" + newLine +
                            "https://firebasestorage.googleapis.com/v0/b/easytosit-a4f7c.appspot.com/o/phone%2FPhoneCredentials.html?alt=media&token=21255627-d130-466c-9719-3698818f3580", userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent, userName.DateEvent.Date.ToString("MM/dd/yyyy"),
                            userName.NameHall);
                        txtMassege.Text = text;
                        txtMass.Text = text;
                    }
                    break;
                case 4:
                    {
                        checkNetunim();
                        string text = string.Format("אורח יקר," + newLine + "תודה על השתתפותך ב{3} חתונה של {0} ו{1} {2}," + newLine +
                            "שמחנו לראותך בין אורחינו."
                             , userName.NameHusband, userName.NameWife, userName.LaseName, userName.TaypeEvent);
                        txtMassege.Text = text;
                        txtMass.Text = text;
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
            //אסיפת כל האורחים שסומנו לרשימה
            for (int i = 0; i < dataGuests.RowCount ; i++)
            {
                if (Convert.ToBoolean(dataGuests.Rows[i].Cells["CheckGuest"].Value).Equals(true))
                {
                    guest = new Guest();
                    guest.FirsNames = dataGuests.Rows[i].Cells["FirstName"].Value.ToString();
                    guest.LastName = dataGuests.Rows[i].Cells["lastName"].Value.ToString();
                    guest.NumberPhone = dataGuests.Rows[i].Cells["phone"].Value.ToString();

                    guestsListSend.Add(guest);
                }
            }
            //ניקוי הצגת האורחים בחלון האחרון
            LBGuest.Items.Clear();
            foreach (Guest g in guestsListSend)
            {
                LBGuest.Items.Add((g.FirsNames.ToString() + " " + g.LastName.ToString()));
            }
        }

        //סימון צ'ק בוקס סימון כל האורחים וסימונם
        //בנוסף גם כשנוריד את הסימון יתבטל הסימון
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

        //מתודת שליחת SMS
        //המקבלת מספר לשליחה וטקסט ההודעה
        //public int sendSms(string phoneNumberToSend,string textMessage)
        //{
        //    try
        //    {
        //        // יצירת אובייקט אס אמ אס
        //      //  SMSCom.SMSSender sms = new SMSCom.SMSSender();

        //        // שם משתמש וסיסמא של ארדני לבנק ההודעות
        //        /sms.Username = "059694463";
        //        sms.Password = "8104781047";

        //        // מספר הטלפון להצגה שממנו לכאורה נשלחה ההודעה
        //        sms.Source = "050-9876543";

        //        // מספר הטלפון שרוצים לשלוח אליו
        //        string phoneNumber = phoneNumberToSend;

        //        // תוכן ההודעה שרוצים לשלוח.
        //        // עד 134 תוים = חיוב הודעה אחת.
        //        // כל 67 תווים = חיוב נוסף.
        //        string message = textMessage;

        //        // מתודה לשליחת ההודעה
        //        sms.SendSMS(message, phoneNumber);

        //        // קבלת קוד תגובה לשליחת ההודעה.
        //        // קוד תגובה 0 = תקין
        //        // קודי תגובה אחרים מייצגים שגיאות שונות - ההודעה לא נשלחה
        //        int result = sms.ResponseCode;

        //        return result;
        //    }
        //    catch { return 0; }
        //}

        //שליחת SMS לאורחים שנבחרו.
        private void btnSend_Click(object sender, EventArgs e)
        {
            string result="";
            int sum=0;
            try
            {
                foreach (Guest guest in guestsListSend)
                {
                   // result = sendSms(guest.NumberPhone, txtMass.Text).ToString();
                    if (result.Equals("0"))
                        sum++;
                }
                if(sum.Equals(0))
                    MessageBox.Show("הודעת שגיאה:" + newLine + result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                MessageBox.Show("ההודעה נשלחה בהצלחה ל-"+sum+" אורחים.","לידיעתך",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
