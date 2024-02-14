using Microsoft.AspNetCore.Mvc;
using View_Component_And_Partial_View.Models;

namespace View_Component_And_Partial_View.Components
{
    public class CommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            HttpClient client = new HttpClient();
            ICollection<CommentViewModel> comments =
            client.GetFromJsonAsync<ICollection<CommentViewModel>>
            ("https://jsonplaceholder.typicode.com/comments?postId=" + id).Result;
            return View("~/Views/Components/_Comments.cshtml", comments);
        }
    }
}
