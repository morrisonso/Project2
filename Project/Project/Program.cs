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
        private static Boolean book, film, tv; 

        static void Main(string[] args)
        {

            //Introduction
            Console.WriteLine("  ~*~*~* Let's Pick Out Some Entertainment For Your Mum Or Dad *~*~*~");
            Console.WriteLine("====================================================================");
            Console.WriteLine("Answer the questions and press 'enter' to submit an answer.");
            Console.WriteLine("");

            //Code


            parentSelection();
            Console.WriteLine();
            visualEntertainment();
            Console.WriteLine();
            entertainmentResults();


            //End
            Console.WriteLine();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();


        }


        public static string parentSelection()

        {
            string temp;
            do
            {

                Console.WriteLine("Is your parent female or male? F or M");
                temp = Console.ReadLine();

                if (temp.ToLower() == "m")
                    parent = "male";
                else if (temp.ToLower() == "f")
                    parent = "female";
                else
                    Console.Write("Invalid input, try again. ");
            }
            while (parent != "female" && parent != "male");
            parentReference();
            Console.WriteLine("Cool! Let's get something for your " + address + ", then.");
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

        public static string visualEntertainment()
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
                Console.WriteLine("Does your " + address + " like books, films, and/or tv? (Yes or No)");
                temp = Console.ReadLine();
            } while (!(temp.ToLower() == "yes" || temp.ToLower() == "no"));
            if (temp == "yes")
            {
                /* like books */
                Console.WriteLine("Does your " + address + " like books?        ");
                temp = Console.ReadLine();
                if (temp.ToLower() == "yes")
                {
                    book = true;
                    /*fiction or non fiction books*/
                    do
                    {
                        Console.WriteLine("Does your " + address + " prefer ficton or non-fiction books? F or N");
                        temp = Console.ReadLine();
                        if (temp.ToLower() == "f")
                        {
                            bookStyle = "fiction";
                        }
                        else if (temp.ToLower() == "n")
                        {
                            bookStyle = "non-fiction";
                        }
                    } while (temp.ToLower() != "f" && temp.ToLower() != "n");
                    /* what genre books */
                    for (int i = 0; i < genreArray.Length; i++)
                    {
                        Console.WriteLine("Does your " + address + " like " + genreArray[i] + " books? Yes or No");
                        temp = Console.ReadLine();
                        if (temp.ToLower() == "yes")
                        {
                            bookGenre.Add(genreArray[i]);

                        }

                    }




                }
                /** film genre preferences */
                Console.WriteLine("Does your " + address + " like films? Yes or No");
                temp = Console.ReadLine();
                if (temp.ToLower() == "yes")
                {
                    film = true;
                    for (int i = 0; i < genreArray.Length; i++)
                    {
                        Console.WriteLine("Does your " + address + " like " + genreArray[i] + " films?      ");
                        temp = Console.ReadLine();
                        if (temp.ToLower() == "yes")
                        {
                            filmGenre.Add(genreArray[i]);

                        }

                    }
                }
                /** tv genre preferences */
                Console.WriteLine("Does your " + address + " watch tv shows?    ");
                temp = Console.ReadLine();
                if (temp.ToLower() == "yes")
                {
                    tv = true;
                    for (int i = 0; i < genreArray.Length; i++)
                    {
                        Console.WriteLine("Does your " + address + " like " + genreArray[i] + " tv shows?   ");
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
            /**
            foreach (int vote in genreCount)
                Console.WriteLine(vote);
            foreach (string genre in genreArray)
                Console.WriteLine(genre);
            **/
            popularGenre = genreArray[7];
            votes = genreCount[7];
            if (book != false && film != false && tv != false)
            {
                Console.WriteLine("The most popular genre overall for your " + address + " is: " + popularGenre + " with " + votes + " number of votes");
            }
                return popularGenre;
        }

        public static void entertainmentResults()
        {
            if (book == true)
            {
                bookAnswer(popularGenre);
            }
            if (film == true)
            {
                moviesAnswer(popularGenre);
            }
            if (tv == true)
            {
                TvShowAnswer(popularGenre);
            }
            else if (book==false && film==false && tv == false)
            {
                Console.WriteLine("Looks like your " + address + " isn't interested in books, films, or tv! We can't help you.");
            }
        }

        private static void TvShowAnswer(string tvShows)
        {
            Console.WriteLine();
            Console.WriteLine("Most popular " + tvShows + " tv show:");
            switch (tvShows)
            {
                case "adventure":
                    Console.WriteLine("Game of Thrones(2011-)");
                    break;

                case "action":
                    Console.WriteLine("Gotham(2014-2019)");
                    break;

                case "comedy":
                    Console.WriteLine("The Big Bang Theory(2007-)");
                    break;

                case "crime":
                    Console.WriteLine("The Act(2019-)");
                    break;

                case "drama":
                    Console.WriteLine("Chambers(2019-)");
                    break;

                case "history":
                    Console.WriteLine("Chambers(2019-)");
                    break;
                case "science":
                    Console.WriteLine("Planet Earth (2006)");
                    break;
                default:
                    Console.WriteLine("it looks like {0} is not in our database");
                    break;

            }
        }

        private static void moviesAnswer(string movies)
        {
            Console.WriteLine();
            Console.WriteLine("Most popular " + movies + " film:");
            switch (movies)
            {
                case "adventure":
                    Console.WriteLine("Indiana Jones: Raiders of the Lost Ark (1981).");
                    break;

                case "action":
                    Console.WriteLine("The Dark Knight (2008)");
                    break;

                case "comedy":
                    Console.WriteLine("Superbad (2007)");
                    break;

                case "crime":
                    Console.WriteLine("Zodiac (2007)");
                    break;

                case "drama":
                    Console.WriteLine("The Godfather (1972)");
                    break;

                case "history":
                    Console.WriteLine("Kingdom of Heaven (2005)");
                    break;

                case "romance":
                    Console.WriteLine("The Notebook (2004)");
                    break;

                case "science":
                    Console.WriteLine("Interstellar (2014)");
                    break;
            }
        }
        private static void bookAnswer(string genre)
        {
            Console.WriteLine();   
            Console.WriteLine("Most popular " + bookStyle + " " + genre + " books:");
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
                        Console.WriteLine("Into Thin Air - 1997 - Jon Krakauer \nInto the Wild - 1996 - Jon Krakauer \nThe Right Stuff - 1979 - Tom Wolfe");
                        break;

                    case "action":
                        Console.WriteLine("The Vagrant - 2016 - Peter Newman \nThe Winner - 2018 - David Baldacci \nChosen - 2010 - Ted Dekker \nAll the Light We Cannot See - 2015 - Anthony Doerr");
                        break;

                    case "comedy":
                        Console.WriteLine("I Feel Bad About My Neck: And Other Thoughts on Being a Woman - 2006 - Nora Ephron \nI Was Told There'd Be Cake - 2008 - Sloane Crosley \nA Supposedly Fun Thing I'll Never Do Again: Essays and Arguments - 1997 - David Foster Wallace \nGulp: Adventures on the Alimentary Canal - 2013 - Mary Roach");
                        break;

                    case "crime":
                        Console.WriteLine("Helter Skelter - 1974 - Curt Gentry and Vincent Bugliosi \nThe Stranger Beside Me - 1980 - Ann Rule \nThe Devil in the White City: Murder, Magic, and Madness at the Fair that Changed America - 2003 - Erik Larson \nKillers of the Flower Moon: The Osage Murders and the Birth of the FBI - 2017 - David Grann");
                        break;

                    case "drama":
                        Console.WriteLine("Blood River: A Journey to Africa's Broken Heart - 2008 - Tim Butcher \nThe Trigger: Hunting the Assassin Who Brought the World to War - 2014 - Tim Butcher \nMidnight in the Garden of Good and Evil - 1994 - John Berendt");
                        break;

                    case "history":
                        Console.WriteLine("Bury My Heart at Wounded Knee - 1970 - Dee Brown \nA People's History of the United States - 1990 - Howard Zinn \nGuns, Germs, and Steel - 1997 - Jared Diamond \nHiroshima - 1946 - John Hersey");
                        break;

                    case "romance":
                        Console.WriteLine("Modern Romance: An Investigation - 2015 - Aziz Ansari and Eric Klinenberg \nEducated - 2018 - Tara Westover \nA Room of One's Own - 1929 - Virginia Woolf \nDead Wake: The Last Crossing of the Lusitania - 2015 - Erik Larson");
                        break;

                    case "science":
                        Console.WriteLine("The Immortal Life of Henrietta Lacks - 2010 - Rebecca Skloot \nThe Poisoner's Handbook - 2010 - Deborah Blum \nSilent Spring - 1962 - Rachel Carson \n A Short History of Nearly Everything - 2003 - Bill Bryson");
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
      
         * */
         
    }

    
}

