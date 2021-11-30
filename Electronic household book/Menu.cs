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
    public partial class Menu : Form
    {
        public int rule = 0;
        public string name;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(int rule, string name)
        {
            InitializeComponent();

            this.rule = rule;
            this.name = name;

            if(rule == 1)
            {
                button_change.Enabled = false;
                button_create.Enabled = false;
                button_delete.Enabled = false;
                button_admin.Visible = false;

                label_mode.Text = "Режим просмотра";
            }
            else if(rule == 2)
            {
                button_change.Enabled = true;
                button_create.Enabled = true;
                button_delete.Enabled = true;
                button_admin.Visible = false;

                label_mode.Text = "Обычный режим";
            }
            else if (rule == 3)
            {
                button_change.Enabled = true;
                button_create.Enabled = true;
                button_delete.Enabled = true;
                button_admin.Visible = true;

                label_mode.Text = "Администратор";
            }
        }

        private void button_view_Click(object sender, EventArgs e)
        {

            Search newForm = new Search(0, this.name);
            newForm.Show();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            LPH newForm = new LPH(1, this.name);
            newForm.Show();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            Search newForm = new Search(2, this.name);
            newForm.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Search newForm = new Search(4, this.name);
            newForm.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            Admin newForm = new Admin(this.name);
            newForm.Show();
            this.Close();
        }

        private void button_user_Click(object sender, EventArgs e)
        {
            Аuthorization newForm = new Аuthorization();
            newForm.Show();
            this.Close();
        }
    }
}
