# DistinctValuesScript&lt;TRow&gt; constructor

Initializes a new instance of the [`DistinctValuesScript`](../DistinctValuesScript-1.md) class.

```csharp
public DistinctValuesScript(ISqlConnections connections, string propertyName)
```

| parameter | description |
| --- | --- |
| connections | The SQL connections. |
| propertyName | The property name. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *connections* or *propertyName* is `null`. |

## See Also

* interface [ISqlConnections](../../../Serenity.Net.Services/Serenity.Data/ISqlConnections.md)
* class [DistinctValuesScript&lt;TRow&gt;](../DistinctValuesScript-1.md)