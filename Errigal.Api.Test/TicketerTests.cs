using Errigal.Api.Data.Ticketer;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Errigal.Api.Test
{
	public class TicketerTests : BaseTest
	{
		public TicketerTests(Xunit.Abstractions.ITestOutputHelper testOutputHelper) : base(testOutputHelper)
		{
		}

		//[Fact]
		//public async void GetRelatedTickets_Succeeds()
		//{
		//}

		[Fact]
		public async void GetRelatedTickets_Succeeds()
		{
			var utcNow = DateTime.UtcNow;
			var oneWeekAgo = utcNow.AddDays(-7);
			var tickets = await Client.Ticketer.GetRelatedTicketsAsync(new GetRelatedTicketsRequest
			{
				StartDate = oneWeekAgo,
				EndDate = utcNow,
				//User = Username,
			})
			.ConfigureAwait(false);

			tickets.Should().BeAssignableTo<IList<TicketResponse>>();
			tickets.Should().NotBeNull();
		}
	}
}
