using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsForm
{
    public partial class DataBase
    {
        public static class Messags
        {
            private const string _nameTable = "Messege.txt";

            public static void AddMessage(int id1, int id2, string text)
            {
                File.AppendAllText($"{_nameBase}/{_nameTable}", "~" + id1 + "~~" + id2 + "~~" + text + "~\n");
            }
            public static List<Message> GetMessages(int id, int id2)
            {
                List<Message> messages = new List<Message>();
                using (StreamReader sr = new StreamReader($"{_nameBase}/{_nameTable}"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] sp = line.Split('~');
                        
                        
                        Message messg = new Message(int.Parse(sp[1]), int.Parse(sp[3]), sp[5]);
                        if (messg.Sender == id && messg.Recipient == id2 || messg.Sender == id2 && messg.Recipient == id)
                        {
                            messages.Add(messg);
                            
                        }
                    }
                }
                return messages;
            }
        }

    }
}
