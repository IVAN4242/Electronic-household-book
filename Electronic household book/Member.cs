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
    public partial class Member : Form
    {

        public int x = 0;
        public int member_id;
        public int lph_id;
        public bool change;
        public string name;
        public MembersSet member;

        public Model1 db = new Model1();

        public Member()
        {
            InitializeComponent();
        }

        public Member(int x, int member_id, int lph_id, string name)
        {
            InitializeComponent();

            this.x = x;
            this.member_id = member_id;
            this.lph_id = lph_id;
            this.name = name;

            this.change = true;

            this.member = db.MembersSet.Single(i => i.Id == member_id);

            if(x == 0 || x == 2 || x == 3)
            {
                if(x == 0)
                {
                    textBox_fio_member.Enabled = false;
                    maskedTextBox_date_birth.Enabled = false;
                    textBox_kinship.Enabled = false;

                    radioButton_female.Enabled = false;
                    radioButton_male.Enabled = false;

                    button_save.Visible = false;
                }

                textBox_fio_member.Text = member.surname + " " + member.name + " " + member.patronymic;

                if (member.gender)
                {
                    radioButton_male.Checked = true;
                }
                else
                {
                    radioButton_female.Checked = true;
                }

                maskedTextBox_date_birth.Text = member.date_birth.ToString();

                if(maskedTextBox_date_birth.Text == "01.01.1900")
                {
                    maskedTextBox_date_birth.Text = null;
                }

                textBox_kinship.Text = member.kinship;

            }
        }

        public Member(int x, int lph_id, string name) : this(x, 1, lph_id, name) 
        {
            textBox_fio_member.Clear();
            maskedTextBox_date_birth.Clear();
            textBox_kinship.Clear();
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;

            this.change = false;
            this.member = new MembersSet();
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
                DateTime creatoin;

                string f = textBox_fio_member.Text.Trim();

                string[] fio = f.Split(' ');

                if (DateTime.TryParse(maskedTextBox_date_birth.Text, out creatoin) && maskedTextBox_date_birth.MaskFull)
                {
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

                    if (radioButton_male.Checked)
                    {
                        member.gender = true;
                    }
                    else
                    {
                        member.gender = false;
                    }

                    this.member.date_birth = creatoin;

                    this.member.kinship = textBox_kinship.Text;

                    

                    if (!this.change)
                    {
                        this.member.LPH_Id = this.lph_id;
                        db.MembersSet.Add(member);
                    }

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
