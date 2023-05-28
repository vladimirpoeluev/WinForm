using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form11 : Form
    {
        private Client _client;
        public Form11(Client client)
        {
            InitializeComponent();
            _client = client;
            label2.Text = client.Name;
            label9.Text = client.ID.ToString();
        }
        void UpdateForm()
        {
            listBox1.Items.Clear();
            foreach(var st in DataBase.SeasonTickets.GetSeasonTickets(_client.ID))
            {
                listBox1.Items.Add(st);
            }
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagUsers.DeleteClient(_client);
            Close();
        }

        private void listBox1_Click(object sender, EventArgs ex)
        {
            MouseEventArgs e = (MouseEventArgs)ex;
            int index = this.listBox1.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                try
                {
                    SeasonTicket client = (SeasonTicket)listBox1.Items[index];

                    new Form12(client).Show();
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"Книга не найдена: {exc.Message}");
                }


            }
        }
    }
}
