using StructuriDeDate.ListaGenerica;
using StructuriDeDate.ListaGenerica.interfaces;
using StructuriDeDate.Models.Users;

internal class Program
{
    private static void Main(string[] args)
    {
        //Lista Simplu Inlantuita
        //
        //
        /*
                ILista lista = new Lista();

                User user = new User(1, "test", "test@e.com", "1234", 18);
                User user2 = new User(2, "test1", "tes1t@e.com", "1234", 19);
                User user3 = new User(3, "test2", "test2@e.com", "1234", 18);
                User user4 = new User(4, "test3", "test3@e.com", "1234", 17);
                User user5 = new User(5, "test4", "test4@e.com", "1234", 20);

                lista.addStart(user);
                lista.addStart(user2);
                lista.addStart(user3);
                lista.addEnd(user4);
                lista.addStart(user5);
                *//*
                        lista.removeStart();
                        lista.removeEnd();
                *//*

                lista.crescator();
                lista.descrescator();


                lista.afisare();

               Console.WriteLine(lista.cautare(user4).descriere());
        */
        //
        //

        //Lista Generica
        //
        //

        IListaGenerica<User> users = new ListaGenerica<User>();

        User user = new User(1, "test", "test@e.com", "1234", 18);
        User user2 = new User(2, "test1", "tes1t@e.com", "1234", 19);
        User user3 = new User(3, "test2", "test2@e.com", "1234", 18);
        User user4 = new User(4, "test3", "test3@e.com", "1234", 17);
        User user5 = new User(5, "test4", "test4@e.com", "1234", 20);

        users.addStart(user);
        users.addStart(user2);
        users.addStart(user3);
        users.addStart(user4);
        users.addEnd(user5);

        users.removeStart();

        users.descrescator();

        users.afisare();

    }
}