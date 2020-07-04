using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class TicketResponse
	{
		[DataMember(Name = "ticketId")]
		public string TicketId { get; set; } = null!;

		[DataMember(Name = "ticketLink")]
		public string TicketLink { get; set; } = null!;

		[DataMember(Name = "entityType")]
		public string EntityType { get; set; } = null!;

		[DataMember(Name = "entityId")]
		public string EntityId { get; set; } = null!;

		[DataMember(Name = "summary")]
		public string Summary { get; set; } = null!;

		[DataMember(Name = "status")]
		public string Status { get; set; } = null!;

		[DataMember(Name = "priority")]
		public string Priority { get; set; } = null!;
	}
}
