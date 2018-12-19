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

namespace CarRentalProject
{
    public partial class ClientsForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CsharpMyDevelopments\CarRentalProject\CarRentalProject\CarRentalDB.mdf;Integrated Security=True";
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDBDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.carRentalDBDataSet.Clients);
        }
        //yurii.andrashko@uzhnu.edu.ua
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [Clients] (ПІБ, Паспортні_дані) VALUES (@ПІБ, @Паспортні_дані)", connection);
                command.Parameters.Add("@ПІБ", Convert.ToString(tbName.Text));
                command.Parameters.Add("@Паспортні_дані", Convert.ToString(tbPasp.Text));
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("FATAL ERROR!! THE NAME IS TOO LONG");
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Clients]", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM [Clients] WHERE Id_Клієнта=@Id_Клієнта", connection);
            command.Parameters.Add("@Id_Клієнта", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE [Clients] SET ПІБ=@ПІБ, Паспортні_дані=@Паспортні_дані WHERE Id_Клієнта=@Id_Клієнта", connection);
                command.Parameters.Add("@Id_Клієнта", Convert.ToInt32(dataGridView1[0, i].Value));
                //string s = dataGridView1[1, i].Value.ToString();
                command.Parameters.Add("@ПІБ", Convert.ToString(dataGridView1[1, i].Value));
                command.Parameters.Add("@Паспортні_дані", Convert.ToString(dataGridView1[2, i].Value));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
