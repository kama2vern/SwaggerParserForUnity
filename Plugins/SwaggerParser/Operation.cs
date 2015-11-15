using System;
using System.Collections.Generic;

namespace SwaggerParser
{
	using Responses = Dictionary<string, Response>;
	using Security = List<Dictionary<string, List<string>>>;

	public class Operation {
		public List<string> consumes { get; private set; }
		public bool deprecated { get; private set; }
		public string description { get; private set; }
		public string operationId { get; private set; }
		public List<Parameter> parameters { get; private set; }
		public List<string> produces { get; private set; }
		public Responses responses { get; private set; }
		public string schemes { get; private set; }
		public Security security { get; private set; }
		public string summary { get; private set; }
		public List<string> tags { get; private set; }
	}
}
