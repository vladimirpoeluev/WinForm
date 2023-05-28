using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    public enum Status
    {
        Librarian,
        Admin
    }
    class User
    {
       
        public string Username { get; }
        public string Login { get; }
        public int ID { get; }
        public Status StatusUser { get; }

        public User(int id, string name, string login, Status stU)
        {
            Username = name;
            Login = login;
            StatusUser = stU;
            ID = id;
        }
        public User(int id, string name)
        {
            Username = name;
            ID = id;
        }
    }
}
