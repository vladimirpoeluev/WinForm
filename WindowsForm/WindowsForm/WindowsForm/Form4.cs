using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(1);
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            ManagForms.ActForm(0);
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Добавить книгу
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(3);
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagForms.ActMain();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(6);
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
