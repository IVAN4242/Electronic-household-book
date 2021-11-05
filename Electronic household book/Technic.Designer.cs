
namespace Electronic_household_book
{
    partial class Technic
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
            this.textBox_mower = new System.Windows.Forms.TextBox();
            this.label_mower = new System.Windows.Forms.Label();
            this.textBox_plows = new System.Windows.Forms.TextBox();
            this.label_plows = new System.Windows.Forms.Label();
            this.textBox_tractors = new System.Windows.Forms.TextBox();
            this.textBox_combines = new System.Windows.Forms.TextBox();
            this.label_combines = new System.Windows.Forms.Label();
            this.label_tractors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(44, 116);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 29;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(125, 116);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 28;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_mower
            // 
            this.textBox_mower.Location = new System.Drawing.Point(108, 90);
            this.textBox_mower.Name = "textBox_mower";
            this.textBox_mower.Size = new System.Drawing.Size(92, 20);
            this.textBox_mower.TabIndex = 47;
            // 
            // label_mower
            // 
            this.label_mower.AutoSize = true;
            this.label_mower.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mower.Location = new System.Drawing.Point(12, 88);
            this.label_mower.Name = "label_mower";
            this.label_mower.Size = new System.Drawing.Size(90, 20);
            this.label_mower.TabIndex = 46;
            this.label_mower.Text = "Сенокосилки";
            // 
            // textBox_plows
            // 
            this.textBox_plows.Location = new System.Drawing.Point(108, 61);
            this.textBox_plows.Name = "textBox_plows";
            this.textBox_plows.Size = new System.Drawing.Size(92, 20);
            this.textBox_plows.TabIndex = 45;
            // 
            // label_plows
            // 
            this.label_plows.AutoSize = true;
            this.label_plows.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_plows.Location = new System.Drawing.Point(12, 61);
            this.label_plows.Name = "label_plows";
            this.label_plows.Size = new System.Drawing.Size(45, 20);
            this.label_plows.TabIndex = 44;
            this.label_plows.Text = "Плуги";
            // 
            // textBox_tractors
            // 
            this.textBox_tractors.Location = new System.Drawing.Point(108, 9);
            this.textBox_tractors.Name = "textBox_tractors";
            this.textBox_tractors.Size = new System.Drawing.Size(92, 20);
            this.textBox_tractors.TabIndex = 43;
            // 
            // textBox_combines
            // 
            this.textBox_combines.Location = new System.Drawing.Point(108, 35);
            this.textBox_combines.Name = "textBox_combines";
            this.textBox_combines.Size = new System.Drawing.Size(92, 20);
            this.textBox_combines.TabIndex = 42;
            // 
            // label_combines
            // 
            this.label_combines.AutoSize = true;
            this.label_combines.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_combines.Location = new System.Drawing.Point(12, 35);
            this.label_combines.Name = "label_combines";
            this.label_combines.Size = new System.Drawing.Size(73, 20);
            this.label_combines.TabIndex = 41;
            this.label_combines.Text = "Комбайны";
            // 
            // label_tractors
            // 
            this.label_tractors.AutoSize = true;
            this.label_tractors.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tractors.Location = new System.Drawing.Point(12, 9);
            this.label_tractors.Name = "label_tractors";
            this.label_tractors.Size = new System.Drawing.Size(65, 20);
            this.label_tractors.TabIndex = 40;
            this.label_tractors.Text = "Трактора";
            // 
            // Technic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 156);
            this.Controls.Add(this.textBox_mower);
            this.Controls.Add(this.label_mower);
            this.Controls.Add(this.textBox_plows);
            this.Controls.Add(this.label_plows);
            this.Controls.Add(this.textBox_tractors);
            this.Controls.Add(this.textBox_combines);
            this.Controls.Add(this.label_combines);
            this.Controls.Add(this.label_tractors);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_close);
            this.Name = "Technic";
            this.Text = "Technic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_mower;
        private System.Windows.Forms.Label label_mower;
        private System.Windows.Forms.TextBox textBox_plows;
        private System.Windows.Forms.Label label_plows;
        private System.Windows.Forms.TextBox textBox_tractors;
        private System.Windows.Forms.TextBox textBox_combines;
        private System.Windows.Forms.Label label_combines;
        private System.Windows.Forms.Label label_tractors;
    }
}