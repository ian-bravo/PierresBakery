using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Title { get; set; }
    public int Id { get; }
    public string Description { get; set; }
    public int Price { get; set; }

    public Order (string orderTitle, string orderDescription, int orderPrice)
    {
      Title = orderTitle;
      _instances.Add(this);
      Id = _instances.Count;
      Description = orderDescription;
      Price = orderPrice;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int findId)
    {
      return _instances[findId-1];
    }
  }
}