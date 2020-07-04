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
		public string Status { get; set; } = null!;

		[DataMember(Name = "ports")]
		public IList<Port> Ports { get; set; } = null!;
	}
}
