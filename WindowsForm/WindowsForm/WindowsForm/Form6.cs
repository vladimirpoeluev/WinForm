﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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

        private void label6_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(2);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagForms.ActMain();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(5);
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagForms.ActMain();
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
