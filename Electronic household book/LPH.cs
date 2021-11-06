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

        public Model1 db = new Model1();

        public LPH()
        {
            InitializeComponent();
        }

        public LPH(int x, int number)
        {
            this.x = x;
            string personal_account = number.ToString();

            InitializeComponent();

            textBox_personal_account.Enabled = false;


            if (x == 0 || x == 2)
            {
                if(x == 0)
                {
                    button_save.Visible = false;
                    button_add_members.Visible = false;
                    textBox_addres.Enabled = false;
                    textBox_fio_senor.Enabled = false;
                    maskedTextBox_create.Enabled = false;
                    maskedTextBox_delete.Enabled = false;
                    textBox_author.Enabled = false;
                }

                textBox_personal_account.Text = personal_account;

                LPHSet lph = db.LPHSet.Single(i => i.personal_account == number);

                textBox_addres.Text = lph.addres;

                MembersSet member = db.MembersSet.Single(i => i.LPH_Id == number && i.senior == true);

                string fio_senior = member.surname + " " + member.name + " " + member.patronymic;

                textBox_fio_senor.Text = fio_senior;

                listBox_members.DataSource = db.MembersSet.ToList(); // Выводит именна вообще всех людей 
                listBox_members.DisplayMember = "name";

                maskedTextBox_create.Text = lph.date_creatoin.ToString();
                maskedTextBox_delete.Text = lph.date_deletion.ToString();

                //textBox_author = оставить автора или удалить?
            }
        }

        public LPH(int x) : this(x, 0) 
        {
            int last = db.LPHSet.Count() + 1; // поменять на LAST после заполнения таблицы
            textBox_personal_account.Text = last.ToString();
        }

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
