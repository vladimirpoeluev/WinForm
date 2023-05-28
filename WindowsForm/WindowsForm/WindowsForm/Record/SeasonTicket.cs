using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    public class SeasonTicket : Element
    {
        public Client Client { get; }
        public Book Book { get; }
        public string Term { get; }

        
        public SeasonTicket(int id, Client client, Book book, string term, string name = "Абонемент")
        {
            ID = id;
            Client = client;
            Book = book;
            Term = term;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Book}: {Client}";
        }
    }
}
