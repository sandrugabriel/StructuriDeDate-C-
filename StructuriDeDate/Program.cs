using StructuriDeDate.Lista.ListaSimpluInlantuita;
using StructuriDeDate.Lista.ListaSimpluInlantuita.interfaces;
using StructuriDeDate.Models.Users;

internal class Program
{
    private static void Main(string[] args)
    {
        ILista lista = new Lista();

        User user = new User(1,"test","test@e.com","1234");
        User user2 = new User(2, "test1", "tes1t@e.com", "1234");
        User user3 = new User(3, "test2", "test2@e.com", "1234");
        User user4 = new User(4, "test3", "test3@e.com", "1234");
        User user5 = new User(5, "test4", "test4@e.com", "1234");

        lista.addStart(user);
        lista.addStart(user2);
        lista.addStart(user3);
        lista.addEnd(user4);
        lista.addStart(user5);
        /*
                lista.removeStart();
                lista.removeEnd();
        */

        lista.crescator();
        lista.descrescator();


        lista.afisare();

       Console.WriteLine(lista.cautare(user4).descriere());

    }
}