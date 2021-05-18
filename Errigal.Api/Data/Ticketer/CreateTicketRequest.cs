using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public abstract class CreateTicketRequest
	{
		[DataMember(Name = "user")]
		public string User { get; set; } = string.Empty;

		[DataMember(Name = "severity")]
		public string Severity { get; set; } = string.Empty;

		[DataMember(Name = "ticketType")]
		public string TicketType { get; set; } = string.Empty;
	}
}