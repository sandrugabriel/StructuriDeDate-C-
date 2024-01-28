using StructuriDeDate.ArboriBinari;
using StructuriDeDate.Arborii;
using StructuriDeDate.ArboriN;
using StructuriDeDate.Coada;
using StructuriDeDate.Coada.interfaces;
using StructuriDeDate.HashTable;
using StructuriDeDate.HashTable.interfaces;
using StructuriDeDate.ListaGenerica;
using StructuriDeDate.ListaGenerica.interfaces;
using StructuriDeDate.Models.Car;
using StructuriDeDate.Models.Users;
using StructuriDeDate.Stiva;
using StructuriDeDate.Stiva.interfaces;

internal class Program
{
    private static void Main(string[] args)
    {

        Car car = new Car(1,"X","Tesla",2020);
        Car car1 = new Car(2, "6", "Golf", 2014);
        Car car2 = new Car(3,"S", "Tesla",2016);


        IHashTable<String, Car> hashTable = new HashTable<String,Car>(10);

        hashTable.Put("CarT",car);

        hashTable.Put("Car1", car2);
        hashTable.Put("CarT2", car1);
        Car test = hashTable.Get("CarT2");
        Console.WriteLine(test.descriere());
    }
}