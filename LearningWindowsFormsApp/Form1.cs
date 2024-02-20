using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningWindowsFormsApp
{
    public partial class Form1 : Form
    {
        protected List<User> users;
        public Form1()
        {
            users = new List<User>();
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string text = "\n";
            text += textBox1.Text + "\n";
            text += comboBox1.Text + "\n";
            if (radioButton1.Checked)
                text += "male\n";
            else if (radioButton2.Checked)
                text += "female\n";
            else if (radioButton3.Checked)
                text += "fool\n";
            text += textBox2.Text + "\n";
            richTextBox1.AppendText(text);
            User user = new User(textBox1.Text, comboBox1.Text);
            users.Add(user);
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