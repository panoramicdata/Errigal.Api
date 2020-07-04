using System.Runtime.Serialization;

namespace Errigal.Api.Data
{
	[DataContract]
	public abstract class NamedIdentifiedItem : IdentifiedItem
	{
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;
	}
}
