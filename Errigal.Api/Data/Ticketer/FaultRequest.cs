using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public abstract class FaultRequest : IdentifiedItem
	{
		[DataMember(Name = "severity")]
		public Severity Severity { get; set; } = Severity.Major;

		[DataMember(Name = "activity")]
		public string Activity { get; set; } = string.Empty;

		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;
	}
}