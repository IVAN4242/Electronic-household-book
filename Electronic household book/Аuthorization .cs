﻿using System;
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
        public int rule = 0;

        public Аuthorization()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            //Electronic_household_book_modelContainer db = new Electronic_household_book_modelContainer();

            //foreach (Users user in db.UsersSet)
            //{
            //    if (user.login == textBox_login.Text || user.password == textBox_password.Text)
            //    {
            //        Menu newForm = new Menu(this.rule);
            //        newForm.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show(
            //        $"Вы ввели неверный логин или пароль", "Сообщение",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //    }
            //}

            //if(textBox_login.Text == "123" && textBox_password.Text == "123")
            //{
            //    this.rule = 1;
            //}
            //else if(textBox_login.Text == "321" && textBox_password.Text == "321")
            //{
            //    this.rule = 2;
            //}
            //else if(textBox_login.Text == "admin" && textBox_password.Text == "admin")
            //{
            //    this.rule = 3;
            //}

            //if(this.rule != 0)
            //{
            //    Menu newForm = new Menu(this.rule);
            //    newForm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show(
            //    $"Вы ввели неверный логин или пароль", "Сообщение",
            //    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //}
        }
    }
}
