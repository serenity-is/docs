# SqlErrorExtractOptions.ServerType property

Gets or sets the server type name, matching [`ServerType`](../../Serenity.Data/ISqlDialect/ServerType.md) (e.g. `SqlServer`, `Postgres`). Typically taken from the current connection's dialect. When specified and recognized, it takes precedence over the type name based inference done by the extractor, which can fail for wrapped, mocked or custom provider exceptions.

```csharp
public string? ServerType { get; set; }
```

## See Also

* class [SqlErrorExtractOptions](../SqlErrorExtractOptions.md)