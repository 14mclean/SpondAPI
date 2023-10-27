using SpondAPI.ResponseModels.Clock;
using SpondAPI.ResponseModels.Device;
using SpondAPI.ResponseModels.Event;
using SpondAPI.ResponseModels.Group;
using SpondAPI.ResponseModels.Profile;
using SpondAPI.ResponseModels.Series;
using SpondAPI.ResponseModels.Test;
using SpondAPI.ResponseModels.Version;

var username = "";
var password = "";

var client = new SpondAPI.SpondClient(username, password);

int selector = 11;

switch(selector)
{
	case 0:
		ClockResponse a = await client.Get<ClockResponse>();
		Console.WriteLine(a.Time);
		break;
	case 1:
		List<DeviceResponse> b = (List<DeviceResponse>) await client.GetAll<DeviceResponse>();
		Console.WriteLine(b[0].Name);
		break;
	case 2:
		List<GroupResponse> c = (List<GroupResponse>) await client.GetAll<GroupResponse>();
		Console.WriteLine(c[0].ID);
		break;
	case 3:
		GroupResponse d = await client.Get<GroupResponse>("DB69B8E93716439E83C5E54DDFCFD4ED");
		Console.WriteLine(d.Name);
		break;
	case 4:
		List<ProfileResponse> e = (List<ProfileResponse>) await client.GetAll<ProfileResponse>();
		Console.WriteLine(e[0].FirstName);
		break;
	case 5:
		ProfileResponse f = await client.Get<ProfileResponse>("1361E05698D023DADC0D42462F717D63");
		Console.WriteLine(f.FirstName);
		break;
	case 6:
		// search
		break;
	case 7:
		SeriesResponse h = await client.Get<SeriesResponse>("65F4BD5E781149B7BC66277DC2B89877");
		Console.WriteLine(h.Heading);
		break;
	case 8:
		List<EventResponse> i = (List<EventResponse>) await client.GetAll<EventResponse>();
		Console.WriteLine(i[0].Heading);
		break;
	case 9:
		EventResponse j = await client.Get<EventResponse>("626A551C4BED45DABF0A075BE54F8AB9");
		Console.WriteLine(j.Heading);
		break;
	case 10:
		TestResponse k = await client.Get<TestResponse>();
		Console.WriteLine(k.Message);
		break;
	case 11:
		VersionResponse l = await client.Get<VersionResponse>();
		Console.WriteLine(l.APILevel);
		break;
}

