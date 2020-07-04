using Errigal.Api.Exceptions;

namespace Errigal.Api
{
	/// <summary>
	/// Errigal Client options
	/// </summary>
	public class ErrigalClientOptions
	{
		/// <summary>
		/// Server URL
		/// </summary>
		public string? Url { get; set; }

		/// <summary>
		/// Username
		/// </summary>
		public string? Username { get; set; }

		/// <summary>
		/// Password
		/// </summary>
		public string? Password { get; set; }

		/// <summary>
		/// Validate the options
		/// </summary>
		public void Validate()
		{
			if (Url is null)
			{
				throw new ConfigurationException("Missing Url");
			}

			if (string.IsNullOrWhiteSpace(Username))
			{
				throw new ConfigurationException("Missing Username");
			}

			if (string.IsNullOrWhiteSpace(Password))
			{
				throw new ConfigurationException("Missing Password");
			}
		}
	}
}
