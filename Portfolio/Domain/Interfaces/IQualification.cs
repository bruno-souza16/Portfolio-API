using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces
{
    public interface IQualification
    {
        public List<Qualification> GetQualifications(string pathFile);
    }
}
