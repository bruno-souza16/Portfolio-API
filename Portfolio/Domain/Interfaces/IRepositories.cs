using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces
{
    public interface IRepositories
    {
        public List<Repositories> GetRepositories(string json);
    }
}
