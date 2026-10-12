# ISqlErrorExtractor interface
**namespace:** *[Serenity.Services.SqlErrors](../README.md#serenity.services.sqlerrors-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extracts constraint violation information from a database exception. Implementations may be registered as a singleton to customize how primary key, unique, foreign key and not null violations are recognized and described for a specific database provider.

```csharp
public interface ISqlErrorExtractor
```

## Members

| name | description |
| --- | --- |
| [Extract](ISqlErrorExtractor/Extract.md)(…) | Extracts constraint violation information from the given exception, or returns `null` if it is not a recognized constraint violation. |

## See Also

* **Source:** *[ISqlErrorExtractor.cs](https://github.com/serenity-is/Serenity/blob/129785379640a01aa65d383053b7eb95a1f6890d/src/services/RequestHandlers/IntegratedFeatures/SqlErrors/ISqlErrorExtractor.cs)*