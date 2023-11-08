using StructuriDeDate.Models.Users;
using StructuriDeDate.Stiva;
using StructuriDeDate.Stiva.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteListe
{
    public class TestStiva
    {

        IStiva<User> stiva;

        [Fact]
        public void test()
        {


            User user = new User(1, "test", "test@e.com", "1234", 18);
            User user2 = new User(2, "test1", "tes1t@e.com", "1234", 19);
            User user3 = new User(3, "test2", "test2@e.com", "1234", 18);
            User user4 = new User(4, "test3", "test3@e.com", "1234", 17);
            User user5 = new User(5, "test4", "test4@e.com", "1234", 20);

            stiva = new Stiva<User>();

            Assert.True(stiva.empty());

            stiva.push(user);
            stiva.push(user2);
            stiva.push(user3);
            stiva.push(user4);
            stiva.push(user5);

            Assert.Equal(user5, stiva.getHead().Value);

            Assert.True(stiva.getHead().Next.Value.getAge() == 17);

            stiva.pop();
            stiva.pop();

            Assert.Equal(user3, stiva.getHead().Value);

            Assert.NotEqual(user2,stiva.top());

        }



    }
}
