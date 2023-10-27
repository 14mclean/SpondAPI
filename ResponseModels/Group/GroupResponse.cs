using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Group
{
	class GroupResponse : IResponse
	{
		#region Response Properties

		[JsonIgnore]
		public string EndpointExtension { get { return $"{SpondClient.standardAPIExtension}/group/{{uid}}"; } }
		[JsonIgnore]
		public string PluralExtension { get { return $"{SpondClient.standardAPIExtension}/groups"; } }

		#endregion

		#region Group Fields

		[JsonProperty("id")]
		public string ID;
		[JsonProperty("contactPerson")]
		public Profile.ProfileResponse ContactPerson; // check this type
		[JsonProperty("name")]
		public string Name;
		[JsonProperty("welcomeMessage")]
		public string WelcomeMessage;
		[JsonProperty("activity")]
		public string Activity;
		[JsonProperty("clubId")]
		public string ClubID;
		[JsonProperty("clubLogo")]
		public string ClubLogo;  // URL
		[JsonProperty("imageUrl")]
		public string ImageURL; // URL
		[JsonProperty("createdTime")]
		public string CreatedTime;
		[JsonProperty("members")]
		public IEnumerable<Member> Members;
		[JsonProperty("subGroups")]
		public IEnumerable<Subgroup> Subgroups;
		[JsonProperty("shareContactInfo")]
		public bool ShareContactInformation;
		[JsonProperty("adminsCanAddMembers")]
		public bool AdminsCanAddMembers;
		[JsonProperty("contactInfoHidden")]
		public bool ContactInformationHidden;
		[JsonProperty("memberPermissions")]
		public IEnumerable<string> MemberPermissions; // only seen as empty list
		[JsonProperty("guardianPermissions")]
		public IEnumerable<string> GuardianPermissions; // only seen as empty list
		[JsonProperty("type")]
		public int Type;
		[JsonProperty("invitedToAppTime")]
		public string InvitedToAppTime;
		[JsonProperty("signupUrl")]
		public string SignUpURL;
		[JsonProperty("allowSmsNag")]
		public bool AllowSMSNag;
		[JsonProperty("bonusEnabled")]
		public bool BonusEnabled;
		[JsonProperty("fieldDefs")]
		public IEnumerable<FieldDefinition> FieldDefinitions;
		[JsonProperty("defaultFields")]
		public Dictionary<string, DefaultField> DefaultFields;
		[JsonProperty("roles")]
		public IEnumerable<Role> Roles;
		[JsonProperty("addressFormat")]
		public IEnumerable<string> AddressFormat;
		[JsonProperty("allowPrivatePayoutAccounts")]
		public bool AllowPrivatePayoutAccounts;
		[JsonProperty("payoutAccounts")]
		public IEnumerable<string> PayoutAccounts; // only seen as empty list

		#endregion
	}
}
