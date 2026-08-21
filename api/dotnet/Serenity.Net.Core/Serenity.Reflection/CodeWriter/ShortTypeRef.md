# CodeWriter.ShortTypeRef method
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Converts a data type with a namespace to a data type without the namespace if its namespace is in the allowed usings, otherwise returns the full name. This can handle nullables, C# keywords, and generics to some extent. See [`IsCSharp`](IsCSharp.md) if you are using this for C#.

```csharp
public string ShortTypeRef(string fullName)
```

| parameter | description |
| --- | --- |
| fullName | The full name of the class. |

## Return Value

The short type reference, or the full name if the namespace cannot be used.

## See Also

* class [CodeWriter](../CodeWriter.md)