# ConnectionStringEntry.Comparer property

Gets or sets the comparer specification used to compare string field values for this connection, e.g. "Ordinal", "OrdinalIgnoreCase", "CurrentCultureIgnoreCase", "tr-TR" or "tr-TR:IgnoreCase". Defaults to null, meaning [`DefaultComparer`](../SqlSettings/DefaultComparer.md) is used.

```csharp
public string? Comparer { get; set; }
```

## See Also

* class [ConnectionStringEntry](../ConnectionStringEntry.md)