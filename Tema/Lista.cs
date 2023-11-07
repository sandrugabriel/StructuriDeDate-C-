using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    public class Lista : ILista
    {

        private Node head = null;


        public void addStart(int nr)
        {


            if (head == null)
            {

                head = new Node();

                head.Next = null;
                head.Data = nr;
            }
            else
            {
                Node nou = new Node();
                nou.Next = head;
                nou.Data = nr;
                head = nou;

            }

        }

        public Node getHead()
        {
            return head;
        }

        public void afisare()
        {


            Node aux = head;


            while (aux != null)
            {

                Console.WriteLine(aux.Data + " ");
                aux = aux.Next;
            }

        }

        public void addEnd(int nr)
        {

            if (head == null)
            {

                head = new Node();

                head.Next = null;
                head.Data = nr;
            }
            else
            {


                Node aux = head;

                while (aux.Next != null)
                {

                    aux = aux.Next;
                }


                Node nou = new Node();

                nou.Next = null;
                nou.Data = nr;
                aux.Next = nou;

            }


        }

        public void addPoz(int nr, int poz)
        {


            if (head == null)
            {

                head = new Node();

                head.Next = null;
                head.Data = nr;
            }
            else
            {

                Node aux = head;

                int ct = 0;

                if (poz == 0)
                {
                    addStart(nr);
                    return;
                }

                while (ct < poz - 1)
                {

                    aux = aux.Next;
                    ct++;
                }

                if (aux.Next == null)
                {

                    addEnd(nr);
                    return;
                }

                Node nou = new Node();
                nou.Next = aux.Next;
                nou.Data = nr;
                aux.Next = nou;

            }


        }

        public void stergereaPrimElement()
        {

            head = head.Next;

        }

        public void stergereUltim()
        {

            Node aux = head;

            while (aux.Next.Next != null)
            {
                aux = aux.Next;
            }

            aux.Next = null;

        }

        public void stergerePoz(int poz)
        {

            Node aux = head;

            int ct = 0;

            if (poz == 0)
            {
                stergereaPrimElement();
                return;
            }

            while (ct < poz - 1)
            {
                aux = aux.Next;
                ct++;
            }

            if (aux.Next == null)
            {
                stergereUltim();
                return;
            }

            aux.Next = aux.Next.Next;

        }

        public int size()
        {

            Node aux = head;
            int ct = 0;
            while (aux.Next != null)
            {
                aux = aux.Next;
                ct++;
            }

            return ct + 1;
        }

        public int getPoz(int poz)
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

        public void setPoz(int poz, int nr)
        {
            Node aux = head;
            int ct = 0;
            while (ct < poz)
            {
                aux = aux.Next;
                ct++;
            }

            aux.Data = nr;


        }

        public void afisareDreapta(int dim)
        {

            Node aux = head;
            for (int i = dim; i >= 1; i--)
            {
                int ct = 0;

                while (ct < i - 1)
                {
                    aux = aux.Next;
                    ct++;
                }

                Console.WriteLine(aux.Data + " ");
                aux = head;
            }


        }

        public int sumParePoz(int dim)
        {

            int s = 0;

            Node aux = head;

            for (int i = 1; i <= dim; i++)
            {

                if (i % 2 == 0)
                    s += aux.Data;
                aux = aux.Next;

            }


            return s;
        }

        public int sumPare(int dim)
        {

            int s = 0;

            Node aux = head;

            for (int i = 0; i < dim; i++)
            {

                if (aux.Data % 2 == 0)
                    s += aux.Data;
                aux = aux.Next;

            }


            return s;
        }

        public int ctdiv10(int dim)
        {

            int ct = 0;

            Node aux = head;

            for (int i = 1; i <= dim; i++)
            {

                if (aux.Data % 10 == 0)
                    ct++;
                aux = aux.Next;

            }


            return ct;
        }

        public int maxi(int dim)
        {
            Node aux = head;
            int maxi = -1;

            for (int i = 0; i < dim; i++)
            {

                if (aux.Data > maxi)
                    maxi = aux.Data;

                aux = aux.Next;
            }

            return maxi;
        }

        public int mini(int dim)
        {
            Node aux = head;
            int mini = 99999;

            for (int i = 0; i < dim; i++)
            {

                if (aux.Data < mini)
                    mini = aux.Data;

                aux = aux.Next;
            }

            return mini;
        }

        public void nextI(int i, Node aux)
        {

            int ct = 0;

            while (ct < i)
            {
                aux = aux.Next;
                ct++;
            }

        }

        public int ctPerechiCifZeci(int dim)
        {

            Node aux = head;
            Node nou = head;
            int ct = 0;

            for (int i = 0; i < dim; i++)
            {
                nou = head;
                nextI(i + 1, nou);

                for (int j = 0; j < dim; j++)
                {

                    if ((nou.Data != aux.Data) && ((nou.Data / 10) % 10 == (aux.Data / 10) % 10))
                    {
                        ct++;
                    }

                    if (nou.Next == null)
                    {
                        j = dim;
                        break;
                    }
                    nou = nou.Next;
                }

                aux = aux.Next;
            }

            return ct / 2;


        }

        public int sumdiv3(int dim)
        {

            int s = 0;

            Node aux = head;

            for (int i = 1; i <= dim; i++)
            {

                if (aux.Data % 3 == 0 && i % 2 == 1)
                    s += aux.Data;
                aux = aux.Next;

            }


            return s;
        }

        public int sumaCif(int nr)
        {

            int s = 0;

            while (nr != 0)
            {
                int c = nr % 10;
                s += c;
                nr /= 10;
            }

            return s;
        }

        public int ctPerechiSumEgal(int dim)
        {

            Node aux = head;
            Node nou = head;
            int ct = 0;

            for (int i = 0; i < dim; i++)
            {
                nou = head;
                nextI(i + 1, nou);

                for (int j = 0; j < dim; j++)
                {

                    if ((nou.Data != aux.Data) && (sumaCif(nou.Data) == sumaCif(aux.Data)))
                    {
                        ct++;
                    }

                    if (nou.Next == null)
                    {
                        j = dim;
                        break;
                    }
                    nou = nou.Next;
                }

                aux = aux.Next;
            }

            return ct / 2;


        }

        public void setHead(Node head)
        {
            this.head = head;
        }

        public void addRestulImp(int dim, ILista list)
        {

            for (int i = 0; i < dim; i++)
            {
                int nr = list.getHead().Data;
                int sumacif = sumaCif(list.getHead().Data);
                addEnd(nr % sumacif);

                list.setHead(list.getHead().Next);
            }

        }

        public void afisareInversaImpar(int dim)
        {

            Node aux = head;
            for (int i = dim; i >= 1; i--)
            {
                int ct = 0;

                while (ct < i - 1)
                {
                    aux = aux.Next;
                    ct++;
                }
                if (aux.Data % 2 == 1)
                    Console.WriteLine(aux.Data + " ");
                aux = head;
            }



        }

        public bool prim(int nr)
        {

            if (nr == 0 || nr == 1)
                return false;

            for (int i = 2; i <= nr / 2; i++)
                if (nr % i == 0)
                    return false;

            return true;
        }

        public void addPrime(int dim, ILista list)
        {

            for (int i = 0; i < dim; i++)
            {

                if (prim(list.getHead().Data))
                {
                    addStart(list.getHead().Data);
                }

                list.setHead(list.getHead().Next);
            }

        }

        public int getUltimulNr(int dim)
        {

            Node aux = head;

            for (int i = 0; i < dim - 1; i++)
                aux = aux.Next;

            return aux.Data;
        }

        public int ctIntervalAfara(int dim)
        {

            Node aux = head;

            int ct = 0;
            int ultim = getUltimulNr(dim);
            int primul = aux.Data;
            for (int i = 0; i < dim; i++)
            {
                if (aux.Data < primul && aux.Data > ultim)
                    ct++;

                aux = aux.Next;
            }

            return ct;
        }

        public int divizorComun(int n, int m)
        {

            while (m != 0)
            {
                int r = n % m;
                n = m;
                m = r;
            }

            return n;
        }

        public int ctPerechiPrime(int dim)
        {

            Node aux = head;

            int ct = 0;

            for (int i = 0; i < dim; i++)
            {
                int n, m;
                n = aux.Data;
                Node nou = head;
                for (int j = 0; j < dim; j++)
                {
                    m = nou.Data;
                    if (divizorComun(n, m) == 1) ct++;
                    nou = nou.Next;
                }

                aux = aux.Next;
            }

            return ct / 2;
        }

        public int ctEgalUiltim(int dim)
        {

            Node aux = head;

            int ct = 0;

            for (int i = 0; i < dim; i++)
            {
                if (aux.Data == getUltimulNr(dim))
                    ct++;

                aux = aux.Next;
            }

            return ct;

        }

        public int ctNrPrime(int dim)
        {

            Node aux = head;

            int ct = 0;

            for (int i = 0; i < dim; i++)
            {
                if (prim(aux.Data))
                    ct++;

                aux = aux.Next;
            }

            return ct;


        }

        public int ctNr(int nr)
        {
            int ct = 0;
            while (nr != 0)
            {
                ct++;
                nr /= 10;
            }
            return ct;
        }

        public bool verifPatratPerfect(int nr)
        {

            int ctnr = ctNr(nr);
            if (ctnr > 2)
            {
                double rez = Math.Pow(10, ctnr - 2);

                nr = nr / ((int)rez);
            }

            if (Math.Sqrt(nr) == (int)Math.Sqrt(nr))
                return true;

            return false;
        }

        public void afisarePatratPerf(int dim)
        {

            Node aux = head;

            int ct = 0;

            for (int i = 0; i < dim; i++)
            {
                if (verifPatratPerfect(aux.Data))
                    Console.WriteLine(aux.Data + " ");


                aux = aux.Next;
            }


        }

        public void afisareSumele(int dim)
        {

            int ct = dim;
            while (ct >= 1)
            {

                Node aux = head;
                int s = 0;
                for (int i = 0; i < ct; i++)
                {

                    s += aux.Data;
                    aux = aux.Next;
                }
                Console.WriteLine(s + "\n");

                ct--;
            }




        }

        public void stergerePare(int dim)
        {

            Node aux = head;
            for (int i = 0; i < dim; i++)
            {

                if (aux.Data % 2 == 0)
                {
                    dim--;
                    i--;
                    stergerePoz(i);
                    aux = head;
                }

                aux = aux.Next;

            }

        }

        public void stergereaPrime(int dim)
        {

            Node aux = head;
            for (int i = 0; i < dim; i++)
            {

                if (prim(aux.Data))
                {
                    dim--;
                    stergerePoz(i);
                    aux = head;
                }

                aux = aux.Next;

            }




        }

        public void inserareMini(int dim, int mini)
        {

            Node aux = head;
            for (int i = 0; i < dim; i++)
            {

                if (aux.Data == mini)
                {
                    setPoz(i - 1, mini);
                }

                aux = aux.Next;

            }




        }

        public void stergereEgaleMini(int dim, int mini)
        {

            Node aux = head;
            for (int i = 0; i < dim; i++)
            {

                if (aux.Data == mini)
                {
                    dim--;
                    stergerePoz(i);
                    i = 0;
                    aux = head;
                }

                aux = aux.Next;

            }



        }

        public bool palindrom(int nr)
        {
            int a = nr;
            int t = 0;
            while (nr != 0)
            {
                int c = nr % 10;
                t = t * 10 + c;
                nr = nr / 10;
            }

            if (a == t) return true;

            return false;
        }

        public void afisarePelindrom(int dim)
        {

            Node aux = head;
            int ct = 0, ct1 = 0;
            for (int i = 0; i <= dim / 2; i++)
            {
                if (ct % 2 == 0)
                {
                    if (palindrom(aux.Data))
                    {
                        Console.WriteLine(aux.Data + " ");
                        ct++;
                        aux = aux.Next;
                    }
                }
                else
                {
                    ct1++;
                    for (int j = 0; j < ct1; j++)
                    {
                        Node nou1 = head;
                        int n = 0;
                        while (n < dim - ct1)
                        {
                            nou1 = nou1.Next;
                            n++;
                        }
                        if (palindrom(nou1.Data))
                        {
                            Console.WriteLine(nou1.Data + " ");
                            j = dim + 1;
                            ct++;
                            aux = aux.Next;
                        }
                        ct1++;
                    }

                }


            }




        }

        public void addDublu(int dim)
        {

            Node aux = head;
            for (int i = 0; i < dim; i++)
            {

                if (aux.Data % 2 == 0)
                {
                    addPoz(aux.Data * 2, i);
                    aux = head;
                }

                aux = aux.Next;

            }



        }

        public void inserareRadacina(int dim)
        {

            Node aux = head;
            for (int i = 0; i < dim; i++)
            {

                if (verifPatratPerfect(aux.Data))
                {
                    double rez = Math.Sqrt(aux.Data);
                    addPoz(((int)rez), i);
                    i++;
                }

                aux = aux.Next;

            }

        }

        public void afisarePermutari(int dim)
        {

            Node aux = head;

            for (int i = 0; i < dim; i++)
            {

                afisare();
                permutarestangaDreapta(dim);
                Console.WriteLine("\n");
            }


        }

        public bool verificareImpare(int dim)
        {

            Node aux = head;

            for (int i = 0; i < dim; i++)
            {
                if (aux.Data % 2 == 1)
                {
                    return true;
                }

                aux = aux.Next;
            }



            return false;
        }

        public void afisareFactorial(int dim)
        {

            Node aux = head;

            int fact = factorial(dim);

            for (int i = 0; i < dim; i++)
            {
                if (fact % aux.Data == 0)
                    Console.WriteLine(aux.Data + " ");



                aux = aux.Next;
            }

        }

        public int factorial(int n)
        {
            int fact = 1;

            for (int i = 1; i <= n; i++)
                fact = i;

            return fact;
        }

        public void permutarestangaDreapta(int dim)
        {

            Node aux = head;
            int i = 0;
            int nr1 = aux.Data;

            for (i = 0; i < dim - 1; i++)
            {

                aux.Data = aux.Next.Data;

                aux = aux.Next;
            }

            aux.Data = nr1;
        }


    }
}
