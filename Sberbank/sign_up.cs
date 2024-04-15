using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Sberbank
{
    public partial class sign_up : Form
    {
        Database database = new Database();
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            passField2.PasswordChar = '*';
            pictureBox3.Visible = false;
            loginField2.MaxLength = 50;
            passField2.MaxLength = 50;
        }

            private void pictureBox3_Click(object sender, EventArgs e)
            {
                passField2.UseSystemPasswordChar = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }

        private void button2_Click(object sender, EventArgs e)
        {
            passField2.Text = "";
            loginField2.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                passField2.UseSystemPasswordChar = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var login = loginField2.Text;
            var password = passField2.Text;
            if (CheckUser())
            {
                return;
            }
            string querystring = $"insert into register( login_user, password_user, is_admin) values('{login}', '{password}', 0)";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                login frm_login = new login();
                this.Hide();
                frm_login.ShowDialog();

            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            database.closeConnection();


        }
        private bool CheckUser()
        {

            var LogUser = loginField2.Text;
            var PassUser = passField2.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{LogUser}' and password_user = '{PassUser}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
