# Codewrinkles.HIBPDotNetCore.Client
.NET consumer for the HaveIBeenPawned API


Installation
To install the client, you can use NuGet:

"Install-Package Codewrinkles.HIBP.Client"

#Usage
The client is very simple to use. 
You can create a new instance of the client by passing in your API key. HttpClient will be created and managed by the client.

var client = new HIBPClient("your-api-key"); 

Or you can use dependency injection to inject the client into your application. 
using "Codewrinkles.HIBP.Client.DependencyInjection" extension.

services.AddHIBPClient("your-api-key");




