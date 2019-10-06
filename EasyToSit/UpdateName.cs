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
    public partial class UpdateName : Form
    {
        private string name;
        private string price;

        public string Name1 { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }

        public UpdateName()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                Name1= txtName.Text;
                if (txtCostOfSapak.Text.Length > 0)
                {
                   Price=txtCostOfSapak.Text;
                    this.Close();
                }
                else
                    new LoginPage().messageBox("לא הוכנס מחיר", "שגיאה");

            }
            else
                new LoginPage().messageBox("נראה לי ששכחת לרשום את השם החדש....", "אופס");
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtCostOfSapak.Clear();
            txtName.Clear();
        }
    }
}
