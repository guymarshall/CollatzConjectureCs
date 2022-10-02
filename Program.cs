using System.Numerics;

public class CollatzConjecture
{
    public static long Collatz(long number)
    {
        long counter = 0;
        // if even, divide by 2
        // else times by 3 and add 1
        while (number > 1)
        {
            counter++;
            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = (3 * number) + 1;
            }
        }

        return counter;
    }

    public static void Main()
    {
        // Console.WriteLine("Enter a positive integer: ");
        // int userInput = int.Parse(Console.ReadLine());

        long start = 1;
        long finish = 1000000;

        long maxNumber = 0;
        long maxSteps = 0;

        Parallel.For(start, finish, i =>
        {
            if (maxSteps < Collatz(i))
            {
                maxSteps = Collatz(i);
                maxNumber = i;
            }
        });

        Console.WriteLine(maxNumber + " had the maximum number of steps at " + maxSteps);
    }
}