# QueryWithParams class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for queries with params like SqlQuery, SqlUpdate, SqlInsert.

```csharp
public class QueryWithParams : IQueryWithParams
```

## Public Members

| name | description |
| --- | --- |
| [QueryWithParams](QueryWithParams/QueryWithParams.md)() | Initializes a new instance of the [`QueryWithParams`](./QueryWithParams.md) class. |
| [DebugText](QueryWithParams/DebugText.md) { get; } | Gets the debug text. |
| [IsDialectOverridden](QueryWithParams/IsDialectOverridden.md) { get; } | Gets a value indicating whether the dialect is overridden. |
| [ParamCount](QueryWithParams/ParamCount.md) { get; } | Gets the parameter count. |
| [Params](QueryWithParams/Params.md) { get; } | Gets the parameters. |
| [AddParam](QueryWithParams/AddParam.md)(…) | Adds the parameter. |
| [AutoParam](QueryWithParams/AutoParam.md)() | Creates an automatically named parameter. |
| [CreateSubQuery&lt;TQuery&gt;](QueryWithParams/CreateSubQuery.md)() | Creates a new query that shares parameter dictionary with this query. |
| [Dialect](QueryWithParams/Dialect.md)() | Gets the dialect (SQL server type / version) for query. |
| [HasAlias](QueryWithParams/HasAlias.md)(…) | Gets a value indicating whether this query tree has an alias registered. |
| [SetParam](QueryWithParams/SetParam.md)(…) | Sets the parameter. |

## Protected Members

| name | description |
| --- | --- |
| [dialect](QueryWithParams/dialect.md) | The dialect. |
| [dialectOverridden](QueryWithParams/dialectOverridden.md) | Is the dialect overridden. |
| [nextAutoParam](QueryWithParams/nextAutoParam.md) | The next auto param counter. |
| [parameters](QueryWithParams/parameters.md) | The parameters. |
| [parent](QueryWithParams/parent.md) | The parent query with param storage. |
| [CloneAliasExpressionsTo](QueryWithParams/CloneAliasExpressionsTo.md)(…) | Copies this query's local alias expressions to another query. |
| [CloneParams](QueryWithParams/CloneParams.md)(…) | Clones the parameters into a target query. |
| [GetAliasExpression](QueryWithParams/GetAliasExpression.md)(…) | Gets the source expression registered for an alias. |
| [ResetAliasExpressions](QueryWithParams/ResetAliasExpressions.md)(…) | Clears the alias expressions registered in this query. If *localOnly* is false, clears the alias expressions in the root query. |
| [SetAliasExpression](QueryWithParams/SetAliasExpression.md)(…) | Sets the source expression for an alias. |

## See Also

* interface [IQueryWithParams](./IQueryWithParams.md)
* **Source:** *[QueryWithParams.cs](https://github.com/serenity-is/Serenity/blob/1547fabf1541054fe943b6a29c0d181fd84080e0/src/services/Data/QueryModel/QueryWithParams.cs)*