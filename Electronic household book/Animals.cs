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
    public partial class Animals : Form
    {

        public int x;
        public int animal;
        public Model1 db = new Model1();

        public Animals()
        {
            InitializeComponent();
        }

        public Animals(int x, int animal)
        {
            InitializeComponent();

            this.x = x;
            this.animal = animal;

            AnimalsSet animals = db.AnimalsSet.Single(i => i.Id == animal);

            if (x == 0 || x == 2)
            {
                if (x == 0)
                {
                    textBox_horse.Enabled = false;
                    textBox_bird.Enabled = false;
                    textBox_cattle.Enabled = false;
                    textBox_goats.Enabled = false;
                    textBox_pigs.Enabled = false;
                    textBox_rabbits.Enabled = false;
                    textBox_sheep.Enabled = false;

                    button_save.Visible = false;
                }

                textBox_cattle.Text = animals.cattle.ToString();
                textBox_pigs.Text = animals.pigs.ToString();
                textBox_sheep.Text = animals.sheep.ToString();
                textBox_goats.Text = animals.goats.ToString();
                textBox_rabbits.Text = animals.rabbits.ToString();
                textBox_horse.Text = animals.horses.ToString();
                textBox_bird.Text = animals.birds.ToString();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
