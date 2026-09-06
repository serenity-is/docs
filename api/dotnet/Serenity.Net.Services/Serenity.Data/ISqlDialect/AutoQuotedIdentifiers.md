# ISqlDialect.AutoQuotedIdentifiers property

Gets a value indicating whether to automatically quote identifiers. Default is null, e.g. SqlSettings.AutoQuotedIdentifiers is used, which itself is false by default, but usually set to true in applications.

```csharp
public bool? AutoQuotedIdentifiers { get; }
```

## See Also

* interface [ISqlDialect](../ISqlDialect.md)