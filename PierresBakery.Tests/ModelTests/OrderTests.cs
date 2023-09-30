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
      Order newOrder = new Order("test title", "10 pastries", 100);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "test title";
      string description = "10 pastries";
      int price = 100;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "test title";
      string description = "10 pastries";
      int price = 100;
      Order newOrder = new Order(title, description, price);
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
      int price = 100;
      Order newOrder = new Order(title, description, price);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      string title1 = "Monday ongoing order";
      string title2 = "Tuesday ongoing order";
      string description = "10 pastries";
      int price = 100;
      Order newOrder1 = new Order(title1, description, price);
      Order newOrder2 = new Order(title2, description, price);
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
      int price = 100;
      Order newOrder1 = new Order(title1, description, price);
      Order newOrder2 = new Order(title2, description, price);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "test title";
      string description = "10 pastries";
      int price = 100;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string title = "test title";
      string description = "10 pastries";
      int price = 100;
      Order newOrder = new Order(title, description, price);
      string changeDescription = "2 pastries";
      newOrder.Description = changeDescription;
      string result = newOrder.Description;
      Assert.AreEqual(changeDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string title = "test title";
      string description = "10 pastries";
      int price = 100;
      Order newOrder = new Order(title, description, price);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      string title = "test title";
      string description = "10 pastries";
      int price = 100;
      Order newOrder = new Order(title, description, price);
      int changePrice = 20;
      newOrder.Price = changePrice;
      int result = newOrder.Price;
      Assert.AreEqual(changePrice, result);
    }
  }
}