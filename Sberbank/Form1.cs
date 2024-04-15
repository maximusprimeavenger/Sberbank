using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Sberbank
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        private readonly CheckUser _user;
        Database database = new Database();
        int SelectedRow;


        public Form1(CheckUser user)
        {
            InitializeComponent();
            _user = user;
        }


        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("account_number", "Номер аккаунта");
            dataGridView1.Columns.Add("category_contribution", "Категория вклада");
            dataGridView1.Columns.Add("passport_details", "Информация о паспорте");
            dataGridView1.Columns.Add("current_deposit_amount", "Текущая сумма вклада");
            dataGridView1.Columns.Add("last_transaction_date", "Последняя дата транзакции");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }
        private void Update()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var DeleteQuary = $"delete from project where id = {id}";
                    var command = new SqlCommand(DeleteQuary, database.GetConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var accpunt = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var category = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var passport = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var deposit_amount = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuary = $"update project set account_number = '{accpunt}', category_contribution = '{category}', passport_details = '{passport}', current_deposit_amount = '{deposit_amount}' where id = '{id}'";

                    var command = new SqlCommand(changeQuary, database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }
        private void ClearTextBox()
        {
            textBox_ID.Text = "";
            textBox_passport.Text = "";
            textBox_current_deposit_amount.Text = "";
            textBox_date_transaction.Text = "";
            textBox_category_contribution.Text = "";
            textBox_Account.Text = "";

        }

        private void ReadSingleRow( DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDecimal(4), record.GetDateTime(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $" select * from project";
            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow( dgw, reader );
            }
            reader.Close();
        }



        private void IsAdmin()
        {
            управлениеToolStripMenuItem.Enabled = _user.IsAdmin;
            button_New_Zap.Enabled = _user.IsAdmin;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbStatusUser.Text = $"{_user.Login}: {_user.Status}";
            IsAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[SelectedRow];
                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_Account.Text = row.Cells[1].Value.ToString();
                textBox_category_contribution.Text = row.Cells[2].Value.ToString();
                textBox_passport.Text = row.Cells[3].Value.ToString();
                textBox_current_deposit_amount.Text = row.Cells[4].Value.ToString();
                textBox_date_transaction.Text = row.Cells[5].Value.ToString();
            }
        }


        private void CircleButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearTextBox();
        }

        private void button_New_Zap_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();
        }

        private void Search(DataGridView dqw)
        {
            dqw.Rows.Clear();
            string searchstring = $"select * from project where concat(id, account_number, category_contribution, passport_details, current_deposit_amount, last_transaction_date) like '%" + textBox_Search.Text + "%'";
            SqlCommand com = new SqlCommand(searchstring, database.GetConnection());
            database.openConnection();
            SqlDataReader read = com.ExecuteReader();    

            while(read.Read())
            {
                ReadSingleRow(dqw, read);
            }
            read.Close();
        }

        

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }
        

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearTextBox();
        }

       

        private void button_Sohr_Click(object sender, EventArgs e)
        {
           Update();
        }

        private void Change()
        {
            var SelectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_ID.Text;
            var accpunt = textBox_Account.Text;
            var category = textBox_category_contribution.Text;
            var passport = textBox_passport.Text;
            var date = DateTime.Now;
            int deposit_amount;
            if (dataGridView1.Rows[SelectedRowIndex].Cells[0].Value.ToString() != string.Empty) 
            { 
                if(int.TryParse(textBox_current_deposit_amount.Text, out deposit_amount))
                {
                    dataGridView1.Rows[SelectedRowIndex].SetValues(id, accpunt, category, passport, deposit_amount);
                    dataGridView1.Rows[SelectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }

        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            Change();
            ClearTextBox();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration adm = new Administration();
            adm.Show();
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information inf = new Information();
            inf.Show();
        }
    }
}
