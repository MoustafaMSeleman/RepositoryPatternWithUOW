using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.Core.IRepositories;
using RepositoryPatternWithUOW.Core.Models;

namespace RepositoryPatternWithUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IRepository<Book> _repo;

        public BookController(IRepository<Book> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_repo.GetById(id));
        }
    }
}
