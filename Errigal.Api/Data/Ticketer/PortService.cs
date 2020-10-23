using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class PortService : IdentifiedItem
	{
		[DataMember(Name = "circuitId")]
		public string CircuitId { get; set; } = null!;

		[DataMember(Name = "carrierCircuitId")]
		public string CarrierCircuitId { get; set; } = null!;

		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

		[DataMember(Name = "type")]
		public string Type { get; set; } = null!;

		[DataMember(Name = "carrierName")]
		public string CarrierName { get; set; } = null!;

		[DataMember(Name = "serviceClass")]
		public string ServiceClass { get; set; } = null!;

		[DataMember(Name = "aLocation")]
		public string ALocation { get; set; } = null!;

		[DataMember(Name = "zLocation")]
		public string ZLocation { get; set; } = null!;

		[DataMember(Name = "aHours")]
		public string AHours { get; set; } = null!;

		[DataMember(Name = "zHours")]
		public string ZHours { get; set; } = null!;

		[DataMember(Name = "aContact")]
		public string AContact { get; set; } = null!;

		[DataMember(Name = "zContact")]
		public string ZContact { get; set; } = null!;

		[DataMember(Name = "carrierContact")]
		public string CarrierContact { get; set; } = null!;

		[DataMember(Name = "customer")]
		public Customer Customer { get; set; } = null!;

		[DataMember(Name = "ports")]
		public IList<ServicePort> Ports { get; set; } = null!;
	}
}