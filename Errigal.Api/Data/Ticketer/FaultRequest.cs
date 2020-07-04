using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public abstract class FaultRequest
	{
		[DataMember(Name = "severity")]
		public string Severity { get; set; } = null!;

		[DataMember(Name = "activity")]
		public string Activity { get; set; } = null!;

		[DataMember(Name = "type")]
		public string Type { get; set; } = null!;

		[DataMember(Name = "description")]
		public string Description { get; set; } = null!;
	}
}