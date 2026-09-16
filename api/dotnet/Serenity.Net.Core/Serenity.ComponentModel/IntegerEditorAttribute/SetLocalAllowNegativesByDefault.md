# IntegerEditorAttribute.SetLocalAllowNegativesByDefault method

Sets the local value for [`AllowNegativesByDefault`](./AllowNegativesByDefault.md) for the current thread and async context. Useful for background tasks, async methods, and testing to set the value locally without affecting other threads or tests.

```csharp
public static bool? SetLocalAllowNegativesByDefault(bool? value)
```

| parameter | description |
| --- | --- |
| value | The local value. Can be null to use the default value. |

## Return Value

The old local value, if any.

## See Also

* class [IntegerEditorAttribute](../IntegerEditorAttribute.md)