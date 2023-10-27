namespace SpondAPI.ResponseModels.Clock
{
    class ClockResponse : IResponse
    {
        public string EndpointExtension { get { return $"{SpondClient.standardAPIExtension}/clock"; } }
        public string PluralExtension { get { return string.Empty; } }
        public string? Time { get; set; }

    }
}
