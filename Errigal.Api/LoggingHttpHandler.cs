using Errigal.Api.Exceptions;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Errigal.Api
{
	internal class LoggingHttpHandler : HttpClientHandler
	{
		private readonly ILogger _logger;

		public LoggingHttpHandler(ILogger logger)
		{
			_logger = logger;
		}

		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			var guid = Guid.NewGuid();
			try
			{
				_logger.LogTrace($"{guid}: Request starting");

				_logger.LogDebug($"{guid}: Request\n{request}");

				var response = await base
					.SendAsync(request, cancellationToken)
					.ConfigureAwait(false);

				_logger.LogDebug($"{guid}: Response ({response.StatusCode})\n{await response.Content.ReadAsStringAsync().ConfigureAwait(false)}");

				if (response.IsSuccessStatusCode)
				{
					return response;
				}
				// Failure

				_logger.LogDebug($"{guid}: Failure code ({response.StatusCode})");
				var responseBody = await response
					.Content
					.ReadAsStringAsync()
					.ConfigureAwait(false);
				throw new ErrigalApiException(responseBody);
			}
			catch (ErrigalApiException)
			{
				throw;
			}
			catch (Exception exception)
			{
				_logger.LogError(exception, exception.Message);
				throw;
			}
			finally
			{
				_logger.LogTrace($"{guid}: Request complete");
			}
		}
	}
}