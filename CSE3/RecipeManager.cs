using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class RecipeManager
{
    private List<Recipe> recipes;

    public RecipeManager()
    {
        recipes = new List<Recipe>();
    }

    public void AddRecipe(string title, string ingredients, string instructions)
    {
        recipes.Add(new Recipe(title, ingredients, instructions));
    }

    public void ListRecipes()
    {
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe);
            Console.WriteLine();
        }
    }

    public Recipe? SearchRecipe(string title)
    {
        foreach (var recipe in recipes)
        {
            if (recipe.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return recipe;
            }
        }

        return null;
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter file = new StreamWriter(filePath))
        {
            foreach (var recipe in recipes)
            {
                file.WriteLine($"{recipe.Title}|{recipe.Ingredients}|{recipe.Instructions}");
            }
        }
    }

    public void LoadFromFile(string filePath)
    {
        recipes.Clear();
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                AddRecipe(parts[0], parts[1], parts[2]);
            }
        }
    }
}