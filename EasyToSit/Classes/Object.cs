﻿using System;
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
    public partial class Object : Form
    {
        private string id;
        private int diner;
        private int numberTable;
        private bool netunim;
        private PictureBox picture;
        private Point point;

        public int Diner { get => diner; set => diner = value; }
        public int NumberTable { get => numberTable; set => numberTable = value; }
        public bool Netunim { get => netunim; set => netunim = value; }
        public PictureBox Picture { get => picture; set => picture = value; }
        public string Id { get => id; set => id = value; }
        public Point Point { get => point; set => point = value; }

        public Object()
        {
            InitializeComponent();
        }

        #region הגדרות פנל ליצירת שולחן
        private void txtCountGuests_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumOfTable.Focus();
                txtNumOfTable.SelectAll();
            }
        }

        private void txtNumOfTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Netunim = false;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCountGuests.Text.Length > 0 && txtNumOfTable.Text.Length > 0)
            {
                Diner = IsNumbber(txtCountGuests);
                numberTable = IsNumbber(txtNumOfTable);
                Netunim = true;
                this.Close();
            }
            else
                new LoginPage().messageBox("לא הוזן פרטים כראוי","Error");

        }
        #endregion

        public int IsNumbber(TextBox t)
        {
            try
            {
                if (t.Text.Length > 0)
                {
                    errorProvider.SetError(t, "");
                    return Int32.Parse(t.Text);
                }
                else
                {
                    errorProvider.SetError(t, "לא הוזן ערך");
                    Netunim = false;
                }

                return 0;
            }
            catch
            {
                errorProvider.SetError(t, "לא הוכנס ערך מספרי");
                return 0;
            }
        }

       

    }
}
