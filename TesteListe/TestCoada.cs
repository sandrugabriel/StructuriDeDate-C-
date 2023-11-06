using StructuriDeDate.Coada.interfaces;
using StructuriDeDate.Coada;
using StructuriDeDate.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteListe
{
    public class TestCoada
    {


        ICoada<User> coada;

        [Fact]
        public void Test1()
        {

            User user = new User(1, "test", "test@e.com", "1234", 18);
            User user2 = new User(2, "test1", "tes1t@e.com", "1234", 19);
            User user3 = new User(3, "test2", "test2@e.com", "1234", 18);
            User user4 = new User(4, "test3", "test3@e.com", "1234", 17);
            User user5 = new User(5, "test4", "test4@e.com", "1234", 20);

            coada = new Coada<User>();

            Assert.True(coada.empty());

            coada.push(user);
            coada.push(user2);
            coada.push(user3);
            coada.push(user4);
            coada.push(user5);
            coada.pop();
            coada.pop();

            Assert.Equal(user3,coada.top());

            Assert.Equal(user5, coada.getHead().Value);

            Assert.False(coada.empty());

        }



    }
}
