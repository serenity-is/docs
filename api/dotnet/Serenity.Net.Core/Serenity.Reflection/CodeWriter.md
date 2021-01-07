# CodeWriter class
**namespace:** *[Serenity.Reflection](../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Used to write formatted code to a string builder.

```csharp
public class CodeWriter
```

## Public Members

| name | description |
| --- | --- |
| [CodeWriter](CodeWriter/CodeWriter.md)(…) | Initializes a new instance of the [`CodeWriter`](CodeWriter.md) class. |
| [BraceOnSameLine](CodeWriter/BraceOnSameLine.md) { get; set; } | Whether to put opening brace on the same line. |
| [Block](CodeWriter/Block.md)(…) | Increases indent, runs the insideBlock and decreases indent back. |
| [EndBrace](CodeWriter/EndBrace.md)() | Decreases indent and closes the brace |
| [InBrace](CodeWriter/InBrace.md)(…) | Adds a brace, increases indent, runs the inside block, decreases indent back, closes the brace. |
| [Indent](CodeWriter/Indent.md)() | Appends current indent |
| [Indented](CodeWriter/Indented.md)(…) | Appends current indent and the specified string |
| [IndentedLine](CodeWriter/IndentedLine.md)(…) | Appends current indent, the specified string, and a new line. |
| [IndentedMultiLine](CodeWriter/IndentedMultiLine.md)(…) | Appends current indent for all lines of the specified string by splitting it by end of line characters, and a new line. |
| [StartBrace](CodeWriter/StartBrace.md)() | Adds a brace, increases indent. |

## See Also

* **Source:** *[CodeWriter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Reflection/CodeWriter.cs)*