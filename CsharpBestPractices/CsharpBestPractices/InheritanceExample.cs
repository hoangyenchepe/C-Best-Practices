using System;
using System.Collections;

namespace CsharpBestPractices
{
    class InheritanceExample
    {
        public void features()
        {
            ArrayList my_features = new ArrayList();

            my_features.Add("Abstraction");
            my_features.Add("Encapsulation");
            my_features.Add("Inheritance");


            Console.WriteLine("Features provided by OOPS:");
            foreach (var elements in my_features)
            {
                Console.WriteLine(elements);
            }
        }
    }

    class Inheritance2 : InheritanceExample
    {
        public void languages()
        {
            ArrayList my_features = new ArrayList();

            my_features.Add("C++");
            my_features.Add("C#");
            my_features.Add("JScript");

            Console.WriteLine("\nLanguages that use OOPS concepts:");
            foreach (var elements in my_features)
            {
                Console.WriteLine(elements);
            }
        }
    }

    class InheritanceToInheritance : Inheritance2 { }
}
