using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{

	[DataContract]
	public class ServiceDevice : NamedIdentifiedItem
	{
		[DataMember(Name = "type")]
		public string Type { get; set; } = null!;

		[DataMember(Name = "status")]
		public string Status { get; set; } = null!;

		[DataMember(Name = "ip")]
		public string Ip { get; set; } = null!;

		[DataMember(Name = "networkArea")]
		public string NetworkArea { get; set; } = null!;
	}
}