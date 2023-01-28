using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Class_Exercise_2;




namespace Class_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    CatFood catFood = new CatFood();

                    Console.WriteLine("\nAdding Cat Food");

                    Console.WriteLine("Name of Cat Food:");
                    catFood.Name = Console.ReadLine();

                    Console.WriteLine("Price:");
                    catFood.Price = Decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Quantity:");
                    catFood.Quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Description:");
                    catFood.Description = Console.ReadLine();

                    Console.WriteLine("Weight in Pounds:");
                    catFood.WeightPounds = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Is it kitten food? Y or N");
                    catFood.IsKittenFood = Console.ReadLine().ToUpper() == "Y";

                    Console.WriteLine(JsonSerializer.Serialize(catFood));
                }
                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Type 'exit to quit");
                userInput = Console.ReadLine();

                
              

            }
        }
    }
}
