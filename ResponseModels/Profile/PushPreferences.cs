using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Profile
{
	class PushPreferences
	{
		[JsonProperty("acceptPushDisabled")]
		public bool AcceptPushDisabled;

		[JsonProperty("declinePushDisabled")]
		public bool DeclinePushDisabled;

		[JsonProperty("acceptTaskPushDisabled")]
		public bool AcceptTaskPushDisabled;

		[JsonProperty("declineTaskPushDisabled")]
		public bool DeclineTaskPushDisabled;

		[JsonProperty("commentNotifications")]
		public string CommentNotifications;

		[JsonProperty("invitationPushDisabled")]
		public bool InvitationPushDisabled;

		[JsonProperty("postPushDisabled")]
		public bool PostPushDisabled;

		[JsonProperty("reminderPushDisabled")]
		public bool ReminderPushDisabled;

		[JsonProperty("scheduledPrealertPushDisabled")]
		public bool ScheduledPrealertPushDisabled;

		[JsonProperty("scheduledSentPushDisabled")]
		public bool ScheduledSentPushDisabled;

		[JsonProperty("bonusContributePushDisabled")]
		public bool BonusContributePushDisabled;

		[JsonProperty("bonusAchievementPushDisabled")]
		public bool BonusAchievementPushDisabled;

		[JsonProperty("matchNotificationsPushDisabled")]
		public bool MatchNotificationsPushDisabled;

		[JsonProperty("availablePushDisabled")]
		public bool AvailablePushDisabled;

		[JsonProperty("unavailablePushDisabled")]
		public bool UnavailablePushDisabled;

		[JsonProperty("availabilityReminderPushDisabled")]
		public bool AvailabilityReminderPushDisabled;
	}
}
