using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class TicketResponse
	{
		[DataMember(Name = "ticketId")]
		public string TicketId { get; set; } = string.Empty;

		[DataMember(Name = "ticketLink")]
		public string TicketLink { get; set; } = string.Empty;

		[DataMember(Name = "entityType")]
		public string EntityType { get; set; } = string.Empty;

		[DataMember(Name = "entityId")]
		public string EntityId { get; set; } = string.Empty;

		[DataMember(Name = "summary")]
		public string Summary { get; set; } = string.Empty;

		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		[DataMember(Name = "priority")]
		public Severity Priority { get; set; }
	}
}
