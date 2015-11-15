using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace SwaggerParser
{
	public class Schema : JsonSchema
	{
		[YamlMember(Alias = "$ref")]
		public string _ref { get; private set; }
		public string discriminator { get; private set; }
		public string example { get; private set; }
		public bool readOnly { get; private set; }
		public Xml xml { get; private set; }

		public Dictionary<string, string> items { get; private set; }
		public Dictionary<string, string> additionalProperties { get; private set; }
		public Dictionary<string, Schema> properties { get; private set; }
	}
}
