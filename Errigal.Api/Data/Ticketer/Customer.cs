using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class Customer : NamedIdentifiedItem
	{
		[DataMember(Name = "email")]
		public string Email { get; set; } = null!;

		[DataMember(Name = "phone")]
		public string Phone { get; set; } = null!;

		[DataMember(Name = "address")]
		public string Address { get; set; } = null!;
	}
}
