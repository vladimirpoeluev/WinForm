using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(0);
           
        }
        void UpdateForm()
        {
            listBox1.Items.Clear();
            foreach (Client client in ManagUsers.GetClients())
            {
                listBox1.Items.Add(client);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(1);
        }
        private void label6_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(2);
        }
        private void label7_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(4);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ManagForms.ActMain();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Label x = (Label)sender;
            x.ForeColor = SystemColors.ControlDark;
        }
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagForms.ActMain();
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Label x = (Label)sender;
            x.ForeColor = SystemColors.ButtonFace;
        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagForms.ActMain();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(7);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
                button3.Text = "Отк.";
            else
                button3.Text = "Скрыть";
            panel2.Visible = !panel2.Visible;
        }
        private void Form4_Click(object sender, EventArgs ex)
        {
            MouseEventArgs e = (MouseEventArgs)ex;
            int index = this.listBox1.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                try
                {
                    Client client = (Client)listBox1.Items[index];
               
                    new Form11(client).Show();
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"Книга не найдена: {exc.Message}");
                }


            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
