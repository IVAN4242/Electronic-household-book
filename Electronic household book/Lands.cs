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
    public partial class Lands : Form
    {

        public int x;
        public int land;
        public Model1 db = new Model1();

        public Lands()
        {
            InitializeComponent();
        }

        public Lands(int x, int land)
        {
            InitializeComponent();

            this.x = x;
            this.land = land;

            LandsSet lands = db.LandsSet.Single(i => i.Id == land);

            if (x == 0 || x == 2)
            {
                if (x == 0)
                {
                    maskedTextBox_number.Enabled = false;
                    textBox_square.Enabled = false;
                    textBox_price.Enabled = false;
                    textBox_fio_owner.Enabled = false;
                    textBox_rent.Enabled = false;

                    radioButton_owner.Enabled = false;
                    radioButton_rent.Enabled = false;

                    button_save.Visible = false;
                }

                maskedTextBox_number.Text = lands.number;
                textBox_square.Text = lands.square.ToString();
                textBox_price.Text = lands.price.ToString();
                textBox_fio_owner.Text = lands.fio_owner;
                textBox_rent.Text = lands.fio_user;

                if (lands.owner)
                {
                    radioButton_owner.Checked = true;
                }
                else
                {
                    radioButton_rent.Checked = true;
                }

            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
