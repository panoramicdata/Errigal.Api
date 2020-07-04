using Errigal.Api.Data.Ticketer;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Errigal.Api.Test
{
	public class TicketerTests : BaseTest
	{
		public TicketerTests(Xunit.Abstractions.ITestOutputHelper testOutputHelper) : base(testOutputHelper)
		{
		}

		[Fact]
		public async void GetRelatedTickets_Succeeds()
		{
			var tickets = await Client.Ticketer.GetRelatedTicketsAsync(new GetRelatedTicketsRequest
			{
				// User = Username,
			})
			.ConfigureAwait(false);

			tickets.Should().BeAssignableTo<IList<TicketResponse>>();
			tickets.Should().NotBeNull();
		}
	}
}
