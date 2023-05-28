using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsForm
{
    partial class DataBase
    {
        public static class Users
        {
            public static int EndId
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
                           
                            User user = new User(int.Parse(sp[1]), sp[7]);
                            endID = user.ID;
                        }
                    }
                    return endID;
                }
            }
            private static Status[] _statuses = new Status[]
            {
                Status.Librarian,
                Status.Admin
            };
            private const string _nameTable = "Users.txt";
            public static void AddUser(int id, string login, string passWord, string name, Status stat)
            {
                try
                {
                    GetUser(id);
                }
                catch
                {
                    File.AppendAllText($"{_nameBase}/{_nameTable}",'\n' + id + " " + login + " " + passWord + " " + name + " " + (int)stat);
                }
                
            }
            public static List<User> GetUsers()
            {
                List<User> users = new List<User>();
                using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] sp = line.Split('~');
                        
                        User user = new User(int.Parse(sp[1]), sp[7]);

                        users.Add(user);


                    }
                }
                return users;
            }
            public static User GetUsers(string login, string passWord)
            {
                User user;
                using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] sp = line.Split('~');
                        
                        if (sp[3] == login && sp[5] == passWord)
                        {
                            Status status = _statuses[int.Parse(sp[9])];
                            user = new User(int.Parse(sp[1]), sp[7], sp[3], status);
                            return user;
                        }
                    }
                    throw new Exception("Пользователь не найден");
                }
            }
            public static User GetUser(int iD)
            {
                User user;
                using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] sp = line.Split('~');
                        if (int.Parse(sp[1]) == iD)
                        {
                            Status status = _statuses[int.Parse(sp[9])];
                            user = new User(int.Parse(sp[1]), sp[7], sp[3], status);
                            return user;
                        }
                    }
                }
                throw new Exception("Пользователь не найден");
            }
        }
    }
}
