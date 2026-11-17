# WrappedProperty.GetImplementedInterfaceProperties method

Gets the properties of the interfaces that a property implements, in the type it was obtained from, ordered by the full names of the interfaces, so the result doesn't depend on the order the runtime lists them in.

```csharp
public static PropertyInfo[] GetImplementedInterfaceProperties(PropertyInfo property)
```

| parameter | description |
| --- | --- |
| property | The property. |

## Return Value

The properties of the interfaces, or an empty array when it implements none.

## See Also

* class [WrappedProperty](../WrappedProperty.md)