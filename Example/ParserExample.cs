using UnityEngine;
using SwaggerParser;

public class ParserExample : MonoBehaviour {
	void Start () {
		Swagger swagger = SwaggerParser.Swagger.parse("Assets/Example/swagger.yaml");
		
		Debug.Log(swagger.basePath); // => "/v2"
		Debug.Log(swagger.host); // => "petstore.swagger.io"
	}
}
