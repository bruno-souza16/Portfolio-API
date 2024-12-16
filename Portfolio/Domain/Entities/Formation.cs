using Newtonsoft.Json;
using Portfolio.Domain.Interfaces;

namespace Portfolio.Domain.Entities
{
    public class Formation : IFormation
    {
        public int Id { get; set; }
        public string? Institution { get; set; }
        public string? Course { get; set; }
        public int? Year { get; set; }

        public Formation GetFormation(string json) 
        {
            if (json != null) return JsonConvert.DeserializeObject<Formation>(json)!;            
            else throw new ArgumentNullException(nameof(json));                 
        }
    }
}
