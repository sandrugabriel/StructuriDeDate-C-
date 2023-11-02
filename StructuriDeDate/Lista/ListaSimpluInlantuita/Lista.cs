using StructuriDeDate.Lista.ListaSimpluInlantuita.interfaces;
using StructuriDeDate.Models.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.Lista.ListaSimpluInlantuita
{
    public class Lista : ILista
    {
        private Node head = null;


        public Node getHead()
        {
            return head;
        }

        public void addStart(User user)
        {
            if (head == null)
            {
                head = new Node();
                head.Next = null;
                head.Data = user;
            }
            else
            {
                Node nou = new Node();

                nou.Next = head;
                nou.Data = user;
                head = nou;

            }
        }

        public void addEnd(User user)
        {

            if (head == null)
            {
                head = new Node();
                head.Next = null;
                head.Data = user;
            }
            else
            {
                Node nou = new Node();

                Node aux = head;

                while (aux.Next != null)
                {

                    aux = aux.Next;

                }


                nou.Next = null;
                nou.Data = user;
                aux.Next = nou;
            }

        }

        public void afisare()
        {
            Node aux = head;

            while (aux != null)
            {

                Console.WriteLine(aux.Data.descriere());
                aux = aux.Next;
            }

        }

        public void removeStart()
        {
            head = head.Next;
        }

        public void removeEnd()
        {
            Node aux = head;

            while (aux.Next.Next != null)
            {
                aux = aux.Next;
            }

            aux.Next = null;

        }

        public int size()
        {

            Node aux = head;

            int ct = 0;

            while (aux != null)
            {
                ct++;
                aux = aux.Next;
            }

            return ct;
        }

        User getPoz(int poz)
        {

            Node aux = head;

            int ct = 0;

            while (ct < poz)
            {
                aux = aux.Next;
                ct++;
            }

            return aux.Data;
        }

        public void setPoz(int poz, User user)
        {

            Node aux = head;

            int ct = 0;

            while (ct < poz)
            {
                aux = aux.Next;
                ct++;
            }

            aux.Data = user;
        }

        public void crescator()
        {

            Node aux = head;

            int semn = 1, dim = size();
            Console.WriteLine(dim.ToString());
            do
            {
                semn = 1;
                aux = head;

                for (int i = 0; i < dim - 1; i++)
                {
                    if (aux.Data.getId() > aux.Next.Data.getId())
                    {
                        User user = getPoz(i);
                        setPoz(i, getPoz(i + 1));
                        setPoz(i + 1, user);
                        semn = 0;
                    }

                    aux = aux.Next;
                }




            } while (semn == 0);


        }

        public void descrescator()
        {

            Node aux = head;

            int semn = 1, dim = size();
            Console.WriteLine(dim.ToString());
            do
            {
                semn = 1;
                aux = head;

                for (int i = 0; i < dim - 1; i++)
                {
                    if (aux.Data.getId() < aux.Next.Data.getId())
                    {
                        User user = getPoz(i);
                        setPoz(i, getPoz(i + 1));
                        setPoz(i + 1, user);
                        semn = 0;
                    }

                    aux = aux.Next;
                }




            } while (semn == 0);


        }

        public User cautare(User user)
        {
            Node aux = head;

            for (int i = 0; i < size(); i++)
            {
                if (aux.Data == user)
                {
                    Console.WriteLine("Exista");
                    return aux.Data;
                }
                aux = aux.Next;
            }

            return null;
        }

    }
}
