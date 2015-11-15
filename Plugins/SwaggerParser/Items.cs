using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace SwaggerParser
{
	public class Items
	{
		[YamlMember(Alias = "default")]
		public string _default { get; private set; }
		[YamlMember(Alias = "enum")]
		public List<string> _enum { get; private set; }
		public string type { get; private set; }
	}
}
