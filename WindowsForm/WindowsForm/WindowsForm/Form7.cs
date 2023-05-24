using System;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(4);
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagForms.ActMain();
        }
    }
}
