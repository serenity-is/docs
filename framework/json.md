# JSON Serialization

Serenity uses **System.Text.Json** as its primary JSON serializer. The `JSON` helper class and the `JSON.Defaults` options are what you should use in your own code. The older `JsonSettings` class (Newtonsoft.Json) is kept only for **backward compatibility** — prefer `JSON.Defaults` for new code.

## The `JSON` Helper

The [JSON](../api/dotnet/Serenity.Net.Core/Serenity/JSON.md) static class provides shortcuts for serializing and deserializing:

- `JSON.Parse<T>(input)` / `JSON.Parse(input, type)` — deserialize (strict by default).
- `JSON.ParseTolerant<T>(input)` — deserialize, ignoring unknown/missing members.
- `JSON.Stringify(value, writeNulls)` / `value.ToJson()` — serialize.
- `JSON.StringifyIndented(value, writeNulls)` — pretty-print.
- `JSON.PopulateObject(target, json, options)` — merge JSON into an existing object.

## Default Options (`JSON.Defaults`)

`JSON.Defaults` exposes four `JsonSerializerOptions` presets:

| Preset | Behavior |
| --- | --- |
| `Strict` | Raises an error on unknown members; omits nulls when serializing |
| `StrictWriteNulls` | Raises an error on unknown members; writes nulls |
| `Tolerant` | Ignores unknown members; omits nulls when serializing |
| `TolerantWriteNulls` | Ignores unknown members; writes nulls |

These are built by `JSON.Defaults.Populate(...)`, which applies the Serenity defaults to a `JsonSerializerOptions`:

- A `JavaScriptEncoder` that covers all Unicode ranges.
- Number handling that allows reading numbers from strings and named floating-point literals.
- Case-insensitive property names, `ReadCommentHandling = Skip`, and no property naming policy (so Pascal-case property names are used as-is).
- The Serenity converters (`SafeInt64JsonConverter`, `ObjectJsonConverter`, `NullableJsonConverter`, `EnumJsonConverter`, and `RowJsonConverter` when available).
- When not writing nulls, `DefaultIgnoreCondition = WhenWritingNull`.
- When not tolerant, `UnmappedMemberHandling = Disallow`.

## Configuring JSON for MVC in `Startup.cs`

ASP.NET Core MVC uses System.Text.Json for both reading request bodies and writing responses. Serenity's `Startup.cs` applies `JSON.Defaults` to MVC's `JsonOptions`:

```cs
services.AddControllersWithViews(...);
services.AddServiceEndpointConventions();

services.Configure<JsonOptions>(options => JSON.Defaults.Populate(options.JsonSerializerOptions));
```

This means all MVC serialization (including service endpoints) uses the same Serenity defaults for converters, number handling, null handling, and case sensitivity.

## Deserializing Request Bodies (`JsonRequestAttribute`)

[JsonRequestAttribute](../api/dotnet/Serenity.Net.Web/Serenity.Services/JsonRequestAttribute.md) is an action filter that deserializes the incoming request body (or a posted form / query string) into the action's `request` parameter, using `JSON.Defaults.Strict`.

It is useful for MVC actions that accept a JSON payload but aren't bound automatically by the model binder — for example, a plain controller action that takes a request object:

```cs
[HttpPost, JsonRequest]
public ServiceResponse MyAction(SaveRequest<MyRow> request)
{
    // request is deserialized from the JSON body
}
```

Options on the attribute:

- `ParamName` — the parameter to deserialize (default `"request"`).
- `AllowGet` — allow GET requests (default `true`).
- `AllowQuery` / `AllowForm` — fall back to reading the JSON from the query string or a posted form.

The old `[JsonFilter]` attribute is obsolete and has been renamed to `[JsonRequest]`.

## Auto-Enabled for ServiceEndpoints

You normally don't need to add `[JsonRequest]` to service endpoints. Serenity registers `ServiceEndpointActionModelConvention`, which automatically adds a `JsonRequestAttribute` to every `ServiceEndpoint` action that has a parameter deriving from [ServiceRequest](../api/dotnet/Serenity.Net.Services/Serenity.Services/ServiceRequest.md), and binds that parameter from the body. This is enabled by `AddServiceEndpointConventions()` in `Startup.cs` (see above).

`AddServiceEndpointConventions` registers `ServiceEndpointApplicationModelProvider`, which applies the convention. So for a normal endpoint:

```cs
public Task<SaveResponse> Create(IUnitOfWork uow, SaveRequest<MyRow> request,
    [FromServices] ISaveHandlerAsync<MyRow> handler, CancellationToken cancellationToken = default)
```

the `request` parameter is deserialized from the JSON body automatically — no attribute needed. You only add `[JsonRequest]` manually when an action isn't on a `ServiceEndpoint`, or when you need to override its defaults. See [Service Endpoints](../services/service_endpoints.md).

## Legacy `JsonSettings` (Newtonsoft.Json)

[JsonSettings](../api/dotnet/Serenity.Net.Core/Serenity/JsonSettings.md) provides the older Newtonsoft.Json `JsonSerializerSettings` presets (`Tolerant`, `TolerantIncludeNulls`, `Strict`, `StrictIncludeNulls`). It is kept only for **backward compatibility** — a few internal components that still rely on Newtonsoft.Json (such as `JsonField`, the code generator, dynamic scripts, and `JsonServiceClient`) reference it.

For new code, prefer the System.Text.Json `JSON` helper / `JSON.Defaults`. Avoid introducing new Newtonsoft.Json usage.

## See Also

- [Service Endpoints](../services/service_endpoints.md)
- [Service Behaviors](../services/behaviors.md)
- [Built-in Service Behaviors](../services/built-in-behaviors.md)
- [Uploads](../services/upload.md)
