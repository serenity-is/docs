# AggregateGroup.GetKey method

Gets the key of [`Values`](./Values.md) for an aggregate type, which are the ones of the aggregators of the grids for the types they have.

```csharp
public static string GetKey(AggregateType type)
```

| parameter | description |
| --- | --- |
| type | The aggregate type. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | The type is not one of the known ones. |

## See Also

* enum [AggregateType](../AggregateType.md)
* class [AggregateGroup](../AggregateGroup.md)