# ISqlOperationInterceptor interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An interface that makes it possible to intercept basic SQL operations on connections (e.g. SqlHelper extensions) mostly for testing purposes. Note that this does not intercept all SQL operations, only the ones that are done through SqlHelper extensions. It does not intercept Dapper operations, for example. This interface should be implemented by the mock connection class used in tests.

```csharp
public interface ISqlOperationInterceptor
```

## Members

| name | description |
| --- | --- |
| [ExecuteNonQuery](ISqlOperationInterceptor/ExecuteNonQuery.md)(…) | Intercepts the [`SqlHelper`](./SqlHelper.md)`Execute` method (SqlDelete/SqlUpdate/SqlInsert). |
| [ExecuteNonQueryAsync](ISqlOperationInterceptor/ExecuteNonQueryAsync.md)(…) | Intercepts the async [`SqlHelper`](./SqlHelper.md)`Execute` methods (SqlDelete/SqlUpdate/SqlInsert). The default implementation forwards to [`ExecuteNonQuery`](./ISqlOperationInterceptor/ExecuteNonQuery.md). |
| [ExecuteReader](ISqlOperationInterceptor/ExecuteReader.md)(…) | Intercepts the [`SqlHelper`](./SqlHelper.md)`ExecuteReader` method. |
| [ExecuteReaderAsync](ISqlOperationInterceptor/ExecuteReaderAsync.md)(…) | Intercepts the async [`SqlHelper`](./SqlHelper.md)`ExecuteReader` methods. The default implementation forwards to [`ExecuteReader`](./ISqlOperationInterceptor/ExecuteReader.md). |
| [ExecuteScalar](ISqlOperationInterceptor/ExecuteScalar.md)(…) | Intercepts the [`SqlHelper`](./SqlHelper.md)`ExecuteScalar` method. |
| [ExecuteScalarAsync](ISqlOperationInterceptor/ExecuteScalarAsync.md)(…) | Intercepts the async [`SqlHelper`](./SqlHelper.md)`ExecuteScalar` methods. The default implementation forwards to [`ExecuteScalar`](./ISqlOperationInterceptor/ExecuteScalar.md). |

## See Also

* **Source:** *[ISqlOperationInterceptor.cs](https://github.com/serenity-is/Serenity/blob/73168d59056410d43d88aeecc9e4fe750d71793a/src/services/Data/SqlHelpers/ISqlOperationInterceptor.cs)*