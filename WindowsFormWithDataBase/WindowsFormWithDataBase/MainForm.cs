using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormWithDataBase
{
    public partial class MainForm : Form
    {
        public NpgsqlConnection npgsqlConnection;
        public void MyLoad()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            npgsqlConnection = new NpgsqlConnection("Server=localhost; Port=5432; UserID=postgres; Password=postpass; Database=Eto Baza");
            npgsqlConnection.Open();
           
        }
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs eventArgs)
        {
           
            MyLoad();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductsForm formProduct = new ProductsForm(npgsqlConnection);
            formProduct.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm(npgsqlConnection);
            clientsForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
