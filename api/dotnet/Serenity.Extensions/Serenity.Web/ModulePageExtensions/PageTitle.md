# ModulePageExtensions.PageTitle method (1 of 3)

Gets the page title local text key for the specified row fields.

```csharp
public static string PageTitle(this RowFieldsBase fields)
```

| parameter | description |
| --- | --- |
| fields | The row fields. |

## Return Value

The page title local text key.

## See Also

* class [RowFieldsBase](../../../Serenity.Net.Services/Serenity.Data/RowFieldsBase.md)
* class [ModulePageExtensions](../ModulePageExtensions.md)

---

# ModulePageExtensions.PageTitle method (2 of 3)

Sets the page title of the result.

```csharp
public static ModulePageResult PageTitle(this ModulePageResult result, LocalText pageTitle)
```

| parameter | description |
| --- | --- |
| result | The module page result. |
| pageTitle | The page title. |

## Return Value

The module page result.

## See Also

* class [ModulePageResult](../ModulePageResult.md)
* class [LocalText](../../../Serenity.Net.Core/Serenity/LocalText.md)
* class [ModulePageExtensions](../ModulePageExtensions.md)

---

# ModulePageExtensions.PageTitle&lt;TRow&gt; method (3 of 3)

Sets the page title of the result from the specified row type.

```csharp
public static ModulePageResult PageTitle<TRow>(this ModulePageResult result)
    where TRow : IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The row type. |
| result | The module page result. |

## Return Value

The module page result.

## See Also

* class [ModulePageResult](../ModulePageResult.md)
* interface [IRow](../../../Serenity.Net.Services/Serenity.Data/IRow.md)
* class [ModulePageExtensions](../ModulePageExtensions.md)