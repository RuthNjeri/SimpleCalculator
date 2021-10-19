using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    // Objects and Classes
    public class Person
    {
        private int _age = 25;
        public int getAge()
        {
            return _age;
        }

        public void setAge(int newAge)
        {
            _age = newAge;
        }

        // Keep static methods self sufficient, 
        // That they don't have any dependancies on the class. Otherwise, make it non static
        static public void greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
