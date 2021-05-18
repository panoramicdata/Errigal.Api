using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class SendDeviceFaultRequest : FaultRequest
	{
		[DataMember(Name = "device")]
		public Device Device { get; set; } = new();
	}
}
