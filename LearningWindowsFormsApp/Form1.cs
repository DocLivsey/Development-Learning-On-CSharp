using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace LearningWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private UsersList users;
        public Form1()
        {
            users = new UsersList();
            InitializeComponent();
        }
        
        private void excelButton_CLick(Object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            String fileName = ofd.FileName;

            Excel.Application excel = new Excel.Application();
            excel.Visible = true;

            Excel.Workbook workbook = excel.Workbooks.Open(fileName, 0, false, 5);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            worksheet.Cells[1] = 0;
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string address = comboBox1.Text;
            string gender;
            if (radioButton1.Checked)
                gender = "male";
            else if (radioButton2.Checked)
                gender = "female";
            else if (radioButton3.Checked)
                gender = "fool";
            else gender = "None";
            string otherInfo = textBox2.Text;
            User user = new User(name, address, gender, otherInfo);
            users.AppendNewUser(user);
            richTextBox1.AppendText(users.ToString());
            MessageBox.Show("button1 was clicked");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}