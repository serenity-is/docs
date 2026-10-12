# SqlInsert.SetNull method

Assigns NULL as the field value.

```csharp
public SqlInsert SetNull(string field)
```

| parameter | description |
| --- | --- |
| field | Field (required). |

## Return Value

SqlInsert object itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentException | field is null or empty, or was already set. |

## See Also

* class [SqlInsert](../SqlInsert.md)