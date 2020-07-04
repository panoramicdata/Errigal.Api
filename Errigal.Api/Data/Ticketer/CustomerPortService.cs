using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	public class CustomerPortService : Customer
	{
		[DataMember(Name = "services")]
		public IList<PortService> Services { get; set; } = null!;
	}
}