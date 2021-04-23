using System;
using System.Linq;

namespace DesignPatternsExample
{
    public abstract class AbstractDesignPatternExampleRunner
    {
        public abstract string GetTitle();

        public abstract void RunInternal();

        public void Run()
        {
            int separatorsCount = 60;
            int nbSeparatorsAtLeftSide = (separatorsCount - GetTitle().Length - 2) / 2;
            int nbSeparatorsAtRightSide = separatorsCount - GetTitle().Length - 2 - nbSeparatorsAtLeftSide;

            Console.WriteLine(
                $"{string.Concat(Enumerable.Repeat("-", nbSeparatorsAtLeftSide))} {GetTitle()} {string.Concat(Enumerable.Repeat("-", nbSeparatorsAtRightSide))}");

            RunInternal();

            Console.WriteLine();
        }
    }
}