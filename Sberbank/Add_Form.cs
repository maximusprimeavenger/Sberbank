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
    public partial class Add_Form : Form
    {
        Database database = new Database();
        public Add_Form()
        {
            InitializeComponent();
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_SOHRANIT_Click(object sender, EventArgs e)
        { 
            database.openConnection();
            var account = textBox_account.Text;
            var category = textBox_category.Text;
            var passport = textBox_Passport.Text;
            int sum_count;
            var date = DateTime.Now;

            if (int.TryParse(textBox_sum_count.Text, out sum_count))
            {
                var addQuery = $"insert into project(account_number, category_contribution, passport_details, current_deposit_amount, last_transaction_date) values ('{account}','{category}','{passport}','{sum_count}','{date}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
            }
            else
            {
                MessageBox.Show("Сумма вклада должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }
    }
}
