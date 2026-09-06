# Criteria.Bracket method

Creates a new criteria containing the field name in brackets.

```csharp
public static Criteria Bracket(string fieldName)
```

| parameter | description |
| --- | --- |
| fieldName | The name of the field. |

## Return Value

A new criteria with the field name in brackets.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | fieldName is null or empty string. |

## See Also

* class [Criteria](../Criteria.md)