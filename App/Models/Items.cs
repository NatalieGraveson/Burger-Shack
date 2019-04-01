namespace BurgerShack.Models
{
  abstract class Items
  {
    public string Name { get; set; }

    public decimal Price { get; set; }


    public decimal Purchase()
    {
      return Price;

    }


    public Items(string name, decimal price)
    {
      Name = name;
      Price = price;

    }
  }
}















