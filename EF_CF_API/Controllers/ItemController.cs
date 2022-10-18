using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataBase;

namespace EF_CF_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase {
        private TestContext _context;
        public ItemController(TestContext context) {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Item> Get() => _context.Items.ToList();
    }
}
