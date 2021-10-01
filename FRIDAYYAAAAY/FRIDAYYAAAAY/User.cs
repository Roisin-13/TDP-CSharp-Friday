using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRIDAYYAAAAY
{
    class User
    {
        public string forename;
        public string surname;
        public string nickname;
        public int age;
        public string email;

        public User(string forename, string surname, string nickname, int age, string email)
        {
            this.forename = forename;
            this.surname = surname;
            this.nickname = nickname;
            this.age = age;
            this.email = email;
        }

        public User()
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"User: {forename} {surname} , nickname: {nickname}, age: {age}, email: {email}");
        }


        public string GetInfo()
        {
            return $"User: {forename} {surname} , nickname: {nickname}, age: {age}, email: {email}";
        }




    }
}
