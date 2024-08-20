using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace GolfCourseApp
{
    public class TeeBoxConverter : Newtonsoft.Json.JsonConverter<List<Tee>>
    {
        public override void WriteJson(JsonWriter writer, List<Tee> value, JsonSerializer serializer)
        {
            // Implement serialization logic if needed
            throw new NotImplementedException();
        }

        public override List<Tee> ReadJson(JsonReader reader, Type objectType, List<Tee> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            var tees = new List<Tee>();

            // Assuming each item in the JSON array is a Tee object
            foreach (var teeToken in token)
            {
                var tee = teeToken.ToObject<Tee>();
                if (tee != null)
                {
                    tees.Add(tee);
                }
            }

            return tees;
        }
    }
}
