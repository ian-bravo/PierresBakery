using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public string Description { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      _instances.Add(this); 
      Id = _instances.Count;
      Orders = new List<Order> {};
      Description = vendorDescription;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int findId)
    {
      return _instances[findId-1];
    }

    public void AddOrder(Order addOrder)
    {
      Orders.Add(addOrder);
    }
  }
}