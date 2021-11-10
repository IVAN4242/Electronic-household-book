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

        public LPHSet lph;
        public MembersSet member;

        public MembersSet new_member;
        public AnimalsSet new_amimal;

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
                    checkBox_delete.Enabled = false;
                }

                textBox_personal_account.Text = personal_account;

                this.lph = db.LPHSet.Single(i => i.personal_account == number);
                this.lph_id = lph.personal_account;
                this.land_id = lph.Lands_Id;
                this.animals_id = lph.Animals_Id;

                textBox_addres.Text = lph.addres;

                this.member = db.MembersSet.Single(i => i.LPH_Id == lph.Id && i.senior == true);

                string fio_senior = member.surname + " " + member.name + " " + member.patronymic;

                textBox_fio_senor.Text = fio_senior;

                listBox_members.DataSource = db.MembersSet.Where(i => i.LPH_Id == this.lph_id).ToList();
                listBox_members.DisplayMember = "name";
                listBox_members.ValueMember = "Id";

                maskedTextBox_create.Text = this.lph.date_creatoin.ToString();
                maskedTextBox_delete.Text = this.lph.date_deletion.ToString();

                if(maskedTextBox_delete.MaskCompleted)
                {
                    checkBox_delete.Checked = true;
                }
                else
                {
                    checkBox_delete.Checked = false;
                    maskedTextBox_delete.Enabled = false;
                }

                textBox_author.Text = name;
            }
            else
            {

            }
        }

        public LPH(int x, string name) : this(x, 0, name) 
        {
            int last = db.LPHSet.Count() + 1; // поменять на LAST после заполнения таблицы
            textBox_personal_account.Text = last.ToString();
        }

        private void listBox_members_DoubleClick(object sender, EventArgs e)
        {
            Member newForm = new Member(this.x, this.member_id, this.lph_id, this.name);
            newForm.Show();
            this.Close();
        }

        private void button_lands_Click(object sender, EventArgs e)
        {

            Lands newForm = new Lands(this.x, this.land_id, this.lph_id, this.name);
            newForm.Show();
            this.Close();
        }

        private void button_animals_Click(object sender, EventArgs e)
        {

            Animals newForm = new Animals(this.x, this.animals_id, this.lph_id, this.name);
            newForm.Show();
            this.Close();
        }

        private void button_technic_Click(object sender, EventArgs e)
        {
            Technic newForm = new Technic(this.x, this.lph_id, this.lph_id, this.name);
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
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
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

            int index2 = index;

            while (db.MembersSet.Count(i => i.Id <= index && i.LPH_Id == this.lph_id) != index2)
            {
                index++;
            }

            MembersSet member_id = db.MembersSet.Single(i => i.Id == index);
            this.member_id = member_id.Id;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Сохранить изменения?", "Сообщение",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                DateTime creatoin;
                DateTime deletion;

                string f = textBox_fio_senor.Text.Trim();

                string[] fio = f.Split(' ');

                if (DateTime.TryParse(maskedTextBox_create.Text, out creatoin) && ((DateTime.TryParse(maskedTextBox_delete.Text, out deletion) && deletion > creatoin) || checkBox_delete.Checked == false)  && fio.Length < 4 && fio.Length > 1)
                {
                    this.lph.addres = textBox_addres.Text;
                    this.lph.date_creatoin = creatoin;

                    this.member.name = fio[1];
                    this.member.surname = fio[0];
                    if(fio.Length == 3)
                    {
                        this.member.patronymic = fio[2];
                    }
                    else
                    {
                        this.member.patronymic = null;
                    };

                    if (maskedTextBox_delete.MaskCompleted)
                    {
                        this.lph.date_deletion = deletion;
                    }
                    else
                    {
                        this.lph.date_deletion = null;
                    }

                    try
                    {
                        db.SaveChanges();

                        this.Close();
                    }
                    catch
                    {
                    MessageBox.Show(
                    $"Одно из полей заполнено некорректно!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    
                }
                else
                {
                    MessageBox.Show(
                    $"Одно из полей заполнено некорректно!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void checkBox_delete_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_delete.Checked == true)
            {
                maskedTextBox_delete.Enabled = true;
            }
            else
            {
                maskedTextBox_delete.Text = null;
                maskedTextBox_delete.Enabled = false;
            }
        }

        private void button_add_members_Click(object sender, EventArgs e)
        {
            Member newForm = new Member(this.x, this.lph_id, this.name);
            newForm.Show();
        }

        private void LPH_Load(object sender, EventArgs e)
        {
            
        }
    }
}
