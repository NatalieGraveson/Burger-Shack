using System.Collections.Generic;
using BurgerShack.Models;

namespace BurgerShack.Models
{
  public class App
  {
    List<Burgers> Burgers { get; set; } = new List<Burgers>()
      {
         new Burgers("Chew And Swallow", 5.00m),
        new Burgers("Don't Think Just Eat", 5.00m)
      };

    List<Sides> Sides { get; set; } = new List<Sides>()
      {
          new Sides("Is It A Fry", 2.00m),
          new Sides("Corn On The Brain", 3.00m)
      };

    List<Drinks> Drinks { get; set; } = new List<Drinks>()
      {
        new Drinks("SoftDrink", "Dr.Pepper", 1.00m),
        new Drinks("SoftDrink", "Coke", 1.00m),
        new Drinks("Water", "Bottled Water", 1.00m),
        new Drinks("Water", "Sparkling Water", 1.00m)
      };

    public int ItemCount { get; set; } = 1;

    public void PrintBurgers()
    {
      for (int i = 0; i < Burgers.Count; i++)
      {
        System.Console.WriteLine($"{i + 1} {Burgers[i].Name} - {Burgers[i].Price}");
      }
    }
    public void PrintDrinks()
    {
      for (int i = 0; i < Drinks.Count; i++)
      {
        System.Console.WriteLine($"{i + 1} {Drinks[i].Name} - {Drinks[i].Price}");
      }
    }
    public void PrintSides()
    {
      for (int i = 0; i < Sides.Count; i++)
      {
        System.Console.WriteLine($"{i + 1} {Sides[i].Name} - {Sides[i].Price}");
      }
    }
    public void PrintAll()
    {
      PrintBurgers();
      PrintSides();
      PrintDrinks();
    }


  }
}