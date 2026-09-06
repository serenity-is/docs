# DataScript constructor (1 of 2)

Creates a new instance of the class.

```csharp
protected DataScript()
```

## See Also

* class [DataScript](../DataScript.md)

---

# DataScript constructor (2 of 2)

Creates a new instance of the class.

```csharp
public DataScript(string key, Func<object> getData)
```

| parameter | description |
| --- | --- |
| key | The data script key. |
| getData | The get data callback. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | getData is null. |

## See Also

* class [DataScript](../DataScript.md)