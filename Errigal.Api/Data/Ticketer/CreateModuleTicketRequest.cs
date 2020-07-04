using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class CreateModuleTicketRequest : CreateTicketRequest
	{
		[DataMember(Name = "module")]
		public Module Module { get; set; } = null!;
	}
}
