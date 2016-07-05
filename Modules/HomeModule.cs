using Nancy;
using System.Collections.Generic;
using QueenAttack;

namespace QueenAttack
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/Leetspeak"] = _ => {
        Queen newQueen = new Queen(
        Request.Query["xq"],Request.Query["yq"],Request.Query["x"],Request.Query["y"]);
        return View["attacked.cshtml", newQueen];
      };
    }
  }
}
