﻿using Divergic.Logging.Xunit;
using Errigal.Api.Test.Config;
using Newtonsoft.Json;
using System.IO;
using Xunit.Abstractions;

namespace Errigal.Api.Test
{
	public abstract class BaseTest
	{
		protected BaseTest(ITestOutputHelper testOutputHelper)
		{
			// Create logger
			Logger = testOutputHelper.BuildLogger();

			// Load config
			var config = JsonConvert.DeserializeObject<TestConfiguration>(File.ReadAllText("../../../appsettings.json"));
			if (config == null)
			{
				throw new System.Exception("Could not load test configuration");
			}

			// Set and validate the options
			var options = new ErrigalClientOptions
			{
				Url = config.Url,
				Username = config.Username,
				Password = config.Password,
			};

			// Create client
			Client = new ErrigalClient(options, Logger);

			// Store the username for test data
			Username = config.Username!;
		}

		protected ErrigalClient Client { get; set; }

		protected string Username { get; set; }

		protected ICacheLogger Logger { get; }
	}
}
