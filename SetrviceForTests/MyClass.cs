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
            //hotfix

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Испарвил !");

        }

        public void NewMethod()
        {

        }

        public void NewMethod2()
        {
            Console.WriteLine();
        }

        public void SomeMethod(int number)
        {
            Console.WriteLine("2");
            Console.WriteLine("Other people");
          
        }

        public void MyName(string name)
        {
            Console.WriteLine(name);
        }
    }
}
