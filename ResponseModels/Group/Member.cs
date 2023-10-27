using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Group
{
	class Member
	{
		[JsonProperty("id")]
		public string ID;
		[JsonProperty("profile")]
		public Profile.ProfileResponse Profile;
		[JsonProperty("firstName")]
		public string FirstName;
		[JsonProperty("lastName")]
		public string LastName;
		[JsonProperty("createdTime")]
		public string CreatedTime; // not in guardian
		[JsonProperty("guardians")]
		public IEnumerable<Member> Guardians; // not in guardian
		[JsonProperty("subGroups")]
		public IEnumerable<string> SubgroupIDs; // not in guardian
		[JsonProperty("fields")]
		public Dictionary<string, string> CustomFieldValues; // not all strings?   not in guardian
		[JsonProperty("respondant")]
		public bool IsRespondant; // not in guardian
	}
}
