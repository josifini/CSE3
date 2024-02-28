# Overview

As a college student, what I want to accomplish from this project is taking a deeper dive into learning  several fundamental aspects of software development, including object-oriented programming, file I/O operations, and data management.

The core functionality of the Recipe Management System is encapsulated in two main components: a Recipe struct and a RecipeManager class. The Recipe struct represents the data structure for storing individual recipes, including properties for the recipe's title, ingredients, and instructions. The RecipeManager class, on the other hand, manages a collection of recipes, providing methods to add a new recipe, list all recipes, search for a specific recipe by title, and save or load recipes from a file.

# Key Features

Adding Recipes: Users can add new recipes to the system, specifying the title, ingredients, and instructions. This demonstrates the use of classes and methods, as well as parameter passing and handling user input.

Listing Recipes: The system can display all recipes currently stored, illustrating the use of loops to iterate over a collection and the overriding of the ToString method to format the output.

Searching for Recipes: Users can search for a recipe by title, showcasing conditional logic and the use of LINQ (Language Integrated Query) for data retrieval from collections.

File I/O Operations: The system can save all recipes to a file and load them back, demonstrating file handling in C#, including writing to and reading from text files, thereby practicing exception handling for potential runtime errors.

Beyond the technical skills acquired, this project was a journey in self-improvement and personal growth. It tested my perseverance, especially when faced with difficult bugs or design decisions, and improved my ability to research and learn independently. The experience has also heightened my appreciation for the importance of clean, readable code and the value of thorough testing and documentation.

[Software Demo Video](https://youtu.be/g5JiPrtax1I)

Variables and Expressions:Variables: The RecipeManager class contains a variable recipes which is a list of Recipe structures. Each Recipe structure has variables Title, Ingredients, and Instructions.
Example;
private List<Recipe> recipes;
public string Title;
public string Ingredients;
public string Instructions;

Expressions: In the AddRecipe method, an instance of Recipe is created using an expression that combines the title, ingredients, and instructions parameters.
Example;
recipes.Add(new Recipe(title, ingredients, instructions));

Conditionals:The SearchRecipe method uses a conditional statement to check if any recipe's title matches the search query, ignoring case differences.
Example;
if (recipe.Title.Equals(title, StringComparison.OrdinalIgnoreCase))

Loops:The ListRecipes and LoadFromFile methods use foreach loops to iterate over the collection of recipes and lines in a file, respectively.
Example;
foreach (var recipe in recipes)
foreach (string line in lines)

Functions (Methods):The RecipeManager class defines several methods such as AddRecipe, ListRecipes, SearchRecipe, SaveToFile, and LoadFromFile. These encapsulate specific functionalities and can be called on instances of the class.
Example;
public void AddRecipe(string title, string ingredients, string instructions)

Classes:The RecipeManager class encapsulates data and methods related to managing a collection of recipes. It demonstrates the use of object-oriented programming principles in C#.
Example;
public class RecipeManager

Structures:The Recipe structure represents a simple data entity with properties for Title, Ingredients, and Instructions. Structures are value types in C# and are used here to model each recipe.
Example;
public struct Recipe

File I/O:The methods SaveToFile and LoadFromFile demonstrate file I/O operations. SaveToFile writes the recipes to a file, while LoadFromFile reads them back into the application.
Example;
using (StreamWriter file = new StreamWriter(filePath))
string[] lines = File.ReadAllLines(filePath);

# Development Environment

The combination of Visual Studio, C#, and the .NET Core framework, along with essential libraries and version control with Git and GitHub, provided a robust and efficient development environment for the Recipe Management System. This setup not only facilitated the writing of clean and maintainable code but also ensured a smooth workflow from development to deployment, showcasing the power and flexibility of the chosen tools and technologies.
C#: The core programming language used for the project. C# is a modern, object-oriented, and type-safe programming language developed by Microsoft. It is part of the .NET framework, which provides a comprehensive class library that supports a wide range of applications from web to mobile to Windows-based applications.

# Useful Websites

- [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)
- [A Beginners Guide For C#](https://www.pluralsight.com/blog/software-development/everything-you-need-to-know-about-c-#:~:text=What%20is%20C%23%20used%20for,Lots%20and%20lots%20of%20games.)

# Future Work

- Recipe Editing and Deletion: Add functionality to edit and delete existing recipes. This would allow users to manage their recipes more effectively, correcting any mistakes or removing outdated recipes.
- User Authentication: Implement a simple user authentication system to allow multiple users to maintain their own private collections of recipes. This could start with basic username/password authentication.
- Mobile Application: Explore the development of a companion mobile app that syncs with the desktop application, allowing users to access their recipes on the go.