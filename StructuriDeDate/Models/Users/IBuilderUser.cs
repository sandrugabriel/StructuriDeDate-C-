using StructuriDeDate.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.Models.Users
{
    public interface IBuilderUser
    {

        User Id(int id);

        User Name(string name);

        User Email(string email);

        User Password(string pass);

        static User Build()
        {
            return new User();
        }

    }
}
