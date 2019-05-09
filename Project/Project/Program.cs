//Cody, Amber, Sophie & Dylan
//Git Group Project
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        private static string parent, popularGenre;
        private static List<string> question = new List<string>();
        private static string address = "them";

        static void Main(string[] args)
        {

            //Introduction
            Console.WriteLine("  ~*~*~* What Gift Should You Get for Your Parent? *~*~*~");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Answer the questions and press 'enter' to submit an answer");
            Console.WriteLine("");

            //Code


            parentSelection();
            Console.WriteLine();
            visualEntertainment();



            //Pause
            Console.WriteLine();
            Console.ReadLine();


        }


        public static string parentSelection()

        {
            string temp;
            do
            {

                Console.Write("Is your parent female or male?       ");
                temp = Console.ReadLine();

                if (temp.ToLower() == "male")
                    parent = "male";
                else if (temp.ToLower() == "female")
                    parent = "female";
                else
                    Console.Write("Invalid input, try again. ");
            }
            while (parent != "female" && parent != "male");
            parentReference();
            Console.Write("Cool! Lets get something for your " + address + " then.");
            return parent;
        }

        public static string parentReference()
        {
            if (parent == "male")
                address = "dad";
                   
            else if (parent == "female")
                address = "mum";
            
            else if (parent != "male" || parent != "female")
                address = "they";
            
            return address;
        }

        public static void visualEntertainment()
        {
            string temp, bookStyle;
            string[] genreArray, genreResults;
            int[] genreCount;
            int votes;


            genreResults = new string[8];
            genreArray = new string[] { "adventure", "action", "comedy", "crime", "drama", "history", "romance", "science" };
            genreCount = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            List<string> bookGenre = new List<string>();
            List<string> filmGenre = new List<string>();
            List<string> tvGenre = new List<string>();

            do
            {
                /*Like books, films or tv general **/
                Console.Write("Does your " + address + " like books, films, or tv? (Yes or No)      ");
                temp = Console.ReadLine();
            } while (!(temp.ToLower() == "yes" || temp.ToLower() == "no"));
            if (temp == "yes")
            {
                /* like books */
                Console.Write("Does your " + address + " like books?        ");
                temp = Console.ReadLine();
                if (temp.ToLower() == "yes")
                {
                    /*fiction or non fiction books*/
                    Console.Write("Does your " + address + " prefer ficton or non-fiction books?    ");
                    temp = Console.ReadLine();
                    if (temp.ToLower() == "fiction" && temp.ToLower() != "non-fiction")
                    {
                        bookStyle = "fiction";

                    }
                    else
                    {
                        bookStyle = "non-fiction";
                    }
                    /* what genre books */
                    for (int i = 0; i < genreArray.Length; i++)
                    {
                        Console.Write("Does your " + address + " like " + genreArray[i] + " books?      ");
                        temp = Console.ReadLine();
                        if (temp.ToLower() == "yes")
                        {
                            bookGenre.Add(genreArray[i]);

                        }

                    }




                }
                /** film genre preferences */
                Console.Write("Does your " + address + " like films?    ");
                temp = Console.ReadLine();
                if (temp.ToLower() == "yes")
                {
                    for (int i = 0; i < genreArray.Length; i++)
                    {
                        Console.Write("Does your " + address + " like " + genreArray[i] + " films?      ");
                        temp = Console.ReadLine();
                        if (temp.ToLower() == "yes")
                        {
                            filmGenre.Add(genreArray[i]);

                        }

                    }
                }
                /** tv genre preferences */
                Console.Write("Does your " + address + " watch tv shows?    ");
                temp = Console.ReadLine();
                if (temp.ToLower() == "yes")
                {
                    for (int i = 0; i < genreArray.Length; i++)
                    {
                        Console.Write("Does your " + address + " like " + genreArray[i] + " tv shows?   ");
                        temp = Console.ReadLine();
                        if (temp.ToLower() == "yes")
                            tvGenre.Add(genreArray[i]);
                    }
                }

            }
            for (int i = 0; i < genreArray.Length; i++)
            {
                if (bookGenre.Contains(genreArray[i]))
                {
                    genreCount[i] += 1;
                }
                if (filmGenre.Contains(genreArray[i]))
                {
                    genreCount[i] += 1;
                }
                if (tvGenre.Contains(genreArray[i]))
                {
                    genreCount[i] += 1;
                }
            }
            Array.Sort(genreCount, genreArray);
            foreach (int vote in genreCount)
                Console.WriteLine(vote);
            foreach (string genre in genreArray)
                Console.WriteLine(genre);
            popularGenre = genreArray[7];
            votes = genreCount[7];

            Console.WriteLine("The most popular genre overall for your " + address + " is: " + popularGenre + " with " + votes + " number of votes");
        
        }

        private static void TvShowAnswer(string tvShows)
        {
            switch (tvShows)
            {
                case "adventure":
                    Console.WriteLine("The most popular {0} TV show is Game of Thrones(2011-)", tvShows);
                    break;

                case "action":
                    Console.WriteLine("The most popular {0} TV show is Gotham(2014-2019)", tvShows);
                    break;

                case "comedy":
                    Console.WriteLine("The most popular {0} TV show is The Big Bang Theory(2007-)", tvShows);
                    break;

                case "crime":
                    Console.WriteLine("The most popular {0} TV show is The Act(2019-)", tvShows);
                    break;

                case "drama":
                    Console.WriteLine("The most popular {0} TV show is Chambers(2019-)", tvShows);
                    break;

                case "history":
                    Console.WriteLine("The most popular {0} TV show is Chambers(2019-)", tvShows);
                    break;
                case "science":
                    Console.WriteLine("The most popular {0} TV show is Planet Earth (2006)", tvShows);
                    break;
                default:
                    Console.WriteLine("it looks like {0} is not in our database", tvShows);
                    break;

            }
        }

        private static void moviesAnswer(string movies)
        {
            switch (movies)
            {
                case "adventure":
                    Console.WriteLine("Sounds like your parent would be interested in an adventure movie. " +
                        "The most popular adventure movie is Indiana Jones: Raiders of the " +
                        " Lost Ark (1981).");
                    break;

                case "action":
                    Console.WriteLine("Sounds like your parent would be interested in an action movie. " +
                        "The most popular action movie is The Dark Knight (2008)");
                    break;

                case "comedy":
                    Console.WriteLine("Sounds like your parent would be interested in a comedy movie. " +
                        "The most popular comedy movie is Superbad (2007)");
                    break;

                case "crime":
                    Console.WriteLine("Sounds like your parent would be interested in a crime movie. " +
                        "The most popular crime movie is Zodiac (2007)");
                    break;

                case "drama":
                    Console.WriteLine("Sounds like your parent would be interested in a drama movie. " +
                        "The most popular drama movie is The Godfather (1972)");
                    break;

                case "history":
                    Console.WriteLine("Sounds like your parent would be interested in a history movie. " +
                        "The most popular history movie is Kingdom of Heaven (2005)");
                    break;

                case "romance":
                    Console.WriteLine("Sounds like your parent would be interested in a romance movie. " +
                        "The most popular romance movie is The Notebook (2004)");
                    break;

                case "science":
                    Console.WriteLine("Sounds like your parent would be interested in a science movie. " +
                        "The most popular science movie is Interstellar (2014)");
                    break;
            }
        }

 /*   
        private void GetQuestions()
        {
            string line;
            StreamReader sr = new StreamReader(@"Questions.txt");

            while ((line = sr.ReadLine()) != null)
            //while the text file has content add it to the list
            {
                question.Add(sr.ReadLine());
            }
            sr.Close();
        }
        */
    }
}

