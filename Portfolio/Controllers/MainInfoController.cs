using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.Interfaces;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Data;

namespace Portfolio.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class MainInfoController : ControllerBase
    {
        IJsonLoader _jsonLoader;

        public MainInfoController()
        {
            _jsonLoader = new JsonLoader(new Experience(), new Formation(), new Qualification(), new Person(), new Repositories(), new Auth());
        }

        // GET: api/<MainInfoController>/experience
        [Route("/api/experience")]
        [HttpGet]
        public IEnumerable<Experience> GetExperience()
        {
            return _jsonLoader.LoadExperience();
        }

        // GET: api/<MainInfoController>/qualification
        [Route("/api/qualification")]
        [HttpGet]
        public IEnumerable<Qualification> GetQualifications()
        {
            return _jsonLoader.LoadQualification();
        }

        // GET: api/<MainInfoController>/formation
        [Route("/api/formation")]
        [HttpGet]
        public Formation GetFormation()
        {
            return _jsonLoader.LoadFormation();
        }

        // GET: api/<MainInfoController>/formation
        [Route("/api/person")]
        [HttpGet]
        public Person GetPerson()
        {
            return _jsonLoader.LoadPerson();
        }

        // GET: api/<MainInfoController>/formation
        [Route("/api/repositories")]
        [HttpGet]
        public IEnumerable<Repositories> GetRepositories()
        {
            return _jsonLoader.LoadRepositories();
        }
    }
}
