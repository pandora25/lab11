using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lap11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> Netflix = new List<Movie>();

            Netflix.Add(new Movie("Sci-Fi", "avangers instanity wars"));
            Netflix.Add(new Movie("Sci-Fi", "star wars"));
            Netflix.Add(new Movie("horror", "IT"));
            Netflix.Add(new Movie("horror", "the centries"));
            Netflix.Add(new Movie("horror", "toy story"));
            Netflix.Add(new Movie("drama", "facebook"));
            Netflix.Add(new Movie("drama", "yahoo"));
            Netflix.Add(new Movie("animated", "history channal"));
            Netflix.Add(new Movie("animated", "vally city"));
            Netflix.Add(new Movie("animated", "grand circus"));

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("welcome to the movies list application! ");

                Console.WriteLine("there are 10 movies in this list ");
                Console.Write("what category are you interested in? choose 1-4: ");

                string google = Console.ReadLine();
                while (!Regex.IsMatch(google, @"^[1-4]"))
                {
                    Console.WriteLine("invalid entry !! try again (Sci-Fi,horror,drama,animated) 1-4: ");
                    google = Console.ReadLine();
                }
                int input = int.Parse(google);

                if (input == 1)
                {
                    foreach (Movie item in Netflix)
                    {
                        if (item.Catagory == "Sci-Fi")
                        {
                            item.PrintInfo();
                        }
                    }
                }
                else if (input == 2)
                {
                    foreach (Movie item in Netflix)
                    {
                        if (item.Catagory == "horror")
                        {
                            item.PrintInfo();
                        }
                    }
                }
                else if (input == 3)
                {
                    foreach (Movie item in Netflix)
                    {
                        if (item.Catagory == "drama")
                        {
                            item.PrintInfo();
                        }
                    }
                }
                else if (input == 4)
                {
                    foreach (Movie item in Netflix)
                    {
                        if (item.Catagory == "animated")
                        {
                            item.PrintInfo();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid entry!!");
                }

                repeat = Confirmation("coninue (y/n)");
            }
        }
        public static bool Confirmation(string message)
        {
            Console.WriteLine(message);
            string googles = Console.ReadLine().ToLower();

            if (googles == "y")
            {
                return true;
            }
            else if (googles == "n")
            {
                return false;
                Console.WriteLine("thank you");
            }
            else
            {
                Console.WriteLine("invalid entry !! try again (y/n): ");
            }
           return  Confirmation(message);
        }
    }
}
