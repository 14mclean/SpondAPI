using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Profile
{
	class Preferences
	{
		[JsonProperty("globalPushPreferences")]
		public PushPreferences GlobalPushPreferences;
		[JsonProperty("groupPushPreferences")]
		public Dictionary<string, PushPreferences> groupPushPreferences;
		[JsonProperty("targetedAdsDisabled")]
		public bool IsTargetedAdsDisabled;
		[JsonProperty("cashbackPromoDisabled")]
		public bool IsCashbackPromotionDisabled;
		[JsonProperty("partnerPromoDisabled")]
		public bool IsPartnerPromotionDisabled;
		[JsonProperty("optionalSettings")]
		public Dictionary<string, string> OptionalSettings; // this probaly aint right
	}
}
