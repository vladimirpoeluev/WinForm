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
    public class User : Element
    {
       
        
        public string Login { get; }
        
        public Status StatusUser { get; }

        public User(int id, string name, string login, Status stU)
        {
            Name = name;
            Login = login;
            StatusUser = stU;
            ID = id;
        }
        public User(int id, string name)
        {
            Name = name;
            ID = id;
        }
        
    }
}
