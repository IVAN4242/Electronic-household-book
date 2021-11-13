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
    public partial class Create_user : Form
    {
        public int id;
        public int x = 0;

        public LPHSet lph;
        public UsersSet new_user = new UsersSet();

        public Model1 db = new Model1();

        public Create_user()
        {
            InitializeComponent();
        }

        public Create_user(int id)
        {
            InitializeComponent();

            this.id = id;
            this.x = 1;

            this.new_user = db.UsersSet.Single(i => i.Id == id);

            textBox_fio_user.Text = new_user.surname + " " + new_user.name + " " + new_user.patronymic;

            if(new_user.role == 1)
            {
                radioButton_1.Checked = true;
            }
            else if (new_user.role == 2)
            {
                radioButton_2.Checked = true;
            }
            else
            {
                radioButton_3.Checked = true;
            }

            textBox_login.Text = new_user.login;
            textBox_password.Text = new_user.password;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           $"Сохранить изменения?", "Сообщение",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                string f = textBox_fio_user.Text.Trim();

                string[] fio = f.Split(' ');

                if(fio.Length < 4 && fio.Length > 1)
                {
                    this.new_user.name = fio[1];
                    this.new_user.surname = fio[0];

                    if (fio.Length == 3)
                    {
                        this.new_user.patronymic = fio[2];
                    }
                    else
                    {
                        this.new_user.patronymic = null;
                    };

                    if (radioButton_1.Checked)
                    {
                        this.new_user.role = 1;
                    }
                    else if (radioButton_2.Checked)
                    {
                        this.new_user.role = 2;
                    }
                    else
                    {
                        this.new_user.role = 3;
                    }

                    this.new_user.login = textBox_login.Text;
                    this.new_user.password = textBox_password.Text;

                    if(x == 0)
                    {
                        db.UsersSet.Add(new_user);
                    }

                    db.SaveChanges();

                    this.Close();
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
