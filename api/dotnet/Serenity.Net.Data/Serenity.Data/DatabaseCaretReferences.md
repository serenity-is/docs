# DatabaseCaretReferences class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Helper class for replacing database caret references in format [^ConnectionKey] in SQL expressions.

```csharp
public class DatabaseCaretReferences
```

## Public Members

| name | description |
| --- | --- |
| [DatabaseCaretReferences](DatabaseCaretReferences/DatabaseCaretReferences.md)() | The default constructor. |
| static [GetDatabaseName](DatabaseCaretReferences/GetDatabaseName.md) { get; set; } | Temporary workaround as this class has no reference to SQL connection strings |
| static [Replace](DatabaseCaretReferences/Replace.md)(…) | Replaces caret references like [^ConnectionKey] in the specified expression with actual database names. |

## See Also

* **Source:** *[DatabaseCaretReferences.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Join/DatabaseCaretReferences.cs)*