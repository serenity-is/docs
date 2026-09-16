# DatabaseCaretReferences class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Helper class for replacing database caret references in format [^ConnectionKey] in SQL expressions.

```csharp
public class DatabaseCaretReferences
```

## Public Members

| name | description |
| --- | --- |
| [DatabaseCaretReferences](DatabaseCaretReferences/DatabaseCaretReferences.md)() | The default constructor. |
| static [GetDatabaseName](DatabaseCaretReferences/GetDatabaseName.md) { get; set; } | Temporary workaround as this class has no reference to SQL connection strings. Getter returns the local resolver if any is set through [`SetLocalGetDatabaseName`](./DatabaseCaretReferences/SetLocalGetDatabaseName.md), otherwise the default one. The default resolver should only be set on application start. The local resolver should be used for unit tests. |
| static [Replace](DatabaseCaretReferences/Replace.md)(…) | Replaces caret references like [^ConnectionKey] in the specified expression with actual database names. |
| static [SetLocalGetDatabaseName](DatabaseCaretReferences/SetLocalGetDatabaseName.md)(…) | Sets the local database name resolver for the current thread and async context. Useful for background tasks, async methods, and testing to set the resolver locally and for auto spawned threads. |

## See Also

* **Source:** *[DatabaseCaretReferences.cs](https://github.com/serenity-is/Serenity/blob/9b5fc556ffc2ba1dcf1ee6bf37162448aaa34578/src/services/Data/Join/DatabaseCaretReferences.cs)*