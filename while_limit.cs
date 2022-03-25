using System;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(1, 10);
            int guess = 0;
            int limit = 1;

            Console.WriteLine("Guess a number between 1-100\nyou only got 3 attempts: ");
            
           
            while (limit <= 3){
                guess = Convert.ToInt32(Console.Read());
                if (num < guess) {
                    Console.WriteLine(limit+". try again lower than "+ guess); Console.ReadLine();               
                }
                if (num > guess){
                    Console.WriteLine(limit + ". try again higher than " + guess); Console.ReadLine();
                }
                if (num == guess){
                    Console.WriteLine(limit + ". good job you finally made it in "+limit
                    +" attempts and you guess it right : " + guess); 
                    Console.ReadLine(); break;
                }
                guess = 1;
                if (num == guess)
                {
                    Console.WriteLine(limit + ". good job you finally made it in " + limit 
                    + " attempts and you guess it right : " + guess);
                    Console.ReadLine(); break;
                }
                limit++;
            }
            Console.WriteLine("\nOpx you suceeded 3 attempts");


        }
    }
}
