using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Group
{
	class Role
	{
		[JsonProperty("id")]
		public string ID;
		[JsonProperty("name")]
		public string Name;
		[JsonProperty("permissions")]
		public IEnumerable<string> Permissions;
	}
}
