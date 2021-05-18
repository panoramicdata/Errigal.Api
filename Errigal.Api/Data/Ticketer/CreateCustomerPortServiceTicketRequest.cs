using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class CreateCustomerPortServiceTicketRequest : CreateTicketRequest
	{
		[DataMember(Name = "customer")]
		public CustomerPortService Customer { get; set; } = new();
	}
}