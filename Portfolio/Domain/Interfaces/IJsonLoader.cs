using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces
{
    public interface IJsonLoader
    {
        public Formation LoadFormation();
        public Person LoadPerson();
        public List<Experience> LoadExperience();
        public List<Qualification> LoadQualification();
        public List<Repositories> LoadRepositories();
        public bool PostLogin(Auth json);
    }
}
