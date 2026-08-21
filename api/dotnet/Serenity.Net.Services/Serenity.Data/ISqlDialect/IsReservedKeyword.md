# ISqlDialect.IsReservedKeyword method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Returns true if the specified identifier is a SQL keyword.

```csharp
public bool IsReservedKeyword(string keyword)
```

| parameter | description |
| --- | --- |
| keyword | The identifier to check. |

## Return Value

`true` if the identifier is a reserved SQL keyword; otherwise, `false`.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)