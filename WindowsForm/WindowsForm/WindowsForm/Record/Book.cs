using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    public class Book : Element
    {
       
        public string Autor { get; }
        public int Price { get; set; }

        public Book(string name, int iD, string autor, int count)
        {
            Name = name;
            ID = iD;
            Autor = autor;
            Price = count;
        }

        


    }
}
