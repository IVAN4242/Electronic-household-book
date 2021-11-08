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
        public int lph_id;
        public string name;
        public TechnicSet technic;
        public Model1 db = new Model1();

        public Technic()
        {
            InitializeComponent();
        }

        public Technic(int x, int tec, int lph_id, string name)
        {
            InitializeComponent();

            this.x = x;
            this.tec = tec;
            this.lph_id = lph_id;
            this.name = name;

            this.technic = db.TechnicSet.Single(i => i.LPH_Id == tec);

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

                textBox_tractors.Text = technic.tractors.ToString();
                textBox_combines.Text = technic.combine.ToString();
                textBox_plows.Text = technic.plow.ToString();
                textBox_mower.Text = technic.haymaker.ToString();
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
                int[] technic = new int[4];

                if (int.TryParse(textBox_tractors.Text, out technic[0]) && int.TryParse(textBox_combines.Text, out technic[1])
                    && int.TryParse(textBox_plows.Text, out technic[2]) && int.TryParse(textBox_mower.Text, out technic[3]))
                {
                    this.technic.tractors = technic[0];
                    this.technic.combine = technic[1];
                    this.technic.plow = technic[2];
                    this.technic.haymaker = technic[3];

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
