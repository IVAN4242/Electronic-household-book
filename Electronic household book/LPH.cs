using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_household_book
{
    public partial class LPH : Form
    {
        public int x;

        public LPH()
        {
            InitializeComponent();
        }

        public LPH(int x, string text)
        {
            this.x = x;
            string fio = text;
            InitializeComponent();

            Model1 db = new Model1();
        }

        public LPH(int x) : this(x, null) { }

        private void listBox_members_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button_lands_Click(object sender, EventArgs e)
        {
            Lands newForm = new Lands(this.x);
            newForm.Show();
        }

        private void button_animals_Click(object sender, EventArgs e)
        {
            Animals newForm = new Animals(this.x);
            newForm.Show();
        }

        private void button_technic_Click(object sender, EventArgs e)
        {
            Technic newForm = new Technic(this.x);
            newForm.Show();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
