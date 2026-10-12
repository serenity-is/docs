# ISqlDialect.WithComparer method

Returns a copy of this dialect with the specified comparer set. Dialects that support a per-connection comparer override this method; the default throws.

```csharp
public ISqlDialect WithComparer(IComparer? comparer)
```

| parameter | description |
| --- | --- |
| comparer | The comparer. |

## Return Value

The dialect with the comparer applied.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)