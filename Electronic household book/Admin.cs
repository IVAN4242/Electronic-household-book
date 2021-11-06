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
    public partial class Admin : Form
    {
        public string name;

        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Create_user newForm = new Create_user();
            newForm.Show();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            Search_user newForm = new Search_user(1);
            newForm.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Search_user newForm = new Search_user(2);
            newForm.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Menu newForm = new Menu(3, this.name);
            newForm.Show();
            this.Close();
        }
    }
}
