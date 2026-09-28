# RowFieldsBase.Initialize method

Initializes the specified annotations.

```csharp
public void Initialize(IAnnotatedType? annotations, ISqlDialect dialect, 
    UserEntityOptions? userEntityOptions)
```

| parameter | description |
| --- | --- |
| annotations | The annotations. |
| dialect | The dialect. |
| userEntityOptions | The user entity options. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | dialect |
| InvalidProgramException |  |

## See Also

* interface [IAnnotatedType](../../../Serenity.Net.Core/Serenity.Reflection/IAnnotatedType.md)
* interface [ISqlDialect](../ISqlDialect.md)
* class [UserEntityOptions](../UserEntityOptions.md)
* class [RowFieldsBase](../RowFieldsBase.md)