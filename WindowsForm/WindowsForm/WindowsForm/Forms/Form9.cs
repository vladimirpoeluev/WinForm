using System;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            textBox4.Text = (ManagUsers.GetEndIndexClient() + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagUsers.AddClient(new Client(int.Parse(textBox4.Text), textBox1.Text));
            ManagForms.ActForm(6);
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagForms.ActMain(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(6);
        }
    }
}
