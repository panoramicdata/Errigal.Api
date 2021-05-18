using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class CreatePortTicketRequest : CreateTicketRequest
	{
		[DataMember(Name = "port")]
		public Port Port { get; set; } = new();
	}
}
