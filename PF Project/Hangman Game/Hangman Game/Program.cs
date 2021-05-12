using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Owner:");
            Console.WriteLine("1. 12113 Shahmeer khan.");
            Console.WriteLine("Welcome to our Project:");
            Console.WriteLine("\t \t \t \t Welcome to Hangman Game!!!!!!!!!!");
            bool gameover = game();
            while (gameover == true)
            {
                Console.WriteLine("Game is over");
                Console.WriteLine("If you want to play again then press R and if you want to quit press Q");
                string action = Console.ReadLine();
                if (action == "r" || action == "R")
                {
                    game();
                }
                else if (action == "q" || action == "Q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You have putted an invalid character");
                }
                Console.ReadKey();
            }
        }
        public static string Category(int idx)
        {
            string[] listcategory = new string[20];
            listcategory[0] = "Animal Name";
            listcategory[1] = "Animal name";
            listcategory[2] = "Science Invention";
            listcategory[3] = "Country Name";
            listcategory[4] = "Fruit Name";
            listcategory[5] = "Dessert Name";
            listcategory[6] = "Flower Name";
            listcategory[7] = "Fruit Name";
            listcategory[8] = "Fruit Name";
            listcategory[9] = "Fruit Name";
            listcategory[10] = "Animal Name";
            listcategory[11] = "Animal Name";
            listcategory[12] = "Car Name";
            listcategory[13] = "Drink Name";
            listcategory[14] = "Gaming Console Name";
            listcategory[15] = "Gaming Console Name";
            listcategory[16] = "AirLine";
            listcategory[17] = "Electronic Gadgets";
            listcategory[18] = "AirLine";
            listcategory[19] = "Electronic Gadegets";
            return listcategory[idx];
        }
        public static string listwords(int idx)
        {
            string[] listwords = new string[20];
            listwords[0] = "sheep";
            listwords[1] = "goat";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";
            listwords[10] = "cow";
            listwords[11] = "markhor";
            listwords[12] = "civic";
            listwords[13] = "pepsi";
            listwords[14] = "playstation";
            listwords[15] = "xbox";
            listwords[16] = "emirates";
            listwords[17] = "smartphones";
            listwords[18] = "pia";
            listwords[19] = "laptops";
            return listwords[idx];
        }
        public static void draw()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  SAVE THE MAN");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  -----------");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t (" + " ^;^" + " )");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  ./" + "|" + "\\.");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  _/" + " " + "\\_");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t --- \t");
            Console.WriteLine("\n");
        }
        public static void draw1()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  -----------");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t (" + " ^;^" + " )");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  ./" + "|" + "\\.");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  _/" + " " + "\\_");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t --- \t");
            Console.WriteLine("\n");
        }
        public static void draw2()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  -----------");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t (" + " ^;^" + " )");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  ./" + "|" + "\\.");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  _/" + " " + "\\_");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t --- \t");
            Console.WriteLine("\n");
        }
        public static void draw3()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  -----------");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t (" + " ^;^" + " )");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  ./" + "|" + "\\.");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  _/" + " " + "\\_");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t --- \t");
            Console.WriteLine("\n");
        }
        public static void draw4()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  -----------");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    |");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t (" + " ^;^" + " )");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  ./" + "|" + "\\.");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  _/" + " " + "\\_");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t --- \t");
            Console.WriteLine("\n");
        }
        public static void draw5()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  -----------");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t (" + " ^_^" + " )");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  ./" + "|" + "\\.");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  _/" + " " + "\\_");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t --- \t");
            Console.WriteLine("\n");
        }
        public static void loss()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  -----------");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t REST IN");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t PEACE");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t     " + "     " + "." + "    " + "|");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t   x" + "     " + "/" + "    " + "/");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t   .(--  --  --");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t   x" + "     " + "\\" + "    " + "\\");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t     " + "    " + "." + "     " + "|");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t --- \t");
            Console.WriteLine("\n");
        }
        public static void won()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  -----------");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    YOU");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    SAVED");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    THE");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    MAN");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t    ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t (" + " ^;^" + " )");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  ./" + "|" + "\\.");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t " + "   | " + " ");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t  | \t  _/" + " " + "\\_");
            Console.WriteLine("\t \t \t \t \t \t \t \t \t \t --- \t");
            Console.WriteLine("\n");
        }
        public static bool game()
        {
            bool gameover = false;
            draw();
            Console.WriteLine("\n");
            Random randword = new Random();
            int idx = randword.Next(0, 19);
            string mysteryWord = listwords(idx);
            string category = Category(idx);
            Console.WriteLine("\t \t \t \t Press Enter to start");
            string key = Console.ReadLine();
            Console.WriteLine("Guess the word with the help of category of the unknown word given below");
            Console.WriteLine("Hint:" + " " + category);
            char[] guess = new char[mysteryWord.Length];
            Console.Write("The hidden word: ");
            for (int p = 0; p < mysteryWord.Length; p++)
            {
                guess[p] = '*';
                Console.Write(guess[p]);
            }
            Console.WriteLine("\n");
            int count = 6;
            Console.WriteLine("\n");
            Console.WriteLine("Total wrong attempts left: " + Convert.ToString(count));
            while (true)
            {
                bool attempt = false;
                bool win = false;
                int correct = 0;
                Console.WriteLine("Enter the Letter of the word You have guessed in your mind:");
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                    {
                        attempt = true;
                        guess[j] = playerGuess;
                    }
                    if (guess[j] != '*')
                    {
                        correct++;
                    }
                    if (correct == guess.Length)
                    {
                        win = true;
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("State of the guess: ");
                Console.Write(guess);
                if (attempt == false)
                {
                    count -= 1;
                }
                Console.WriteLine("\n");
                Console.WriteLine("Total wrong attempts left: " + Convert.ToString(count));
                Console.WriteLine("\n");
                Console.WriteLine(guess);
                if (count == 5)
                {
                    draw1();
                }
                if (count == 4)
                {
                    draw2();
                }
                if (count == 3)
                {
                    draw3();
                }
                if (count == 2)
                {
                    draw4();
                }
                if (count == 1)
                {
                    draw5();
                }
                if (count == 0)
                {
                    loss();
                    Console.WriteLine("\t \t \t \t YOU LOSE");
                    gameover = true;
                    break;
                }
                if (win == true)
                {
                    won();
                    Console.WriteLine("\t \t \t \t YOU WON");
                    gameover = true;
                    break;
                }
            }
            return gameover;
        }
    }
}