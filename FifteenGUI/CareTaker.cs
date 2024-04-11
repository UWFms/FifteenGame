using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    internal class CareTaker
    {
        Stack<Memento> stack = new Stack<Memento>();

        public void Push(Memento pos)
        {
            stack.Push(pos);
        }
        public int Pop()
        {
            return stack.Pop().Position;
        }
    }
}
