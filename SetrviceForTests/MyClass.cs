using System;

namespace SetrviceForTests
{
    public class MyClass
    {
        public void WriteYourName(string name)
        {
            Console.WriteLine($"Hello {name} , date : {DateTime.Now.Date}");

            Console.WriteLine("Bay-bay!!!");
            Console.WriteLine("Pupsik");
            Console.WriteLine();
        }

        public void SomeMethod(int number)
        {
            Console.WriteLine(number);
        }
    }
}
