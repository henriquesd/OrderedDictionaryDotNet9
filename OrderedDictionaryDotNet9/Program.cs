// Creating an OrderedDictionary<TKey, TValue>, to store recipe steps;
var recipeSteps = new OrderedDictionary<int, string>
{
    [1] = "Gather all ingredients.",
    [2] = "Mix flour and sugar",
    [3] = "Add eggs and stir well",
};

// Adding a new step at the end of the OrderedDictionary with key 4;
recipeSteps.Add(4, "Bake for 25 minutes.");

// Removing the first element in the dictionary by its index;
recipeSteps.RemoveAt(0);

// Inserting a new step at the beginning of the OrderedDictionary (position 0), with key 1;
recipeSteps.Insert(0, 1, "Preheat the oven to 180°C");

// Displaying the recipe steps in order;
Console.WriteLine("Recipe Steps:");
foreach (var step in recipeSteps) Console.WriteLine($"Step {step.Key}: {step.Value}");