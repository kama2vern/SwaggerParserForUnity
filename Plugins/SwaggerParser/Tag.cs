using System;

namespace SwaggerParser
{
	public class Tag {
		public string name { get; private set; }
		public string description { get; private set; }
		public ExternalDocumentation externalDocs { get; private set; }
	}
}
