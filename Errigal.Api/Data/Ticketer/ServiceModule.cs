using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class ServiceModule : NamedIdentifiedItem
	{
		[DataMember(Name = "index")]
		public int Index { get; set; }

		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		[DataMember(Name = "device")]
		public ServiceDevice Device { get; set; } = new();
	}
}