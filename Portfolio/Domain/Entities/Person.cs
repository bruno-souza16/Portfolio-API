using Newtonsoft.Json;
using Portfolio.Domain.Interfaces;

namespace Portfolio.Domain.Entities
{
    public class Person : IPerson
    {
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public int? Filhos { get; set; }
        public string? EstadoCivil { get; set; }
        public string? Residencia { get; set; }
        public string? Whatsapp { get; set; }
        public string? Email { get; set; }
        public string? Objetivo { get; set; }
        public string? Sobre { get; set; }

        public Person GetPerson(string json)
        {
            if (json != null) return JsonConvert.DeserializeObject<Person>(json)!;
            else throw new ArgumentNullException(nameof(json));
        }
    }
}
