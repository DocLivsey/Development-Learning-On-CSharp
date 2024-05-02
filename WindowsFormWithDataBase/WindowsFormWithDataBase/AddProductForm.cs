using System;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormWithDataBase
{
    public partial class AddProductForm : Form
    {
        public NpgsqlConnection npgsqlConnection;
        public AddProductForm(NpgsqlConnection npgsqlConnection)
        {
            InitializeComponent();
            this.npgsqlConnection = npgsqlConnection;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand("Insert Into product (name, unit) Values(:name, :unit)", npgsqlConnection);
                npgsqlCommand.Parameters.AddWithValue("name", textBox1.Text);
                npgsqlCommand.Parameters.AddWithValue("unit", textBox2.Text);
                npgsqlCommand.ExecuteNonQuery();
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "YesButton"); }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
