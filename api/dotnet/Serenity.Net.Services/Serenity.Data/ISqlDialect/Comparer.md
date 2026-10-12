# ISqlDialect.Comparer property

Gets the comparer used to compare string field values for this connection, or null to fall back to [`DefaultComparer`](../SqlSettings/DefaultComparer.md). Dialects that support a per-connection comparer override this and [`WithComparer`](./WithComparer.md).

```csharp
public IComparer? Comparer { get; }
```

## See Also

* interface [ISqlDialect](../ISqlDialect.md)