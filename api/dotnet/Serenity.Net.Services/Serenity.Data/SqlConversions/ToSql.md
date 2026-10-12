# SqlConversions.ToSql method (1 of 10)

Converts the value to SQL.

```csharp
public static string ToSql(this bool? value)
```

| parameter | description |
| --- | --- |
| value | The value. |

## Return Value

The SQL constant, or NULL if the value has no value.

## See Also

* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSql method (2 of 10)

Converts the value to SQL.

```csharp
public static string ToSql(this decimal? value)
```

| parameter | description |
| --- | --- |
| value | The value. |

## Return Value

The SQL constant, or NULL if the value has no value.

## See Also

* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSql method (3 of 10)

Converts the value to SQL.

```csharp
public static string ToSql(this double? value)
```

| parameter | description |
| --- | --- |
| value | The value. |

## Return Value

The SQL constant, or NULL if the value has no value.

## See Also

* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSql method (4 of 10)

Converts the value to SQL.

```csharp
public static string ToSql(this float? value)
```

| parameter | description |
| --- | --- |
| value | The value. |

## Return Value

The SQL constant, or NULL if the value has no value.

## See Also

* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSql method (5 of 10)

Converts the value to SQL.

```csharp
public static string ToSql(this int? value)
```

| parameter | description |
| --- | --- |
| value | The value. |

## Return Value

The SQL constant, or NULL if the value has no value.

## See Also

* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSql method (6 of 10)

Converts the value to SQL.

```csharp
public static string ToSql(this long? value)
```

| parameter | description |
| --- | --- |
| value | The value. |

## Return Value

The SQL constant, or NULL if the value has no value.

## See Also

* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSql method (7 of 10)

Converts the value to SQL.

```csharp
public static string ToSql(this DateTime value, ISqlDialect? dialect = null)
```

| parameter | description |
| --- | --- |
| value | The value. |
| dialect | The dialect. |

## Return Value

The SQL constant.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSql method (8 of 10)

Converts the value to SQL.

```csharp
public static string ToSql(this DateTime? value, ISqlDialect? dialect = null)
```

| parameter | description |
| --- | --- |
| value | The value. |
| dialect | The dialect. |

## Return Value

The SQL constant, or NULL if the value has no value.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSql method (9 of 10)

Converts the GUID to an SQL literal appropriate for the specified dialect.

```csharp
public static string ToSql(this Guid? value, ISqlDialect? dialect = null)
```

| parameter | description |
| --- | --- |
| value | The value. |
| dialect | The target dialect. If null, [`DefaultDialect`](../SqlSettings/DefaultDialect.md) is used. |

## Return Value

The SQL constant, or NULL if the value has no value.

## Remarks

FluentMigrator 8.0.1 maps `AsGuid()` to `UNIQUEIDENTIFIER` on SQL Server, `UUID` on PostgreSQL, `RAW(16)` on Oracle, `CHAR(16) CHARACTER SET OCTETS` on Firebird, `CHAR(36)` on MySQL, and `UNIQUEIDENTIFIER` on SQLite (or `TEXT` for strict tables). This method follows those storage conventions: Oracle uses the .NET Guid byte-array order used by FluentMigrator's Oracle quoter, and Firebird uses the canonical UUID byte order used by Firebird UUID functions. Other dialects, and a null dialect, use a quoted canonical string to remain compatible with string-based GUID columns.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlConversions](../SqlConversions.md)

---

# SqlConversions.ToSql method (10 of 10)

Converts the value to SQL.

```csharp
public static string ToSql(this string value, ISqlDialect? dialect = null)
```

| parameter | description |
| --- | --- |
| value | The value. |
| dialect | The dialect. |

## Return Value

The SQL constant, or NULL if the value is null.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlConversions](../SqlConversions.md)