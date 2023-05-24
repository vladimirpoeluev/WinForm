using System;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(2);
        }

        
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagForms.ActMain();
        }
    }
}
