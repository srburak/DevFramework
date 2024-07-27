﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DevFramework.Northwind.Business.Concrete;
using DevFramework.Northwind.Business.Concrete.Managers;
using DevFramework.Northwind.DataAccsess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;
using Moq;

namespace DevFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);
            productManager.Add(new Product());
        }
    }
}
