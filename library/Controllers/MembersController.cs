using library.Data;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    public class MembersController : Controller
    {
        private readonly MemberRepository _members;

        public MembersController(MemberRepository members)
        {
            _members = members;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _members.GetAllAsync());
        }
    }
}