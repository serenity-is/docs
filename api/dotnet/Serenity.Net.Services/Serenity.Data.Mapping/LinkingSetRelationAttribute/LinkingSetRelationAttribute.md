# LinkingSetRelationAttribute constructor
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Specifies a linking set relation (1-N relation of ID values, like a check list.)

```csharp
public LinkingSetRelationAttribute(Type rowType, string thisKey, string itemKey)
```

| parameter | description |
| --- | --- |
| rowType | Linking row type |
| thisKey | Name of the field in linking row that corresponds to ID in this table |
| itemKey | Name of the field in linking row that will hold item values in list |

## Remarks

Declares a linking set relation

## See Also

* class [LinkingSetRelationAttribute](../LinkingSetRelationAttribute.md)