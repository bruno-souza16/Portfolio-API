using Newtonsoft.Json;
using Portfolio.Domain.Interfaces;

namespace Portfolio.Domain.Entities
{
    public class Repositories : IRepositories
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }

        public List<Repositories> GetRepositories(string json)
        {
            if (json != null) return JsonConvert.DeserializeObject<List<Repositories>>(json)!;
            else throw new ArgumentNullException(nameof(json));
        }
    }
}
