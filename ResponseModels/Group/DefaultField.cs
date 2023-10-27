using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Group
{
	class DefaultField
	{
		[JsonProperty("visibility")]
		public string Visibility;
		[JsonProperty("permission")]
		public string Permissions;
		[JsonProperty("locked")]
		public bool IsLocked;
		[JsonProperty("required")]
		public bool IsRequired;
	}
}
