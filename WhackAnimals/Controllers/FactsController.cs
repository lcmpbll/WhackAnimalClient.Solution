using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhackAnimals.Models;

namespace WhackAnimals.Controllers.v1
{
  public class FactsV1Controller: Controller
  {
    public IActionResult Index()
    {
      var allFacts = Fact.GetFacts();
      return View(allFacts);
    }


  }
}