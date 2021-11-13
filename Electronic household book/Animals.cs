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
        public int lph_id;
        public string name;
        AnimalsSet animals;
        public Model1 db = new Model1();

        public Animals()
        {
            InitializeComponent();
        }

        public Animals(int x, int animal, int lph_id, string name)
        {
            InitializeComponent();

            this.x = x;
            this.animal = animal;
            this.lph_id = lph_id;
            this.name = name;

            this.animals = db.AnimalsSet.Single(i => i.Id == animal);

            if (x == 0 || x == 2 || x == 3)
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

                textBox_cattle.Text = this.animals.cattle.ToString();
                //if(textBox_cattle.Text == "-1")
                //{
                //    textBox_cattle.Text = null;
                //}
                textBox_pigs.Text = this.animals.pigs.ToString();
                textBox_sheep.Text = this.animals.sheep.ToString();
                textBox_goats.Text = this.animals.goats.ToString();
                textBox_rabbits.Text = this.animals.rabbits.ToString();
                textBox_horse.Text = this.animals.horses.ToString();
                textBox_bird.Text = this.animals.birds.ToString();
            }
        }
        private void exit()
        {
            LPH newForm = new LPH(this.x, this.lph_id, this.name);
            newForm.Show();
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            if (this.x != 0)
            {
                DialogResult result = MessageBox.Show(
                $"Вы уверены что хотите выйти? Все несохраненные данные будут утеряны!", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    exit();
                }
            }
            else
            {
                exit();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Сохранить тзменения?", "Сообщение",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                int[] animal = new int[7];

                if (int.TryParse(textBox_cattle.Text, out animal[0]) && int.TryParse(textBox_pigs.Text, out animal[1]) && int.TryParse(textBox_sheep.Text, out animal[2]) 
                    && int.TryParse(textBox_goats.Text, out animal[3]) && int.TryParse(textBox_rabbits.Text, out animal[4]) && int.TryParse(textBox_horse.Text, out animal[5]) 
                    && int.TryParse(textBox_bird.Text, out animal[6]))
                {
                    this.animals.cattle = animal[0];
                    this.animals.pigs = animal[1];
                    this.animals.sheep = animal[2];
                    this.animals.goats = animal[3];
                    this.animals.rabbits = animal[4];
                    this.animals.horses = animal[5];
                    this.animals.birds = animal[6];

                    db.SaveChanges();
                    exit();
                }
                else
                {
                    MessageBox.Show(
                    $"Одно из полей заполнено некорректно!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                }
            }
        }
    }
}
