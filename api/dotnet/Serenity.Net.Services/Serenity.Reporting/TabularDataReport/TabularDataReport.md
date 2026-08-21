# TabularDataReport constructor (1 of 4)
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Initializes a new instance of the class.

```csharp
protected TabularDataReport()
```

## See Also

* class [TabularDataReport](../TabularDataReport.md)

---

# TabularDataReport constructor (2 of 4)
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Initializes a new instance of the class with the given data and report columns.

```csharp
public TabularDataReport(IEnumerable data, IEnumerable<ReportColumn> columns)
```

| parameter | description |
| --- | --- |
| data | The data objects |
| columns | List of report columns |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *data* or *columns* is `null`. |

## See Also

* class [ReportColumn](../ReportColumn.md)
* class [TabularDataReport](../TabularDataReport.md)

---

# TabularDataReport constructor (3 of 4)
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Initializes a new instance of the class with the given data and columns type.

```csharp
public TabularDataReport(IEnumerable data, Type columnsType, IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| data | The data objects |
| columnsType | The columns type |
| serviceProvider | Service provider that will be used to extract PropertyItems from the columns type |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *data*, *columnsType* or *serviceProvider* is `null`. |

## See Also

* class [TabularDataReport](../TabularDataReport.md)

---

# TabularDataReport constructor (4 of 4)
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Initializes a new instance of the class with the given data, columns type and export columns.

```csharp
public TabularDataReport(IEnumerable data, Type columnsType, IEnumerable<string> exportColumns, 
    IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| data | The data objects |
| columnsType | The columns type |
| exportColumns | The list of column property names to export |
| serviceProvider | Service provider that will be used to extract PropertyItems from the columns type |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *data*, *columnsType*, *exportColumns* or *serviceProvider* is `null`. |

## See Also

* class [TabularDataReport](../TabularDataReport.md)