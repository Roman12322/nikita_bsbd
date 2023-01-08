using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikita
{
    public partial class drivers : Form
    {
        private SqlConnection conn;
        private readonly user _user;
        public drivers(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void drivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.FillByDRIVERID(this.database1DataSet.drivers, _user.id);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, БИС, Лунев Никита Денисович, 740-1, 2022", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            orders orders = new orders(_user);
            orders.Show();
        }

        private void tarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tarifs tarifs = new tarifs(_user);
            tarifs.Show();
        }
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект command для SQL команды
            SqlCommand command = conn.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }
        private void update_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            conn.Open();
            var first_name = firstname_driver_txt.Text;
            var last_name = lastname_driver_txt.Text;
            var phone = phone_driver_txt.Text;
            try
            {
                string sqlcommand = "UPDATE drivers SET first_name = @first_name, last_name = @last_name, phone_number = @phone_number WHERE Id = @Id";
                SqlCommand command = conn.CreateCommand();
                command.CommandText = sqlcommand;
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(_user.id));
                command.Parameters.AddWithValue("@first_name", first_name);
                command.Parameters.AddWithValue("@last_name", last_name);
                command.Parameters.AddWithValue("@phone_number", phone);

                command.ExecuteNonQuery();
                dataGridView1.DataSource = FillDataGridView("select * FROM drivers");
                MessageBox.Show("Succesfully updated", "Success", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error query.\n" + err.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
    }
}
