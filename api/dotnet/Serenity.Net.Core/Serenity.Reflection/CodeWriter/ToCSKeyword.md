# CodeWriter.ToCSKeyword method

Converts a primitive class name to its C# keyword. If the given class is not a primitive class, returns `null`.

```csharp
public static string? ToCSKeyword(string dataType)
```

| parameter | description |
| --- | --- |
| dataType | The class name to convert. |

## Return Value

The corresponding C# keyword, or `null` if the class is not a primitive.

## See Also

* class [CodeWriter](../CodeWriter.md)