# CodeWriter.ShortTypeName method (1 of 3)
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to add namespace

```csharp
public string ShortTypeName(string fullName)
```

## Return Value

if succeeds returns only typeName if fails returns fullName

## See Also

* class [CodeWriter](../CodeWriter.md)

---

# CodeWriter.ShortTypeName method (2 of 3)
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Converts datatype with a namespace to datatype without namespace if its namespace is in the allowed usings else returns fullname.

Please see [`IsCSharp`](IsCSharp.md) if you are using this for C#

```csharp
public string ShortTypeName(CodeWriter cw, string fullName)
```

| parameter | description |
| --- | --- |
| cw |  |
| fullName |  |

## See Also

* class [CodeWriter](../CodeWriter.md)

---

# CodeWriter.ShortTypeName method (3 of 3)
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to add namespace

```csharp
public string ShortTypeName(string nameSpace, string typeName)
```

| parameter | description |
| --- | --- |
| nameSpace |  |
| typeName |  |

## Return Value

if succeeds returns only typeName if fails returns fullName

## See Also

* class [CodeWriter](../CodeWriter.md)