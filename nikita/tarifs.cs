using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikita
{
    public partial class tarifs : Form
    {
        private SqlConnection conn;
        private readonly user _user;
        public tarifs(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void tarifs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.tarif". При необходимости она может быть перемещена или удалена.
            this.tarifTableAdapter.Fill(this.database1DataSet.tarif);
            if (_user.role == "driver")
            {
                customersToolStripMenuItem.Visible = false;
            }
            else if (_user.role == "customer")
            {
                driversToolStripMenuItem.Visible = false;
            }
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

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            customers customers = new customers(_user);
            customers.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            drivers drivers = new drivers(_user);
            drivers.Show();
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
        private void show_button_Click(object sender, EventArgs e)
        {
            var categories = tarif_categories.Text;
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            conn.Open();
            switch (categories)
            {
                case "with kid place":
                    dataGridView1.DataSource = FillDataGridView("select * from tarif\r\nwhere kid_place = 'yes'\r\norder by cost");
                    break;
                case "with pet place":
                    dataGridView1.DataSource = FillDataGridView("select * from tarif\r\nwhere pet_place = 'yes'\r\norder by cost");
                    break;
                case "luxury cars":
                    dataGridView1.DataSource = FillDataGridView("select * from tarif\r\nwhere car_class = 'luxury'\r\norder by cost");
                    break;
                case "econom":
                    dataGridView1.DataSource = FillDataGridView("select * from tarif\r\nwhere car_class = 'econom'\r\norder by cost");
                    break;
                default:
                    dataGridView1.DataSource = FillDataGridView("select * FROM drivers");
                    break;
            }
        }
    }
}
