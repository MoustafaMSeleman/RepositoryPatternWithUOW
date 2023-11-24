using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.Core.IRepositories;
using RepositoryPatternWithUOW.Core.Models;

namespace RepositoryPatternWithUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutherController : ControllerBase
    {
        private IRepository<Auther> _repo;

        public AutherController(IRepository<Auther> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult GetAutherById(int id)
        {
            return Ok(_repo.GetById(id));
        }
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetAutherByIdAsync(int id)
        {
            return Ok(await _repo.GetByIdAsync(id));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }
    }
}
