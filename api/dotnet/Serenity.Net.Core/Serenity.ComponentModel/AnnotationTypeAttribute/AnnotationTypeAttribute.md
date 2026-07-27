# AnnotationTypeAttribute constructor
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Declares that the type with this attribute is an annotation type for another type, e.g. it contains attributes for the other type and its properties. This is mainly used to separate dependencies between rows and UI related properties like editor types etc.

```csharp
public AnnotationTypeAttribute(Type type)
```

| parameter | description |
| --- | --- |
| type | The type to match. It can be a type, an interface or an attribute type that type other type should have. |

## Remarks

Creates an instance of AnnotationType attribute

## See Also

* class [AnnotationTypeAttribute](../AnnotationTypeAttribute.md)