
namespace Electronic_household_book
{
    partial class Search
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
            this.label_search = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.comboBox_searh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.Location = new System.Drawing.Point(76, 133);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(118, 20);
            this.label_search.TabIndex = 4;
            this.label_search.Text = "Лицевой счет:";
            this.label_search.Click += new System.EventHandler(this.label_search_Click);
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_title.Location = new System.Drawing.Point(73, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(576, 83);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "Введите номер лицевого счета интересующего вас ЛПХ";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(574, 205);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Эакрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(473, 205);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Найти";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(473, 205);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(473, 205);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 9;
            this.button_create.Text = "Создать ";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // comboBox_searh
            // 
            this.comboBox_searh.FormattingEnabled = true;
            this.comboBox_searh.Location = new System.Drawing.Point(200, 132);
            this.comboBox_searh.Name = "comboBox_searh";
            this.comboBox_searh.Size = new System.Drawing.Size(449, 21);
            this.comboBox_searh.TabIndex = 10;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 246);
            this.Controls.Add(this.comboBox_searh);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_search);
            this.Name = "Search";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.ComboBox comboBox_searh;
    }
}