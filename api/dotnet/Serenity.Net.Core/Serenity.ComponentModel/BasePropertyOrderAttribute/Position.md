# BasePropertyOrderAttribute.Position property

Gets or sets where the properties of the base types of the type are placed, relative to the ones of the type. The default is before. The ones of the types in [`TypesBefore`](./TypesBefore.md) and [`TypesAfter`](./TypesAfter.md), and the ones of the base types that are placed by [`WhenInherited`](./WhenInherited.md), are not placed by this.

```csharp
public BasePropertyPosition Position { get; set; }
```

## See Also

* enum [BasePropertyPosition](../BasePropertyPosition.md)
* class [BasePropertyOrderAttribute](../BasePropertyOrderAttribute.md)