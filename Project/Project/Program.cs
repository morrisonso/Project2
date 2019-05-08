//Cody, Amber, Sophie & Dylan
//Git Group Project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        public static string parent;

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
        public static void parentSelection()
        {
            string temp;
            do
            {
                Console.Write("Is your parent female or male? ");
                temp = Console.ReadLine();
                
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
        }
    }
}
