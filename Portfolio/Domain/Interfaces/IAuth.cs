using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces
{
    public interface IAuth
    {
        public bool ValidateAuth(Auth json, string userCompare, string passCompare);
        public Auth GetAuth(string json);
    }
}
