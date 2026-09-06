# RowFieldsBase.Initialize method

Initializes the specified annotations.

```csharp
public void Initialize(IAnnotatedType annotations, ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| annotations | The annotations. |
| dialect | The dialect. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | dialect |
| InvalidProgramException |  |

## See Also

* interface [IAnnotatedType](../../../Serenity.Net.Core/Serenity.Reflection/IAnnotatedType.md)
* interface [ISqlDialect](../ISqlDialect.md)
* class [RowFieldsBase](../RowFieldsBase.md)