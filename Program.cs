using System;
using System.Collections.Generic;
using BurgerShack.Models;

namespace BurgerShack
{
  class Program
  {
    static void Main(string[] args)
    {

      App app = new App();
      bool playing = true
      Console.WriteLine("Welcome to the Best Burger Shack");



      Console.WriteLine("Would you like to view the menu? ");
      string result = Console.ReadLine().ToLower();
      if (result == "no")
      {
        return;
      }
      while (playing)
      {


        System.Console.WriteLine("Burgers");

        System.Console.WriteLine("Sides");

        System.Console.WriteLine("Drinks");

        System.Console.WriteLine("Select Item: ");
        string category = Console.ReadLine().ToLower();
        if (category != "burgers")
        {
          System.Console.WriteLine("invalid Item. Please try again");
        }
        else
        {
          app.PrintBurgers();
          System.Console.WriteLine("Please select number: ");
          string selection = Console.ReadLine();
          int select;
          if (!Int32.TryParse(selection, out select))
          {
            System.Console.WriteLine("That is not a number...");
            continue;
          }
        }
      }















    }
  }
}