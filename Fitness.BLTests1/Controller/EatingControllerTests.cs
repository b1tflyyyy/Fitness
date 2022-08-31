using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fitness.BL.Controller;
using System;
using Fitness.BL.Model;

namespace Fitness.BL.Controller.Tests
{
    [TestClass()]
    public class EatingControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            var userName = Guid.NewGuid().ToString();
            var userController = new UserController(userName);

            var rnd = new Random();
            var eatingController = new EatingController(userController.CurrentUser);
            var foodName = Guid.NewGuid().ToString();
            var food = new Food(foodName,
                                rnd.Next(50, 500),
                                rnd.Next(50, 500),
                                rnd.Next(50, 500),
                                rnd.Next(50, 500));

            // Act
            eatingController.Add(food, 100);

            // Assert
            Assert.AreEqual(food.Name, eatingController.Eating.Foods.First().Key.Name);
        }
    }
}