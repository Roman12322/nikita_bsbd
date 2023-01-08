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

namespace nikita
{
    public partial class orders : Form
    {
        private SqlConnection conn;
        private readonly user _user;
        public orders(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.orders". При необходимости она может быть перемещена или удалена.
            
            if (_user.role == "driver")
            {
                this.ordersTableAdapter.FillByDRIVERID(this.database1DataSet.orders, _user.id);
                customersToolStripMenuItem.Visible = false;
            }
            else if (_user.role == "customer")
            {
                this.ordersTableAdapter.FillByCUSTOMERID(this.database1DataSet.orders, _user.id);
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

        private void tarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tarifs tarifs = new tarifs(_user);
            tarifs.Show();
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
    }
}
