using System;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsForm
{
    public partial class Form10 : Form
    {
        private Book book;
        private Client client;
        public Form10(Book book)
        {
            InitializeComponent();
            UpdateForm();
            
            this.book = book;
            label2.Text = book.Name;
            label3.Text = book.Autor;
            label9.Text = book.ID.ToString();
            label14.Text = book.Price.ToString();
        }
        void UpdateForm()
        {
            listBox1.Items.Clear();
            foreach(Client client in ManagUsers.GetClients())
            {
                listBox1.Items.Add(client);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagUsers.DeleteBook(book.ID);
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            bool isExis = true;
            foreach (var b in ManagUsers.GetSeasonTickets())
            {
                if (b.Book.ID == book.ID)
                {
                    isExis = false; break;
                }
            }
            if (isExis)
            {
                label12.BackColor = Color.Green;
                label12.Text = "Есть";
            }
            else
            {
                label12.Text = "Нету";
            }
            button2.Enabled = isExis;
        }

        private void listBox1_Click(object sender, EventArgs ex)
        {
            MouseEventArgs e = (MouseEventArgs)ex;
            int index = this.listBox1.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                try
                {
                    client = (Client)listBox1.Items[index];
                    textBox1.Text = client.ID.ToString();
                    textBox2.Text = client.Name;
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"Книга не найдена: {exc.Message}");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagUsers.AddSeasonTicket(client, book);
            Close();
        }
    }
}
