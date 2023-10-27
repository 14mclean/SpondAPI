using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Event
{
    class EventResponse : IResponse
	{
		#region Response Properties

		[JsonIgnore]
		public string EndpointExtension { get { return $"{SpondClient.standardAPIExtension}/sponds/{{uid}}"; } }
		[JsonIgnore]
		public string PluralExtension { get { return $"{SpondClient.standardAPIExtension}/sponds/"; } }

		#endregion

		[JsonProperty("id")]
		public string ID;

		[JsonProperty("creatorId")]
		public string CreatorID;

		[JsonProperty("owners")]
		public IEnumerable<Dictionary<string, string>> Owners;

		[JsonProperty("heading")]
		public string Heading;

		[JsonProperty("startTimestamp")]
		public string StartTimestamp;

		[JsonProperty("endTimestamp")]
		public string EndTimestamp;

		[JsonProperty("location")]
		public Location Location;

		[JsonProperty("picture")]
		public string Picture;

		[JsonProperty("recipients")]
		public Recipients Recipients;

		[JsonProperty("responses")]
		public Dictionary<string, IEnumerable<string>> Responses;

		[JsonProperty("tasks")]
		public Dictionary<string, IEnumerable<string>> Tasks;

		[JsonProperty("comments")]
		public IEnumerable<string> Comments;

		[JsonProperty("attachments")]
		public IEnumerable<string> Attachments;

		[JsonProperty("createdTime")]
		public string CreatedTime;

		[JsonProperty("inviteTime")]
		public string InviteTime;

		[JsonProperty("seriesId")]
		public string SeriesID;

		[JsonProperty("seriesOrdinal")]
		public long SeriesOrdinal;

		[JsonProperty("modifiedFromSeries")]
		public bool IsModifiedFromSeries;

		[JsonProperty("expired")]
		public bool IsExpired;

		[JsonProperty("visibility")]
		public string Visibility;

		[JsonProperty("maxAccepted")]
		public long MaxAccepted;

		[JsonProperty("behalfOfIds")]
		public IEnumerable<string> BehalfOf;

		[JsonProperty("autoAccept")]
		public bool AutoAccept;

		[JsonProperty("hidden")]
		public bool IsHidden;

		[JsonProperty("autoReminderType")]
		public string AutoReminderType;

		[JsonProperty("participantsHidden")]
		public bool IsParticipantsHidden;

		[JsonProperty("registered")]
		public bool IsRegistered;

		[JsonProperty("commentsDisabled")]
		public bool CommentsDisabled;

		[JsonProperty("type")]
		public string Type;

		[JsonProperty("updated")]
		public long lastUpdated;

		[JsonProperty("matchEvent")]
		public bool IsMatchEvent;
	}
}
