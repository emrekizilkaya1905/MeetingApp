using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers {
  public class HomeController:Controller 
  {
  
    public IActionResult Index() {
      int hour=DateTime.Now.Hour;
      // ViewBag.hi= hour >12 ? "Good Day" : "Good Morning";
      ViewData["hi"]=hour >12 ? "Good Day" : "Good Morning";
      int userCount = Repository.Users.Where(info => info.WillAttend == true).Count();
    
      var meetingInfo=new MeetingInfo(){
        Id = 1,
        Location="Stockholm Globen Center",
        Date=new DateTime(2024,12,01,20,0,0),
        NumberOfPeople=userCount
      };
      return View(meetingInfo);
    }
  }
}