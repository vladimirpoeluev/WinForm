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
            ManagForms.StartForm(0);
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
        
    }
}
