using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Order
  {
    public string Title { get; set; }

    public Order (string orderTitle)
    {
      Title = orderTitle;
    }
  }
}