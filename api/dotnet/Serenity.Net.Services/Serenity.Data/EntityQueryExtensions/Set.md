# EntityQueryExtensions.Set&lt;T&gt; method (1 of 2)

Sets a field value with a parameter.

```csharp
public static T Set<T>(this T self, IField field, object value)
    where T : ISetFieldByStatement
```

| parameter | description |
| --- | --- |
| self | The query to set the field value on. |
| field | The field name. |
| value | The parameter value. |

## Return Value

The object itself.

## See Also

* interface [IField](../IField.md)
* interface [ISetFieldByStatement](../ISetFieldByStatement.md)
* class [EntityQueryExtensions](../EntityQueryExtensions.md)

---

# EntityQueryExtensions.Set&lt;T&gt; method (2 of 2)

Sets all field values in a row with auto named parameters (field name prefixed with '@').

```csharp
public static T Set<T>(this T self, IRow row, IField exclude = null)
    where T : ISetFieldByStatement
```

| parameter | description |
| --- | --- |
| self | The query to set the field values on. |
| row | The row with modified field values. Must be in TrackAssignments mode, or an exception is raised. |
| exclude | The field to exclude from being set. |

## Return Value

The object itself.

## See Also

* interface [IRow](../IRow.md)
* interface [IField](../IField.md)
* interface [ISetFieldByStatement](../ISetFieldByStatement.md)
* class [EntityQueryExtensions](../EntityQueryExtensions.md)