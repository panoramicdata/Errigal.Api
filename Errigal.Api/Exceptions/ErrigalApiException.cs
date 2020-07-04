using System;

namespace Errigal.Api.Exceptions
{
	public class ErrigalApiException : Exception
	{
		public ErrigalApiException() : base()
		{
		}

		public ErrigalApiException(string message) : base(message)
		{
		}

		public ErrigalApiException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
