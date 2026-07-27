# CodeWriter class
**namespace:** *[Serenity.Reflection](../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Used to write formatted code to a string builder.

```csharp
public class CodeWriter
```

| parameter | description |
| --- | --- |
| sb | The sb. |
| tabSize | Number of spaces. |

## Public Members

| name | description |
| --- | --- |
| [CodeWriter](CodeWriter/CodeWriter.md)(…) | Used to write formatted code to a string builder. (3 constructors) |
| [AllowUsing](CodeWriter/AllowUsing.md) { get; set; } | Gets sets function that determines if a namespace is allowed to be added to the local usings |
| [BraceOnSameLine](CodeWriter/BraceOnSameLine.md) { get; set; } | Whether to put opening brace on the same line. |
| [Builder](CodeWriter/Builder.md) { get; } | Gets internal string builder |
| [CurrentNamespace](CodeWriter/CurrentNamespace.md) { get; set; } | Gets / sets current namespace |
| [FileComment](CodeWriter/FileComment.md) { get; set; } | Gets / sets file comment |
| [FileScopedNamespaces](CodeWriter/FileScopedNamespaces.md) { get; set; } | Use a file scoped namespace instead. Can only be used with one namespace per file. |
| [GlobalUsings](CodeWriter/GlobalUsings.md) { get; set; } | Gets / sets global usings hash set |
| [Indentation](CodeWriter/Indentation.md) { get; } | Gets current indentation string |
| [IsCSharp](CodeWriter/IsCSharp.md) { get; set; } | Gets / sets if the code writer is used for generating C# code. |
| [LocalUsings](CodeWriter/LocalUsings.md) { get; } | Gets / sets local usings hash set |
| [Tab](CodeWriter/Tab.md) { get; } | Gets tab string |
| [Append](CodeWriter/Append.md)(…) | Appends text to internal string builder (2 methods) |
| [AppendLine](CodeWriter/AppendLine.md)() | Appends a line to internal string builder |
| [AppendLine](CodeWriter/AppendLine.md)(…) | Appends a line to internal string builder |
| [Block](CodeWriter/Block.md)(…) | Increases indent, runs the insideBlock and decreases indent back. |
| [DecreaseIndent](CodeWriter/DecreaseIndent.md)() | Decreases indenting by tab size |
| [EndBrace](CodeWriter/EndBrace.md)(…) | Decreases indent and closes the brace |
| [InBrace](CodeWriter/InBrace.md)(…) | Adds a brace, increases indent, runs the inside block, decreases indent back, closes the brace. |
| [IncreaseIndent](CodeWriter/IncreaseIndent.md)() | Increases indenting using tab string |
| [Indent](CodeWriter/Indent.md)() | Appends current indent |
| [Indented](CodeWriter/Indented.md)(…) | Appends current indent and the specified string |
| [IndentedLine](CodeWriter/IndentedLine.md)(…) | Appends current indent, the specified string, and a new line. |
| [IndentedMultiLine](CodeWriter/IndentedMultiLine.md)(…) | Appends each of the text's lines with current indent, and a new line. |
| [InNamespace](CodeWriter/InNamespace.md)(…) | Executes action by opening namespace if it is not null or empty |
| [Insert](CodeWriter/Insert.md)(…) | Inserts string to internal string builder |
| [IsUsing](CodeWriter/IsUsing.md)(…) | Returns true if the namespace is in list of usings. |
| [ShortTypeName](CodeWriter/ShortTypeName.md)(…) | Tries to add namespace (2 methods) |
| [ShortTypeRef](CodeWriter/ShortTypeRef.md)(…) | Converts datatype with a namespace to datatype without namespace if its namespace is in the allowed usings else returns fullname. This can handle nullables, CS keywords and generics to some extent. Please see [`IsCSharp`](CodeWriter/IsCSharp.md) if you are using this for C# |
| [StartBrace](CodeWriter/StartBrace.md)() | Adds a brace, increases indent. |
| override [ToString](CodeWriter/ToString.md)() | Returns string representation of internal string builder, including file comment and any local usings if any |
| [Using](CodeWriter/Using.md)(…) | Returns true if the namespace is in list of usings. If AllowUsing callback is null or returns true, or force is true, this may add it to the list of local usings. (2 methods) |
| static readonly [SafeSetOfUsings](CodeWriter/SafeSetOfUsings.md) | List of usings that can be safely used during code generation without causing type name clashes |
| static [IsCSKeyword](CodeWriter/IsCSKeyword.md)(…) | Determines is Type is a C# primitive keyword |
| static [IsJSKeyword](CodeWriter/IsJSKeyword.md)(…) | Returns true if the identifier is a reserved JavaScript keyword |
| static [ToCSKeyword](CodeWriter/ToCSKeyword.md)(…) | Converts primitive class to C# keyword if given class is not a primitive class returns null. |

## Remarks

Initializes a new instance of the [`CodeWriter`](CodeWriter.md) class.

## See Also

* **Source:** *[CodeWriter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Reflection/CodeWriter.cs)*