using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.ListaGenerica
{
    public class Node<T> where T : IComparable<T>
    {

        public Node<T> Next { get; set; }

        public T Value { get; set; }

        
    }
}
