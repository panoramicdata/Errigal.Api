using System.Runtime.Serialization;

namespace Errigal.Api.Data.Ticketer
{
	[DataContract]
	public class SearchedEntity
	{
		[DataMember(Name = "entityType")]
		public string EntityType { get; set; } = string.Empty;

		[DataMember(Name = "entityId")]
		public string EntityId { get; set; } = string.Empty;
	}
}
