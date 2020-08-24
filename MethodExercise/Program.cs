using System;

namespace MethodExercise
{
    class Program
    {
        public static void AdLib (string name, string favoriteColor, string favoriteAnimal, string favoriteBand)
        { 
            Console.WriteLine($"Welcome {name}! You have stumbled into a land where only two colors exist white and {favoriteColor}. It's not all bad though because the only animal is {favoriteAnimal}. Oh and the wind sounds like {favoriteBand}. Not too shabby.");
        }

        public static int Sum(int x, int y)
        {
            return  x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static decimal Divide(int x,int y)
        {
            return x / y;
        }

        public static int Remander(int x, int y)
        {
            return x % y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int SuperAdd(params int[] awesome)
        {
            int duper = 0;

            foreach (int number in awesome)
            {
                duper = duper + number;
            }
            return duper;
        }
        static void Main(string[] args)
        {
            /*    Console.WriteLine("What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine("What's your favorite color?");
                string favoriteColor = Console.ReadLine();
                Console.WriteLine("What's your favorite animal?");
                string favoriteAnimal = Console.ReadLine();
                Console.WriteLine("What's your favorite band?");
                string favoriteBand = Console.ReadLine();

                Console.WriteLine("Would you like to hear your story?");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    AdLib(name, favoriteColor, favoriteAnimal, favoriteBand);
                } else
                {
                    Console.WriteLine($"Every party has a pooper. and that's you, {name}.");
                }*/

            Console.WriteLine(Sum(2, 4));
            Console.WriteLine(Multiply(4, 4));
            Console.WriteLine(Divide(4, 2));
            Console.WriteLine(Remander(9, 5));
            Console.WriteLine(Subtract(6, 5));
            Console.WriteLine(SuperAdd(4, 4, 4, 4, 4));
        }
    }
}
