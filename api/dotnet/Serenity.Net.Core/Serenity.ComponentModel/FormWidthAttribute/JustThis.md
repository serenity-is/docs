# FormWidthAttribute.JustThis property

Applies this form width (e.g. bootstrap grid size) to just the current field and doesn't cancel a prior form width attribute with an UntilNext attribute. Don't set UntilNext = true if you set JustThis = true, as they are exclusive.

```csharp
public bool JustThis { get; set; }
```

## See Also

* class [FormWidthAttribute](../FormWidthAttribute.md)