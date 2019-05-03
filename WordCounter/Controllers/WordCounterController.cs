using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCount.Models;

namespace WordCount.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/wordcounter/show")]
    public ActionResult Show()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create(string word, string sentence)
    {
      if (sentence.Contains('.') || sentence.Contains('?') || sentence.Contains('!') || sentence.Contains(',') || sentence.Contains(';') || word.Contains(' '))
      {
        return View("Invalid");
      }
      else
      {
      Machine newMachine = new Machine(word, sentence);
      return View("Index", newMachine);
      }
    }

  }
}
