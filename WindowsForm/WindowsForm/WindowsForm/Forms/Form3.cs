using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form3 : Form
    {
        User recip;
        public Form3()
        {
            InitializeComponent();
            
            
        }
        private void UpdateText()
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            
            foreach(User user in ManagUsers.GetListOfUsers())
            {
                listBox1.Items.Add(user);
            }
            if (recip != null)
            {
                foreach (Message mess in ManagUsers.GetMessege(recip.ID))
                {
                    textBox1.Text += $"<{ManagUsers.GetUserName(mess.Sender)}> {mess.Text}" + Environment.NewLine;
                }
            }
            else { 
                recip = (User)listBox1.Items[0];
                foreach (Message mess in ManagUsers.GetMessege(recip.ID))
                {
                    textBox1.Text += $"<{ManagUsers.GetUserName(mess.Sender)}> {mess.Text}" + Environment.NewLine;
                }
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            UpdateText();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ManagUsers.AddMessege(recip.ID, textBox2.Text);
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
                recip = (User)listBox1.Items[index];
            }
            UpdateText();
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ManagUsers.AddMessege(recip.ID, textBox2.Text);
                UpdateText();
                textBox2.Clear();
            }
        }
    }
}
