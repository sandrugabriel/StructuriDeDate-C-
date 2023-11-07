using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    public interface ILista
    {

        void addStart(int nr);

        Node getHead();

        void afisare();

        void addEnd(int nr);

        void addPoz(int nr, int poz);

        void stergereaPrimElement();

        void stergereUltim();

        void stergerePoz(int poz);

        int size();

        int getPoz(int poz);

        void setPoz(int poz, int nr);

        void afisareDreapta(int dim);


        int sumParePoz(int dim);

        int sumPare(int dim);

        int ctdiv10(int dim);

        void nextI(int i, Node aux);

        int ctPerechiCifZeci(int dim);

        int sumdiv3(int dim);

        int sumaCif(int nr);

        int ctPerechiSumEgal(int dim);

        void addRestulImp(int dim, ILista list);

        void afisareInversaImpar(int dim);

        bool prim(int nr);

        void addPrime(int dim, ILista list);

        int getUltimulNr(int dim);

        int ctIntervalAfara(int dim);

        int divizorComun(int n, int m);

        int ctPerechiPrime(int dim);

        int ctEgalUiltim(int dim);

        int ctNrPrime(int dim);

        int ctNr(int nr);

        bool verifPatratPerfect(int nr);

        void afisarePatratPerf(int dim);

        void afisareSumele(int dim);

        void stergerePare(int dim);

        void stergereaPrime(int dim);

        void inserareMini(int dim, int mini);

        void stergereEgaleMini(int dim, int mini);

        bool palindrom(int nr);

        void afisarePelindrom(int dim);

        void addDublu(int dim);

        void inserareRadacina(int dim);

        void afisarePermutari(int dim);

        bool verificareImpare(int dim);

        void afisareFactorial(int dim);

        int factorial(int n);

        void permutarestangaDreapta(int dim);

        void setHead(Node head);


        int maxi(int dim);

        int mini(int dim);

    }
}
