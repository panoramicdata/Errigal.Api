using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class SendPortFaultRequest : FaultRequest
	{
		[DataMember(Name = "port")]
		public Port Port { get; set; } = new();
	}
}
