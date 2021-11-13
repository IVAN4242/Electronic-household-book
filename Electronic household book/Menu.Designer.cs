
namespace Electronic_household_book
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.button_view = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.label_mode = new System.Windows.Forms.Label();
            this.button_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(12, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(533, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Электронная похозяйственная книга";
            // 
            // button_view
            // 
            this.button_view.Location = new System.Drawing.Point(173, 89);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(200, 50);
            this.button_view.TabIndex = 1;
            this.button_view.Text = "Просмотреть ЛПХ\r\n";
            this.button_view.UseVisualStyleBackColor = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // button_change
            // 
            this.button_change.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_change.Location = new System.Drawing.Point(173, 201);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(200, 50);
            this.button_change.TabIndex = 3;
            this.button_change.Text = "Изменить ЛПХ";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(173, 257);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(200, 50);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Удалить ЛПХ";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(173, 313);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(200, 50);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_create
            // 
            this.button_create.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create.Location = new System.Drawing.Point(173, 145);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(200, 50);
            this.button_create.TabIndex = 2;
            this.button_create.Text = "Создать ЛПХ";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mode.Location = new System.Drawing.Point(204, 57);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(145, 20);
            this.label_mode.TabIndex = 6;
            this.label_mode.Text = "Режим просмотра";
            this.label_mode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_admin
            // 
            this.button_admin.Location = new System.Drawing.Point(173, 369);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(200, 29);
            this.button_admin.TabIndex = 7;
            this.button_admin.Text = "Настройки администратора";
            this.button_admin.UseVisualStyleBackColor = true;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 410);
            this.ControlBox = false;
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.label_title);
            this.Name = "Menu";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.Button button_admin;
    }
}

