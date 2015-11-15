using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace SwaggerParser
{
	public class SecurityScheme
	{
		public string authorizationUrl { get; private set; }
		public string description { get; private set; }
		public string flow { get; private set; }
		[YamlMember(Alias = "in")]
		public string _in { get; private set; }
		public string name { get; private set; }
		public Dictionary<string, string> scopes { get; private set; }
		public string tokenUrl { get; private set; }
		public string type { get; private set; }
	}
}

