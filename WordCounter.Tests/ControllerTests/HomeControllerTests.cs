using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCount.Controllers;
using WordCount.Models;

namespace WordCount.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      HomeController controller = new HomeController();

      ActionResult indexView = controller.Index();

      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      WordCounterController controller = new WordCounterController();

      ActionResult newView = controller.New();

      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_ViewResult()
    {
      WordCounterController controller = new WordCounterController();

      IActionResult view = controller.Create("hello", "hello you hello");

      Assert.IsInstanceOfType(view, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectView_Index()
    {
      WordCounterController controller = new WordCounterController();
      ViewResult viewResult = controller.Create("hello", "hello you hello") as ViewResult;

      string result = viewResult.ViewName;

      Assert.AreEqual(result, "Index");
    }
  }
}
