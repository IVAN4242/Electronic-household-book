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
    public partial class Technic : Form
    {

        public int x;

        public Technic()
        {
            InitializeComponent();
        }

        public Technic(int x)
        {
            InitializeComponent();

            this.x = x;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
