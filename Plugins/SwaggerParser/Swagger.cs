using System.Collections.Generic;

namespace SwaggerParser
{
	using Parameters = Dictionary<string, Parameter>;
	using Paths = Dictionary<string, Path>;
	using ResponseDefinitions = Dictionary<string, Response>;
	using Security = Dictionary<string, List<string>>;
	using SecurityDefinitions = Dictionary<string, SecurityScheme>;

	public class Swagger {
		public string basePath { get; private set; }
		public string consumes { get; private set; }
		public Dictionary<string, Schema> definitions { get; private set; }
		public string errors { get; set; }
		public string host { get; private set; }
		public Info info { get; private set; }
		public Parameters parameters { get; private set; }
		public Paths paths { get; private set; }
		public string produces { get; private set; }
		public ResponseDefinitions responses { get; private set; }
		public List<string> schemes { get; private set; }
		public Security security { get; private set; }
		public SecurityDefinitions securityDefinitions { get; private set; }
		public string swagger { get; private set; }
		public List<Tag> tags { get; private set; }
	}
}
