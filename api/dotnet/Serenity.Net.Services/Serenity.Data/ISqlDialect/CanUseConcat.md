# ISqlDialect.CanUseConcat property

Gets a value indicating whether the server supports the CONCAT() function (used by `ConcatAttribute` to decide between `CONCAT(...)` and an infix operator). This does not imply [`ConcatOperator`](./ConcatOperator.md) is available: e.g. MySQL supports `CONCAT()` but has no infix concatenation operator (`||` is logical OR there unless PIPES_AS_CONCAT mode is on).

```csharp
public bool CanUseConcat { get; }
```

## Property Value

`true` if the server supports CONCAT function; otherwise, `false`.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)