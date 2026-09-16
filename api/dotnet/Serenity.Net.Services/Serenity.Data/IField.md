# IField interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field object abstraction for SQL query.

```csharp
public interface IField
```

## Members

| name | description |
| --- | --- |
| [ColumnAlias](IField/ColumnAlias.md) { get; } | Select as column alias. Can be equal to property name or name. |
| [Expression](IField/Expression.md) { get; } | The expression (can be equal to name if no expression). |
| [Name](IField/Name.md) { get; } | Column name. |

## See Also

* **Source:** *[IField.cs](https://github.com/serenity-is/Serenity/blob/7d4534fc93adbd2968e8fbf317070a0cb6f67b1e/src/services/Data/QueryModel/IField.cs)*