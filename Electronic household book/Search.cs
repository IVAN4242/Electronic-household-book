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
        bool error = true;

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

            if (x == 4)
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
                    break;
                }
                else
                {
                    if (lph.personal_account == personal_account)
                    {
                        this.error = false;

                        if (x == 4)
                        {
                            //db.LPHSet.Remove(db.LPHSet.Single(i => i.personal_account == lph.personal_account));
                            db.LPHSet.Remove(lph);
                            db.LandsSet.Remove(db.LandsSet.Single(i => i.Id == lph.Lands_Id));
                            db.AnimalsSet.Remove(db.AnimalsSet.Single(i => i.Id == lph.Animals_Id));
                            db.TechnicSet.Remove(db.TechnicSet.Single(i => i.LPH_Id == lph.Id));

                            db.MembersSet.RemoveRange(db.MembersSet.Where(i => i.LPH_Id == lph.Id));

                            //db.SaveChanges();

                            //MessageBox.Show(
                            //$"Данные о ЛПХ успешно удалены", "Сообщение",
                            //MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                            //this.Close();

                            break;
                        }
                        else
                        {
                            LPH newForm = new LPH(this.x, personal_account, this.name);
                            newForm.Show();
                            this.Close();

                            break;
                        }
                        
                    }
                }
                
            }
            if(x == 4)
            {
                db.SaveChanges();

                MessageBox.Show(
                $"Данные о ЛПХ успешно удалены", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                this.Close();
            }
            

            if (this.error)
            {
                error_massage();
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
            DialogResult result = MessageBox.Show(
                $"Вы уверены что хотите удалить данное ЛПХ?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                check();
            }
            
        }
    }
}
