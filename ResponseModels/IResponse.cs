namespace SpondAPI.ResponseModels
{
    interface IResponse
    {
        public abstract string EndpointExtension { get; }
        public string PluralExtension { get; }
    }
}
