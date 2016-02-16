using System;
using Microsoft.AspNet.Mvc;


namespace TheWorld.Controllers.Web
{
	public class AppController : Controller
	{
		public IActionResult Index()
		{
			Console.WriteLine("Index Controller") ;
			Console.WriteLine(View().ViewName.Length) ;
			Console.WriteLine("Hello") ;
			
			return View();
		}
	}
}