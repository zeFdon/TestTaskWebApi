using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TestTaskWebApi.Dto
{
	[Serializable]
	public class PersonDto
	{

		//public PersonDto(string json)
		//{
		//	JObject jObject = JObject.Parse(json);
		//	JToken jUser = jObject["results"];
		//	Name = (string) jUser["name"];
		//	Status = (string)jUser["status"];
		//	Species = (string)jUser["species"];
		//	Type = (string)jUser["type"];
		//	Gender = (string) jUser["gender"];
		//}

		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("status")]
		public string Status { get; set; }
		[JsonProperty("species")]
		public string Species { get; set; }
		[JsonProperty("type")]
		public string Type { get; set; }
		[JsonProperty("gender")]
		public string Gender { get; set; }
		[JsonProperty("origin")]
		public OriginDto Origin { get; set; }

   //     public PersonDto(string name, string status, string species, string type, string gender)
   //     {
			//Name = name;
			//Status = status;
			//Species = species;
			//Type = type;
			//Gender = gender;
   //     }
	}
}
