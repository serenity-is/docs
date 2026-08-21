# CodeWriter.ShortTypeName method (1 of 2)
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns the short type name for the given fully qualified name, adding the namespace to the local usings if possible.

```csharp
public string ShortTypeName(string fullName)
```

| parameter | description |
| --- | --- |
| fullName | The fully qualified type name. |

## Return Value

The type name alone if the namespace can be used, otherwise the fully qualified name.

## See Also

* class [CodeWriter](../CodeWriter.md)

---

# CodeWriter.ShortTypeName method (2 of 2)
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns the short type name for the given namespace and type name, adding the namespace to the local usings if possible.

```csharp
public string ShortTypeName(string ns, string typeName)
```

| parameter | description |
| --- | --- |
| ns | The namespace. |
| typeName | The type name. |

## Return Value

The type name alone if the namespace can be used, otherwise the fully qualified name.

## See Also

* class [CodeWriter](../CodeWriter.md)