using Newtonsoft.Json;
using Portfolio.Domain.Interfaces;

namespace Portfolio.Domain.Entities
{
    public class Auth : IAuth
    {
        public string? Username { get; set; }
        public string? Password { get; set; }      

        public bool ValidateAuth(Auth json, string userCompare, string passCompare)
        {
            if (json == null) throw new ArgumentNullException("username or password is null");

            try
            {
                if (json.Username == userCompare)
                {
                    if (json.Password == passCompare)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public Auth GetAuth(string json)
        {
            if (json != null) return JsonConvert.DeserializeObject<Auth>(json)!;
            else throw new ArgumentNullException(nameof(json));
        }

    }
}
