using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    public abstract class Element
    {
        public int ID { get; protected set; }
        public string Name { get; protected set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
