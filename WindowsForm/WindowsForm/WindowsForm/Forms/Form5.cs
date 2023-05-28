using System;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox4.Text = (DataBase.Books.EndID + 1).ToString();
        }
        private void ClearTxBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ManagUsers.AddBook(int.Parse(textBox4.Text), textBox1.Text, textBox3.Text, int.Parse(textBox5.Text));
                ManagForms.ActForm(2);
                ClearTxBox();
            }
            catch(Exception)
            {
                MessageBox.Show("Что то пошло не так");
                
            }
           
            
        }

        
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            ManagForms.ActMain();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTxBox();
            textBox4.Text = (DataBase.Books.EndID + 1).ToString();
            ManagForms.ActForm(2);
        }
    }
}
