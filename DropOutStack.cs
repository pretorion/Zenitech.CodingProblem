using System;
using System.Collections;
using System.Linq;

namespace Zenitech.CodingProblem
{
    public class DropOutStack
    {
        private UInt10[] items;
        private int top = 0;
        public DropOutStack(int capacity)
        {
            items = new UInt10[capacity];
        }
        public ushort? Add()
        {
            if(top>1)
            {
                return Push((ushort)(Mod(Pop().Value + Pop().Value)));
            }
            return null;
        }
        public ushort? Sub()
        {
            if (top > 1)
            {
                return Push((ushort)(Mod(Pop().Value - Pop().Value)));
            }
            return null;
        }
        public ushort? Push(ushort val)
        {
            if(top == items.Length)
            {
                return null;
            }
            items[top] = new UInt10(val);
            top = (top + 1);
            return val;
        }
        public ushort? Pop()
        {
            if (top < 1 )
            {
                return null;
            }
            top -= 1;
            return items[top].ToUInt16();
        }
        public string Print()
        {
            return String.Join(", ", items.Take(top).Select(s=> s.ToUInt16().ToString()));
        }
        private int Mod(int x, int m=1024)
        {
            return (x % m + m) % m;
        }
    }
}
