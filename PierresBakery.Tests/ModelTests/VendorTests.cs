using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor-name", "best vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test vendor-name";
      string description = "best vendor";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "test vendor-name";
      string description = "best vendor";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id; 
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Peets";
      string name2 = "Starbucks";
      string description = "best vendor";
      Vendor newVendor1 = new Vendor(name1, description);
      Vendor newVendor2 = new Vendor(name2, description);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Peets";
      string name2 = "Starbucks";
      string description = "best vendor";
      Vendor newVendor1 = new Vendor(name1, description);
      Vendor newVendor2 = new Vendor(name2, description);

      Vendor result = Vendor.Find(1);

      Assert.AreEqual(newVendor1, result);
    }

    [TestMethod]
    public void AddOrder_ConnectsOrderToVendor_OrderList()
    {
      string title = "Wednesday ongoing order";
      string descriptionOfOrder = "10 pastries";
      int price = 100;
      string date = "sept 29";
      Order newOrder = new Order(title, descriptionOfOrder, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Peets";
      string description = "best vendor";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "test vendor-name";
      string description = "best vendor";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string name = "test vendor-name";
      string description = "best vendor";
      Vendor newVendor = new Vendor(name, description);
      string changeDescription = "an ok vendor";
      newVendor.Description = changeDescription;
      string result = newVendor.Description;
      Assert.AreEqual(changeDescription, result);
    }
  }
}