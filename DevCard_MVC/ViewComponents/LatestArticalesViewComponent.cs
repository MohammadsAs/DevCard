using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace DevCard_MVC.ViewComponents
{
	public class LatestArticalesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var article = new List<Articale>
			{
				new Articale(id: 1,title:"آموزش 20 کتابخانه جاوااسکریپت برای بازار کار",description:"امروزه کتابخانه‌ها کد نویسی را خیلی آسان و لذت بخش تر کرده.",
				image: "blog-post-thumb-4.jpg"),
				new Articale(id: 2,title:"آموزش کاربردی Git & Github",description:"گیت یه Version Controller هست که نسخه های مختلف پروژه هامون رو مدیریت و",
				image: "blog-post-thumb-3.jpg"),
				new Articale(id: 3,title:"آموزش اموزش لینوکس با گرایش امنیت",description:"کاملترین دوره آموزش لینوکس با گرایش امنیت",
				image: "blog-post-thumb-5.jpg"),
				new Articale(id: 4,title:"آموزش جنگو به صورت پروژه محور",description:" آموزش جنگو به صورت کامل ",
				image: "blog-post-thumb-1.jpg"),

			};
			return View("ArticleLatest", article);
		}
	}
}
