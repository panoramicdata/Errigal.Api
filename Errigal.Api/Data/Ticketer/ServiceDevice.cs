using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class ServiceDevice : NamedIdentifiedItem
	{
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		[DataMember(Name = "ip")]
		public string Ip { get; set; } = string.Empty;

		[DataMember(Name = "networkArea")]
		public string NetworkArea { get; set; } = string.Empty;
	}
}