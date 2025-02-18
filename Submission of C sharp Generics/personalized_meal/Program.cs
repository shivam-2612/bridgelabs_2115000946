using System;

interface IMealPlan { }
class VegetarianMeal : IMealPlan { }
class VeganMeal : IMealPlan { }

class Meal<T> where T : IMealPlan
{
    public string Name { get; set; }
}

class MealPlanGenerator
{
    public static void GenerateMeal<T>(T meal) where T : IMealPlan
    {
        Console.WriteLine($"Meal Plan Created: {meal.GetType().Name}");
    }
}

class Program
{
    static void Main()
    {
        Meal<VegetarianMeal> vegetarianMeal = new Meal<VegetarianMeal> { Name = "Veg Salad" };
        MealPlanGenerator.GenerateMeal(vegetarianMeal);
    }
}
