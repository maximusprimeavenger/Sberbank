namespace Sberbank
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Sohr = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_New_Zap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_date_transaction = new System.Windows.Forms.TextBox();
            this.textBox_current_deposit_amount = new System.Windows.Forms.TextBox();
            this.textBox_passport = new System.Windows.Forms.TextBox();
            this.textBox_category_contribution = new System.Windows.Forms.TextBox();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_date_transaction = new System.Windows.Forms.Label();
            this.label_current_deposit_amount = new System.Windows.Forms.Label();
            this.label_passport = new System.Windows.Forms.Label();
            this.label_category_contribution = new System.Windows.Forms.Label();
            this.label_account_number = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbStatusUser = new System.Windows.Forms.ToolStripTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отдел 1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 729);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1246, 696);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отдел 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Search);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.CircleButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 100);
            this.panel1.TabIndex = 1;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(934, 32);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(198, 26);
            this.textBox_Search.TabIndex = 3;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(887, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Управление записями:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_Sohr);
            this.panel3.Controls.Add(this.button_Change);
            this.panel3.Controls.Add(this.button_Delete);
            this.panel3.Controls.Add(this.button_New_Zap);
            this.panel3.Location = new System.Drawing.Point(871, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 262);
            this.panel3.TabIndex = 6;
            // 
            // button_Sohr
            // 
            this.button_Sohr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sohr.Location = new System.Drawing.Point(48, 200);
            this.button_Sohr.Name = "button_Sohr";
            this.button_Sohr.Size = new System.Drawing.Size(149, 38);
            this.button_Sohr.TabIndex = 3;
            this.button_Sohr.Text = "Сохранить";
            this.button_Sohr.UseVisualStyleBackColor = true;
            this.button_Sohr.Click += new System.EventHandler(this.button_Sohr_Click);
            // 
            // button_Change
            // 
            this.button_Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Change.Location = new System.Drawing.Point(48, 143);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(149, 38);
            this.button_Change.TabIndex = 2;
            this.button_Change.Text = "Изменить";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.Location = new System.Drawing.Point(48, 82);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(149, 38);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_New_Zap
            // 
            this.button_New_Zap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_New_Zap.Location = new System.Drawing.Point(48, 27);
            this.button_New_Zap.Name = "button_New_Zap";
            this.button_New_Zap.Size = new System.Drawing.Size(149, 38);
            this.button_New_Zap.TabIndex = 0;
            this.button_New_Zap.Text = "Новая запись";
            this.button_New_Zap.UseVisualStyleBackColor = true;
            this.button_New_Zap.Click += new System.EventHandler(this.button_New_Zap_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBox_date_transaction);
            this.panel2.Controls.Add(this.textBox_current_deposit_amount);
            this.panel2.Controls.Add(this.textBox_passport);
            this.panel2.Controls.Add(this.textBox_category_contribution);
            this.panel2.Controls.Add(this.textBox_Account);
            this.panel2.Controls.Add(this.textBox_ID);
            this.panel2.Controls.Add(this.label_date_transaction);
            this.panel2.Controls.Add(this.label_current_deposit_amount);
            this.panel2.Controls.Add(this.label_passport);
            this.panel2.Controls.Add(this.label_category_contribution);
            this.panel2.Controls.Add(this.label_account_number);
            this.panel2.Controls.Add(this.label_ID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(62, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 285);
            this.panel2.TabIndex = 5;
            // 
            // textBox_date_transaction
            // 
            this.textBox_date_transaction.Location = new System.Drawing.Point(409, 229);
            this.textBox_date_transaction.Name = "textBox_date_transaction";
            this.textBox_date_transaction.Size = new System.Drawing.Size(216, 26);
            this.textBox_date_transaction.TabIndex = 12;
            // 
            // textBox_current_deposit_amount
            // 
            this.textBox_current_deposit_amount.Location = new System.Drawing.Point(409, 190);
            this.textBox_current_deposit_amount.Name = "textBox_current_deposit_amount";
            this.textBox_current_deposit_amount.Size = new System.Drawing.Size(216, 26);
            this.textBox_current_deposit_amount.TabIndex = 11;
            // 
            // textBox_passport
            // 
            this.textBox_passport.Location = new System.Drawing.Point(409, 150);
            this.textBox_passport.Name = "textBox_passport";
            this.textBox_passport.Size = new System.Drawing.Size(216, 26);
            this.textBox_passport.TabIndex = 10;
            // 
            // textBox_category_contribution
            // 
            this.textBox_category_contribution.Location = new System.Drawing.Point(409, 105);
            this.textBox_category_contribution.Name = "textBox_category_contribution";
            this.textBox_category_contribution.Size = new System.Drawing.Size(216, 26);
            this.textBox_category_contribution.TabIndex = 9;
            // 
            // textBox_Account
            // 
            this.textBox_Account.Location = new System.Drawing.Point(409, 62);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.Size = new System.Drawing.Size(216, 26);
            this.textBox_Account.TabIndex = 8;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(409, 17);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(216, 26);
            this.textBox_ID.TabIndex = 7;
            // 
            // label_date_transaction
            // 
            this.label_date_transaction.AutoSize = true;
            this.label_date_transaction.Location = new System.Drawing.Point(120, 235);
            this.label_date_transaction.Name = "label_date_transaction";
            this.label_date_transaction.Size = new System.Drawing.Size(231, 20);
            this.label_date_transaction.TabIndex = 6;
            this.label_date_transaction.Text = "Дата последней транзакции:";
            // 
            // label_current_deposit_amount
            // 
            this.label_current_deposit_amount.AutoSize = true;
            this.label_current_deposit_amount.Location = new System.Drawing.Point(160, 196);
            this.label_current_deposit_amount.Name = "label_current_deposit_amount";
            this.label_current_deposit_amount.Size = new System.Drawing.Size(191, 20);
            this.label_current_deposit_amount.TabIndex = 5;
            this.label_current_deposit_amount.Text = "Текущая сумма вклада: ";
            // 
            // label_passport
            // 
            this.label_passport.AutoSize = true;
            this.label_passport.Location = new System.Drawing.Point(146, 156);
            this.label_passport.Name = "label_passport";
            this.label_passport.Size = new System.Drawing.Size(205, 20);
            this.label_passport.TabIndex = 4;
            this.label_passport.Text = "Информация о паспорте: ";
            // 
            // label_category_contribution
            // 
            this.label_category_contribution.AutoSize = true;
            this.label_category_contribution.Location = new System.Drawing.Point(198, 111);
            this.label_category_contribution.Name = "label_category_contribution";
            this.label_category_contribution.Size = new System.Drawing.Size(153, 20);
            this.label_category_contribution.TabIndex = 3;
            this.label_category_contribution.Text = "Категория вклада:";
            // 
            // label_account_number
            // 
            this.label_account_number.AutoSize = true;
            this.label_account_number.Location = new System.Drawing.Point(212, 68);
            this.label_account_number.Name = "label_account_number";
            this.label_account_number.Size = new System.Drawing.Size(139, 20);
            this.label_account_number.TabIndex = 2;
            this.label_account_number.Text = "Номер аккаунта: ";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(321, 23);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(30, 20);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "ID:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(73, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Запись: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 300);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.информацияToolStripMenuItem.Text = "Информация";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.информацияToolStripMenuItem_Click);
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.управлениеToolStripMenuItem.Text = "Управление";
            this.управлениеToolStripMenuItem.Click += new System.EventHandler(this.управлениеToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem,
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbStatusUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1254, 36);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbStatusUser
            // 
            this.tbStatusUser.Name = "tbStatusUser";
            this.tbStatusUser.Size = new System.Drawing.Size(100, 36);
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(861, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(67, 64);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // CircleButton
            // 
            this.CircleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CircleButton.Image = ((System.Drawing.Image)(resources.GetObject("CircleButton.Image")));
            this.CircleButton.Location = new System.Drawing.Point(770, 13);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(68, 64);
            this.CircleButton.TabIndex = 2;
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.Location = new System.Drawing.Point(680, 13);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(62, 64);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 795);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_passport;
        private System.Windows.Forms.Label label_category_contribution;
        private System.Windows.Forms.Label label_account_number;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_date_transaction;
        private System.Windows.Forms.Label label_current_deposit_amount;
        private System.Windows.Forms.Button button_Sohr;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_New_Zap;
        private System.Windows.Forms.TextBox textBox_date_transaction;
        private System.Windows.Forms.TextBox textBox_current_deposit_amount;
        private System.Windows.Forms.TextBox textBox_passport;
        private System.Windows.Forms.TextBox textBox_category_contribution;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tbStatusUser;
    }
}