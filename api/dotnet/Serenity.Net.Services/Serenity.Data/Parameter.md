# Parameter structure
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Parameter struct.

```csharp
public struct Parameter
```

| parameter | description |
| --- | --- |
| name | The name. Must start with "@": parameter names are always "@"-prefixed, and dialect translation happens later when the command is built (see SqlHelper.AddParamWithValue). |

## Public Members

| name | description |
| --- | --- |
| [Parameter](Parameter/Parameter.md)(…) | Parameter struct. |
| [Name](Parameter/Name.md) { get; } | Gets the name. |
| static [CheckName](Parameter/CheckName.md)(…) | Validates a parameter name, so that null, empty, "@"-only and whitespace-only names are rejected in one place. Used by this constructor and other parameter-name entry points (AddParam / SetParam / ParamCriteria). |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | name is null or empty. |
| ArgumentOutOfRangeException | name doesn't start with "@", or has nothing but whitespace after it. |

## Remarks

Initializes a new instance of the [`Parameter`](./Parameter.md) struct.

## See Also

* **Source:** *[Parameter.cs](https://github.com/serenity-is/Serenity/blob/693241c83ea72bbdcad767653dcd87c6afd5bb8b/src/services/Data/QueryModel/Parameter.cs)*