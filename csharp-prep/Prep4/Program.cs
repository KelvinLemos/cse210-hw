using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    
    {
    
        List<int> numbers = new List<int>();
        
        int number_user = -1;

        while (number_user != 0)
        {   
            Console.Write("Enter Number (0 to quit): ");

            string response = Console.ReadLine();
            number_user = int.Parse(response);

            if (number_user != 0)
            {
                numbers.Add(number_user);
            }
            
        }
        
        int sum = 0;
        foreach (int number in numbers) 
            {
                sum += number;
            }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");



        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }



    
    






}