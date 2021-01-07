# IField interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Field object abstraction for SQL query

```csharp
public interface IField
```

## Members

| name | description |
| --- | --- |
| [ColumnAlias](IField/ColumnAlias.md) { get; } | Select as column alias. Can be equal to property name or name. |
| [Expression](IField/Expression.md) { get; } | The expression (can be equal to name if no expression) |
| [Name](IField/Name.md) { get; } | Column name |

## See Also

* **Source:** *[IField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/QueryModel/IField.cs)*