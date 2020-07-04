using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class SendPortFaultRequest : FaultRequest
	{
		[DataMember(Name = "module")]
		public Port Port { get; set; } = null!;
	}
}
