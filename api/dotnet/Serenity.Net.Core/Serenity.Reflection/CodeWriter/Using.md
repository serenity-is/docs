# CodeWriter.Using method (1 of 2)

Returns true if the namespace is in the list of usings. If the AllowUsing callback is null or returns true, this may add it to the list of local usings.

```csharp
public bool Using(string ns)
```

| parameter | description |
| --- | --- |
| ns | The namespace to check. |

## Return Value

`true` if the namespace is in the list of usings; otherwise, `false`.

## See Also

* class [CodeWriter](../CodeWriter.md)

---

# CodeWriter.Using method (2 of 2)

Returns true if the namespace is in the list of usings. If the AllowUsing callback is null or returns true, or force is true, this may add it to the list of local usings.

```csharp
public bool Using(string ns, bool force)
```

| parameter | description |
| --- | --- |
| ns | The namespace to check. |
| force | `true` to add the namespace to the local usings regardless of the AllowUsing callback. |

## Return Value

`true` if the namespace is in the list of usings; otherwise, `false`.

## See Also

* class [CodeWriter](../CodeWriter.md)