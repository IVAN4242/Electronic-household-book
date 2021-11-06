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
        public string name;

        public Model1 db = new Model1();

        public Search()
        {
            InitializeComponent();
        }

        public Search(int x, string name)
        {
            InitializeComponent();

            this.x = x;
            this.name = name;

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

            comboBox_searh.DataSource = db.LPHSet.ToList();
            comboBox_searh.DisplayMember = "personal_account";

        }

        private void error_massage()
        {
            MessageBox.Show(
            $"Введен неверный номер ЛПХ", "Сообщение",
            MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void check()
        {
            foreach (LPHSet lph in db.LPHSet)
            {
                int personal_account = 0;

                if (!int.TryParse(comboBox_searh.Text, out personal_account))
                {
                    error_massage();
                }
                else
                {
                    if (lph.personal_account == personal_account)
                    {
                        LPH newForm = new LPH(this.x, personal_account, this.name);
                        newForm.Show();
                        this.Close();
                    }
                    else
                    {
                        error_massage();
                    }
                }

                
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            check();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            check();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            check();
        }
    }
}
