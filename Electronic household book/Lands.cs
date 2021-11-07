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
        public int lph_id;
        public string name;
        public LandsSet lands;
        public Model1 db = new Model1();

        public Lands()
        {
            InitializeComponent();
        }

        public Lands(int x, int land, int lph_id, string name)
        {
            InitializeComponent();

            this.x = x;
            this.land = land;
            this.lph_id = lph_id;
            this.name = name;

            lands = db.LandsSet.Single(i => i.Id == land);

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
                float sqare;
                float price;

                if (maskedTextBox_number.MaskFull && float.TryParse(textBox_square.Text, out sqare) && float.TryParse(textBox_price.Text, out price))
                {
                    this.lands.number = maskedTextBox_number.Text;
                    this.lands.square = sqare;
                    this.lands.price = price;

                    if (radioButton_owner.Checked)
                    {
                        this.lands.owner = true;
                    }
                    else
                    {
                        this.lands.owner = false;
                    }

                    this.lands.fio_owner = textBox_fio_owner.Text;
                    this.lands.fio_user = textBox_rent.Text;

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
