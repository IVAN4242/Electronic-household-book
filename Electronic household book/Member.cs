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
        public string fio;

        public Member()
        {
            InitializeComponent();
        }

        public Member(int x, string fio)
        {
            InitializeComponent();

            this.x = x;
            this.fio = fio;

            textBox_fio_member.Text = fio;

            if(x == 0)
            {
                textBox_fio_member.Enabled = false;
                maskedTextBox_date_birth.Enabled = false;
                textBox_kinship.Enabled = false;

                radioButton_female.Enabled = false;
                radioButton_male.Enabled = false;

                button_save.Visible = false;
            }
            else
            {
                textBox_fio_member.Enabled = true;
                maskedTextBox_date_birth.Enabled = true;
                textBox_kinship.Enabled = true;

                radioButton_female.Enabled = true;
                radioButton_male.Enabled = true;

                button_save.Visible = true;
            }
        }

        public Member(int x) : this(x, null) { }

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
