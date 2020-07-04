using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class GetRelatedTicketsRequest
	{
		[DataMember(Name = "user")]
		public string User { get; set; } = null!;

		[DataMember(Name = "searchedEntities")]
		public IList<SearchedEntity> SearchedEntities { get; set; } = null!;

		[DataMember(Name = "status")]
		public string Status { get; set; } = null!;

		[DataMember(Name = "startDate")]
		public DateTime StartDate { get; set; }

		[DataMember(Name = "endDate")]
		public DateTime EndDate { get; set; }
	}
}
