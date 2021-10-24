//POLONAN, JANA RINOAH B
//CCP 1103 - ITBC
//JACK 'EN POY

using System;

namespace JackEnPoy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String answer;
            String inputWeaponP1;
            String inputWeaponP2;

            int weaponP1;
            int weaponP2;

            do
            {//text prompt
                Console.Clear();
                Console.WriteLine("Jack 'en Poy");
                Console.WriteLine();
                Console.WriteLine("Select your Weapon.");
                Console.WriteLine("[1] Paper");
                Console.WriteLine("[2] Rock");
                Console.WriteLine("[3] Scissors");

                //selection of player one
                Console.WriteLine();
                Console.Write("Player 1, Choose your Weapon: ");
                inputWeaponP1 = Console.ReadLine();

                if (Int32.TryParse(inputWeaponP1, out weaponP1) == true)
                {
                    switch (weaponP1)
                    {
                        case 1:
                        case 2:
                        case 3:

                            //selection of player two
                            Console.Write("Player 2, Choose your Weapon: ");
                            inputWeaponP2 = Console.ReadLine();

                            if (Int32.TryParse(inputWeaponP2, out weaponP2) == true)
                            {
                                switch (weaponP2)
                                {
                                    case 1:
                                    case 2:
                                    case 3:
                                        //evaluation
                                        if (weaponP1 == 1 && weaponP2 == 2)
                                        {
                                            Console.WriteLine("Player 1 wins!");
                                        }
                                        else if (weaponP1 == 1 && weaponP2 == 3)
                                        {
                                            Console.WriteLine("Player 2 wins!");
                                        }
                                        else if (weaponP1 == 2 && weaponP2 == 1)
                                        {
                                            Console.WriteLine("Player 2 wins!");
                                        }
                                        else if (weaponP1 == 2 && weaponP2 == 3)
                                        {
                                            Console.WriteLine("Player 1 wins!");
                                        }
                                        else if(weaponP1 == 3 && weaponP2 == 1)
                                        {
                                            Console.WriteLine("Player 1 wins!");
                                        }
                                        else if (weaponP1 == 3 && weaponP2 == 2)
                                        {
                                            Console.WriteLine("Player 2 wins!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("It's a tie!");
                                        }

                                            break;

                                    default:
                                        Console.WriteLine("Invalid Input. Please choose numbers from 1-3 only.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input. Please choose numbers from 1-3 only.");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid Input. Please choose numbers from 1-3 only.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please choose numbers from 1-3 only.");
                }

                Console.Write("Do you want to try again? [Y/y]: ");
                answer = Console.ReadLine();
            } while ((answer == "Y") || (answer == "y"));
            Console.WriteLine("End of the program. Press any key to exit.");

        }
    }
}