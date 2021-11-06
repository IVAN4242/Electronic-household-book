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
        public int tec;
        public Model1 db = new Model1();

        public Technic()
        {
            InitializeComponent();
        }

        public Technic(int x, int tec)
        {
            InitializeComponent();

            this.x = x;
            this.tec = tec;

            TechnicSet Technic = db.TechnicSet.Single(i => i.LPH_Id == tec);

            if (x == 0 || x == 2)
            {
                if (x == 0)
                {
                    textBox_tractors.Enabled = false;
                    textBox_combines.Enabled = false;
                    textBox_plows.Enabled = false;
                    textBox_mower.Enabled = false;

                    button_save.Visible = false;
                }

                textBox_tractors.Text = Technic.tractors.ToString();
                textBox_combines.Text = Technic.combine.ToString();
                textBox_plows.Text = Technic.plow.ToString();
                textBox_mower.Text = Technic.haymaker.ToString();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
