
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
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(41, 19);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(405, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Личное подсобное хозяйство";
            // 
            // label_personal_account
            // 
            this.label_personal_account.AutoSize = true;
            this.label_personal_account.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_personal_account.Location = new System.Drawing.Point(44, 95);
            this.label_personal_account.Name = "label_personal_account";
            this.label_personal_account.Size = new System.Drawing.Size(94, 20);
            this.label_personal_account.TabIndex = 10;
            this.label_personal_account.Text = "Лицевой счёт";
            // 
            // LPH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 426);
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
    }
}