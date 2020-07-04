using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class SendModuleFaultRequest : FaultRequest
	{
		[DataMember(Name = "module")]
		public Module Module { get; set; } = null!;
	}
}
