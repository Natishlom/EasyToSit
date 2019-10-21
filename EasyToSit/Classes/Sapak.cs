using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyToSit.Classes
{
    class Sapak
    {
        private int id;
        private string name;
        private int price;
        

        public Sapak()
        {
            
        }

        public Sapak(int id ,string name, int price)
        {
            this.id = id;
            this.Name = name;
            this.Price = price;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }
}
