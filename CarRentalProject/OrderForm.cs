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

namespace CarRentalProject
{
    public partial class OrderForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CsharpMyDevelopments\CarRentalProject\CarRentalProject\CarRentalDB.mdf;Integrated Security=True";
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDBDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.carRentalDBDataSet.Order);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [Order] (Id_Клієнта, Id_Автомобіля, Дата) VALUES (@Id_Клієнта, @Id_Автомобіля, @Дата)", connection);
                command.Parameters.Add("@Id_Клієнта", Convert.ToString(tbClientId.Text));
                command.Parameters.Add("@Id_Автомобіля", Convert.ToString(tbCarId.Text));
                command.Parameters.Add("@Дата", Convert.ToString(tbDate.Text));
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("FATAL ERROR!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Order]", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("FATAL ERROR!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM [Order] WHERE Id_Замовлення=@Id_Замовлення", connection);
                command.Parameters.Add("@Id_Замовлення", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("FATAL ERROR!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE [Order] SET Id_Клієнта=@Id_Клієнта, Id_Автомобіля=@Id_Автомобіля, Дата=@Дата WHERE Id_Замовлення=@Id_Замовлення", connection);
                command.Parameters.Add("@Id_Замовлення",Convert.ToInt32(dataGridView1[0,i].Value));
                command.Parameters.Add("@Id_Клієнта", Convert.ToInt32(dataGridView1[1, i].Value));
                command.Parameters.Add("@Id_Автомобіля", Convert.ToInt32(dataGridView1[2, i].Value));
                command.Parameters.Add("@Дата", Convert.ToString(dataGridView1[3, i].Value));
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
