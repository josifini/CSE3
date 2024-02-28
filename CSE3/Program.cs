using System;
class Program
{
    static void Main(string[] args)
    {
        RecipeManager manager = new RecipeManager();

        // Add a couple of recipes
        manager.AddRecipe("Pasta", "Pasta, Tomato Sauce", "Boil pasta; add sauce");
        manager.AddRecipe("Salad", "Lettuce, Tomato, Cucumber", "Chop ingredients; mix");
        manager.AddRecipe("Pancake", "Pancake Mix, Water, pinch of salt", "Mix ingredients; spoon 3tablespoon of batter onto the skillet. Make sure to flip the pancake once each side is done! ");

        // List recipes
        Console.WriteLine("All Recipes:");
        manager.ListRecipes();

        // Search for a recipe
        var searchResult = manager.SearchRecipe("Pasta");
        if (searchResult.HasValue)
        {
            Console.WriteLine("Search Result:");
            Console.WriteLine(searchResult.Value);
        }

        // Save recipes to file
        string filePath = "recipes.txt";
        manager.SaveToFile(filePath);

        // Load recipes from file
        manager.LoadFromFile(filePath);
        Console.WriteLine("Recipes loaded from file:");
        manager.ListRecipes();
    }
}