using Newtonsoft.Json;
using Portfolio.Domain.Interfaces;

namespace Portfolio.Domain.Entities
{
    public class Qualification : IQualification
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public List<Qualification> GetQualifications(string json)
        {
            if (json != null) return JsonConvert.DeserializeObject<List<Qualification>>(json)!;
            else throw new ArgumentNullException(nameof(json));
        }
    }
}
