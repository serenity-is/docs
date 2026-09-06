# EntityFieldExtensions.IsTableField method

Checks to see if field is an actual table field, e.g. not a foreign or calculated field. This is determined by field flags and having expression.

```csharp
public static bool IsTableField(this Field field)
```

| parameter | description |
| --- | --- |
| field | The field. |

## Return Value

True if field seems to be an actual table field.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field |

## See Also

* class [Field](../Field.md)
* class [EntityFieldExtensions](../EntityFieldExtensions.md)