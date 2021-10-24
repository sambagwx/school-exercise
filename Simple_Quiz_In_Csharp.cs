using System;

namespace WhileLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a Simple Quiz with only 3 chances to answer it correctly

            int life = 3;

            string correctAnswer = "Derrick Rose";
            string answer;

            while (life > 0) 
            {
                Console.WriteLine("Life: " + life);
                Console.WriteLine("Who is the youngest MVP on NBA?");
                Console.WriteLine();
                Console.Write("Answer: ");
                answer = Console.ReadLine();

                if (answer.Equals(correctAnswer))
                {
                    Console.WriteLine("You got it correct!");
                    break;
                }
                else Console.WriteLine("Wrong answer!");
                     Console.WriteLine();
                     Console.WriteLine("----------");
                     Console.WriteLine();
                     life--;

                if (life == 0)
                {
                    Console.WriteLine("Please try again next time!");
                    Console.WriteLine();
                    Console.WriteLine("----------");
                    Console.WriteLine();
                }

            }

        }
    }
}
