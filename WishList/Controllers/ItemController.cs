
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Create() => View();
    }
}
