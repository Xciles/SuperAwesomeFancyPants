using System;
using Newtonsoft.Json;

namespace SuperAwesomeFancyPants.Threading.Logic
{
    public class JsonManager
    {
        public string ConvertToJson(User user)
        {
            return JsonConvert.SerializeObject(user);
        }

        public User ConvertToJson(string stringToDeserialize)
        {
            return JsonConvert.DeserializeObject<User>(stringToDeserialize);
        }
    }
}
