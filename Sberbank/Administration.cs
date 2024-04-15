using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sberbank
{
    public partial class Administration : Form
    {
        Database database = new Database();


        public Administration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_user", "ID");
            dataGridView1.Columns.Add("Login", "Логин");
            dataGridView1.Columns.Add("Password", "Пароль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "IsAdmin";
            dataGridView1.Columns.Add(checkColumn);
        }
        private void ReadSingleRow(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetBoolean(3));
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            string queryString = $" select * from register";
            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow( reader);
            }
            reader.Close();
        }
        private void Administration_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var isadmin = dataGridView1.Rows[index].Cells[3].Value.ToString();


                    var changeQuary = $"update register set is_admin = '{isadmin}' where id_user = '{id}'";

                    var command = new SqlCommand(changeQuary, database.GetConnection());
                    command.ExecuteNonQuery();
                
            }

            database.closeConnection();
            RefreshDataGrid();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var SelectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView1.Rows[SelectedRowIndex].Cells[0].Value);
            var DeleteQuary = $"delete from register where id_user = {id}";
            var command = new SqlCommand(DeleteQuary, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
            RefreshDataGrid();
        }
    }
}
