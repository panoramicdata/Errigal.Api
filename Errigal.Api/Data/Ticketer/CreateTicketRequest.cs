using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public abstract class CreateTicketRequest
	{
		[DataMember(Name = "user")]
		public string User { get; set; } = null!;

		[DataMember(Name = "severity")]
		public string Severity { get; set; } = null!;

		[DataMember(Name = "ticketType")]
		public string TicketType { get; set; } = null!;
	}
}