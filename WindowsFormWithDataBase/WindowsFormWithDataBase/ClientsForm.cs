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
    public partial class ClientsForm : Form
    {
        public NpgsqlConnection npgsqlConnection;
        public DataTable table = new DataTable();
        public DataSet set = new DataSet();
        public ClientsForm(NpgsqlConnection npgsqlConnection)
        {
            this.npgsqlConnection = npgsqlConnection;
            InitializeComponent();
        }
        public void MyUpdate()
        {
            string sqlQuerry = "Select * From clients";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sqlQuerry, npgsqlConnection);
            set.Reset(); dataAdapter.Fill(set);
            table = set.Tables[0];
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "_id";
            dataGridView1.Columns[1].HeaderText = "first name";
            dataGridView1.Columns[2].HeaderText = "last name";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientForm form = new AddClientForm(npgsqlConnection);
            form.ShowDialog();
            MyUpdate();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            NpgsqlCommand command = new NpgsqlCommand("Delete from product Where ID = :id", npgsqlConnection);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
            MyUpdate();
        }
    }
}
