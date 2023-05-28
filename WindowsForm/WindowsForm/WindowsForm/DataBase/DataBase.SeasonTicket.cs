using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsForm
{
    public static partial class DataBase
    {
        public static class SeasonTickets
        {
            private const string _nameTable = "SeasonTicket.txt";
            public static int EndID
            {
                get
                {
                    int endID = 0;
                    using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] sp = line.Split('~');
                            SeasonTicket book = new SeasonTicket(int.Parse(sp[1]), Clients.GetClient(int.Parse(sp[3])), Books.GetBook(int.Parse(sp[5])), sp[7]);
                            endID = book.ID;
                        }
                    }
                    return endID;
                }
            }
            public static List<SeasonTicket> GetSeasonTickets()
            {
                List<SeasonTicket> list = new List<SeasonTicket>();
                using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] sp = line.Split('~');
                        SeasonTicket at = new SeasonTicket(int.Parse(sp[1]), Clients.GetClient(int.Parse(sp[3])), Books.GetBook(int.Parse(sp[5])), sp[7]);

                        list.Add(at);

                    }
                }
                return list;
            }
            public static List<SeasonTicket> GetSeasonTickets(int id)
            {
                List<SeasonTicket> list = new List<SeasonTicket>();
                using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] sp = line.Split('~');
                        SeasonTicket at = new SeasonTicket(int.Parse(sp[1]), Clients.GetClient(int.Parse(sp[3])), Books.GetBook(int.Parse(sp[5])), sp[7]);
                        if(at.Client.ID == id)
                            list.Add(at);
                    }
                }
                return list;
            }
            public static void DeleteRecord(int iD)
            {
                List<SeasonTicket> clients = GetSeasonTickets();
                File.WriteAllText($"{_nameBase}/{_nameTable}", null);
                for (int i = 0; i < clients.Count; i++)
                {
                    if (clients[i].ID != iD)
                    {
                        AddSeasonTickets(clients[i].Client, clients[i].Book, clients[i].Term);
                    }
                }
            }
            public static void AddSeasonTickets(Client client, Book book, string date)
            {
                File.AppendAllText($"{_nameBase}/{_nameTable}", "~" + (EndID + 1) + "~~" + client.ID + "~~" + book.ID + "~~" + date + "~\n");
            }
        }
    }
}
