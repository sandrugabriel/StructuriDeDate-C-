using StructuriDeDate.ListaGenerica;
using StructuriDeDate.ListaGenerica.interfaces;
using StructuriDeDate.Models.Users;

namespace TesteListe
{
    public class ListaGenerica
    {

        IListaGenerica<User> users;

        [Fact]
        public void Test1()
        {

            User user = new User(1, "test", "test@e.com", "1234", 18);
            User user2 = new User(2, "test1", "tes1t@e.com", "1234", 19);
            User user3 = new User(3, "test2", "test2@e.com", "1234", 18);
            User user4 = new User(4, "test3", "test3@e.com", "1234", 17);
            User user5 = new User(5, "test4", "test4@e.com", "1234", 20);

            users = new ListaGenerica<User>();  

            users.addStart(user);
            users.addStart(user2);
            users.addStart(user3);
            users.addStart(user4);
            users.addEnd(user5);

            Assert.Equal(user4,users.getHead().Value);

            Assert.NotEqual(user2,users.getHead().Next.Value);

            users.crescator();

            Assert.Equal(17,users.getHead().Value.getAge());
            Assert.NotEqual(20, users.getHead().Next.Value.getAge());

            users.descrescator();

            Assert.Equal(20, users.getHead().Value.getAge());

        }
    }
}