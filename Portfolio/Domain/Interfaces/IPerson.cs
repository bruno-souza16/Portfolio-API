using Newtonsoft.Json;
using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces
{
    public interface IPerson
    {
        public Person GetPerson(string json);
    }
}
