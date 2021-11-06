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
        public string name;
        public int member_id;
        public int lph_id;
        public int land_id;
        public int animals_id;

        public Model1 db = new Model1();

        public LPH()
        {
            InitializeComponent();
        }

        public LPH(int x, int number, string name)
        {
            this.x = x;
            this.name = name;
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
                this.lph_id = lph.personal_account;
                this.land_id = lph.Lands_Id;
                this.animals_id = lph.Animals_Id;

                textBox_addres.Text = lph.addres;

                MembersSet member = db.MembersSet.Single(i => i.LPH_Id == number && i.senior == true);

                string fio_senior = member.surname + " " + member.name + " " + member.patronymic;

                textBox_fio_senor.Text = fio_senior;

                listBox_members.DataSource = db.MembersSet.Where(i => i.LPH_Id == number).ToList();
                listBox_members.DisplayMember = "name";
                listBox_members.ValueMember = "Id";

                maskedTextBox_create.Text = lph.date_creatoin.ToString();
                maskedTextBox_delete.Text = lph.date_deletion.ToString();

                textBox_author.Text = name;
            }
        }

        public LPH(int x, string name) : this(x, 0, name) 
        {
            int last = db.LPHSet.Count() + 1; // поменять на LAST после заполнения таблицы
            textBox_personal_account.Text = last.ToString();
        }

        private void listBox_members_DoubleClick(object sender, EventArgs e)
        {
            Member newForm = new Member(this.x, this.member_id);
            newForm.Show();
        }

        private void button_lands_Click(object sender, EventArgs e)
        {
            //MembersSet land = db.MembersSet.Single(i => i.Id == this.land_id);
            //this.land_id = land.Id;

            Lands newForm = new Lands(this.x, this.land_id);
            newForm.Show();
        }

        private void button_animals_Click(object sender, EventArgs e)
        {
            //AnimalsSet animals = db.AnimalsSet.Single(i => i.Id == this.lph_id);
            //this.land_id = land.Id;

            Animals newForm = new Animals(this.x, this.animals_id);
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

        private void listBox_members_Format(object sender, ListControlConvertEventArgs e)
        {
            string name = ((MembersSet)e.ListItem).name;
            string surname = ((MembersSet)e.ListItem).surname;
            string patronymic = ((MembersSet)e.ListItem).patronymic;

            e.Value = surname + " " + name + " " + patronymic;
        }

        private void listBox_members_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_members.SelectedIndex + 1;
            MembersSet member_id = db.MembersSet.Single(i => i.Id == index);
            this.member_id = member_id.Id;
        }
    }
}
