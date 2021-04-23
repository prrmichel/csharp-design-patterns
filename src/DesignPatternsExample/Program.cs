using System;
using DesignPatternsExample.CreationalPatterns;

namespace DesignPatternsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            new AbstractFactoryExampleRunner().Run();
            new FactoryExampleRunner().Run();

            Console.ReadKey();
        }
    }
}