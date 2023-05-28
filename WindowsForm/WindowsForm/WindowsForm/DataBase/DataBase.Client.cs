using System.Collections.Generic;
using System.IO;
using System;


namespace WindowsForm
{
    public static partial class DataBase
    {
        private const string _nameTable = "Client.txt";
        public static class Clients
        {
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
                            Client book = new Client(int.Parse(sp[1]), sp[3]);
                            endID = book.ID;
                        }
                    }
                    return endID;
                }
            }
            
            public static void AddClient(int id1, string  name)
            {
                File.AppendAllText($"{_nameBase}/{_nameTable}", "~" + id1 + "~~" + name + "~\n");
            }
            public static Client GetClient(int iD)
            {
                
                using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] sp = line.Split('~');
                        Client clientA = new Client(int.Parse(sp[1]), sp[3]);
                        if(clientA.ID == iD)
                        {
                            return clientA;
                        }
                    }
                }
                throw new Exception("Клиент не найден");
            }
            public static void DeleteRecord(int iD)
            {
                List<Client> clients = GetClients();
                File.WriteAllText($"{_nameBase}/{_nameTable}", null);
                for (int i = 0; i < clients.Count; i++)
                {
                    if (clients[i].ID != iD)
                    {
                        AddClient(clients[i].ID, clients[i].Name);
                    }
                }
            }
            public static List<Client> GetClients()
            {
                List<Client> clients = new List<Client>();
                using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] sp = line.Split('~');
                        Client client = new Client(int.Parse(sp[1]), sp[3]);
                        
                        clients.Add(client);
                    }
                }
                return clients;
            }
        }
    }
}
