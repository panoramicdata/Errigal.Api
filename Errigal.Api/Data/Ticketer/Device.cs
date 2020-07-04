using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class Device : NamedIdentifiedItem
	{
		[DataMember(Name = "type")]
		public string Type { get; set; } = null!;

		[DataMember(Name = "status")]
		public string Status { get; set; } = null!;

		[DataMember(Name = "ip")]
		public string Ip { get; set; } = null!;

		[DataMember(Name = "networkArea")]
		public string NetworkArea { get; set; } = null!;

		[DataMember(Name = "modules")]
		public IList<Module> Modules { get; set; } = null!;
	}
}
