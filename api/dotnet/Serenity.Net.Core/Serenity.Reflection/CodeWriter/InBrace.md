# CodeWriter.InBrace method
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds a brace, increases indent, runs the inside block, decreases indent back, closes the brace.

```csharp
public void InBrace(Action insideBlock, bool endLine = true)
```

| parameter | description |
| --- | --- |
| insideBlock | The inside block. |
| endLine | If should end the line |

## See Also

* class [CodeWriter](../CodeWriter.md)