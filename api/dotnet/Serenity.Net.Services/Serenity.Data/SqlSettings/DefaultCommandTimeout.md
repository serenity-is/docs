# SqlSettings.DefaultCommandTimeout property

Gets or sets the default command timeout. Returns the local timeout if any is set through [`SetLocalCommandTimeout`](./SetLocalCommandTimeout.md), otherwise the default timeout. The local timeout should be used for unit tests.

```csharp
public static int? DefaultCommandTimeout { get; set; }
```

## Property Value

The default command timeout.

## See Also

* class [SqlSettings](../SqlSettings.md)