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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClientsList_Click(object sender, EventArgs e)
        {
            ClientsForm clf = new ClientsForm();
            clf.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarsList_Click(object sender, EventArgs e)
        {
            CarsForm crf = new CarsForm();
            crf.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm of = new OrderForm();
            of.Show();
        }

        private void btnOrdersList_Click(object sender, EventArgs e)
        {
            OrdersList olf = new OrdersList();
            olf.Show();
        }
    }
}
