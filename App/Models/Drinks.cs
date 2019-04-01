namespace BurgerShack.Models
{
  class Drinks : Items
  {
    public string Type { get; set; }


    public Drinks(string type, string name, decimal price) : base(name, price)
    {
      Type = type;
    }

  }
}
