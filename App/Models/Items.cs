namespace BurgerShack.Models
{
  abstract class Items
  {
    public string Name { get; set; }

    public decimal Price { get; set; }


    public void Purchase()
    {

    }


    public Items(string name, decimal price)
    {
      Name = name;
      Price = price;

    }
  }
}















