using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    public class Node
    {

        public Node Next { get; set; }

        public int Data { get; set; }

        public Node() { }

        public Node(Node next, int nr)
        {

            Next = next;
            Data = nr;

        }

    }
}
