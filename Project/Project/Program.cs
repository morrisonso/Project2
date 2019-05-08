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
        private static string parent, address;

        static void Main(string[] args)
        {
            //Declare Variables


            //Introduction
            Console.WriteLine("                   ~*~*~* Q & A *~*~*~");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Answer the questions and press 'enter' to submit your answer");

            //Code
            parentSelection();



            //Pause
            Console.WriteLine();
            Console.ReadLine();
            //Test comment

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
               
        }
    }

