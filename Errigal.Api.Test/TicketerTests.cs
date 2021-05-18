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

		[Fact]
		public async void SendingDeviceFaultSucceeds()
		{
			var request = new SendDeviceFaultRequest
			{
				Id = "logicmonitor-unique-fault-id-test01",
				Severity = Severity.Major,
				Activity = "ACTIVE",
				Type = "System Trap",
				Description = "Loss of signal",
				Device = new Device()
				{
					Id = "panoramic-device-id-test01",
					Name = "Panoramic Device Test01",
					Type = "Router",
					Status = "Active"
				}
			};
			var ticketResponse = await Client.Ticketer.SendDeviceFaultAsync(request).ConfigureAwait(false);
			ticketResponse.Should().NotBeNull();
		}

		[Fact]
		public async void GettingSucceeds()
		{
			var utcNow = DateTime.UtcNow;
			var oneWeekAgo = utcNow.AddDays(-7);
			var tickets = await Client.Ticketer.GetRelatedTicketsAsync(new GetRelatedTicketsRequest
			{
				StartDate = oneWeekAgo,
				EndDate = utcNow,
				Status = "Open",
				SearchedEntities = new List<SearchedEntity>()
				{
					new SearchedEntity
					{
						EntityType = "Fault",
						EntityId = "logicmonitor-unique-fault-id-test01"
					}
				}
				//User = Username,
			})
			.ConfigureAwait(false);

			tickets.Should().NotBeNull();
			tickets.Should().BeAssignableTo<IList<TicketResponse>>();
		}
	}
}
