using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sberbank
{
    public partial class login : Form

    {
        Database database = new Database();
        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
        }
        private void login_Load(object sender, EventArgs e)
        {
            passField.PasswordChar = '*';
            pictureBox3.Visible = false;
            loginField.MaxLength = 50;
            passField.MaxLength = 50;

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.Red;
        }

        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.White;
        }
        Point lastpoint;
        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = loginField.Text;
            var passUser = passField.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user = '{passUser}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                var User = new CheckUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));


                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1(User);
                this.Hide();
                form1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта нет!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm_sign = new sign_up();
            frm_sign.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passField.Text = "";
            loginField.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

