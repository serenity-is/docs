# ISqlDialect.ScopeIdentityExpression property

Gets the SCOPE IDENTITY expression.

```csharp
public string ScopeIdentityExpression { get; }
```

## Property Value

The SCOPE IDENTITY expression.

## Remarks

Dialects that don't use SCOPE IDENTITY (check [`UseScopeIdentity`](./UseScopeIdentity.md) first, e.g. dialects using RETURNING) throw NotImplementedException.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)