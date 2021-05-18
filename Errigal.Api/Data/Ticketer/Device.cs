using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class Device : NamedIdentifiedItem
	{
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		[DataMember(Name = "ip")]
		public string Ip { get; set; } = string.Empty;

		[DataMember(Name = "networkArea")]
		public string NetworkArea { get; set; } = string.Empty;

		[DataMember(Name = "modules")]
		public List<Module> Modules { get; set; } = new();
	}
}
