using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Profile
{
	class ProfileResponse : IResponse
	{
		#region Response Properties

		[JsonIgnore]
		public string EndpointExtension { get { return $"{SpondClient.standardAPIExtension}/profile/{{uid}}"; } }
		[JsonIgnore]
		public string PluralExtension { get { return $"{SpondClient.standardAPIExtension}/profiles"; } }

		#endregion

		#region Profile Fields

		[JsonProperty("primaryEmail")]
		public string PrimaryEmail;
		[JsonProperty("phoneNumber")]
		public string PhoneNumber;
		[JsonProperty("dummy")]
		public bool IsDummy;
		[JsonProperty("trackingId")]
		public string TrackingID;
		[JsonProperty("timezone")]
		public string Timezone;
		[JsonProperty("unsubscribeCode")]
		public string UnsubscribeCode;
		[JsonProperty("locale")]
		public string Locale;
		[JsonProperty("countryCode")]
		public string CountryCode;
		[JsonProperty("internal")]
		public bool IsInternal;
		[JsonProperty("Deleted")]
		public string IsDeleted;
		[JsonProperty("preferences")]
		public Preferences Preferences;
		[JsonProperty("dateOfBirth")]
		public string DateOfBirth;
		[JsonProperty("tosVersion")]
		public int TermsOfServiceVersion;
		[JsonProperty("contact")]
		public bool CanContact;
		[JsonProperty("formattedPhoneNumber")]
		public string FormattedPhoneNumber;

		#endregion

		#region Member Fields

		[JsonProperty("id")]
		public string ID;
		[JsonProperty("firstName")]
		public string FirstName;
		[JsonProperty("lastName")]
		public string LastName;
		[JsonProperty("contactMethod")]
		public string ContactMethod;
		[JsonProperty("unabledToReach")]
		public bool IsUnabledToReach;
		[JsonProperty("imageUrl")]
		public string ImageURL; // only one not also in profile endpoint

		#endregion
	}
}
