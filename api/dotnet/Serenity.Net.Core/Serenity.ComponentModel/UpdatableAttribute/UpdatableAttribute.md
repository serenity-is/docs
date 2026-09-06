# UpdatableAttribute constructor

Controls if this field is editable in update record mode. When used with fields, turns on or off the updatable flag.

```csharp
public UpdatableAttribute(bool updatable = true)
```

| parameter | description |
| --- | --- |
| updatable | True to make the field updatable. |

## Remarks

When placed on a field, this attribute controls whether the field is included when updating an existing record.

## See Also

* class [UpdatableAttribute](../UpdatableAttribute.md)