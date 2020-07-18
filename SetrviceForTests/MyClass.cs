using System;

namespace SetrviceForTests
{
    public interface IMyClass
    {
        void MyName(string name);
    }

    public class MyClass : IMyClass
    {
        public void WriteYourName(string name)
        {
                //
            Console.WriteLine($"Hello {name} , date : {DateTime.Now.Date}");

            Console.WriteLine("Bay-bay!!!");

            Console.WriteLine("Pupsik");


            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Испарвил !");

        }

        public void NewMethod()
        {

        }

        public void SomeMethod(int number)
        {
            Console.WriteLine("2");
            Console.WriteLine("Other people");
            Console.WriteLine(number);

            Console.WriteLine("I");

            Console.WriteLine("1");
            Console.WriteLine();

            Console.WriteLine();


            Console.WriteLine(1);


        }

        public void MyName(string name)
        {
            Console.WriteLine(name);
        }
    }
}
