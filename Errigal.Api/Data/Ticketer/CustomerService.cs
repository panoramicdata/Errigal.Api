using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class CustomerService : IdentifiedItem
	{
		[DataMember(Name = "circuitId")]
		public string CircuitId { get; set; } = string.Empty;

		[DataMember(Name = "carrierCircuitId")]
		public string CarrierCircuitId { get; set; } = string.Empty;

		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		[DataMember(Name = "carrierName")]
		public string CarrierName { get; set; } = string.Empty;

		[DataMember(Name = "serviceClass")]
		public string ServiceClass { get; set; } = string.Empty;

		[DataMember(Name = "aLocation")]
		public string ALocation { get; set; } = string.Empty;

		[DataMember(Name = "zLocation")]
		public string ZLocation { get; set; } = string.Empty;

		[DataMember(Name = "aHours")]
		public string AHours { get; set; } = string.Empty;

		[DataMember(Name = "zHours")]
		public string ZHours { get; set; } = string.Empty;

		[DataMember(Name = "aContact")]
		public string AContact { get; set; } = string.Empty;

		[DataMember(Name = "zContact")]
		public string ZContact { get; set; } = string.Empty;

		[DataMember(Name = "carrierContact")]
		public string CarrierContact { get; set; } = string.Empty;

		[DataMember(Name = "customer")]
		public Customer Customer { get; set; } = new();
	}
}
