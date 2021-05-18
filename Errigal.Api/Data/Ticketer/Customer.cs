using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class Customer : NamedIdentifiedItem
	{
		[DataMember(Name = "email")]
		public string Email { get; set; } = string.Empty;

		[DataMember(Name = "phone")]
		public string Phone { get; set; } = string.Empty;

		[DataMember(Name = "address")]
		public string Address { get; set; } = string.Empty;
	}
}
