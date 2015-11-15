using System;
using System.Collections;
using System.Collections.Generic;

namespace SwaggerParser
{
	public class Path
	{
		public static List<string> OPERATION_NAMES = new List<string> {
			"delete",
			"get",
			"head",
			"options",
			"patch",
			"post",
			"put"
		};

		public Operation delete { get; private set; }
		public Operation get { get; private set; }
		public Operation head { get; private set; }
		public List<Operation> operations { get; private set; }
		public Operation options { get; private set; }
		public Parameter parameters { get; private set; }
		public Operation patch { get; private set; }
		public Operation post { get; private set; }
		public Operation put { get; private set; }
	}
}

