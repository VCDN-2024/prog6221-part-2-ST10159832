using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10159832_Part2PoeProg6221
{
    internal class Layout
    {
        public void ProgramLayout()
        {
            RecipeProcess recipeProcess = new RecipeProcess();
            bool exit = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Add a new recipe");
                Console.WriteLine("2) Display list of recipes");
                Console.WriteLine("3) Display a recipe");
                Console.WriteLine("4) Display total calories of a recipe");
                Console.WriteLine("5) Exit");

                Console.WriteLine("Please enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipeProcess.AddRecipe();
                        break;
                    case 2:
                        recipeProcess.DisplayRecipes();
                        break;
                    case 3:
                        Console.WriteLine("Enter the name of the recipe to display:");
                        string recipeName = Console.ReadLine();
                        recipeProcess.DisplayRecipe(recipeName);
                        break;
                    case 4:
                        Console.WriteLine("Enter the name of the recipe to display total calories:");
                        string recipeNameForCalories = Console.ReadLine();
                        recipeProcess.DisplayTotalCalories(recipeNameForCalories);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        break;
                }
            } while (!exit);
        }
    }
}
