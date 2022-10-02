using System.Numerics;

public class CollatzConjecture
{
    public static int Collatz(int number)
    {
        int counter = 0;
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
        Console.WriteLine("Enter a positive integer: ");
        int userInput = int.Parse(Console.ReadLine());

        int maxNumber = 0;
        int maxSteps = 0;

        /* Make like rust program with defined starting and finishing numbers */

        Parallel.For(1, userInput, i =>
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