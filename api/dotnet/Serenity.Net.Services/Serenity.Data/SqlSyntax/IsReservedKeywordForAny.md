# SqlSyntax.IsReservedKeywordForAny method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Returns true if the specified identifier is a SQL keyword in any of the known dialects.

```csharp
public static bool IsReservedKeywordForAny(string identifier)
```

| parameter | description |
| --- | --- |
| identifier | The identifier. |

## Return Value

True if the identifier is a reserved keyword in any dialect; otherwise, false.

## See Also

* class [SqlSyntax](../SqlSyntax.md)