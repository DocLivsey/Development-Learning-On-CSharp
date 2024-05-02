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

namespace Shop_app
{
    public partial class Form2 : Form
    {
        public NpgsqlConnection con;
        public Form2(NpgsqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO tovar (name, merge) VALUES (:name, :merge)", con);
                command.Parameters.AddWithValue("name", textBox1.Text);
                command.Parameters.AddWithValue("merge", textBox2.Text);
                command.ExecuteNonQuery();
                Close();
            }
            catch {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
