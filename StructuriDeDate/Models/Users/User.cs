using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.Models.Users
{
    public class User : IBuilderUser , IComparable<User>
    {

        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private int _age;

        public User(int id, string name, string email, string password, int age)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
            _age = age;
        }

        public User()
        {

        }

        public int getId() { return _id; }
        public void setId(int id) { _id = id; }
        public string getName() { return _name; }
        public void setName(string name) { _name = name; }
        public string getEmail() { return _email; }
        public void setEmail(string email) { _email = email; }
        public string getPassword() { return _password; }
        public void setPassword(string password) { _password = password; }
        public int getAge() { return _age; }
        public void setAge(int age) { _age = age; }


        public User Id(int id)
        {
            _id = id;
            return this;
        }

        public User Name(string name)
        {
            _name = name;
            return this;
        }

        public User Email(string email)
        {
            _email = email;
            return this;
        }

        public User Password(string password)
        {
            _password = password;
            return this;
        }

        public User Age(int age)
        {
            this._age = age;
            return this;
        }

        public string descriere()
        {
            string t = "";

            t += "Id " + _id.ToString() + "\n";
            t += $"Name {_name} \n";
            t += $"Email {_email} \n";
            t += $"Age {_age} \n";
            return t;
        }

        public override string ToString()
        {
            return descriere();
        }

        public int CompareTo(User? other)
        {
            if (this._age > other._age)
            {
                return 1;

            }
            else if (this._age < other._age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
