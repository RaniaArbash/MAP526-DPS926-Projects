using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private int age;

        public string getName() {
            return name;
        }
        public int getAge() {
            return age;
        }
 
        public void setName(string n)
        {
            name = n;
        }
        public void setAge(int a) {
            age = a;
        }

        public void checkAge(int a) {
            switch (a) {
                case 20:
                    Console.WriteLine("The age is : 20 years old");
                    break;
                case 25:
                    Console.WriteLine(" The age is : 25 years old");
                    break;
                case 27:
                    Console.WriteLine("The age is : 27 years old");
                    break;
            }


        }


    }
}
