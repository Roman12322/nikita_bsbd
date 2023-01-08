using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace nikita
{
    public partial class auth : Form
    {
        private SqlConnection conn;
        public auth()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                conn.Open();
                var user_login = login_auth_txt.Text;
                var user_password = pass_auth_txt.Text;
                var user_phone = phone_auth_txt.Text;
                var status = signinstatus.Text;

                if (status == "" || status == null)
                {
                    MessageBox.Show("Выберите роль для входа");
                }
                else if (status == "customer")
                {
                    SqlDataAdapter adapter_customers = new SqlDataAdapter();
                    DataTable dt_customers = new DataTable();

                    string query_customers = $"select id from customers where login = '{user_login}' and password = '{user_password}' and phone_number = '{user_phone}'";
                    SqlCommand command_customers = new SqlCommand(query_customers, conn);

                    adapter_customers.SelectCommand = command_customers;
                    adapter_customers.Fill(dt_customers);

                    if (dt_customers.Rows.Count == 1)
                    {
                        var user = new user(id: Convert.ToInt32(Convert.ToInt32(dt_customers.Rows[0].ItemArray[0])), "customer");
                        customers customers = new customers(user);
                        MessageBox.Show($"Вход произведен успешно от роли {user.role}");
                        customers.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ах ты шалоболка, нельзя тебе сюда");
                    }

                }
                else if (status == "driver")
                {
                    SqlDataAdapter adapter_drivers = new SqlDataAdapter();
                    DataTable dt_drivers = new DataTable();

                    string query_drivers = $"select id from drivers where login = '{user_login}' and password = '{user_password}' and phone_number = '{user_phone}'";

                    SqlCommand command_drivers = new SqlCommand(query_drivers, conn);

                    adapter_drivers.SelectCommand = command_drivers;
                    adapter_drivers.Fill(dt_drivers);

                    if (dt_drivers.Rows.Count == 1)
                    {
                        var user = new user(id: Convert.ToInt32(Convert.ToInt32(dt_drivers.Rows[0].ItemArray[0])), "driver");
                        drivers drivers = new drivers(user);
                        MessageBox.Show($"Вход произведен успешно от роли {user.role}");
                        drivers.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ах ты шалоболка, нельзя тебе сюда");
                    }
                }    
            }
            catch
            {
                MessageBox.Show("Ах ты шалоболка, нельзя тебе сюда");
            }
        }
    }
}
