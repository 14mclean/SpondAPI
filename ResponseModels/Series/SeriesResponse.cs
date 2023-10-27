using Newtonsoft.Json;
using SpondAPI.ResponseModels.Event;

namespace SpondAPI.ResponseModels.Series
{
    class SeriesResponse : IResponse
	{
		#region Response Properties

		[JsonIgnore]
		public string EndpointExtension { get { return $"{SpondClient.standardAPIExtension}/series/{{uid}}"; } }
		[JsonIgnore]
		public string PluralExtension { get { return string.Empty; } }

		#endregion

		[JsonProperty("id")]
		public string ID;

		[JsonProperty("heading")]
		public string Heading;

		[JsonProperty("ownerIds")]
		public IEnumerable<string> OwnerIds;

		[JsonProperty("location")]
		public Location Location;

		[JsonProperty("picture")]
		public string Picture;

		[JsonProperty("startTime")]
		public string StartTime;

		[JsonProperty("lastStart")]
		public string LastStartTime;

		[JsonProperty("meetupPrior")]
		public long MeetupPriorOffset;

		[JsonProperty("timeZone")]
		public string Timezone;

		[JsonProperty("groupId")]
		public string GroupID;

		[JsonProperty("interval")]
		public string Interval;

		[JsonProperty("duration")]
		public long Duration;

		[JsonProperty("inviteOffset")]
		public long InviteOffset;

		[JsonProperty("rsvpOffset")]
		public long RSVPOffset;

		[JsonProperty("maxAccepted")]
		public long MaxAccepted;

		[JsonProperty("autoAccept")]
		public bool AutoAccept;

		[JsonProperty("inviteMuted")]
		public bool IsInviteMuted;

		[JsonProperty("participantsHidden")]
		public bool IsParticipantsHidden;

		[JsonProperty("autoReminderType")]
		public string AutoReminderType;

		[JsonProperty("visibility")]
		public string Visibility;

		[JsonProperty("commentsDisabled")]
		public string IsCommentsDisabled;
	}
}
