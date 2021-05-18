using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class CreatePortServiceTicketRequest : CreateTicketRequest
	{
		[DataMember(Name = "service")]
		public PortService Service { get; set; } = new();
	}
}