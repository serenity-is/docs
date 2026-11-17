# BasePropertyOrderAttribute.WhenInherited property

Gets or sets where the properties of the type are placed in a type that inherits it, instead of the position that type gives its base types, which is Default. Before is before all the other properties, and After is after all of them, unless the inheriting type lists it.

```csharp
public BasePropertyPosition WhenInherited { get; set; }
```

## See Also

* enum [BasePropertyPosition](../BasePropertyPosition.md)
* class [BasePropertyOrderAttribute](../BasePropertyOrderAttribute.md)