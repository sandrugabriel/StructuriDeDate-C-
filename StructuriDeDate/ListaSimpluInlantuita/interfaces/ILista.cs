using StructuriDeDate.ListaSimpluInlantuita;
using StructuriDeDate.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.ListaSimpluInlantuita.interfaces
{
    public interface ILista
    {

        Node getHead();

        void addStart(User user);

        void addEnd(User user);

        void afisare();

        void removeStart();

        void removeEnd();

        void crescator();

        void descrescator();

        User cautare(User node);
    }
}
