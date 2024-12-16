using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces
{
    public interface IExperience
    {
        public List<Experience> GetExperiences(string pathFile);
    }
}
