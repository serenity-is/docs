# SqlQuery.FullTextSearchJoin method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

MSSQL'de full text araması için gerekli join'i oluşturur.

```csharp
public SqlQuery FullTextSearchJoin(string searchTable, string searchFields, string searchQuery, 
    string searchTableAlias, string searchTableKey, string containsAlias)
```

| parameter | description |
| --- | --- |
| searchTable | Arama yapılacak alanları içeren tablo adı (zorunlu). |
| searchFields | Arama yapılacak alanlar (zorunlu). |
| searchQuery | Aranan kelime, ya da kelime grubu (zorunlu). Kelimeler virgülle ayrılmalı. |
| searchTableAlias | Arama yapılacak tabloya, sorgunun FROM kısmında atanmış olan alias (zorunlu, ör. T0). |
| searchTableKey | Arama yapılacak tablonun anahtar (ID) sahası (zorunlu). |
| containsAlias | Bağlama yapılan contains table'a atanacak alias (zorunlu, ör. CT). |

## Return Value

SqlSelect nesnesinin kendisi.

## See Also

* class [SqlQuery](../SqlQuery.md)