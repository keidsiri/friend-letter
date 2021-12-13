using Microsoft.AspNetCore.Mvc;  //imports functionality from the ASP.NET Core MVC package

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    public string Hello() { return "Hello friend!"; }
  }
}