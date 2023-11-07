using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    public class Solutii
    {

        private ILista list;

        public Solutii()
        {

            list = new Lista();

        }


        /*#492
        Să se determine suma numerelor divizibile cu 3 și aflate pe poziții impare.
        Ex:
        10
        1 2 3 4 5 6 7 8 9 10
        se afiseaza 12
        */
        public void solutia1()
        {

            int dim = 10;
            int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            Console.WriteLine(list.sumdiv3(dim));
        }

        /*#4286
        Se dă un vector x cu n elemente, numere naturale. Să se construiască un alt vector, y, care să conțină 
        elementele impare din x, în ordine inversă.
        Ex:
        6
        50 5 15 29 13 40
        se afiseaza 
        13 29 15 5*/
        public void solutia2()
        {

            int dim = 6;
            int[] v = { 50, 5, 15, 29, 13, 40 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.afisareInversaImpar(dim);

        }

        /*#493
        Se dă un vector x cu n elemente, numere naturale. Să se construiască un alt vector, y, cu proprietatea că y[i] este egal
        cu restul împărțirii lui x[i] la suma cifrelor lui x[i].
        Ex:
        6
        50 1815 15 289 35 40
        se afiseaza 0 0 3 4 3 0
        */
        public void solutia3()
        {

            int dim = 6;
            int[] v = { 50, 1815, 15, 289, 35, 40 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            ILista y = new Lista();

            y.addRestulImp(dim, list);
            y.afisare();

        }


        /*#986
        Se dă un șir cu n elemente, numere reale. Să se determine câte dintre elemente se află în afara intervalului închis
        determinat de primul și ultimul element.
        Ex:
        6
        2 0 4 -1 -8 -3 se afiseaza 2
        */
        public void solutia4()
        {

            int dim = 6;
            int[] v = { 2, 0, 4, -1, -8, -3 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            Console.WriteLine(list.ctIntervalAfara(dim));
        }

        /*#4381
        Se dă un vector cu n numere naturale. Să se determine câte dintre perechile de elemente egal 
        depărtate de capetele vectorului au aceeași cifră a zecilor.
        Ex:
        6
        145 207 56 1248 1001 249
        se afiseaza 4
        */
        public void solutia5()
        {

            int dim = 6;
            int[] v = { 145, 207, 56, 1248, 1001, 249 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            Console.WriteLine(list.ctPerechiCifZeci(dim));

        }

        /*#1550
        Se da un vector cu n elemente. Sa se afișeze pe ecran elementele din vector care divid factorialul numărului de elemente n.
        Ex:
        5
        16 3 71 30 25
        se afiseaza 3 30
        */
        public void solutia6()
        {

            int dim = 5;
            int[] v = { 16, 3, 71, 30, 25 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.afisareFactorial(dim);
        }

        /*#162
        Se dă un vector cu n elemente numere naturale. Determinați toate permutările circulare spre stânga ale vectorului.
        Ex:
        5
        7 2 8 4 5
        se afiseaza
        7 2 8 4 5
        2 8 4 5 7
        8 4 5 7 2
        4 5 7 2 8
        5 7 2 8 4*/
        public void solutia7()
        {

            int dim = 5;
            int[] v = { 7, 2, 8, 4, 5 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.afisarePermutari(dim);
        }

        /*
        #289
        Se dă un şir cu n elemente, numere naturale. Să se verifice dacă în şir există elemente impare.
        Ex:
        5
        2 8 6 10 8
        se afiseaza 0
        */
        public void solutia8()
        {

            int dim = 5;
            int[] v = { 2, 8, 6, 10, 8 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            Console.WriteLine(list.verificareImpare(dim));
        }
        /*#495
        Se dă un vector x cu n elemente, numere naturale. Să se construiască un alt vector, y, care să conțină elementele prime
        din x, în ordine inversă.
        Ex:
        6
        50 5 15 29 13 40
         se afiseaza 13 29 5
        */
        public void solutia9()
        {

            int dim = 6;
            int[] v = { 50, 5, 15, 29, 13, 40 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);
            ILista y = new Lista();

            y.addPrime(dim, list);
            y.afisare();
        }

        /*#499
        Se dă un vector cu n numere naturale. Să se determine câte dintre perechile de elemente din vector sunt
        formate din valori cu aceeași sumă a cifrelor.
        Ex:
        6
        51 842 15 28 77 132
        se afiseaza 4
        */
        public void solutia10()
        {

            int dim = 6;
            int[] v = { 51, 842, 15, 28, 77, 132 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            Console.WriteLine(list.ctPerechiSumEgal(dim));
        }


        /*#498
        Se dă un vector cu n numere naturale. Să se determine câte dintre perechile de elemente din vector sunt prime între ele.
        Ex:
        6
        51 18 15 28 77 121 se afiseaza 9
        */
        public void solutia11()
        {

            int dim = 6;
            int[] v = { 51, 18, 15, 28, 77, 121 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            Console.WriteLine(list.ctPerechiPrime(dim));

        }

        /*#99
        Se dă un șir cu n elemente numere naturale. Să se determine câte elemente din şir sunt egale cu ultimul element al acestuia.
        Ex:5
        5 3 2 4 5
        se afiseaza 2
        */
        public void solutia12()
        {

            int dim = 5;
            int[] v = { 5, 3, 2, 4, 5 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            Console.WriteLine(list.ctEgalUiltim(dim));
        }

        /*#100
        Se dă un șir cu n elemente numere naturale. Să se determine câte elemente din şir sunt numere prime.
        Ex:
        5
        25 17 2 10 13
        se afiseaza 3
        */
        public void solutia13()
        {

            int dim = 5;
            int[] v = { 25, 17, 2, 10, 13 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            Console.WriteLine(list.ctNrPrime(dim));
        }

        /*#132
        Să se afișeze elementele din șir care au proprietatea că primele două cifre din scrierea zecimală formează un pătrat perfect.
        Ex:
        5
        253 16 225 100 3678
        se afiseaza 253 16 3678
        */
        public void solutia14()
        {

            int dim = 5;
            int[] v = { 253, 16, 225, 100, 3678 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.afisarePatratPerf(dim);
        }

        /*#82
        Calculaţi valoarea minima minim si valoarea maxima maxim a celor n numere date.
        Ex:
        5
        8 2 9 4 5 
        se afiseaza 2 9*/
        public void solutia15()
        {

            int dim = 5;
            int[] v = { 8, 2, 9, 4, 5 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);
            Console.WriteLine(list.mini(dim) + " " + list.maxi(dim));
        }

        /*#237
        Se dă un şir cu n numere naturale. Să se afişeze suma primilor n termeni din şir, apoi suma
        primilor n-1 termeni din şir, şi aşa mai departe.
        Ex:
        4
        1 7 3 4
        se afiseaza
        15
        11
        8
        1
        */
        public void solutia16()
        {

            int dim = 4;
            int[] v = { 1, 7, 3, 4 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.afisareSumele(dim);

        }

        /*#163
        Se dă un vector cu n elemente numere naturale. Să se șteargă din vector toate elementele care sunt numere prime.
        Ex:
        5
        7 8 9 17 1
        se afiseaza
        8 9 1
        */
        public void solutia17()
        {

            int dim = 5;
            int[] v = { 7, 8, 9, 17, 1 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);
            list.stergereaPrime(dim);
            list.afisare();
        }

        /*#4386
        Se dă un vector cu n elemente numere naturale. Să se transforme vectorul, duplicând fiecare apariție a valorii minime.
        Ex:
        7
        7 9 4 2 1 6 1
        se afiseaza
        7 9 4 2 1 1 6 1 1
        */
        public void solutia18()
        {

            int dim = 7;
            int[] v = { 7, 9, 4, 2, 1, 6, 1 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);
            list.inserareMini(dim, list.mini(dim));
            list.afisare();
        }

        /*
        #4385
        Se dă un vector cu n elemente numere naturale. Să se șteargă din vector toate elementele 
        egale cu cea mai mică valoare din vector.
        Ex:
        7
        7 1 4 2 1 6 1
        se afiseaza
        7 4 2 6*/
        public void solutia19()
        {

            int dim = 7;
            int[] v = { 7, 1, 4, 2, 1, 6, 1 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.stergereEgaleMini(dim, list.mini(dim));
            list.afisare();
        }

        /*#2375
          Să se afișeze numerele palindrom din fișier în ordinea primul, ultimul, al doilea, penultimul etc.
        Ex:
        8
        11 21 303 4114 51 66 75 808
        se afiseaza 11 808 303 66 4114   */
        public void solutia20()
        {

            int dim = 8;
            int[] v = { 11, 21, 303, 4114, 51, 66, 75, 808 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.afisarePelindrom(dim);
        }

        /*
        #160
        Să se insereze în șir înaintea fiecărui element pătrat perfect rădăcina sa pătrată.
        Ex:
        5
        7 3 4 1 5
        se afiseaza
        7 3 2 4 1 1 5
        */
        public void solutia21()
        {

            int dim = 5, poz = 2, nr = 10;
            int[] v = { 7, 3, 4, 1, 5 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.inserareRadacina(dim);
            list.afisare();
        }

        /*
        #1453
        Se dă un vector cu n elemente numere naturale. Să se șteargă din vector toate elementele pare.
        Ex:
        7
        7 9 4 2 1 6 5
        se afiseaza
        7 9 1 5*/
        public void solutia22()
        {

            int dim = 7;
            int[] v = { 7, 9, 4, 2, 1, 6, 5 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.stergerePare(dim);
            list.afisare();
        }

        /*#158
         Se dă un șir cu n elemente întregi, valoare întreagă X și un număr p.
        Să se insereze pe poziția p în șir valoarea X.
        Ex:
        5 10 2
        7 3 9 1 6
        se afiseaza
        7 10 3 9 1 6*/
        public void solutia23()
        {

            int dim = 5, poz = 2, nr = 10;
            int[] v = { 7, 3, 9, 1, 6 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.addPoz(nr, poz - 1);
            list.afisare();
        }

        /*
        #159
        Să se insereze în șir după fiecare element par dublul său.
        Ex:
        5
        7 3 4 1 6
        se afiseaza
        7 3 4 8 1 6 12
        */
        public void solutia24()
        {

            int dim = 5, poz = 2, nr = 10;
            int[] v = { 7, 3, 4, 1, 6 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.addDublu(dim);
            list.afisare();


        }
        
        /*
        #1452
        Să se șteargă din șirul X elementul aflat pe poziția p.
        ex:
        5 2
        7 3 9 1 6
        se afiseaza 7 9 1 6*/
        public void solutia25()
        {

            int dim = 5, poz = 2;
            int[] v = { 7, 3, 9, 1, 6 };
            for (int i = 0; i < dim; i++)
                list.addEnd(v[i]);

            list.stergerePoz(poz - 1);
            list.afisare();
        }


    }
}
