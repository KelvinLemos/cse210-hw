using System;

class Program
{   
    static void Main(string[] args)
    {
        Console.WriteLine("Please, guess the magic number");
        
    
    Random randomGenerator = new Random();
        int integer_magic = randomGenerator.Next(1, 101);
    int guess = -1;
    while (guess != integer_magic)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());  

            if (guess == integer_magic)
            {
                Console.WriteLine("You guessed it");
            }
            else if (guess <= integer_magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess >= integer_magic)
            {
                Console.WriteLine("Lower");
            }
        }
    }   
}
    