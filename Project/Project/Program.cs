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
        private static string parent, popularGenre, bookStyle;
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
            string temp;
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
        private static void bookAnswer(string genre)
        {
            if (bookStyle == "fiction")
            {
                switch(genre)
                {
                    case "adventure":
                        Console.WriteLine("Treasure Island - Louis Stevenson - 1882 \nThe call of the wild - Jack London - 1903 \nThe Lord of the Rings - 1954 - J.R.R.Tolkien \nKing Solomon's Mines - 1885 - H. Rider Haggard");

                        break;

                    case "action":
                        Console.WriteLine("Spartan Gold - 2009 - Clive Cussler and  Grant Blackwood \nThe Striker - 2013 - Clive Cussler and  Justin Scott \nThe Thief - 2012 - Justin Scott ");
                        break;

                    case "comedy":
                        Console.WriteLine("Good Omens - 1990 - Neil Gaiman and Terry Pratchett \nThe Ultimate Hitchhiker's Guide - 1979 - Douglas Adams \nA Confederacy of Dunces - 1980 - John Kennedy Toole \nWhere'd You Go, Bernadette - 2012 - Maria Semple");
                        break;

                    case "crime":
                        Console.WriteLine("In Cold Blood - 1965 - Truman Capote \nThe Top 100 Crime Novels of All Time - 1990 - Crime Writers' Association \nThe Girl with the Dragon Tattoo - 2005 - Stieg Larsson \nThe Big Sleep - 1939 - Raymond Chandler");
                        break;

                    case "drama":
                        Console.WriteLine("To Kill a Mockingbird - 1960 - Harper Lee \nThe Kite Runner - 2003 - Khaled Hosseini \nOf Mice and Men - 1937 - John Steinbeck  \nThe Alchemist - 1988 - Paulo Coelho");
                        break;

                    case "history":
                        Console.WriteLine("Beloved - 1987 - Toni Morrison \nAll the Light We Cannot See - 2014 - Anthony Doerr \nLilac Girls: A Novel - 1939 - Martha Hall Kelly \nWolf Hall - 2009 - Hilary Mantel");
                        break;

                    case "romance":
                        Console.WriteLine("Love Story - 1970 - Erich Sega \nPride and Prejudice - 1813 - Jane Austen \nOutlander - 1991 - Diana Gabaldon \nThe Kiss Quotient - 2018 - Helen Hoang");
                        break;

                    case "science":
                        Console.WriteLine("1984 - 1949 - George Orwell \nDune - 1965 - Frank Herbert \nEnder's Game - 1985 - Orson Scott Card \nNeuromancer - 1984 - William Gibson");
                        break;
                    default:
                        break;
                }
            }
            else {
                switch (genre)
                {
                    case "adventure":

                        break;

                    case "action":

                        break;

                    case "comedy":

                        break;

                    case "crime":

                        break;

                    case "drama":

                        break;

                    case "history":

                        break;

                    case "romance":

                        break;

                    case "science":

                        break;
                    default:
                        break;
                }
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

