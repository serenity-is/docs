# RowFieldsBase.GetFieldsByAttribute method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the fields that have an attribute of the specified type.

```csharp
public Field[] GetFieldsByAttribute(Type attrType)
```

| parameter | description |
| --- | --- |
| attrType | Type of the attribute. |

## Return Value

The fields that have an attribute of the specified type.

## See Also

* class [Field](../Field.md)
* class [RowFieldsBase](../RowFieldsBase.md)

---

# RowFieldsBase.GetFieldsByAttribute&lt;TAttr&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the fields that have an attribute of the specified type.

```csharp
public Field[] GetFieldsByAttribute<TAttr>()
    where TAttr : Attribute
```

| parameter | description |
| --- | --- |
| TAttr | The type of the attribute. |

## Return Value

The fields that have an attribute of the specified type.

## See Also

* class [Field](../Field.md)
* class [RowFieldsBase](../RowFieldsBase.md)