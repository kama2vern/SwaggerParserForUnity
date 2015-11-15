using System;
using YamlDotNet.Serialization;

namespace SwaggerParser
{
	public class Xml
	{
		public bool attribute { get; private set; }
		public string name { get; private set; }
		[YamlMember(Alias = "namespace")]
		public string _namespace { get; private set; }
		public string prefix { get; private set; }
		public bool wrapped { get; private set; }
	}
}
