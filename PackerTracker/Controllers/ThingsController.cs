using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ThingsController : Controller
  {

    [HttpGet("/things")]
    public ActionResult Index()
    {
      Dictionary<string, string> allthings = Thing.GetAll();
      return View(allthings);
    }

    [HttpGet("/things/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/things")]
    public ActionResult Create(string inputName, string inputWeight, string inputManufacturer, string inputPacked, string inputPurchase)
    {
      Thing myThing = new Thing();
      return RedirectToAction("Index");
    }

    [HttpPost("/things/delete")]
    public ActionResult Delete()
    {
      Thing.ClearAll();
      return View();
    }
    
    [HttpGet("/things/{id}")]
    public ActionResult Show(int id)
    {
      Thing foundThing = Thing.Find(id);
      return View(foundThing);
    }
  }
}