using StructuriDeDate.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.Lista.ListaSimpluInlantuita
{

    public class Node
    {

        public Node Next { get; set; }

        public User Data { get; set; }

        public Node() { }

        public Node(Node next, User user)
        {

            Next = next;
            Data = user;

        }
    }
}
