using Errigal.Api.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Refit;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Errigal.Api
{
	public class ErrigalClient : IDisposable
	{
		private bool disposedValue;
		private readonly HttpClient _httpClient;
		private readonly ILogger? _logger;

		public ErrigalClient(ErrigalClientOptions options, ILogger? logger = null)
		{
			// Validation
			if (options is null)
			{
				throw new ArgumentNullException(nameof(options));
			}
			options.Validate();

			_logger = logger ?? new NullLogger<ErrigalClient>();

			var authenticatedHttpHandler = new LoggingHttpHandler(
				_logger);

			_httpClient = new HttpClient(authenticatedHttpHandler)
			{
				BaseAddress = new Uri(options.Url),
			};
			_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
				"Basic",
				Convert.ToBase64String(Encoding.ASCII.GetBytes($"{options.Username}:{options.Password}")));
			_httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
			_logger.LogTrace("Constructor complete");

			Ticketer = RestService.For<ITicketer>(_httpClient);
		}

		public ITicketer Ticketer { get; }

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					_httpClient?.Dispose();
				}

				disposedValue = true;
			}
		}

		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
