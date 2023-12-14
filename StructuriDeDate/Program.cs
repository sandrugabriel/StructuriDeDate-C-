using StructuriDeDate.ArboriBinari;
using StructuriDeDate.Arborii;
using StructuriDeDate.Coada;
using StructuriDeDate.Coada.interfaces;
using StructuriDeDate.ListaGenerica;
using StructuriDeDate.ListaGenerica.interfaces;
using StructuriDeDate.Models.Users;
using StructuriDeDate.Stiva;
using StructuriDeDate.Stiva.interfaces;

internal class Program
{
    private static void Main(string[] args)
    {


        //Lista Simplu Inlantuita
        //
        //
        /*
                ILista lista = new Lista();

                lista.addStart(user);
                lista.addStart(user2);
                lista.addStart(user3);
                lista.addEnd(user4);
                lista.addStart(user5);

                lista.removeStart();
                lista.removeEnd();


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
        /*
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

                        users.afisare();*/

        //
        //

        //Coada
        /*
                ICoada<User> coada = new Coada<User>();

                coada.push(user);
                coada.push(user2);
                coada.push(user3);
                coada.push(user4);
                coada.push(user5);
                coada.pop();
                coada.pop();

                coada.afisare();
        */
        //
        //

        //Stiva

        /*    IStiva<User> stiva = new Stiva<User>();

            stiva.push(user);
            stiva.push(user2);
            stiva.push(user3);
            stiva.push(user4);
            stiva.push(user5);
            stiva.pop();
            stiva.pop();

            stiva.afisare();
    */

        /*        Ierarhie ierarhie = new Ierarhie();
                ierarhie.add("null", "CEO");
                ierarhie.add("CEO", "Deputy Director");
                ierarhie.add("Deputy Director","IT");
                ierarhie.add("Deputy Director", "Marketing");
                ierarhie.add("IT", "Security");
                ierarhie.add("IT", "App");
                ierarhie.add("Marketing", "Logic");
                ierarhie.add("Marketing", "Relations");
                *//*
                        Console.WriteLine("Right:");
                        Console.WriteLine(ierarhie.getTreeNode().Data);
                        Console.WriteLine(ierarhie.getTreeNode().Right.Data);
                        Console.WriteLine(ierarhie.getTreeNode().Right.Right.Data);
                        Console.WriteLine(ierarhie.getTreeNode().Right.Left.Data);

                        Console.WriteLine("\nLeft:");
                        Console.WriteLine(ierarhie.getTreeNode().Data);
                        Console.WriteLine(ierarhie.getTreeNode().Left.Data);
                        Console.WriteLine(ierarhie.getTreeNode().Left.Right.Data);
                        Console.WriteLine(ierarhie.getTreeNode().Left.Left.Data);*//*

                ierarhie.afisare();*/

        User user = new User(1, "F", "", "", 18);
        User user2 = new User(2, "D", "", "", 11);
        User user3 = new User(3, "J", "", "", 26);
        User user4 = new User(4, "B", "", "", 7);
        User user5 = new User(5, "E", "", "", 12);
        User user6 = new User(6, "G", "", "", 22);
        User user7 = new User(7, "K", "", "", 29);
        User user8 = new User(8, "A", "", "", 6);
        User user9 = new User(9, "C", "", "", 8);
        User user10 = new User(10, "I", "", "", 25);
        User user11 = new User(11, "H", "", "", 23);


        ArboriBinari<User> arborebinar = new ArboriBinari<User>();
        arborebinar.add(user, arborebinar.getNode());
        arborebinar.add(user2, arborebinar.getNode());
        arborebinar.add(user3, arborebinar.getNode());
        arborebinar.add(user4, arborebinar.getNode());
        arborebinar.add(user5, arborebinar.getNode());
        arborebinar.add(user6, arborebinar.getNode());
        arborebinar.add(user7, arborebinar.getNode());
        arborebinar.add(user8, arborebinar.getNode());
        arborebinar.add(user9, arborebinar.getNode());
        arborebinar.add(user10, arborebinar.getNode());
        arborebinar.add(user11, arborebinar.getNode());


        // arborebinar.afisare();
        /*
                User useNull = new User();
                User usermini = new User(0, "", "", "", 1000);

                arborebinar.maximul(useNull);
                arborebinar.minimul(usermini);*/
        Console.WriteLine("\n\nAFISAREA PE NIVELE:\n");
        arborebinar.afisare();

        Console.WriteLine("\n\nAFISAREA IN PREORDINE:\n");
        arborebinar.afisarePreordine(arborebinar.getNode());

        Console.WriteLine("\n\nAFISAREA IN INORDINE:\n");
        arborebinar.afisareiInordine(arborebinar.getNode());

        Console.WriteLine("\n\nAFISAREA IN POSTORDINE:\n");
        arborebinar.afisarePostordine(arborebinar.getNode());
    }
}