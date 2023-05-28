using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form3 : Form
    {
        int numUser = 0;
        public Form3()
        {
            InitializeComponent();

        }
        private void UpdateText()
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            foreach (Message mess in ManagUsers.GetMessege(2))
            {
                textBox1.Text += $"<{ManagUsers.GetUserName(mess.Sender)}> {mess.Text}" + Environment.NewLine;
            }
            foreach(User user in ManagUsers.GetListOfUsers())
            {
                listBox1.Items.Add(user.Username);
            }
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            UpdateText();
            Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagUsers.AddMessege(numUser, textBox2.Text);
            UpdateText();
            
            textBox2.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagForms.ActMain();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(2);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
                button3.Text = "Отк.";
            else
                button3.Text = "Скрыть";
            panel2.Visible = !panel2.Visible;
        }

        private void listBox1_Click(object sender, EventArgs ex)
        {
            MouseEventArgs e = (MouseEventArgs)ex;
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                numUser = index + 1;
            }
            UpdateText();
        }
    }
}
