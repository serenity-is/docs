# PropertyCondition.Values property

Gets or sets the values that meet the condition, any of which the field can have. When there are none, the condition is met when the field has a value, which is one that is not null, an empty string, an empty list or false. Enum values are given as their numbers, as the editors have them.

```csharp
public object?[]? Values { get; set; }
```

## See Also

* class [PropertyCondition](../PropertyCondition.md)