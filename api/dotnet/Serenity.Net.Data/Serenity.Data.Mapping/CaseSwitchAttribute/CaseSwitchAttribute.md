# CaseSwitchAttribute constructor
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new instance

```csharp
public CaseSwitchAttribute(object switchValue, object when1, object then1, 
    params object[] pairsElse)
```

| parameter | description |
| --- | --- |
| switchValue | Switch value |
| when1 | When expression 1 |
| then1 | When expression 2 |
| pairsElse | Additional when else pairs, followed by an optional ELSE statement. Else assumed only if the number of elements is odd |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of expressions is null |

## See Also

* class [CaseSwitchAttribute](../CaseSwitchAttribute.md)