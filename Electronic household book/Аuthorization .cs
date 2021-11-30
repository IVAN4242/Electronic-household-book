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
    public partial class Аuthorization : Form
    {
        public int rule = 3;
        public string name;
        bool error = true;

        public Аuthorization()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();

            foreach (UsersSet user in db.UsersSet)
            {
                if (user.login == textBox_login.Text && user.password == textBox_password.Text)
                {
                    this.error = false;
                    this.rule = user.role;
                    this.name = user.surname + " " + user.name + " " + user.patronymic;

                    Menu newForm = new Menu(this.rule, this.name);
                    newForm.Show();
                    this.Hide();
                    break;
                }
                
            }
            if (this.error)
            {
                MessageBox.Show(
                $"Вы ввели неверный логин или пароль", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
