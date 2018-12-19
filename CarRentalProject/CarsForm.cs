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
    public partial class CarsForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CsharpMyDevelopments\CarRentalProject\CarRentalProject\CarRentalDB.mdf;Integrated Security=True";
        public CarsForm()
        {
            InitializeComponent();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Cars]", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [Cars] (Назва, Наявність, Ціна_аренди) VALUES (@Назва, @Наявність, @Ціна_аренди)", connection);
                command.Parameters.Add("@Назва", tbName.Text.ToString());
                command.Parameters.Add("@Наявність", tbAv.Text.ToString());
                command.Parameters.Add("@Ціна_аренди", tbPrice.Text.ToString());
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
                SqlCommand command = new SqlCommand("UPDATE [Cars] SET Назва=@Назва, Наявність=@Наявність, Ціна_аренди=@Ціна_аренди WHERE Id_Автомобіля=@Id_Автомобіля",connection);
                command.Parameters.Add("@Id_Автомобіля", Convert.ToInt32(dataGridView1[0, i].Value));
                //string s = dataGridView1[1, i].Value.ToString();
                command.Parameters.Add("@Назва", Convert.ToString(dataGridView1[1, i].Value));
                command.Parameters.Add("@Наявність", Convert.ToString(dataGridView1[2, i].Value));
                command.Parameters.Add("@Ціна_аренди",Convert.ToString(dataGridView1[3,i].Value));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM [Cars] WHERE Id_Автомобіля=@Id_Автомобіля",connection);
            command.Parameters.Add("@Id_Автомобіля", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
