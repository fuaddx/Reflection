using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class User
    {

        private int id;
        private string name;
        private static int Age = 10;

        public User(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void UserInfo()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {Age}");
        }

        public static void ChangeAge(int age)
        {
            Age = age;
        }


    }
}
