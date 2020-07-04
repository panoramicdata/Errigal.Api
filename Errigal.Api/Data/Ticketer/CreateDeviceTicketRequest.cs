using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class CreateDeviceTicketRequest : CreateTicketRequest
	{
		[DataMember(Name = "device")]
		public Device Device { get; set; } = null!;
	}
}
