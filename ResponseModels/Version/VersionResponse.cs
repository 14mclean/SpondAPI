using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Version
{
	internal class VersionResponse : IResponse
	{
		#region Response Properties

		[JsonIgnore]
		public string EndpointExtension { get { return $"{SpondClient.standardAPIExtension}/version"; } }
		[JsonIgnore]
		public string PluralExtension { get { return string.Empty; } }

		#endregion

		[JsonProperty("apiLevel")]
		public string APILevel;

		[JsonProperty("releaseBuildVersion")]
		public string ReleaseBuildVersion;

		[JsonProperty("buildRevision")]
		public string BuildRevision;

		[JsonProperty("buildTime")]
		public string BuildTime;

		[JsonProperty("buildTags")]
		public string BuildTags;

		[JsonProperty("buildDirty")]
		public string BuildDirty;
	}
}
