using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace DevCard_MVC.ViewComponents
{
	public class ProjectViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<project>
   {
				new project(id: 1, name: "تاکسی", description: "درخواست آنلاین تاکسی برای سفر های درون شهری", image: "project-1.jpg", client: "Snapp"),
				new project(id: 2, name: "زود فود", description: "درخواست آنلاین غذا برای سراسر کشور", image: "project-7.jpg", client: "ZOODFOOD"),
				new project(id: 3, name: "مدارس", description: "سیستم مدیریت یکپارچه مدارس", image: "project-4.jpg", client: "MONOP"),
				new project(id: 4, name: "کشاورزی", description: "برنامه مدیریت یکپارچه آبیاری زمین های کشاورزی", image: "project-5.jpg", client: "Green"),

   };
			return View("_project", projects);
		}
	}
}
