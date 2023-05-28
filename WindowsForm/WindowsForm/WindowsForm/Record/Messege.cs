using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    
    public class Message
    {
        public int Sender { get; }
        public int Recipient { get; }
        public string Text { get; }

        public Message(int sender, int recip, string text)
        {
            Sender = sender;
            Recipient = recip;
            Text = text;
        }
        
    }
}
