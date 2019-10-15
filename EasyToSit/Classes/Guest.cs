using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyToSit
{
    class Guest
    {
        private int rowNum;
        private string firsNames;
        private string lastName;
        private int quantity;
        private string numberPhone;
        private bool invitation;
        private bool isComing;
        private int gift;

        public int RowNum { get => rowNum; set => rowNum = value; }
        public string FirsNames { get => firsNames; set => firsNames = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public bool Invitation { get => invitation; set => invitation = value; }
        public bool IsComing { get => isComing; set => isComing = value; }
        public int Gift { get => gift; set => gift = value; }
    }
}
