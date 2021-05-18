using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class GetRelatedTicketsRequest
	{
		[DataMember(Name = "user")]
		public string User { get; set; } = string.Empty;

		[DataMember(Name = "searchedEntities")]
		public List<SearchedEntity> SearchedEntities { get; set; } = new();

		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		[DataMember(Name = "startDate")]
		public DateTime StartDate { get; set; }

		[DataMember(Name = "endDate")]
		public DateTime EndDate { get; set; }
	}
}
