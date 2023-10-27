using Newtonsoft.Json;
using SpondAPI.ResponseModels;
using SpondAPI.ResponseModels.Login;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace SpondAPI
{
    class SpondClient
	{
		private static string baseURL { get { return "https://api.spond.com"; } }
		public static string standardAPIExtension { get { return "core/v1";} }
		public static string chatAPIExtension { get { return "chat/v1"; } }

		private HttpClient _client;
		private string? _bearerToken;
		private string _username;
		private string _password;

		public SpondClient(string username, string password)
		{
			_username = username;
			_password = password;
			_client = new HttpClient();
			Task.Run(async () => { await Login(); });
		}

		private async Task Login()
		{
			string requestURI = $"{baseURL}/{standardAPIExtension}/login";
			var loginDetails = new Dictionary<string, string>()
			{
				{"email", _username}, {"password", _password}
			};
			var content = new StringContent(
				JsonConvert.SerializeObject(loginDetails),
				Encoding.UTF8,
				"application/json");

			var response = await _client.PostAsync(requestURI, content);

			if (response.IsSuccessStatusCode)
			{
				_bearerToken = (await response.Content.ReadFromJsonAsync<LoginResponse>()).LoginToken;
			}
			else
			{
				throw new Exception("Login error");
			}
		}

		private async Task<HttpResponseMessage> SendGet(string urlExtension)
		{
			if (string.IsNullOrEmpty(_bearerToken))
			{
				await Login();
			}

			using(var request = new HttpRequestMessage(HttpMethod.Get, $"{baseURL}/{urlExtension}"))
			{
				request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);
				var response = await _client.SendAsync(request);
				return response;
			}
		}

		public async Task<T> Get<T>(string uid = "") where T : IResponse, new()
		{
			var instance = new T();

			if (instance.EndpointExtension == string.Empty)
				throw new ArgumentException("This type does not have a singular");

			string urlExtension = instance.EndpointExtension;

			if(urlExtension.Contains("{uid}"))
			{
				urlExtension = urlExtension.Replace("{uid}", uid);
			}

			var response = await SendGet(urlExtension);
			var body = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<T>(body);
		}

		public async Task<IEnumerable<T>> GetAll<T>() where T : IResponse, new()
		{
			var instance = new T();

			if (instance.PluralExtension == string.Empty)
				throw new ArgumentException("This type does not have a plural");

			var response = await SendGet(instance.PluralExtension);
			var body = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<IEnumerable<T>>(body);
		}

		public async Task<HttpResponseMessage> Options(string endpointName)
		{
			if (string.IsNullOrEmpty(_bearerToken))
			{
				await Login();
			}

			using (var request = new HttpRequestMessage(HttpMethod.Options, $"{baseURL}/{endpointName}"))
			{
				request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);
				var response = await _client.SendAsync(request);
				return response;
			}
		}
	}
}
