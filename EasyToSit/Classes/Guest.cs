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



        public int GuestId { get => guestId; set => guestId = value; }
        public string FirsNames { get => firsNames; set => firsNames = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public bool? Invitation { get => invitation; set { if (value != null) invitation = value; else invitation = false; } }
        public bool? IsComing { get => isComing; set { if (value != null) isComing = value; else isComing = false; } }
        public int Gift { get => gift; set => gift = value; }
    }
}
