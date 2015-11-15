# SwaggerParserForUnity

[Swagger](http://swagger.io/) schema parser for Unity.

## Requirements

- [YamlDotNet For Unity](https://www.assetstore.unity3d.com/jp/#!/content/36292)

## Usage

```
Swagger swagger = SwaggerParser.Swagger.parse("Assets/Example/swagger.yaml");
		
Debug.Log(swagger.basePath); // => "/v2"
Debug.Log(swagger.host); // => "petstore.swagger.io"
Debug.Log(swagger.info.title); // => "Swagger Petstore"
```
