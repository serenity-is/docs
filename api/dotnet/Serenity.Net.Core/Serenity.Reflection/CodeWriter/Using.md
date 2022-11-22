# CodeWriter.Using method (1 of 2)
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns true if the namespace is in list of usings. If AllowUsing callback is null or returns true, this may add it to the list of local usings.

```csharp
public bool Using(string ns)
```

| parameter | description |
| --- | --- |
| ns |  |

## See Also

* class [CodeWriter](../CodeWriter.md)

---

# CodeWriter.Using method (2 of 2)
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns true if the namespace is in list of usings. If AllowUsing callback is null or returns true, or force is true, this may add it to the list of local usings.

```csharp
public bool Using(string ns, bool force)
```

| parameter | description |
| --- | --- |
| ns |  |
| force |  |

## See Also

* class [CodeWriter](../CodeWriter.md)