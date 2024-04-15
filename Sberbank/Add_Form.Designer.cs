namespace Sberbank
{
    partial class Add_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Info_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.button_SOHRANIT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.textBox_Passport = new System.Windows.Forms.TextBox();
            this.textBox_sum_count = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Info_button);
            this.panel1.Controls.Add(this.Clear_button);
            this.panel1.Location = new System.Drawing.Point(199, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 108);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отдел No1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Создание записи:";
            // 
            // Info_button
            // 
            this.Info_button.Image = ((System.Drawing.Image)(resources.GetObject("Info_button.Image")));
            this.Info_button.Location = new System.Drawing.Point(359, 24);
            this.Info_button.Name = "Info_button";
            this.Info_button.Size = new System.Drawing.Size(60, 60);
            this.Info_button.TabIndex = 1;
            this.Info_button.UseVisualStyleBackColor = true;
            // 
            // Clear_button
            // 
            this.Clear_button.Image = ((System.Drawing.Image)(resources.GetObject("Clear_button.Image")));
            this.Clear_button.Location = new System.Drawing.Point(443, 24);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(60, 60);
            this.Clear_button.TabIndex = 0;
            this.Clear_button.UseVisualStyleBackColor = true;
            // 
            // button_SOHRANIT
            // 
            this.button_SOHRANIT.Location = new System.Drawing.Point(368, 348);
            this.button_SOHRANIT.Name = "button_SOHRANIT";
            this.button_SOHRANIT.Size = new System.Drawing.Size(185, 62);
            this.button_SOHRANIT.TabIndex = 2;
            this.button_SOHRANIT.Text = "Сохранить";
            this.button_SOHRANIT.UseVisualStyleBackColor = true;
            this.button_SOHRANIT.Click += new System.EventHandler(this.button_SOHRANIT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер аккаунта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Категория вклада: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Информация о паспорте: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Текущая сумма вклада:";
            // 
            // textBox_account
            // 
            this.textBox_account.Location = new System.Drawing.Point(355, 167);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(211, 26);
            this.textBox_account.TabIndex = 8;
            // 
            // textBox_category
            // 
            this.textBox_category.Location = new System.Drawing.Point(355, 208);
            this.textBox_category.Name = "textBox_category";
            this.textBox_category.Size = new System.Drawing.Size(211, 26);
            this.textBox_category.TabIndex = 9;
            // 
            // textBox_Passport
            // 
            this.textBox_Passport.Location = new System.Drawing.Point(355, 246);
            this.textBox_Passport.Name = "textBox_Passport";
            this.textBox_Passport.Size = new System.Drawing.Size(211, 26);
            this.textBox_Passport.TabIndex = 10;
            // 
            // textBox_sum_count
            // 
            this.textBox_sum_count.Location = new System.Drawing.Point(355, 284);
            this.textBox_sum_count.Name = "textBox_sum_count";
            this.textBox_sum_count.Size = new System.Drawing.Size(211, 26);
            this.textBox_sum_count.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_sum_count);
            this.Controls.Add(this.textBox_Passport);
            this.Controls.Add(this.textBox_category);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_SOHRANIT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Info_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button button_SOHRANIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_account;
        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.TextBox textBox_Passport;
        private System.Windows.Forms.TextBox textBox_sum_count;
    }
}