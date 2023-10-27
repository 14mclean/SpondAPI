using Newtonsoft.Json;
using SpondAPI.ResponseModels.Group;
using SpondAPI.ResponseModels.Profile;

namespace SpondAPI.ResponseModels.Event
{
	class Recipients
	{
		[JsonProperty("group")]
		public GroupResponse Group;
		[JsonProperty("profiles")]
		public IEnumerable<ProfileResponse> Profiles;
		[JsonProperty("Guardians")]
		public IEnumerable<Member> Guardian;
	}
}
