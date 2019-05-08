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
        private static string parent, address;
        private static List<string> question = new List<string>();

        static void Main(string[] args)
        {

            //Introduction
            Console.WriteLine("  ~*~*~* What Gift Should You Get for Your Parent? *~*~*~");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Answer the questions and press 'enter' to submit an answer");
            Console.WriteLine("");

            //Code
            parentSelection();


            //Pause
            Console.WriteLine();
            Console.ReadLine();

        }
    

        public static string parentSelection()

        {
            string temp;
            Console.Write("Is your parent female or male? ");
            temp = Console.ReadLine();

            
            do{
            if (temp.ToLower() == "male")
            {

                parent = "male";

            }
            else if (temp.ToLower() == "female")
            {
                parent = "female";
            }
            else
            {
                Console.WriteLine("\nNot a vaild input\n");
            }
            
            } while (parent != "female" && parent != "male");
            return parent;
        }

        public static void parentReference()
        {
            if (parentSelection() == "male")
            {
                address = "dad";

            }
            else if (parentSelection() == "female")
            {
                address = "mum";
            }
            else
            {
                address = "they";                 
            }
        }

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

    }
}

