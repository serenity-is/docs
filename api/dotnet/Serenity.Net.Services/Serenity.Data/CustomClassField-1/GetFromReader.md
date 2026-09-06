# CustomClassField&lt;TValue&gt;.GetFromReader method (1 of 2)

Gets field value from a data reader.

```csharp
protected virtual TValue GetFromReader(IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| index | The index. |

## Return Value

The field value read from the reader.

## Exceptions

| exception | condition |
| --- | --- |
| NotImplementedException | This method must be overridden in a derived class. |

## See Also

* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.GetFromReader method (2 of 2)

Gets field value from a data reader.

```csharp
public override void GetFromReader(IDataReader reader, int index, IRow row)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| index | The index. |
| row | The row. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | reader is null. |

## See Also

* interface [IRow](../IRow.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)