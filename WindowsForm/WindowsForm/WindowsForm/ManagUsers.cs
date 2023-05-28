using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System;

namespace WindowsForm
{
    static class ManagUsers
    {
       
        private static User _actUser;
        
        public static User ActUser
        {
            get
            {
                return _actUser;
            }
        }
        public static void AddSeasonTicket(Client client, Book book)
        {
            DataBase.SeasonTickets.AddSeasonTickets(client, book, DateTime.Now.ToString());
        }
        public static void DeleteSeasonTicket(SeasonTicket st)
        {
            DataBase.SeasonTickets.DeleteRecord(st.ID);
        }
        public static List<SeasonTicket> GetSeasonTickets()
        {
             return DataBase.SeasonTickets.GetSeasonTickets();
        }
        public static List<SeasonTicket> GetSeasonTickets(Client client)
        {
            return DataBase.SeasonTickets.GetSeasonTickets(client.ID);
        }
        public static void DeleteClient(SeasonTicket st)
        {
            DataBase.SeasonTickets.DeleteRecord(st.ID);
        } 
        public static void AddClient(Client client)
        {
            DataBase.Clients.AddClient(client.ID, client.Name);
        }
        public static void DeleteClient(Client client)
        {
            DataBase.Clients.DeleteRecord(client.ID);
        }
        public static int GetEndIndexClient()
        {
            return DataBase.Clients.EndID;
        }
        public static List<Client> GetClients()
        {
            return DataBase.Clients.GetClients();
        }
        public static void DeleteUser(int iD)
        {
            DataBase.Clients.DeleteRecord(iD);
        }
        public static bool Aundif(string login, string passWord)
        {
            try
            {
                _actUser = DataBase.Users.GetUsers(login, passWord);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
           
        }
        public static string GetUserName(int iD)
        {
            return DataBase.Users.GetUser(iD).Name;
        }
        public static List<Book> GetBooks()
        {
            return DataBase.Books.GetBooks();
        }
        public static void AddBook(int id, string name, string autor, int price)
        {
            DataBase.Books.AddBook(id, name, autor, price);
        }
        public static List<Message> GetMessege(int a)
        {
            return DataBase.Messags.GetMessages(_actUser.ID, a); 
        }
        public static bool AddMessege(int id, string text)
        {
            DataBase.Messags.AddMessage(_actUser.ID, id, text);
           
            return false;
        }
        public static void DeleteBook(int iD)
        {
            DataBase.Books.DeleteRecord(iD);
        }
        public static List<User> GetListOfUsers()
        {
            return DataBase.Users.GetUsers();
        }

    }
}
