using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    internal class Memento
    {
        public int Position { get; private set; }
        public Memento(int pos)
        {
            Position = pos;
        }
    }
}
