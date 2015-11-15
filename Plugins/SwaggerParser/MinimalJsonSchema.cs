using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace SwaggerParser
{
	public class MinimalJsonSchema
	{
		[YamlMember(Alias = "default")]
		public string _default { get; private set; }
		public string description { get; private set; }
		[YamlMember(Alias = "enum")]
		public List<string> _enum { get; private set; }
		public string exclusiveMaximum { get; private set; }
		public string exclusiveMinimum { get; private set; }
		public string format { get; private set; }
		public string maximum { get; private set; }
		public string maxItems { get; private set; }
		public string maxLength { get; private set; }
		public string minimum { get; private set; }
		public string minItems { get; private set; }
		public string minLength { get; private set; }
		public string multipleOf { get; private set; }
		public string pattern { get; private set; }
		public string title { get; private set; }
		public string type { get; private set; }
		public bool uniqueItems { get; private set; }
	}
}

