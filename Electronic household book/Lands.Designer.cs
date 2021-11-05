
namespace Electronic_household_book
{
    partial class Lands
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_fio_senor = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_square = new System.Windows.Forms.TextBox();
            this.label_square = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.maskedTextBox_number = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_owner = new System.Windows.Forms.GroupBox();
            this.radioButton_owner = new System.Windows.Forms.RadioButton();
            this.radioButton_rent = new System.Windows.Forms.RadioButton();
            this.textBox_rent = new System.Windows.Forms.TextBox();
            this.label_fio_rent = new System.Windows.Forms.Label();
            this.textBox_fio_owner = new System.Windows.Forms.TextBox();
            this.label_fio_owner = new System.Windows.Forms.Label();
            this.groupBox_owner.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(271, 238);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 31;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(352, 238);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 30;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_fio_senor
            // 
            this.textBox_fio_senor.Location = new System.Drawing.Point(238, 74);
            this.textBox_fio_senor.Name = "textBox_fio_senor";
            this.textBox_fio_senor.Size = new System.Drawing.Size(183, 20);
            this.textBox_fio_senor.TabIndex = 37;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price.Location = new System.Drawing.Point(24, 74);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(162, 20);
            this.label_price.TabIndex = 36;
            this.label_price.Text = "Стоимасть участка (руб.)";
            // 
            // textBox_square
            // 
            this.textBox_square.Location = new System.Drawing.Point(238, 48);
            this.textBox_square.Name = "textBox_square";
            this.textBox_square.Size = new System.Drawing.Size(183, 20);
            this.textBox_square.TabIndex = 34;
            // 
            // label_square
            // 
            this.label_square.AutoSize = true;
            this.label_square.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_square.Location = new System.Drawing.Point(24, 48);
            this.label_square.Name = "label_square";
            this.label_square.Size = new System.Drawing.Size(208, 20);
            this.label_square.TabIndex = 33;
            this.label_square.Text = "Общяя площядь участка (кв. м.)";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number.Location = new System.Drawing.Point(24, 22);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(185, 20);
            this.label_number.TabIndex = 32;
            this.label_number.Text = "Кадастровый номер участка";
            // 
            // maskedTextBox_number
            // 
            this.maskedTextBox_number.Location = new System.Drawing.Point(238, 22);
            this.maskedTextBox_number.Mask = "00:00:000000:000";
            this.maskedTextBox_number.Name = "maskedTextBox_number";
            this.maskedTextBox_number.Size = new System.Drawing.Size(183, 20);
            this.maskedTextBox_number.TabIndex = 38;
            // 
            // groupBox_owner
            // 
            this.groupBox_owner.Controls.Add(this.radioButton_owner);
            this.groupBox_owner.Controls.Add(this.radioButton_rent);
            this.groupBox_owner.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox_owner.Location = new System.Drawing.Point(28, 100);
            this.groupBox_owner.Name = "groupBox_owner";
            this.groupBox_owner.Size = new System.Drawing.Size(393, 63);
            this.groupBox_owner.TabIndex = 39;
            this.groupBox_owner.TabStop = false;
            this.groupBox_owner.Text = "Права собственности";
            // 
            // radioButton_owner
            // 
            this.radioButton_owner.AutoSize = true;
            this.radioButton_owner.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.radioButton_owner.Location = new System.Drawing.Point(6, 25);
            this.radioButton_owner.Name = "radioButton_owner";
            this.radioButton_owner.Size = new System.Drawing.Size(131, 24);
            this.radioButton_owner.TabIndex = 8;
            this.radioButton_owner.TabStop = true;
            this.radioButton_owner.Text = "В собственности";
            this.radioButton_owner.UseVisualStyleBackColor = true;
            // 
            // radioButton_rent
            // 
            this.radioButton_rent.AutoSize = true;
            this.radioButton_rent.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.radioButton_rent.Location = new System.Drawing.Point(143, 25);
            this.radioButton_rent.Name = "radioButton_rent";
            this.radioButton_rent.Size = new System.Drawing.Size(90, 24);
            this.radioButton_rent.TabIndex = 9;
            this.radioButton_rent.TabStop = true;
            this.radioButton_rent.Text = "В аренде ";
            this.radioButton_rent.UseVisualStyleBackColor = true;
            // 
            // textBox_rent
            // 
            this.textBox_rent.Location = new System.Drawing.Point(244, 203);
            this.textBox_rent.Name = "textBox_rent";
            this.textBox_rent.Size = new System.Drawing.Size(183, 20);
            this.textBox_rent.TabIndex = 43;
            // 
            // label_fio_rent
            // 
            this.label_fio_rent.AutoSize = true;
            this.label_fio_rent.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fio_rent.Location = new System.Drawing.Point(30, 203);
            this.label_fio_rent.Name = "label_fio_rent";
            this.label_fio_rent.Size = new System.Drawing.Size(178, 20);
            this.label_fio_rent.TabIndex = 42;
            this.label_fio_rent.Text = "ФИО пользователя участка";
            // 
            // textBox_fio_owner
            // 
            this.textBox_fio_owner.Location = new System.Drawing.Point(244, 177);
            this.textBox_fio_owner.Name = "textBox_fio_owner";
            this.textBox_fio_owner.Size = new System.Drawing.Size(183, 20);
            this.textBox_fio_owner.TabIndex = 41;
            // 
            // label_fio_owner
            // 
            this.label_fio_owner.AutoSize = true;
            this.label_fio_owner.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fio_owner.Location = new System.Drawing.Point(30, 177);
            this.label_fio_owner.Name = "label_fio_owner";
            this.label_fio_owner.Size = new System.Drawing.Size(160, 20);
            this.label_fio_owner.TabIndex = 40;
            this.label_fio_owner.Text = "ФИО владельца участка";
            // 
            // Lands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 282);
            this.Controls.Add(this.textBox_rent);
            this.Controls.Add(this.label_fio_rent);
            this.Controls.Add(this.textBox_fio_owner);
            this.Controls.Add(this.label_fio_owner);
            this.Controls.Add(this.groupBox_owner);
            this.Controls.Add(this.maskedTextBox_number);
            this.Controls.Add(this.textBox_fio_senor);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.textBox_square);
            this.Controls.Add(this.label_square);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_close);
            this.Name = "Lands";
            this.Text = "Lands";
            this.groupBox_owner.ResumeLayout(false);
            this.groupBox_owner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_fio_senor;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_square;
        private System.Windows.Forms.Label label_square;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_number;
        private System.Windows.Forms.GroupBox groupBox_owner;
        private System.Windows.Forms.RadioButton radioButton_owner;
        private System.Windows.Forms.RadioButton radioButton_rent;
        private System.Windows.Forms.TextBox textBox_rent;
        private System.Windows.Forms.Label label_fio_rent;
        private System.Windows.Forms.TextBox textBox_fio_owner;
        private System.Windows.Forms.Label label_fio_owner;
    }
}