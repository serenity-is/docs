# ComparerResolver.Parse method

Parses the specified comparer specification. Returns null for null or empty values.

```csharp
public static StringComparer? Parse(string? value)
```

| parameter | description |
| --- | --- |
| value | The comparer specification. |

## Return Value

The parsed string comparer, or null if *value* is null or empty.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentException | The comparer specification is not valid. |

## See Also

* class [ComparerResolver](../ComparerResolver.md)