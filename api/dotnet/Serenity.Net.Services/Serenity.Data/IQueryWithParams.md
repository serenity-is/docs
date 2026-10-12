# IQueryWithParams interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for objects setting parameters by PARAM method (like SqlInsert, SqlUpdate, SqlDelete...).

```csharp
public interface IQueryWithParams
```

## Members

| name | description |
| --- | --- |
| [Dialect](IQueryWithParams/Dialect.md) { get; } | Gets the dialect. |
| [HasAutoParams](IQueryWithParams/HasAutoParams.md) { get; } | Gets a value indicating whether any automatically named parameters were generated for this query or one of the queries sharing its parameter storage. Manually named parameters don't affect this. Note that this may still return false before the query is rendered (e.g. via ToString()), as auto parameters only materialize at render time. |
| [IsFrozen](IQueryWithParams/IsFrozen.md) { get; } | Gets a value indicating whether this query or one of its parents has been frozen. |
| [IsParamsFrozen](IQueryWithParams/IsParamsFrozen.md) { get; } | Gets a value indicating whether parameters have been frozen. |
| [Params](IQueryWithParams/Params.md) { get; } | Gets the parameters. |
| [Parent](IQueryWithParams/Parent.md) { get; } | Gets access to parent query if any. |
| [AddParam](IQueryWithParams/AddParam.md)(…) | Adds the parameter. |
| [AutoParam](IQueryWithParams/AutoParam.md)() | Creates an automatically named parameter. |
| [Freeze](IQueryWithParams/Freeze.md)() | Freezes the query and its parameters, and prepares its SQL text for reuse. |
| [FreezeParams](IQueryWithParams/FreezeParams.md)() | Freezes the query's parameters so they can no longer be added or changed. |
| [SetParam](IQueryWithParams/SetParam.md)(…) | Sets the parameter. |

## See Also

* **Source:** *[IQueryWithParams.cs](https://github.com/serenity-is/Serenity/blob/6e521bfc632b686bd33cfa0fa27cc54852a56835/src/services/Data/QueryModel/IQueryWithParams.cs)*