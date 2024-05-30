using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10159832_Part2PoeProg6221
{
    internal class RecipeProcess
    {
        // Collection to store recipes
        List<Recipe> recipes = new List<Recipe>();

        // Method to add a new recipe
        public void AddRecipe()
        {
            Recipe recipe = new Recipe();
            Console.WriteLine("Please enter the name of the recipe: ");
            recipe.Name = Console.ReadLine();

            // Adding ingredients
            recipe.Ingredients = new List<Ingredient>(); // Ensure Ingredients is initialized
            Console.WriteLine("Please enter the number of ingredients used in the recipe: ");
            int numIngredients = int.Parse(Console.ReadLine());
            for (int i = 0; i < numIngredients; i++)
            {
                Ingredient ingredient = new Ingredient();
                Console.WriteLine($"Enter ingredient {i + 1} name: ");
                ingredient.Name = Console.ReadLine();
                Console.WriteLine($"Enter quantity for {ingredient.Name}: ");
                ingredient.Quantity = double.Parse(Console.ReadLine());
                Console.WriteLine($"Enter unit for {ingredient.Name}:");
                ingredient.Unit = Console.ReadLine();
                Console.WriteLine($"Enter calories for {ingredient.Name}: ");
                ingredient.Calories = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter food group for {ingredient.Name}: ");
                ingredient.FoodGroup = Console.ReadLine();
                recipe.Ingredients.Add(ingredient);
            }

            // Adding steps
            recipe.Steps = new List<string>(); // Ensure Steps is initialized
            Console.WriteLine("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}: ");
                recipe.Steps.Add(Console.ReadLine());
            }

            recipes.Add(recipe);
        }

        // Method to display list of recipes
        public void DisplayRecipes()
        {
            try
            {
                Console.WriteLine("List of Recipes: ");
                var sortedRecipes = recipes.OrderBy(r => r.Name).ToList();
                foreach (var recipe in sortedRecipes)
                {
                    Console.WriteLine(recipe.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while displaying recipes: {ex.Message}");
            }
        }

        // Method to display a recipe
        public void DisplayRecipe(string recipeName)
        {
            try
            {
                Recipe recipe = recipes.FirstOrDefault(r => r.Name == recipeName);
                if (recipe != null)
                {
                    Console.WriteLine($"Recipe: {recipe.Name}");
                    Console.WriteLine("Ingredients:");
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
                        Console.WriteLine($"Calories: {ingredient.Calories}");
                    }
                    Console.WriteLine("Steps:");
                    foreach (var step in recipe.Steps)
                    {
                        Console.WriteLine(step);
                    }
                }
                else
                {
                    Console.WriteLine("The recipe not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while displaying the recipe: {ex.Message}");
            }
        }

        // Method to calculate and display total calories of a recipe
        public void DisplayTotalCalories(string recipeName)
        {
            try
            {
                Recipe recipe = recipes.Find(r => r.Name == recipeName);
                if (recipe != null)
                {
                    int totalCalories = recipe.CalculateTotalCalories();
                    Console.WriteLine($"The total Calories for {recipe.Name}: {totalCalories}");
                    if (totalCalories > 300)
                    {
                        Console.WriteLine("The total calories of the recipe exceeds 300");
                    }
                }
                else
                {
                    Console.WriteLine("The recipe was not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while calculating and displaying total calories: {ex.Message}");
            }
        }


    }
}
