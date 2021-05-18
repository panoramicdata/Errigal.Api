using System.Runtime.Serialization;

namespace Errigal.Api.Data
{
	[DataContract]
	public abstract class IdentifiedItem
	{
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;
	}
}
