using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces
{
    public interface IFormation
    {
        public Formation GetFormation(string pathFile);
    }
}
