using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace SwaggerParser
{
	public class Parameter : JsonSchema
	{
		public bool allowEmptyValue { get; private set; }
		public string collectionFormat { get; private set; }
		[YamlMember(Alias = "in")]
		public string _in { get; private set; }
		public Items items { get; private set; }
		public string name { get; private set; }
		public bool required { get; private set; }
		public Schema schema { get; private set; }
	}
}

