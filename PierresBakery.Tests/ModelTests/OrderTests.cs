using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test title", "10 pastries");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "test title";
      string description = "10 pastries";
      Order newOrder = new Order(title, description);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "test title";
      string description = "10 pastries";
      Order newOrder = new Order(title, description);
      string changeTitle = "modified holiday order";
      newOrder.Title = changeTitle;
      string result = newOrder.Title;
      Assert.AreEqual(changeTitle, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title = "test title";
      string description = "10 pastries";
      Order newOrder = new Order(title, description);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      string title1 = "Monday ongoing order";
      string title2 = "Tuesday ongoing order";
      string description = "10 pastries";
      Order newOrder1 = new Order(title1, description);
      Order newOrder2 = new Order(title2, description);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title1 = "Monday ongoing order";
      string title2 = "Tuesday ongoing order";
      string description = "10 pastries";
      Order newOrder1 = new Order(title1, description);
      Order newOrder2 = new Order(title2, description);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "test title";
      string description = "10 pastries";
      Order newOrder = new Order(title, description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}