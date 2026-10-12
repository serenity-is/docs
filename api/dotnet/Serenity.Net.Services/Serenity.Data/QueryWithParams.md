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
| [HasAutoParams](QueryWithParams/HasAutoParams.md) { get; } | Gets a value indicating whether any automatically named parameters were generated for this query or one of the queries sharing its parameter storage. Derived from the auto param counter, so no separate tracking state is needed. Note that this may still return false before the query is rendered (e.g. via ToString()), as auto parameters only materialize at render time. |
| [IsDialectOverridden](QueryWithParams/IsDialectOverridden.md) { get; } | Gets a value indicating whether the dialect is overridden. |
| [IsFrozen](QueryWithParams/IsFrozen.md) { get; } | Gets a value indicating whether this query or one of its parents has been frozen. |
| [IsParamsFrozen](QueryWithParams/IsParamsFrozen.md) { get; } | Gets a value indicating whether parameters have been frozen. |
| [ParamCount](QueryWithParams/ParamCount.md) { get; } | Gets the parameter count. |
| [Params](QueryWithParams/Params.md) { get; } | Gets the parameters. |
| [Parent](QueryWithParams/Parent.md) { get; } | Gets access to parent query if any. |
| [AddParam](QueryWithParams/AddParam.md)(…) | Adds the parameter. |
| [AutoParam](QueryWithParams/AutoParam.md)() | Creates an automatically named parameter. |
| [CreateSubQuery&lt;TQuery&gt;](QueryWithParams/CreateSubQuery.md)() | Creates a new query that shares parameter storage and dialect with this query tree. |
| [Dialect](QueryWithParams/Dialect.md)() | Gets the dialect (SQL server type / version) for query. |
| [HasAlias](QueryWithParams/HasAlias.md)(…) | Gets a value indicating whether this query tree has an alias registered. |
| [SetParam](QueryWithParams/SetParam.md)(…) | Sets the parameter. |

## Protected Members

| name | description |
| --- | --- |
| [cachedToString](QueryWithParams/cachedToString.md) | The cached SQL string and the dialect it was formatted with. |
| [dialect](QueryWithParams/dialect.md) | The dialect. |
| [dialectOverridden](QueryWithParams/dialectOverridden.md) | Is the dialect overridden. |
| [nextAutoParam](QueryWithParams/nextAutoParam.md) | The next auto param counter. |
| [parameters](QueryWithParams/parameters.md) | The parameters. |
| [parent](QueryWithParams/parent.md) | The parent query with param storage. |
| [BeforeModify](QueryWithParams/BeforeModify.md)() | Invalidates this query's cached SQL and that of its parent query. |
| [CloneAliasExpressionsTo](QueryWithParams/CloneAliasExpressionsTo.md)(…) | Copies this query's local alias expressions to another query. |
| [CloneParams](QueryWithParams/CloneParams.md)(…) | Clones the parameters into a target query. |
| [GetAliasExpression](QueryWithParams/GetAliasExpression.md)(…) | Gets the source expression registered for an alias. |
| [GetCachedToString](QueryWithParams/GetCachedToString.md)(…) | Gets the cached SQL string, regenerating it when this query tree's dialect changes. |
| [ResetAliasExpressions](QueryWithParams/ResetAliasExpressions.md)(…) | Clears the alias expressions registered in this query. If *localOnly* is false, clears the alias expressions in the root query. |
| [SetAliasExpression](QueryWithParams/SetAliasExpression.md)(…) | Sets the source expression for an alias. |
| [SetDialect](QueryWithParams/SetDialect.md)(…) | Sets the dialect for this query tree, propagating the change to its root. |

## See Also

* interface [IQueryWithParams](./IQueryWithParams.md)
* **Source:** *[QueryWithParams.cs](https://github.com/serenity-is/Serenity/blob/abc2c8d4a2aa2be4c3652541931f850f86324a47/src/services/Data/QueryModel/QueryWithParams.cs)*