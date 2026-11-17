# StringEnumField&lt;TStringEnum&gt;.ConvertJsonValue method

Checks that the value read from JSON is one of the members of the string enumeration. An empty value is converted to null, like an empty string is for an enum field, so it is left to the required field validation.

```csharp
protected override string? ConvertJsonValue(string? value)
```

| parameter | description |
| --- | --- |
| value | The value. |

## Return Value

The value itself, or null if it is empty.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidCastException | The value is not one of the members. |

## See Also

* class [StringEnumField&lt;TStringEnum&gt;](../StringEnumField-1.md)