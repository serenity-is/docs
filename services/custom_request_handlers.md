# Custom Request Handlers

Besides the standard CRUD handlers (Save, List, Retrieve, Delete, Undelete), you can write **custom request handlers** for actions that don't fit the CRUD pattern — e.g. `StartTask`, `FinishTask`, `RecalculatePrice`, or updating a user's preferences.

A custom handler is just a class with public methods that performs the operation. For Serenity's automatic registration system to find it, the handler must **implement [IRequestHandler](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRequestHandler.md)** (directly, or transitively through an interface).

## Without Pro.Coder (plain Serenity)

If you don't use `Serenity.Pro.Coder` (e.g. in Serene or another project), you write the interface yourself and make it derive from `IRequestHandler`. The handler class derives from [BaseRequestHandler](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseRequestHandler.md) (which takes `IRequestContext` and provides `Context`, `Cache`, `Connection`, etc.) and implements that interface:

```cs
public interface IMySomethingHandler : IRequestHandler
{
    SaveResponse Update(IUnitOfWork uow, MySomethingRequest request);
}

public class MySomethingHandler(IRequestContext context)
    : BaseRequestHandler(context), IMySomethingHandler
{
    public SaveResponse Update(IUnitOfWork uow, MySomethingRequest request)
    {
        // ...
    }
}
```

The explicit `IRequestHandler` base on the interface is what makes `AddCustomRequestHandlers` pick this handler up automatically (see [Auto-Registration of Request Handlers](handler_auto_registration.md)).

## With Pro.Coder (StartSharp)

In StartSharp, you don't have to write the interface. Put [GenerateInterface](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/GenerateInterfaceAttribute.md) on the class. As long as the class name ends with `Handler`, the generated interface gets `IRequestHandler` as its base — so the class transitively implements `IRequestHandler` and is picked up automatically. No explicit interface is needed.

Here is `WorkLogStartTaskHandler` from the StartSharp WorkLog module:

```cs
namespace Serenity.Pro.WorkLog.RequestHandlers;

[GenerateInterface]
public class WorkLogStartTaskHandler(IWorkLogSaveHandler handler) : IWorkLogStartTaskHandler
{
    public SaveResponse StartTask(IUnitOfWork uow, WorkLogStartTaskRequest request)
    {
        // ...
    }
}
```

A few things to note:

- The class name ends with `Handler`, so the `InterfaceSourceGenerator` generates `IWorkLogStartTaskHandler : IRequestHandler` (in the `Serenity.Pro.WorkLog` namespace — the `.RequestHandlers` suffix is stripped), and includes the public `StartTask` method.
- The handler doesn't derive from `BaseRequestHandler` — it composes another handler (`IWorkLogSaveHandler`) via constructor injection to do the actual save. Custom handlers can be as simple or as complex as needed.

## Exposing the Handler via an Endpoint

A custom handler is called from an endpoint action that injects it via `[FromServices]`:

```cs
[HttpPost, AuthorizeUpdate(typeof(MyRow))]
public SaveResponse StartTask(IUnitOfWork uow, WorkLogStartTaskRequest request,
    [FromServices] IWorkLogStartTaskHandler handler)
{
    return handler.StartTask(uow, request);
}
```

## See Also

- [Auto-Registration of Request Handlers](handler_auto_registration.md)
- [Generating Handler Interfaces](generate_interface.md)
- [Service Endpoints](service_endpoints.md)
