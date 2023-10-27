using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Group
{
	class Subgroup
	{
		[JsonProperty("id")]
		public string ID;
		[JsonProperty("name")]
		public string Name;
		[JsonProperty("color")]
		public string Colour;
		[JsonProperty("imageUrl")]
		public string ImageURL;
	}
}
