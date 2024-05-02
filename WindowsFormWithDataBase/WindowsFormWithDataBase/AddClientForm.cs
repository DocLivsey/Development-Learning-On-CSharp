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
    public partial class AddClientForm : Form
    {
        public NpgsqlConnection npgsqlConnection;
        public AddClientForm(NpgsqlConnection npgsqlConnection)
        {
            InitializeComponent();
            this.npgsqlConnection = npgsqlConnection;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Insert Into clients (first_name, last_name) Values(:first_name, :last_name)", npgsqlConnection);
            npgsqlCommand.Parameters.AddWithValue("first_name", textBox1.Text);
            npgsqlCommand.Parameters.AddWithValue("last_name", textBox2.Text);
            npgsqlCommand.ExecuteNonQuery();
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
