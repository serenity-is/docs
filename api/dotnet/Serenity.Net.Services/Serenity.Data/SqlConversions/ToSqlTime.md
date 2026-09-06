# SqlConversions.ToSqlTime method (1 of 2)

Converts the value to a SQL time.

```csharp
public static string ToSqlTime(this DateTime value, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| value | The value. |
| dialect | The dialect. |

## Return Value

The SQL time constant.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSqlTime method (2 of 2)

Converts the value to a SQL time.

```csharp
public static string ToSqlTime(this DateTime? value, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| value | The value. |
| dialect | The dialect. |

## Return Value

The SQL time constant, or NULL if the value has no value.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlConversions](../SqlConversions.md)