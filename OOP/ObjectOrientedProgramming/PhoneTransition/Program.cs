using System;

namespace PhoneTransition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstGeneration myPhone = new FirstGeneration("Nokia","3310");
            myPhone.Call();
            SecondGeneration myPhone2 = new SecondGeneration();
            Console.WriteLine(myPhone2.Name);
            myPhone2.SendMMS();
            Console.WriteLine("Hello World!");
        }
    }
}
