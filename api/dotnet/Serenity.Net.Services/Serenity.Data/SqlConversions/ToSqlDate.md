# SqlConversions.ToSqlDate method (1 of 2)

Converts the value to a SQL date.

```csharp
public static string ToSqlDate(this DateTime value, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| value | The value. |
| dialect | The dialect. |

## Return Value

The SQL date constant.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSqlDate method (2 of 2)

Converts the value to a SQL date.

```csharp
public static string ToSqlDate(this DateTime? value, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| value | The value. |
| dialect | The dialect. |

## Return Value

The SQL date constant, or NULL if the value has no value.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlConversions](../SqlConversions.md)