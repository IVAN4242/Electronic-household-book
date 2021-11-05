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

            int[] cpicok = { 1, 2, 3, 4, 5 };

            comboBox_searh.DataSource = cpicok;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Create_user newForm = new Create_user();
            newForm.Show();
            this.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_user_Load(object sender, EventArgs e)
        {

        }
    }
}
