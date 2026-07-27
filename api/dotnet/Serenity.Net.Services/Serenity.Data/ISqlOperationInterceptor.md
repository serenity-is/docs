# ISqlOperationInterceptor interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An interface that makes it possible to intercept basic SQL operations on connections (e.g. SqlHelper extensions) mostly for testing purposes. Note that this does not intercept all SQL operations, only the ones that are done through SqlHelper extensions. It does not intercept Dapper operations, for example. This interface should be implemented by the mock connection class used in tests.

```csharp
public interface ISqlOperationInterceptor
```

## Members

| name | description |
| --- | --- |
| [ExecuteNonQuery](ISqlOperationInterceptor/ExecuteNonQuery.md)(…) | Intercepts SqlHelper.Execute(SqlDelete/SqlUpdate/SqlInsert) method. Command textParametersThe query.Expected rowsTrue if InsertAndGetID is called |
| [ExecuteReader](ISqlOperationInterceptor/ExecuteReader.md)(…) | Intercepts SqlHelper.ExecuteReader method. |
| [ExecuteScalar](ISqlOperationInterceptor/ExecuteScalar.md)(…) | Intercepts SqlHelper.ExecuteReader method. |

## See Also

* **Source:** *[ISqlOperationInterceptor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/SqlHelpers/ISqlOperationInterceptor.cs)*