# TestArgoApp.WebApi
> The REST API that can provides the input and output of the application.

The `TestArgoApp.WebApi` is a REST API built using ASP.NET Core, is intended to act as the I/O device for the application. This is where the concerns about the input of the application, like HTTP request headers and HTTP response payloads, should be handled.

This project should focus on consuming interfaces from the `TestArgoApp.Domain.Services` namespace, so that it can operate on the business logic and use cases supported by the problem domain. This project will also be responsible for translating from the details of an HTTP request, like the HTTP request content, to a domain model that the domain services operate in.