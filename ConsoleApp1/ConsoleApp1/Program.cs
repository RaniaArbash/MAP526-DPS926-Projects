using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static string giveDescription() {
            return "This is our first static function in C#";
        }

        private int addNumbers(int num1, int num2) {

            return num1 + num2;
 
        }

        static void Main(string[] args)
        {

            Person std1 = new Person();
            Person std2 = new Person();
            std1.setName("Jone");
            std2.setName("Roy");

            std1.setAge(25);
            std2.setAge(27);

           


            Console.WriteLine("The first studen name is " + std1.getName() + " and his age is " + std1.getAge());

            Console.WriteLine("The second studen name is " + std2.getName() + " and his age is " + std2.getAge());

            std1.checkAge(std1.getAge());
            std2.checkAge(std2.getAge());

            Console.WriteLine(Program.giveDescription());

            Program firstObject = new Program();
           int result = firstObject.addNumbers(3, 4);
            Console.WriteLine(result);



           // addNumbers(3, 4);

            Console.WriteLine("Hello C#");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();

            Console.WriteLine("The age is " + Convert.ToInt32(age));

            Console.WriteLine("The name is " + name);
            Console.ReadLine();

        }
    }
}
