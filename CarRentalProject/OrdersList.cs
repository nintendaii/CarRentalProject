using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CarRentalProject
{
    public partial class OrdersList : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CsharpMyDevelopments\CarRentalProject\CarRentalProject\CarRentalDB.mdf;Integrated Security=True";
        public OrdersList()
        {
            InitializeComponent();
        }

        private void OrdersList_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT o.Дата, o.Id_Замовлення, o.Id_Клієнта, o.Id_Автомобіля, cl.ПІБ, cl.Паспортні_дані, cr.Назва, cr.Ціна_аренди FROM [Order] o INNER JOIN [Clients] cl ON o.Id_Клієнта=cl.Id_Клієнта INNER JOIN [Cars] cr ON o.Id_Автомобіля=cr.Id_Автомобіля", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
