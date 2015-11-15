using System;
using System.Collections.Generic;

namespace SwaggerParser
{
	using Example = Dictionary<string, Dictionary<string, string>>;
	using Headers = Dictionary<string, Header>;

	public class Response
	{
		public string description { get; private set; }
		public List<Example> examples { get; private set; }
		public Headers headers { get; private set; }
		public Schema schema { get; private set; }
	}
}
