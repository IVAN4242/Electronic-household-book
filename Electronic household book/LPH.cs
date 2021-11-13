using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;

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

        //public MembersSet new_member;
        public AnimalsSet new_amimal;
        public LandsSet new_land;
        public TechnicSet new_technic;

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


            if (x == 0 || x == 2 || x == 3)
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
                    label_hint.Visible = false;
                }

                textBox_personal_account.Text = personal_account;

                this.lph = db.LPHSet.Single(i => i.personal_account == number);
                this.lph_id = lph.Id;
                this.land_id = lph.Lands_Id;
                this.animals_id = lph.Animals_Id;

                textBox_addres.Text = lph.addres;

                this.member = db.MembersSet.Single(i => i.LPH_Id == lph.Id && i.senior == true);

                string fio_senior = member.surname + " " + member.name + " " + member.patronymic;

                textBox_fio_senor.Text = fio_senior;

                
                //listBox_members.DataSource = db.MembersSet.Where(i => i.LPH_Id == 1008).ToList();

                foreach (MembersSet m in db.MembersSet)
                {
                    if (m.LPH_Id == lph.Id)
                    {
                        listBox_members.Items.Add(m);
                    }
                }

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

                if(maskedTextBox_create.Text == "01.01.1900")
                {
                    maskedTextBox_create.Text = null;
                }

                if(textBox_addres.Text == "Введите адресс")
                {
                    textBox_addres.Text = null;
                }
            }
            else if (x == 1)
            {
                LPHSet lastlph = db.LPHSet.ToList().Last();
                int last = lastlph.personal_account + 1; //db.LPHSet.Count() + 1; // поменять на LAST после заполнения таблицы
                textBox_personal_account.Text = last.ToString();

                this.new_amimal = new AnimalsSet();
                this.new_amimal.cattle = null;
                this.new_amimal.pigs = null;
                this.new_amimal.sheep = null;
                this.new_amimal.goats = null;
                this.new_amimal.rabbits = null;
                this.new_amimal.horses = null;
                this.new_amimal.birds = null;

                this.new_land = new LandsSet();
                this.new_land.number = "00:00:000000:000";
                this.new_land.square = 0;
                this.new_land.owner = true;
                this.new_land.fio_owner = "Пусто";
                this.new_land.fio_user = "Пусто";
                this.new_land.price = 0;

                db.AnimalsSet.Add(this.new_amimal);
                db.LandsSet.Add(this.new_land);

                db.SaveChanges();


                this.new_amimal = db.AnimalsSet.ToList().Last();
                this.new_land = db.LandsSet.ToList().Last();

                this.lph = new LPHSet();
                this.lph.personal_account = last;
                this.lph.addres = "Введите адресс";
                this.lph.date_creatoin = DateTime.Parse("01.01.1900");
                this.lph.date_deletion = null;
                this.lph.Animals_Id = this.new_amimal.Id;
                this.lph.Lands_Id = this.new_land.Id;

                db.LPHSet.Add(this.lph);

                db.SaveChanges();

                this.lph = db.LPHSet.ToList().Last();

                this.member = new MembersSet();
                this.member.name = "ЛПХ";
                this.member.surname = "Глава";
                this.member.patronymic = null;
                this.member.date_birth = DateTime.Parse("01.01.1900");
                this.member.kinship = null;
                this.member.gender = true;
                this.member.senior = true;
                this.member.LPH_Id = lph.Id;

                this.new_technic = new TechnicSet();
                this.new_technic.tractors = null;
                this.new_technic.combine = null;
                this.new_technic.plow = null;
                this.new_technic.haymaker = null;
                this.new_technic.LPH_Id = lph.Id;

                db.MembersSet.Add(this.member);
                db.TechnicSet.Add(this.new_technic);

                db.SaveChanges();

                this.member_id = this.member.Id;
                this.land_id = this.new_land.Id;
                this.animals_id = this.new_amimal.Id;
                this.lph_id = this.lph.Id;

                foreach (MembersSet m in db.MembersSet)
                {
                    if (m.LPH_Id == lph.Id)
                    {
                        listBox_members.Items.Add(m);
                    }
                }

                listBox_members.DisplayMember = "name";
                listBox_members.ValueMember = "Id";

                this.x = 3;
            }
        }

        public LPH(int x, string name) : this(x, 0, name) 
        {
            //int last = db.LPHSet.Count() + 1; // поменять на LAST после заполнения таблицы
            //textBox_personal_account.Text = last.ToString();

            //LPHSet last = db.LPHSet.Last(); // поменять на LAST после заполнения таблицы
            //textBox_personal_account.Text = last.personal_account.ToString();
        }

        private void listBox_members_DoubleClick(object sender, EventArgs e)
        {
            Member newForm = new Member(this.x, this.member_id, this.lph_id, this.lph.personal_account, this.name);
            newForm.Show();
            this.Close();
        }

        private void button_lands_Click(object sender, EventArgs e)
        {

            Lands newForm = new Lands(this.x, this.land_id, this.lph.personal_account, this.name);
            newForm.Show();
            this.Close();
        }

        private void button_animals_Click(object sender, EventArgs e)
        {

            Animals newForm = new Animals(this.x, this.animals_id, this.lph.personal_account, this.name);
            newForm.Show();
            this.Close();
        }

        private void button_technic_Click(object sender, EventArgs e)
        {
            Technic newForm = new Technic(this.x, this.lph_id, this.lph.personal_account, this.name);
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
                    if(this.x == 3)
                    {
                        db.LPHSet.Remove(this.lph);
                        db.LandsSet.Remove(db.LandsSet.Single(i => i.Id == this.lph.Lands_Id));
                        db.AnimalsSet.Remove(db.AnimalsSet.Single(i => i.Id == this.lph.Animals_Id));
                        db.TechnicSet.Remove(db.TechnicSet.Single(i => i.LPH_Id == this.lph.Id));

                        db.MembersSet.RemoveRange(db.MembersSet.Where(i => i.LPH_Id == this.lph.Id));

                        db.SaveChanges();
                    }
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
            //int index = listBox_members.SelectedIndex + 1;

            //int index2 = index;

            List<MembersSet> selected_member = db.MembersSet.Where(i => i.LPH_Id == this.lph_id).ToList();

            MembersSet member = selected_member[0];

            if (listBox_members.SelectedIndex != -1)
            {
                member = selected_member[listBox_members.SelectedIndex];

                
            }
            else
            {
                member = selected_member[selected_member.Count -1];
            }

            this.member_id = member.Id;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Сохранить изменения?", "Сообщение",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if(this.x != 1)
            {
                if (result == DialogResult.Yes)
                {
                    DateTime creatoin;
                    DateTime deletion;

                    string f = textBox_fio_senor.Text.Trim();

                    string[] fio = f.Split(' ');

                    if (DateTime.TryParse(maskedTextBox_create.Text, out creatoin) && ((DateTime.TryParse(maskedTextBox_delete.Text, out deletion) && deletion > creatoin) || checkBox_delete.Checked == false)
                        && fio.Length < 4 && fio.Length > 1)
                    {
                        this.lph.addres = textBox_addres.Text;
                        this.lph.date_creatoin = creatoin;

                        this.member.name = fio[1];
                        this.member.surname = fio[0];
                        if (fio.Length == 3)
                        {
                            this.member.patronymic = fio[2];
                        }
                        else
                        {
                            this.member.patronymic = null;
                        }

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
            else
            {

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
            Member newForm = new Member(this.x, this.lph_id, this.lph.personal_account, this.name);
            newForm.Show();
            this.Close();
        }

        private void LPH_Load(object sender, EventArgs e)
        {
            
        }
    }
}
