using System;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ManagUsers.Aundif(textBox1.Text, textBox2.Text))
                ManagForms.StartForm(0);
            else
                MessageBox.Show("Неправильно введен пароль или логин");
        }

        
        

        private void checkBox1_Click(object sender, EventArgs e)
        {
               
                if (checkBox1.Checked)
                {
                    checkBox1.Text = "Логин и пароль можно получить\n у админитратора";
                }
                else
                {
                    checkBox1.Text = String.Empty;
                }
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }


        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ManagUsers.Aundif(textBox1.Text, textBox2.Text))
                {
                    ManagForms.StartForm(0);
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Неправильно введен пароль или логин");
                    textBox2.Clear();
                    
                }
                    
            }
        }
    }
}
