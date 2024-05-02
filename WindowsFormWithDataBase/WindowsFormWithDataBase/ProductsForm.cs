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
    public partial class ProductsForm : Form
    {
        public NpgsqlConnection npgsqlConnection;
        public DataTable table = new DataTable();
        public DataSet set = new DataSet();
        public ProductsForm(NpgsqlConnection npgsqlConnection)
        {
            InitializeComponent();
            this.npgsqlConnection = npgsqlConnection;
            
        }
        public void Form2_Load(object sender, EventArgs eventArgs)
        {
            MyUpdate();
        }
        public void MyUpdate()
        {
            string sqlQuerry = "Select * From product";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sqlQuerry, npgsqlConnection);
            set.Reset(); dataAdapter.Fill(set);
            table = set.Tables[0];
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[2].HeaderText = "Ед. измерения";
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(npgsqlConnection);
            form.ShowDialog();
            MyUpdate();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            NpgsqlCommand command = new NpgsqlCommand("Delete from product Where ID = :id", npgsqlConnection);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
            MyUpdate();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm form3 = new AddProductForm(npgsqlConnection);
            form3.ShowDialog();
            MyUpdate();
        }
    }
}
