# AttributeOrigin enumeration
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Attribute source types for [`GetAttribute`](../Serenity.Reflection/IPropertyInfo/GetAttribute.md) and [`GetAttributes`](../Serenity.Reflection/IPropertyInfo/GetAttributes.md)

```csharp
public enum AttributeOrigin
```

## Values

| name | value | description |
| --- | --- | --- |
| Explicit | `0` | Only attributes explicitly declared on the property itself. This does not include attributes that are inherited from base classes or interfaces, intrinsic attributes, annotation-derived attributes, or attributes from based on fields. It only includes attributes that are directly applied to the property. |
| Inherit | `1` | Attributes inherited from base classes or interfaces. This includes attributes that are declared on base classes or interfaces and are inherited by the property. |
| Intrinsic | `2` | Attributes intrinsicly defined by [`IIntrinsicPropertyAttributeProvider`](../Serenity.Reflection/IIntrinsicPropertyAttributeProvider.md) |
| Annotation | `4` | Attributes derived from annotations, such as [`AnnotationTypeAttribute`](../Serenity.ComponentModel/AnnotationTypeAttribute.md). |
| BasedOnField | `8` | From the row field that the property is based on, if any. This is used for properties that are based on fields via BasedOnRow attribute. If a property is based on a field, then attributes from that field can be considered as well. If this flag is included, then attributes from the based on field whether explicitly declared, inherited, intrinsic, or annotation-derived will be included in the search for attributes, as Field object has an attribute list that does not include source for the attributes and there can be dynamic fields that are not based on a property but still have attributes. |
| All | `15` | Represents a combination of all available member types, including inherited, intrinsic, annotation, and members based on fields. |
| ExcludeInherit | `14` | Excludes inherited attributes, but includes intrinsic, annotation-derived, and based on field attributes. This is a combination of the Intrinsic, Annotation, and BasedOnField flags, but does not include the Inherit flag. |
| ExcludeBasedOnField | `7` | Excludes attributes from based on fields, but includes inherited, intrinsic, and annotation-derived attributes. This is a combination of the Inherit, Intrinsic, and Annotation flags, but does not include the BasedOnField flag. |

## See Also

* **Source:** *[AttributeOrigin.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Reflection/AttributeOrigin.cs)*