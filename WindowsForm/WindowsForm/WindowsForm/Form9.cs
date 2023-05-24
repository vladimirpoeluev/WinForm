using System;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagForms.ActForm(6);
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            ManagForms.ActMain();
            ManagForms.ActMain();
            
        }
    }
}
