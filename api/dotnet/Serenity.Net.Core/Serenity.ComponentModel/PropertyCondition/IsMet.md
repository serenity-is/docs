# PropertyCondition.IsMet method

Gets whether a value meets the condition, by the same rules as the forms: a value matches one of the values when they are the same as text, e.g. 2 and "2", or true and "true", and a list matches when any of its items does. It can be used to check on the server what a form checks, e.g. that a field required by a condition has a value.

```csharp
public bool IsMet(object? value)
```

| parameter | description |
| --- | --- |
| value | The value of the field. |

## See Also

* class [PropertyCondition](../PropertyCondition.md)