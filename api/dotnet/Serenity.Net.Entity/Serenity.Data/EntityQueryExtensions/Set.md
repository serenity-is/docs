# EntityQueryExtensions.Set&lt;T&gt; method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Sets a field value with a parameter.

```csharp
public static T Set<T>(this T self, IField field, object value)
    where T : ISetFieldByStatement
```

| parameter | description |
| --- | --- |
|  | Field name. |
|  | Parameter name |
|  | Parameter value |

## Return Value

Object itself.

## See Also

* class [T](../Serenity.Net.Entity/../EntityQueryExtensions.T.md)
* interface [IField](../Serenity.Net.Data/../IField.md)
* interface [ISetFieldByStatement](../Serenity.Net.Data/../ISetFieldByStatement.md)
* class [EntityQueryExtensions](../EntityQueryExtensions.md)

---

# EntityQueryExtensions.Set&lt;T&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Sets all field values in a row with auto named parameters (field name prefixed with '@').

```csharp
public static T Set<T>(this T self, IRow row, IField exclude = null)
    where T : ISetFieldByStatement
```

| parameter | description |
| --- | --- |
|  | The row with modified field values. Must be in TrackAssignments mode, or an exception is raised. |

## Return Value

Object itself.

## See Also

* class [T](../Serenity.Net.Entity/../EntityQueryExtensions.T.md)
* interface [IRow](../IRow.md)
* interface [IField](../Serenity.Net.Data/../IField.md)
* interface [ISetFieldByStatement](../Serenity.Net.Data/../ISetFieldByStatement.md)
* class [EntityQueryExtensions](../EntityQueryExtensions.md)