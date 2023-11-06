using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.Stiva.interfaces
{
    public interface IStiva<T> where T : IComparable<T>
    {

        Node<T> getHead();

        void push(T value);

        void pop();

        bool empty();

        T top();

        void afisare();

    }
}
