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
    public partial class Search : Form
    {

        public int x = 0;

        public Search()
        {
            InitializeComponent();
        }

        public Search(int x)
        {
            InitializeComponent();

            this.x = x;

            if (x == 3)
            {
                button_delete.Visible = true;
                button_search.Visible = false;
                button_create.Visible = false;

            }
            else if(x == 1)
            {
                button_delete.Visible = false;
                button_search.Visible = false;
                button_create.Visible = true;
            }
            else
            {
                button_delete.Visible = false;
                button_search.Visible = true;
                button_create.Visible = false;
            }

            comboBox_searh.Text = null;
            button_delete.Enabled = false;
            button_create.Enabled = false;

            int[] cpicok = {1, 2, 3, 4, 5};

            comboBox_searh.DataSource = cpicok;

        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void label_search_Click(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            LPH newForm = new LPH(this.x, comboBox_searh.Text);
            newForm.Show();
            this.Close();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            LPH newForm = new LPH(this.x, comboBox_searh.Text);
            newForm.Show();
            this.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Вы уверены что хотите удалить ЛПХ с номером лицевого счета {comboBox_searh.Text}?", "Сообщение",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_searh.Text != null)
            {
                button_delete.Enabled = true;
                button_create.Enabled = true;
            }
            else
            {
                button_delete.Enabled = false;
                button_create.Enabled = false;

            }
        }
    }
}
