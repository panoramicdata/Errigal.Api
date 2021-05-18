using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class ServicePort : NamedIdentifiedItem
	{
		[DataMember(Name = "index")]
		public int Index { get; set; }

		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		[DataMember(Name = "module")]
		public Module Module { get; set; } = new();
	}
}