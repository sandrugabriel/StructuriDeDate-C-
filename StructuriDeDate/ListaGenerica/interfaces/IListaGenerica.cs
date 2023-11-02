using StructuriDeDate.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.ListaGenerica.interfaces
{
    public interface IListaGenerica<T> where T : IComparable<T>
    {

        Node<T> getHead();

        void addStart(T data);

        void addEnd(T data);

        void afisare();

        void removeStart();

        void removeEnd();

        void crescator();

        void descrescator();

        int size();

    }
}
