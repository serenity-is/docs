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
| [Params](IQueryWithParams/Params.md) { get; } | Gets the parameters. |
| [AddParam](IQueryWithParams/AddParam.md)(…) | Adds the parameter. |
| [AutoParam](IQueryWithParams/AutoParam.md)() | Creates an automatically named parameter. |
| [SetParam](IQueryWithParams/SetParam.md)(…) | Sets the parameter. |

## See Also

* **Source:** *[IQueryWithParams.cs](https://github.com/serenity-is/Serenity/blob/03d9544633af3a843d9921adc3e91fceec981ad4/src/services/Data/QueryModel/IQueryWithParams.cs)*