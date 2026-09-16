# DatabaseCaretReferences.GetDatabaseName property

Temporary workaround as this class has no reference to SQL connection strings. Getter returns the local resolver if any is set through [`SetLocalGetDatabaseName`](./SetLocalGetDatabaseName.md), otherwise the default one. The default resolver should only be set on application start. The local resolver should be used for unit tests.

```csharp
public static Func<string, string>? GetDatabaseName { get; set; }
```

## See Also

* class [DatabaseCaretReferences](../DatabaseCaretReferences.md)