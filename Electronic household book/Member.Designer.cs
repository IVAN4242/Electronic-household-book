
namespace Electronic_household_book
{
    partial class Member
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
            this.label_fio_member = new System.Windows.Forms.Label();
            this.textBox_fio_member = new System.Windows.Forms.TextBox();
            this.label_date_birth = new System.Windows.Forms.Label();
            this.groupBox_gender = new System.Windows.Forms.GroupBox();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.textBox_kinship = new System.Windows.Forms.TextBox();
            this.label_kinship = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.maskedTextBox_date_birth = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_fio_member
            // 
            this.label_fio_member.AutoSize = true;
            this.label_fio_member.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fio_member.Location = new System.Drawing.Point(12, 25);
            this.label_fio_member.Name = "label_fio_member";
            this.label_fio_member.Size = new System.Drawing.Size(113, 20);
            this.label_fio_member.TabIndex = 9;
            this.label_fio_member.Text = "ФИО члена ЛПХ:";
            // 
            // textBox_fio_member
            // 
            this.textBox_fio_member.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_fio_member.HideSelection = false;
            this.textBox_fio_member.Location = new System.Drawing.Point(266, 27);
            this.textBox_fio_member.Name = "textBox_fio_member";
            this.textBox_fio_member.Size = new System.Drawing.Size(220, 20);
            this.textBox_fio_member.TabIndex = 10;
            // 
            // label_date_birth
            // 
            this.label_date_birth.AutoSize = true;
            this.label_date_birth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date_birth.Location = new System.Drawing.Point(12, 131);
            this.label_date_birth.Name = "label_date_birth";
            this.label_date_birth.Size = new System.Drawing.Size(178, 20);
            this.label_date_birth.TabIndex = 11;
            this.label_date_birth.Text = "Дата рождения члена ЛПХ:";
            // 
            // groupBox_gender
            // 
            this.groupBox_gender.Controls.Add(this.radioButton_male);
            this.groupBox_gender.Controls.Add(this.radioButton_female);
            this.groupBox_gender.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox_gender.Location = new System.Drawing.Point(16, 53);
            this.groupBox_gender.Name = "groupBox_gender";
            this.groupBox_gender.Size = new System.Drawing.Size(470, 63);
            this.groupBox_gender.TabIndex = 13;
            this.groupBox_gender.TabStop = false;
            this.groupBox_gender.Text = "Пол члена ЛПХ";
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.radioButton_male.Location = new System.Drawing.Point(6, 25);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(58, 24);
            this.radioButton_male.TabIndex = 8;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Муж.";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.radioButton_female.Location = new System.Drawing.Point(70, 25);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(58, 24);
            this.radioButton_female.TabIndex = 9;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Жен.";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // textBox_kinship
            // 
            this.textBox_kinship.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_kinship.HideSelection = false;
            this.textBox_kinship.Location = new System.Drawing.Point(266, 171);
            this.textBox_kinship.Name = "textBox_kinship";
            this.textBox_kinship.Size = new System.Drawing.Size(220, 20);
            this.textBox_kinship.TabIndex = 15;
            // 
            // label_kinship
            // 
            this.label_kinship.AutoSize = true;
            this.label_kinship.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kinship.Location = new System.Drawing.Point(12, 169);
            this.label_kinship.Name = "label_kinship";
            this.label_kinship.Size = new System.Drawing.Size(248, 20);
            this.label_kinship.TabIndex = 14;
            this.label_kinship.Text = "Родственные отношения к главе ЛПХ:";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(411, 218);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 16;
            this.button_close.Text = "Эакрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(330, 218);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 20;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_date_birth
            // 
            this.maskedTextBox_date_birth.Location = new System.Drawing.Point(266, 131);
            this.maskedTextBox_date_birth.Mask = "00/00/0000";
            this.maskedTextBox_date_birth.Name = "maskedTextBox_date_birth";
            this.maskedTextBox_date_birth.Size = new System.Drawing.Size(220, 20);
            this.maskedTextBox_date_birth.TabIndex = 21;
            this.maskedTextBox_date_birth.ValidatingType = typeof(System.DateTime);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 256);
            this.Controls.Add(this.maskedTextBox_date_birth);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.textBox_kinship);
            this.Controls.Add(this.label_kinship);
            this.Controls.Add(this.groupBox_gender);
            this.Controls.Add(this.label_date_birth);
            this.Controls.Add(this.textBox_fio_member);
            this.Controls.Add(this.label_fio_member);
            this.Name = "Member";
            this.Text = "Член ЛПХ";
            this.groupBox_gender.ResumeLayout(false);
            this.groupBox_gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_fio_member;
        private System.Windows.Forms.TextBox textBox_fio_member;
        private System.Windows.Forms.Label label_date_birth;
        private System.Windows.Forms.GroupBox groupBox_gender;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.TextBox textBox_kinship;
        private System.Windows.Forms.Label label_kinship;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_date_birth;
    }
}