using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
namespace ShoppingProov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name three colors.");
            string userInput = Console.ReadLine();


            string[] colors = userInput.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

             List<string> colorList = colors.ToList();

            foreach(string color in colorList)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("Add or remove a color");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "add") 
            {
                Console.WriteLine("Enter a color to add");
                string userAnswer = Console.ReadLine();
                colorList.Add(userAnswer);
            }

            else if (userChoice.ToLower() == "remove") 
            {
                Console.WriteLine("Enter a color to remove");
                string userAnswer = Console.ReadLine();
                colorList.Remove(userAnswer);
            }
            else
            {
                Console.WriteLine("Unknown command.");
            }

            foreach(string color in colorList)
            {
                Console.WriteLine(color);
            }



            Console.ReadLine();

        }
    }
}
