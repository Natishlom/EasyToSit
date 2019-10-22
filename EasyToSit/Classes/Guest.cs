using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyToSit.Classes
{
    public class Guest
    {
        private int guestId;
        private string firsNames;
        private string lastName;
        private int quantity;
        private string numberPhone;
        private bool? invitation;
        private bool? isComing;
        private int gift;
        private string userNamer;
        private int tableNumber;
        public Guest() { }

        public Guest(int guestId, string firsNames, string lastName, int quantity, string numberPhone, bool? invitation, bool? isComing, int gift)
        {
            this.guestId = guestId;
            this.firsNames = firsNames;
            this.lastName = lastName;
            this.quantity = quantity;
            this.numberPhone = numberPhone;
            this.invitation = invitation;
            this.isComing = isComing;
            this.gift = gift;
        }

        public int GuestId { get => guestId; set => guestId = value; }
        public string FirsNames { get => firsNames; set => firsNames = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public bool? Invitation { get => invitation; set { if (value != null) invitation = value; else invitation = false; } }
        public bool? IsComing { get => isComing; set { if (value != null) isComing = value; else isComing = false; } }
        public int Gift { get => gift; set => gift = value; }
        public string UserNamer { get => userNamer; set => userNamer = value; }
        public int TableNumber { get => tableNumber; set => tableNumber = value; }
    }
}
