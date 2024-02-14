using Microsoft.AspNetCore.Mvc;
using View_Component_And_Partial_View.Models;

namespace View_Component_And_Partial_View.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            PostViewModel model = new PostViewModel
            {
                Id = 1,
                Title = "What is ASP.NET Core",
                Author = "Shailendra Chauhan",
                Body = "ASP.NET Core is an open-source framework for building UI and API..."
            };
            return View(model);
        }
    }
}
