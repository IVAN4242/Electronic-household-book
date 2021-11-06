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

        public Model1 db = new Model1();

        public Member()
        {
            InitializeComponent();
        }

        public Member(int x, int member_id)
        {
            InitializeComponent();

            this.x = x;
            this.member_id = member_id;

            MembersSet member = db.MembersSet.Single(i => i.Id == member_id);

            if(x == 0 || x == 2)
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

                textBox_kinship.Text = member.kinship;

            }
        }

        public Member(int x) : this(x, 1) 
        {
            textBox_fio_member.Clear();
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
    }
}
