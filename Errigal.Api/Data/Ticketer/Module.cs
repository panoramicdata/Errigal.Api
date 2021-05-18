using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class Module : NamedIdentifiedItem
	{
		[DataMember(Name = "index")]
		public int Index { get; set; }

		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		[DataMember(Name = "ports")]
		public List<Port> Ports { get; set; } = new();
	}
}
