using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Group
{
	class FieldDefinition
	{
		[JsonProperty("id")]
		public string ID;
		[JsonProperty("name")]
		public string Name;
		[JsonProperty("type")]
		public string Type;
		[JsonProperty("visibility")]
		public string Visibility;
		[JsonProperty("source")]
		public string Source;
		[JsonProperty("permission")]
		public string Permissions;
		[JsonProperty("locked")]
		public bool IsLocked;
		[JsonProperty("required")]
		public bool IsRequired;
	}
}
