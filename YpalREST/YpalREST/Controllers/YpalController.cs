using Microsoft.AspNetCore.Mvc;
using YpalREST.Models;
using YpalREST.Repo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YpalREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YpalController : ControllerBase
    {
        private IYpal _YpalRepo;


        public YpalController(IYpal ypalRepo)
        {
            _YpalRepo = ypalRepo;
            // _BookRepo = new InMemBookRepo();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ypal>> GetYpals()
        {
            return _YpalRepo.GetYpals().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Ypal> GetYpal(Guid id)
        {
            var student = _YpalRepo.GetYpal(id);
            if (student == null)
                return NotFound();
            return student;
        }

        // POST api/Books
        [HttpPost]
        public ActionResult CreateYpal(CreateOrUpdateYpalSchema ypal)
        {
            var myypal = new Ypal();
            myypal.YpalID = Guid.NewGuid();
            myypal.Name = ypal.Name;
            myypal.Email = ypal.Email;
            _YpalRepo.CreateYpal(myypal);
            return Ok();
        }
    }
}
