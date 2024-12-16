using Newtonsoft.Json;
using Portfolio.Domain.Interfaces;

namespace Portfolio.Domain.Entities
{
    public class Experience : IExperience
    {
        public int Id { get; set; }
        public string? Company { get; set; }
        public string? Title { get; set; }
        public string? DateStart { get; set; }
        public string? DateEnd { get; set; }
        public string? Description { get; set; }

        public List<Experience> GetExperiences(string json)
        {
            if (json != null) return JsonConvert.DeserializeObject<List<Experience>>(json)!;
            else throw new ArgumentNullException(nameof(json));
        }
    }    
}
