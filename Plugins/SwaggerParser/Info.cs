using System;

namespace SwaggerParser
{
	public class Info {
		public string title { get; private set; }
		public string description { get; private set; }
		public string termsOfService { get; private set; }
		public Contact contact { get; private set; }
		public License license { get; private set; }
		public string version { get; private set; }
	}
}
