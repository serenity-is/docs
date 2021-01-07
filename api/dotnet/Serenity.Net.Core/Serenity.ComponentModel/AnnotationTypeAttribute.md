# AnnotationTypeAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Declares that the type with this attribute is an annotation type for another type, e.g. it contains attributes for the other type and its properties. This is mainly used to separate dependencies between rows and UI related properties like editor types etc.

```csharp
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public class AnnotationTypeAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [AnnotationTypeAttribute](AnnotationTypeAttribute/AnnotationTypeAttribute.md)(…) | Creates an instance of AnnotationType attribute |
| [AnnotatedType](AnnotationTypeAttribute/AnnotatedType.md) { get; } | Other type, interface or type of attribute that other type should have |
| [Inherited](AnnotationTypeAttribute/Inherited.md) { get; set; } | Should type exactly match, or can it be a subclass of the type. Default is true, ignored for attribute types. |
| [Namespaces](AnnotationTypeAttribute/Namespaces.md) { get; set; } | If specified this annotation only applies to types in the namespaces and their sub namespaces if namespace ends with ".*" |
| [Properties](AnnotationTypeAttribute/Properties.md) { get; set; } | If specified, this annotation matches the type only if it has all the properties listed in this array. |

## See Also

* **Source:** *[AnnotationTypeAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Extensibility/AnnotationTypeAttribute.cs)*