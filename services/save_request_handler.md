# Save Request Handler

The `SaveRequestHandler` is the base class that handles Create (insert) and Update service requests. Sergen generates a small subclass for every entity; the base class contains all the default logic, so an empty subclass already produces a working save service.

## Generated Handler

For a `Language` entity, Sergen generates:

```cs
using MyRow = MyProject.Administration.LanguageRow;

namespace MyProject.Administration;

public interface ILanguageSaveHandler : ISaveHandler<MyRow> { }

public class LanguageSaveHandler(IRequestContext context)
    : SaveRequestHandler<MyRow>(context), ILanguageSaveHandler
{
}
```

The interface (`ISaveHandler<MyRow>`) and the class derive from the generic [SaveRequestHandler&lt;TRow&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Services/SaveRequestHandler-1.md) and [ISaveRequestHandler](../api/dotnet/Serenity.Net.Services/Serenity.Services/ISaveRequestHandler.md). Request handlers are auto-registered via the type source, so no explicit registration is needed.

> In StartSharp, the handler interface does not have to be written by hand — it can be generated from the handler class with the `[GenerateInterface]` attribute. This works for all request handler types. See [Generating Handler Interfaces](generate_interface.md). For how handlers are discovered and registered automatically, see [Auto-Registration of Request Handlers](handler_auto_registration.md).

## The Service Endpoint

The endpoint exposes two actions that delegate to the handler:

```cs
[Route("Services/Administration/Language/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class LanguageEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ILanguageSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ILanguageSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
}
```

- `[AuthorizeCreate(typeof(MyRow))]` / `[AuthorizeUpdate(typeof(MyRow))]` validate the create/update permission declared on the row.
- The `IUnitOfWork` argument provides a transaction, so the save either commits or rolls back as a whole.
- `[FromServices]` injects the (auto-registered) handler.

## The Request and Response

The request is a [SaveRequest&lt;TEntity&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Services/SaveRequest-1.md):

```cs
public class SaveRequest<TEntity> : ServiceRequest, ISaveRequest
{
    public object EntityId { get; set; }
    public TEntity Entity { get; set; }
    public Dictionary<string, TEntity> Localizations { get; set; }
}
```

- `EntityId` — set for Update (which record to update); ignored for Create.
- `Entity` — the fields to insert/update. Because rows track assignments, only the fields actually sent from the client are included in the SQL statement.
- `Localizations` — optional per-language entity values when localization is used.

The response is a [SaveResponse](../api/dotnet/Serenity.Net.Services/Serenity.Services/SaveResponse.md):

```cs
public class SaveResponse : ServiceResponse
{
    public object EntityId { get; set; }
}
```

`EntityId` contains the ID of the created or updated record.

## Create vs Update

Inside the handler, `IsCreate` is `true` for Create requests and `IsUpdate` for Update requests:

```cs
if (IsCreate)
    // new record
else
    // existing record
```

`Row` holds the entity being saved. For updates, `Old` holds the previously stored entity.

## Lifecycle Methods

The main overridable methods are:

- `OnValidateRequest()` — validate the request (permissions, required fields, etc.).
- `OnSetInternalFields()` — set fields like `InsertUserId`, `InsertDate`, `UpdateUserId`, `UpdateDate`.
- `BeforeSave()` — called right before the INSERT/UPDATE is executed.
- `AfterSave()` — called right after the INSERT/UPDATE succeeds.
- `OnReturn()` — called just before the response is returned.

The `BeforeSave`/`AfterSave` methods also invoke any registered `SaveBehavior.OnBeforeSave` / `OnAfterSave`, so a behavior runs in the same phase.

## Example: Calculating a Value Before Save

A common use is computing a value in `BeforeSave`. For example, the Student Information System tutorial computes a grade average before the record is saved:

```cs
public class GradesSaveHandler : SaveRequestHandler<MyRow>, IGradesSaveHandler
{
    public GradesSaveHandler(IRequestContext context) : base(context)
    {
    }

    protected override void BeforeSave()
    {
        base.BeforeSave();

        Row.CalculateAverage();
    }
}
```

## Behaviors

Behaviors implementing [ISaveBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/ISaveBehavior.md) run for every save handler. They are discovered through the type source and are the recommended way to add cross-cutting save logic (audit logging, multi-tenancy, master–detail saving, etc.) without touching individual handlers.

## See Also

- [Service Endpoints](service_endpoints.md)
- [List Request Handler](list_request_handler.md)
- [Delete Request Handler](delete_request_handler.md)
- [Undelete Request Handler](undelete_request_handler.md)
- [Custom Request Handlers](custom_request_handlers.md)
