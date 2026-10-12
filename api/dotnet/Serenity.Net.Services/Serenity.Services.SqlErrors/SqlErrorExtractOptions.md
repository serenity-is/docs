# SqlErrorExtractOptions class
**namespace:** *[Serenity.Services.SqlErrors](../README.md#serenity.services.sqlerrors-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Options for [`Extract`](./ISqlErrorExtractor/Extract.md).

```csharp
public class SqlErrorExtractOptions
```

## Public Members

| name | description |
| --- | --- |
| [SqlErrorExtractOptions](SqlErrorExtractOptions/SqlErrorExtractOptions.md)() | The default constructor. |
| [ServerType](SqlErrorExtractOptions/ServerType.md) { get; set; } | Gets or sets the server type name, matching [`ServerType`](../Serenity.Data/ISqlDialect/ServerType.md) (e.g. `SqlServer`, `Postgres`). Typically taken from the current connection's dialect. When specified and recognized, it takes precedence over the type name based inference done by the extractor, which can fail for wrapped, mocked or custom provider exceptions. |

## See Also

* **Source:** *[SqlErrorExtractOptions.cs](https://github.com/serenity-is/Serenity/blob/129785379640a01aa65d383053b7eb95a1f6890d/src/services/RequestHandlers/IntegratedFeatures/SqlErrors/SqlErrorExtractOptions.cs)*