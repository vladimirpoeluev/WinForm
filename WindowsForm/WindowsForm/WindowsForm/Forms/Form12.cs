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
    public partial class Form12 : Form
    {
        SeasonTicket st;
        public Form12(SeasonTicket st)
        {
            InitializeComponent();
            this.st = st;
        }
        

        private void Form12_Load(object sender, EventArgs e)
        {
            
            label2.Text = st.Client.ToString();
            label4.Text = st.Book.ToString();
            label9.Text = st.ID.ToString();
            label7.Text = st.Term;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagUsers.DeleteClient(st);
            this.Close();
        }
    }
}
