using System;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your dog's name?  ");
            string dogName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Well then I have this highly reliable report on {0}'s prestigious background right here.", dogName);
            Console.WriteLine();
            Console.WriteLine("{0} is :", dogName);
          

            int[] percentages = new int[5];
            int max = 101;
            int total = 0;
            Random rand = new Random();

            // how do I make sure they add up to 100??

            for (int i = 0; i < 4; i++)
            {
                int percentage = rand.Next(max);
                percentages[i] = percentage;
                max = max - percentage;
                total += percentage;
            }

            percentages[4] = 100 - total;


            Console.WriteLine("{0}% St. Bernard", percentages[0]);
            
            Console.WriteLine("{0}% Chihuahua", percentages[1]);

            Console.WriteLine("{0}% Dramatic RedNosed Asian Pug", percentages[2]);

            Console.WriteLine("{0}% Common Cur", percentages[3]);

            Console.WriteLine("{0}% King Doberman",percentages[4]);
            Console.WriteLine();

            Console.WriteLine("Wow, thats QUITE the dog!");
        }
    }
}
