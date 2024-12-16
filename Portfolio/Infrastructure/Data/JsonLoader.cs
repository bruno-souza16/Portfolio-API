using Portfolio.Domain.Interfaces;
using Portfolio.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Portfolio.Infrastructure.Data
{
    public class JsonLoader : IJsonLoader
    {
        IExperience _experience;
        IFormation _formation;
        IQualification _qualification;
        IPerson _person;
        IRepositories _repositories; 
        IAuth _auth;


        public JsonLoader(IExperience experience, IFormation formation, IQualification qualification, IPerson person, IRepositories repositories, IAuth auth) 
        { 
            _experience = experience;
            _formation = formation;
            _qualification = qualification;
            _person = person;
            _repositories = repositories; 
            _auth = auth;
        }

        public Formation LoadFormation() { return _formation.GetFormation(File.ReadAllText(@"C:\Users\bruno\source\repos\Portfolio\Portfolio\Infrastructure\Repositories\formation.json")); }
        public Person LoadPerson() { return _person.GetPerson(File.ReadAllText(@"C:\Users\bruno\source\repos\Portfolio\Portfolio\Infrastructure\Repositories\person.json")); }
        public List<Experience> LoadExperience() { return _experience.GetExperiences(File.ReadAllText(@"C:\Users\bruno\source\repos\Portfolio\Portfolio\Infrastructure\Repositories\experience.json")); }
        public List<Qualification> LoadQualification() { return _qualification.GetQualifications(File.ReadAllText(@"C:\Users\bruno\source\repos\Portfolio\Portfolio\Infrastructure\Repositories\qualifications.json")); }
        public List<Repositories> LoadRepositories() { return _repositories.GetRepositories(File.ReadAllText(@"C:\Users\bruno\source\repos\Portfolio\Portfolio\Infrastructure\Repositories\repositories.json")); }
    

        public bool PostLogin(Auth json)
        {
            Auth auth = _auth.GetAuth(File.ReadAllText(@"C:\Users\bruno\source\repos\Portfolio\Portfolio\Infrastructure\Repositories\access.json"));
            if (auth.Username != null && auth.Password != null)
                return _auth.ValidateAuth(json, auth.Username, auth.Password);
            else
                return false;
        }
    }
}
