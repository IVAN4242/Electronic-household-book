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
    public partial class Search_user : Form
    {
        public int x;
        public int id;
        public bool error = true;

        public Model1 db = new Model1();

        public Search_user()
        {
            InitializeComponent();
        }

        public Search_user(int x)
        {
            InitializeComponent();

            this.x = x;

            if(x == 1)
            {
                button_delete.Visible = false;
                button_search.Visible = true;
            }
            else
            {
                button_delete.Visible = true;
                button_search.Visible = false;
            }

            //int[] cpicok = { 1, 2, 3, 4, 5 };

            //comboBox_searh.DataSource = cpicok;
            comboBox_searh.DataSource = db.UsersSet.ToList();
            comboBox_searh.DisplayMember = "name";
            comboBox_searh.ValueMember = "Id";
        }

        private void error_massage()
        {
            MessageBox.Show(
            $"Введен неверный номер ЛПХ", "Сообщение",
            MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void vixod(UsersSet user)
        {
            this.id = user.Id;
            Create_user newForm = new Create_user(this.id);
            newForm.Show();
            this.Close();
        }

        private void rem(bool del, UsersSet user)
        {
            this.error = false;

            if (del)
            {
                db.UsersSet.Remove(user);
                this.Close();
            }
            else
            {
                vixod(user);
            }
        }

        private void check(bool del)
        {
            string f = comboBox_searh.Text.Trim();

            string[] fio = f.Split(' ');

            if (fio.Length < 4 && fio.Length > 1)
            {
                foreach (UsersSet user in db.UsersSet)
                {

                    if (user.patronymic != null)
                    {
                        if(fio.Length == 3)
                        {
                            if (fio[0] == user.surname && fio[1] == user.name && fio[2] == user.patronymic)
                            {
                                rem(del, user);
                            }
                        }
                        
                    }
                    else
                    {
                        if (fio[0] == user.surname && fio[1] == user.name)
                        {
                            rem(del, user);
                        }
                    }

                }

                if (del)
                {
                    db.SaveChanges();

                    MessageBox.Show(
                    $"Пользователь успешно удален", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }

                if (this.error)
                {
                    error_massage();
                }
            }
            else
            {
                error_massage();
            }

            
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            check(false);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Вы уверены что хотите удалить данного пользователя", "Сообщение",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                check(true);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_searh_Format(object sender, ListControlConvertEventArgs e)
        {
            string name = ((UsersSet)e.ListItem).name;
            string surname = ((UsersSet)e.ListItem).surname;
            string patronymic = ((UsersSet)e.ListItem).patronymic;

            e.Value = surname + " " + name + " " + patronymic;
        }
    }
}
