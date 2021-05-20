using Errigal.Api.Data.Ticketer;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Errigal.Api.Interfaces
{
	public interface ITicketer
	{
		[Post("/adapter/netace/in/fault/device")]
		Task<TicketResponse> SendDeviceFaultAsync(
			SendDeviceFaultRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/fault/module")]
		Task<TicketResponse> SendModuleFaultAsync(
			SendModuleFaultRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/fault/port")]
		Task<TicketResponse> SendPortFaultAsync(
			SendPortFaultRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/ticket/device")]
		Task<TicketResponse> CreateDeviceTicketAsync(
			CreateDeviceTicketRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/ticket/{ticketId}/device")]
		Task<TicketResponse> UpdateDeviceTicketAsync(
			int ticketId,
			CreateDeviceTicketRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/ticket/module")]
		Task<TicketResponse> CreateModuleTicketAsync(
			CreateModuleTicketRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/ticket/port")]
		Task<TicketResponse> CreatePortTicketAsync(
			CreatePortTicketRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/ticket/{ticketId}/service")]
		Task<TicketResponse> UpdatePortServiceTicketAsync(
			int ticketId,
			CreatePortServiceTicketRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/ticket/service")]
		Task<TicketResponse> CreatePortServiceTicketAsync(
			CreatePortServiceTicketRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/ticket/customer")]
		Task<TicketResponse> CreateCustomerPortServiceTicketAsync(
			CreateCustomerPortServiceTicketRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/ticket/{ticketId}/customer")]
		Task<TicketResponse> UpdateCustomerPortServiceTicketAsync(
			int ticketId,
			CreateCustomerPortServiceTicketRequest request,
			CancellationToken cancellationToken = default
			);

		[Post("/adapter/netace/in/ticket/related")]
		Task<List<TicketResponse>> GetRelatedTicketsAsync(
			GetRelatedTicketsRequest request,
			CancellationToken cancellationToken = default
			);
	}
}
