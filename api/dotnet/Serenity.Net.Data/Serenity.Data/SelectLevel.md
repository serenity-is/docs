# SelectLevel enumeration
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Select level enumeration

```csharp
public enum SelectLevel
```

## Values

| name | value | description |
| --- | --- | --- |
| Auto | `0` | Auto is equivalent to List level for table fields and Details level for view fields. |
| Always | `1` | Always select this field, even if it is in ExcludeColumns list |
| Lookup | `2` | Obsolete. Use [LookupInclude] attribute. |
| List | `3` | Select this field in ColumnSelection.List or ColumnSelection.Details modes, or if it's specified in IncludeColumns list (if not also in ExcludeColumns list) |
| Details | `4` | Select this field in ColumnSelection.Details mode or if it's specified in IncludeColumns list (if not also in ExcludeColumns list) |
| Explicit | `5` | Don't select this field in any mode. Select it if specified in IncludeColumns list (if not also in ExcludeColumns list) |
| Never | `6` | Never select this column. Use this for sensitive fields like password hash. |

## See Also

* **Source:** *[SelectLevel.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/SelectLevel.cs)*