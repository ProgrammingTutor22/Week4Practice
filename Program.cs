using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace Week4Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {   //practicing arrays
            string[] menuOptions = { "Pizza", "Pasta", "Salad", "Drinks" };

            int choice;

            // Display the menu options
            Console.WriteLine("Welcome to our Restaurant!");
            Console.WriteLine("Here are your options:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + menuOptions[i]);
            }

            // Get user input for their choice
            Console.Write("Enter your choice (1-" + menuOptions.Length + "): ");
            choice = Convert.ToInt32(Console.ReadLine());

            // Validate user input and display chosen option
            if (choice >= 1 && choice <= menuOptions.Length)
            {
                Console.WriteLine("You selected: " + menuOptions[choice - 1]);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.ReadLine();
        }
    }
}
