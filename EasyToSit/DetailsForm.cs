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
    public partial class DetailsForm : Form
    {
        public DetailsForm(int x, int y)
        {
            InitializeComponent();

            this.Location = new Point(x, y + 39);
        }

    }
}
