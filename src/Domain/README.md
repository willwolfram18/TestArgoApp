# TestArgoApp.Domain
> The business logic of the application.

The `TestArgoApp.Domain` project is intended to house the business logic of the application. This is where the bulk of business rules should be implemented, isolated from concerns like "what database do I read the data from?" or "Where is the input for this action coming form?". As it's referred to in the _Clean Architecture_ book, this would be the equivalent of an "Interactor" component.

> ⚠️⚠️⚠️ As always, this is intended to serve as a rough template and is not a silver bullet. You should update and adapt the projects as needed depending on your situation. Perhaps this template works initially, and requires decomposition at a later time into more discrete projects: don't be afraid to do that!

* `TestArgoApp.Domain.Abstractions`: This namespace aims to outline the low-level abstractions that would be implemented by the `TestArgoApp.Infrastructure` project. Interfaces defined in this namespace should be as isolated from the low-level concerns, like query langague or persistence model, as possible and used domain models.
* `TestArgoApp.Domain.Implementations`: This namespace is for implementations of domain services that would be consumed by a presentation or input layer of some kind. These classes make up the bulk of the business logic or "use cases", as referred to by Robert Martin, that operate on the domain models and entities.
    > Classes in this namespace would be ideally defined as `internal` so that consumers of the DLL can only see the public interfaces that the I/O should care about.
* `TestArgoApp.Domain.Models`: This namespace, as the name implies, is intended to house the entites and models that make up the problem domain. This namespace is where you can put classes that are intended to serve as the data your application works with.
* `TestArgoApp.Domain.Services`: This namespace aims to define the set of public interfaces and operations that presentation and input layers can depend on for performing actions in the application.