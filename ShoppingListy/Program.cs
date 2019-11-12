using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Timer = System.Timers.Timer;
using System.Threading;
namespace ShoppingListy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
1. The program asks the user to provide a list of goods they would
need to buy from a supermarket.
User provides a list of goods separated by a comma and a space.
2. After the user has provided their list,
the program cleans the console, displays the provided list as, e.g.:
item 1: milk
item 2: bread
item 3:...
….
3. Program asks if the user would like to add or remove an item
or quit the app.
Depending on the user's choice,
the program adds or removes the item
(the user enters the item they want to add as a string) if the user has
chosen to quit the app, the program wishes them to shop wisely.
5. After the item has been added or removed, the program cleans
the console and displays an updated list and asks if the user would like
to add or remove another item or quit the app.
*/



           

            Console.WriteLine("Enter the goods you want to buy from the shop and separate them by commas.");
            string userChoices = Console.ReadLine();

            string[] items = userChoices.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> shoppingList = items.ToList();


            Console.Clear();
            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }

        
            while (true)
            {
                Console.WriteLine("Do you want to add something or to remove anything? Or do you want to quit the app?");
                Console.WriteLine("Write add or remove or press the Q to quit.");
                string userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "add")
                {
                    ToAdd(shoppingList);
                }




                else if (userAnswer.ToLower() == "remove")
                {
                    ToRemove(shoppingList);
                }

                else if(userAnswer.ToLower() == "q")
                {
                    Console.Clear();
                    Console.WriteLine("Shop wisely!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }

                foreach (string item in shoppingList)
                {
                    Console.WriteLine(item);

                }

            }

        }

        
        public static void ToAdd(List<string> shoppingList)
        {


            Console.WriteLine("Enter an item you want to add");
            string userInput = Console.ReadLine();
            shoppingList.Add(userInput);
            Console.Clear();
        }

       



        public static void ToRemove(List<string> shoppingList)
        {
            Console.WriteLine("Enter an item you want to remove.");
            string userInput = Console.ReadLine();
            shoppingList.Remove(userInput);
            Console.Clear();
        }
    }
}
