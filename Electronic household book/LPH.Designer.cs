
namespace Electronic_household_book
{
    partial class LPH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.label_personal_account = new System.Windows.Forms.Label();
            this.label_addres = new System.Windows.Forms.Label();
            this.textBox_addres = new System.Windows.Forms.TextBox();
            this.textBox_personal_account = new System.Windows.Forms.TextBox();
            this.textBox_fio_senor = new System.Windows.Forms.TextBox();
            this.label_fio_senor = new System.Windows.Forms.Label();
            this.label_members = new System.Windows.Forms.Label();
            this.listBox_members = new System.Windows.Forms.ListBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label_author = new System.Windows.Forms.Label();
            this.label_delete = new System.Windows.Forms.Label();
            this.label_create = new System.Windows.Forms.Label();
            this.maskedTextBox_delete = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_create = new System.Windows.Forms.MaskedTextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_lands = new System.Windows.Forms.Button();
            this.button_animals = new System.Windows.Forms.Button();
            this.button_technic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(240, 29);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(405, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Личное подсобное хозяйство";
            // 
            // label_personal_account
            // 
            this.label_personal_account.AutoSize = true;
            this.label_personal_account.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_personal_account.Location = new System.Drawing.Point(44, 104);
            this.label_personal_account.Name = "label_personal_account";
            this.label_personal_account.Size = new System.Drawing.Size(94, 20);
            this.label_personal_account.TabIndex = 10;
            this.label_personal_account.Text = "Лицевой счёт";
            // 
            // label_addres
            // 
            this.label_addres.AutoSize = true;
            this.label_addres.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_addres.Location = new System.Drawing.Point(44, 130);
            this.label_addres.Name = "label_addres";
            this.label_addres.Size = new System.Drawing.Size(79, 20);
            this.label_addres.TabIndex = 11;
            this.label_addres.Text = "Адрес ЛПХ";
            // 
            // textBox_addres
            // 
            this.textBox_addres.Location = new System.Drawing.Point(159, 130);
            this.textBox_addres.Name = "textBox_addres";
            this.textBox_addres.Size = new System.Drawing.Size(259, 20);
            this.textBox_addres.TabIndex = 12;
            // 
            // textBox_personal_account
            // 
            this.textBox_personal_account.Location = new System.Drawing.Point(159, 104);
            this.textBox_personal_account.Name = "textBox_personal_account";
            this.textBox_personal_account.Size = new System.Drawing.Size(259, 20);
            this.textBox_personal_account.TabIndex = 13;
            // 
            // textBox_fio_senor
            // 
            this.textBox_fio_senor.Location = new System.Drawing.Point(159, 156);
            this.textBox_fio_senor.Name = "textBox_fio_senor";
            this.textBox_fio_senor.Size = new System.Drawing.Size(259, 20);
            this.textBox_fio_senor.TabIndex = 15;
            // 
            // label_fio_senor
            // 
            this.label_fio_senor.AutoSize = true;
            this.label_fio_senor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fio_senor.Location = new System.Drawing.Point(44, 156);
            this.label_fio_senor.Name = "label_fio_senor";
            this.label_fio_senor.Size = new System.Drawing.Size(109, 20);
            this.label_fio_senor.TabIndex = 14;
            this.label_fio_senor.Text = "ФИО главы ЛПХ";
            // 
            // label_members
            // 
            this.label_members.AutoSize = true;
            this.label_members.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_members.Location = new System.Drawing.Point(44, 186);
            this.label_members.Name = "label_members";
            this.label_members.Size = new System.Drawing.Size(81, 20);
            this.label_members.TabIndex = 16;
            this.label_members.Text = "Члены ЛПХ";
            // 
            // listBox_members
            // 
            this.listBox_members.FormattingEnabled = true;
            this.listBox_members.Location = new System.Drawing.Point(159, 186);
            this.listBox_members.Name = "listBox_members";
            this.listBox_members.Size = new System.Drawing.Size(259, 95);
            this.listBox_members.TabIndex = 17;
            this.listBox_members.DoubleClick += new System.EventHandler(this.listBox_members_DoubleClick);
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(588, 158);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(245, 20);
            this.textBox_author.TabIndex = 23;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_author.Location = new System.Drawing.Point(439, 156);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(129, 20);
            this.label_author.TabIndex = 22;
            this.label_author.Text = "ФИО автора записи";
            // 
            // label_delete
            // 
            this.label_delete.AutoSize = true;
            this.label_delete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_delete.Location = new System.Drawing.Point(439, 130);
            this.label_delete.Name = "label_delete";
            this.label_delete.Size = new System.Drawing.Size(143, 20);
            this.label_delete.TabIndex = 19;
            this.label_delete.Text = "Дата ликвидации ЛПХ";
            // 
            // label_create
            // 
            this.label_create.AutoSize = true;
            this.label_create.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_create.Location = new System.Drawing.Point(439, 104);
            this.label_create.Name = "label_create";
            this.label_create.Size = new System.Drawing.Size(128, 20);
            this.label_create.TabIndex = 18;
            this.label_create.Text = "Дата создания ЛПХ";
            // 
            // maskedTextBox_delete
            // 
            this.maskedTextBox_delete.Location = new System.Drawing.Point(588, 130);
            this.maskedTextBox_delete.Mask = "00/00/0000";
            this.maskedTextBox_delete.Name = "maskedTextBox_delete";
            this.maskedTextBox_delete.Size = new System.Drawing.Size(245, 20);
            this.maskedTextBox_delete.TabIndex = 24;
            this.maskedTextBox_delete.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_create
            // 
            this.maskedTextBox_create.Location = new System.Drawing.Point(588, 104);
            this.maskedTextBox_create.Mask = "00/00/0000";
            this.maskedTextBox_create.Name = "maskedTextBox_create";
            this.maskedTextBox_create.Size = new System.Drawing.Size(245, 20);
            this.maskedTextBox_create.TabIndex = 25;
            this.maskedTextBox_create.ValidatingType = typeof(System.DateTime);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(671, 328);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 27;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(752, 328);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 26;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_lands
            // 
            this.button_lands.Location = new System.Drawing.Point(443, 193);
            this.button_lands.Name = "button_lands";
            this.button_lands.Size = new System.Drawing.Size(139, 44);
            this.button_lands.TabIndex = 28;
            this.button_lands.Text = "Информация о земельном участке";
            this.button_lands.UseVisualStyleBackColor = true;
            this.button_lands.Click += new System.EventHandler(this.button_lands_Click);
            // 
            // button_animals
            // 
            this.button_animals.Location = new System.Drawing.Point(588, 192);
            this.button_animals.Name = "button_animals";
            this.button_animals.Size = new System.Drawing.Size(245, 45);
            this.button_animals.TabIndex = 29;
            this.button_animals.Text = "Информация о сельскохозяйственных животных";
            this.button_animals.UseVisualStyleBackColor = true;
            this.button_animals.Click += new System.EventHandler(this.button_animals_Click);
            // 
            // button_technic
            // 
            this.button_technic.Location = new System.Drawing.Point(443, 243);
            this.button_technic.Name = "button_technic";
            this.button_technic.Size = new System.Drawing.Size(390, 38);
            this.button_technic.TabIndex = 30;
            this.button_technic.Text = "Информация о сельскохозяйственной технике";
            this.button_technic.UseVisualStyleBackColor = true;
            this.button_technic.Click += new System.EventHandler(this.button_technic_Click);
            // 
            // LPH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 362);
            this.Controls.Add(this.button_technic);
            this.Controls.Add(this.button_animals);
            this.Controls.Add(this.button_lands);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.maskedTextBox_create);
            this.Controls.Add(this.maskedTextBox_delete);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_delete);
            this.Controls.Add(this.label_create);
            this.Controls.Add(this.listBox_members);
            this.Controls.Add(this.label_members);
            this.Controls.Add(this.textBox_fio_senor);
            this.Controls.Add(this.label_fio_senor);
            this.Controls.Add(this.textBox_personal_account);
            this.Controls.Add(this.textBox_addres);
            this.Controls.Add(this.label_addres);
            this.Controls.Add(this.label_personal_account);
            this.Controls.Add(this.label_title);
            this.Name = "LPH";
            this.Text = "LPH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_personal_account;
        private System.Windows.Forms.Label label_addres;
        private System.Windows.Forms.TextBox textBox_addres;
        private System.Windows.Forms.TextBox textBox_personal_account;
        private System.Windows.Forms.TextBox textBox_fio_senor;
        private System.Windows.Forms.Label label_fio_senor;
        private System.Windows.Forms.Label label_members;
        private System.Windows.Forms.ListBox listBox_members;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_delete;
        private System.Windows.Forms.Label label_create;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_delete;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_create;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_lands;
        private System.Windows.Forms.Button button_animals;
        private System.Windows.Forms.Button button_technic;
    }
}