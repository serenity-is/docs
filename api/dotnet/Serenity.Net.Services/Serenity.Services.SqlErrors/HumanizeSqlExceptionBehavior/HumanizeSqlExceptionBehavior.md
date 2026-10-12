# HumanizeSqlExceptionBehavior constructor

Implicit save/delete/undelete behavior that converts recognized database constraint violations (primary key, unique, foreign key, not null) into localized ValidationErrors using [`ISqlErrorExtractor`](../ISqlErrorExtractor.md) and [`ToString`](../SqlErrorInfo/ToString.md) instead of letting the raw provider exception surface as a server error.

```csharp
public HumanizeSqlExceptionBehavior(ISqlErrorExtractor extractor)
```

| parameter | description |
| --- | --- |
| extractor | SQL error extractor. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *extractor* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [ISqlErrorExtractor](../ISqlErrorExtractor.md)
* class [HumanizeSqlExceptionBehavior](../HumanizeSqlExceptionBehavior.md)