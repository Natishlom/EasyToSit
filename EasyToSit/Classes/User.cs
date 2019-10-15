using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyToSit
{

    class User
    {
        private int id;
        private string userName;
        private string password;
        private string phone;
        private string nameHusband;
        private string nameWife;
        private string laseName;
        private string taypeEvent;
        private DateTime dateEvent;
        private string nameHall;
        private string eMail;

        public User(int id, string userName, string password, string phone, string nameHusband, string nameWife, string laseName,
            string taypeEvent, DateTime dateEvent, string nameHall, string eMail)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.phone = phone;
            this.nameHusband = nameHusband;
            this.nameWife = nameWife;
            this.laseName = laseName;
            this.taypeEvent = taypeEvent;
            this.dateEvent = dateEvent;
            this.nameHall = nameHall;
            this.eMail = eMail;
        }

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public string NameHusband { get => nameHusband; set => nameHusband = value; }
        public string NameWife { get => nameWife; set => nameWife = value; }
        public string LaseName { get => laseName; set => laseName = value; }
        public string TaypeEvent { get => taypeEvent; set => taypeEvent = value; }
        public DateTime DateEvent { get => dateEvent; set => dateEvent = value; }
        public string NameHall1 { get => nameHall; set => nameHall = value; }
        public string EMail { get => eMail; set => eMail = value; }
    }
}
