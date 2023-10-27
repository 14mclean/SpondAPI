using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Test
{
	class TestResponse : IResponse
	{
		#region Response Properties

		[JsonIgnore]
		public string EndpointExtension { get { return $"{SpondClient.standardAPIExtension}/test"; } }
		[JsonIgnore]
		public string PluralExtension { get { return string.Empty; } }

		#endregion

		[JsonProperty("Message")]
		public string Message;
	}
}
