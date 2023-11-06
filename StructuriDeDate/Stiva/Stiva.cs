using StructuriDeDate.Stiva.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.Stiva
{
    public class Stiva<T> : IStiva<T> where T : IComparable<T>
    {

        private Node<T> head = null;

        public Node<T> getHead() { return head; }

        public void push(T value)
        {

            if (head == null)
            {
                head = new Node<T>();
                head.Value = value;
                head.Next = null;
            }
            else
            {
                Node<T> nou = new Node<T>();

                nou.Value = value;
                nou.Next = head;
                head = nou;

            }

        }

        public void pop()
        {
            head = head.Next;
        }

        public bool empty()
        {
            if (head == null) return true;
            return false;
        }

        public T top()
        {
            return head.Value;
        }
        

        public void afisare()
        {
            Node<T> aux = head;

            while(aux != null)
            {
                Console.WriteLine(aux.Value.ToString());
                aux = aux.Next;
            }
        } 

    }
}
