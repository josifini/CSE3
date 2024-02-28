using System;
public struct Recipe
{
    public string Title;
    public string Ingredients;
    public string Instructions;

    public Recipe(string title, string ingredients, string instructions)
    {
        Title = title;
        Ingredients = ingredients;
        Instructions = instructions;
    }

    public override string ToString()
    {
        return $"Title: {Title}\nIngredients: {Ingredients}\nInstructions: {Instructions}";
    }
}