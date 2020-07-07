using System;
using System.Net;

namespace Errigal.Api.Exceptions
{
	public class ErrigalApiException : Exception
	{
		public HttpStatusCode? StatusCode { get; }

		public string? ResponseBody { get; }

		public ErrigalApiException()
		{
		}

		public ErrigalApiException(string message) : base(message)
		{
		}

		public ErrigalApiException(string message, Exception innerException) : base(message, innerException)
		{
		}

		public ErrigalApiException(HttpStatusCode statusCode, string responseBody) : base($"{(int)statusCode} {statusCode}: {responseBody}")
		{
			StatusCode = statusCode;
			ResponseBody = responseBody;
		}
	}
}
