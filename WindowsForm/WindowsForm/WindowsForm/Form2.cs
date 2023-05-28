using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = ManagUsers.ActUser.Username;
            label3.Text = ManagUsers.ActUser.ID.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagForms.ActMain();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(2);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagForms.ActMain();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Label x = (Label)sender;
            x.ForeColor = SystemColors.ControlDark;
        }

        

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Label x = (Label)sender; 
            x.ForeColor = SystemColors.ButtonFace;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(4);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
                button3.Text = "Отк.";
            else
                button3.Text = "Скрыть";
            panel2.Visible = !panel2.Visible;
        }
    }
}
