using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm
{
    static class ManagForms
    {
        static List<Form> _listForms = new List<Form>()
        {
            new Form2(),
            new Form3(),
            new Form4(),
            new Form5(),
            new Form6(),
            new Form7(),
            new Form8(),
            new Form9()
        };


        static Form _act = new Form();
        

        
        public static void AddForm(Form form)
        {
            _listForms.Add(form);
        }

        public static void ActForm(int i)
        {
            Point a = _act.Location;
            _act.Hide();
            _act = _listForms[i];
            _act.Show();
            _act.Location = a;

        }
        public static void StartForm(int i)
        {
            int t = _act.Top;
            int l = _act.Left;
            Program.form.Visible = false;
            _act = _listForms[i];
            _act.Top = Program.form.Top;
            _act.Left = Program.form.Left;
            _act.Show();
        }
        public static void ActMain()
        {
            Program.form.Top = _act.Top;
            Program.form.Left = _act.Left;
            _act.Visible = false;
            _listForms = new List<Form>()
            {
                new Form2(),
                new Form3(),
                new Form4(),
                new Form5(),
                new Form6(),
                new Form7(),
                new Form8(),
                new Form9()
            };
            
            
            Program.form.Visible = true;
        }
    }
}
