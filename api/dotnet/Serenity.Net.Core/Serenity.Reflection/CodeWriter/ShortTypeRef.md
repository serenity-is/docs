# CodeWriter.ShortTypeRef method
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Converts datatype with a namespace to datatype without namespace if its namespace is in the allowed usings else returns fullname. This can handle nullables, CS keywords and generics to some extent. Please see [`IsCSharp`](IsCSharp.md) if you are using this for C#

```csharp
public string ShortTypeRef(string fullName)
```

| parameter | description |
| --- | --- |
| fullName | Full name of the class |

## See Also

* class [CodeWriter](../CodeWriter.md)