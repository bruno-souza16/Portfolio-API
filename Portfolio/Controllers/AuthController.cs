using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.Entities;
using Portfolio.Domain.Interfaces;
using Portfolio.Infrastructure.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IJsonLoader _jsonLoader;

        public AuthController()
        {
            _jsonLoader = new JsonLoader(new Experience(), new Formation(), new Qualification(), new Person(), new Repositories(), new Auth());
        }

        // POST api/<AuthController>
        [HttpPost]
        [Route("/api/auth")]
        public bool Post([FromBody]Auth value)
        {
            return _jsonLoader.PostLogin(value);
        }

    }
}
