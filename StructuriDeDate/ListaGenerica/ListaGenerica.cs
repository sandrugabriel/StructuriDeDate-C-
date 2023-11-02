using StructuriDeDate.ListaSimpluInlantuita;
using StructuriDeDate.ListaGenerica.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.ListaGenerica
{
    public class ListaGenerica<T> : IListaGenerica<T> where T : IComparable<T>
    {

        private Node<T> head = null;

        public Node<T> getHead() { return head; }

        public void addStart(T data)
        {

            if (head == null)
            {
                head = new Node<T>();
                head.Value = data;
                head.Next = null;
            }
            else
            {
                Node<T> nou = new Node<T>();

                nou.Value = data;
                nou.Next = head;
                head = nou;

            }
        }

        public void addEnd(T data)
        {

            if (head == null)
            {
                head = new Node<T>();
                head.Value = data;
                head.Next = null;
            }
            else
            {

                Node<T> aux = head;

                while (aux.Next != null)
                {
                    aux = aux.Next;
                }

                Node<T> nou = new Node<T>();

                nou.Value = data;
                nou.Next = null;
                aux.Next = nou;

            }

        }

        public void afisare()
        {
            Node<T> aux = head;

            while (aux != null)
            {
                Console.WriteLine(aux.Value.ToString());
                aux = aux.Next;
            }
        }


        public void removeStart()
        {
            head = head.Next;
        }

        public void removeEnd()
        {
            Node<T> aux = head;

            while (aux.Next.Next != null)
            {
                aux = aux.Next;
            }

            aux.Next = null;

        }

        public int size()
        {

            Node<T> aux = head;

            int ct = 0;

            while (aux != null)
            {
                ct++;
                aux = aux.Next;
            }

            return ct;
        }

        T getPoz(int poz)
        {

            Node<T> aux = head;

            int ct = 0;

            while (ct < poz)
            {
                aux = aux.Next;
                ct++;
            }

            return aux.Value;
        }

        public void setPoz(int poz, T value)
        {

            Node<T> aux = head;

            int ct = 0;

            while (ct < poz)
            {
                aux = aux.Next;
                ct++;
            }

            aux.Value = value;
        }

        public void crescator()
        {

            Node<T> aux = head;

            int semn = 1, dim = size();
            //   Console.WriteLine(dim.ToString());
            do
            {
                semn = 1;
                aux = head;

                for (int i = 0; i < dim - 1; i++)
                {
                    int compare = aux.Value.CompareTo(aux.Next.Value);

                    if (compare == 1)
                    {
                        T nou = getPoz(i);
                        setPoz(i, getPoz(i + 1));
                        setPoz(i + 1, nou);
                        semn = 0;
                    }

                    aux = aux.Next;
                }




            } while (semn == 0);


        }

        public void descrescator()
        {

            Node<T> aux = head;

            int semn = 1, dim = size();
            Console.WriteLine(dim.ToString());
            do
            {
                semn = 1;
                aux = head;

                for (int i = 0; i < dim - 1; i++)
                {
                    int compare = aux.Value.CompareTo(aux.Next.Value);
                    if (compare == -1)
                    {
                        T nou = getPoz(i);
                        setPoz(i, getPoz(i + 1));
                        setPoz(i + 1, nou);
                        semn = 0;
                    }

                    aux = aux.Next;
                }




            } while (semn == 0);


        }

    }
}
