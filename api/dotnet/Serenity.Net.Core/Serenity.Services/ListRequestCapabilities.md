# ListRequestCapabilities enumeration
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Specifies the capabilities of a list request handler.

```csharp
[Flags]
public enum ListRequestCapabilities
```

## Values

| name | value | description |
| --- | --- | --- |
| None | `0x0` | No list operations are handled by the source. |
| ContainsText | `0x1` | The source applies ContainsText. |
| ContainsField | `0x2` | The source applies ContainsField together with ContainsText. |
| EqualityFilter | `0x4` | The source applies EqualityFilter. |
| Criteria | `0x8` | The source applies Criteria. |
| FilteringOptions | `0xF` | Combined text-search, equality-filter, and criteria options. |
| Sort | `0x10` | The source applies sorting. |
| Skip | `0x20` | The source applies Skip. |
| Take | `0x40` | The source applies Take. |
| IncludeDeleted | `0x80` | The source applies IncludeDeleted. |
| ColumnSelection | `0x100` | The source applies ColumnSelection. |
| IncludeColumns | `0x200` | The source applies IncludeColumns. |
| ExcludeColumns | `0x400` | The source applies ExcludeColumns. |
| ColumnOptions | `0x700` | Combined column-selection, include-column, and exclude-column options. |
| DistinctFields | `0x800` | The source applies DistinctFields. |
| ExportColumns | `0x1000` | The source applies ExportColumns. |
| Localize | `0x2000` | The source applies Localize. |
| ExcludeTotalCount | `0x4000` | The source honors ExcludeTotalCount. |
| IncludeMore | `0x8000` | The handler supports the IncludeMore request option. |
| PagingOptions | `0xC060` | Combined paging options, including the IncludeMore option. |
| Aggregates | `0x10000` | The handler calculates Aggregates from all the rows the request matches. |
| GroupBy | `0x20000` | The handler calculates the aggregates of the groups of GroupBy. |
| ExcludeEntities | `0x40000` | The handler honors ExcludeEntities. |
| TimeZone | `0x80000` | The handler groups the dates by the days of the TimeZone of the request. |
| AggregateOptions | `0xF0000` | Combined aggregate, group, entity exclusion and time zone options. Only the entity exclusion is in ListHandler, and all of them are in ProListHandler. |
| SourceAdapter | `0xFC87F` | Capabilities supported by the in-memory list request source adapter by default. |
| Baseline | `0x4FFFF` | Fixed set of baseline capabilities. This value will not be expanded with future capabilities added to `ListRequest` or `ListRequestHandler` implementations. |
| ListHandler | `0x4FFFF` | The capabilities of `ListRequestHandler` itself, without the behaviors of Serenity.Pro.Extensions. Currently equivalent to Baseline. May include capabilities added to it in the future. |
| ProListHandler | `0xFFFFF` | The capabilities of `ListRequestHandler` with the behaviors of Serenity.Pro.Extensions, which are the ones of ListHandler and AggregateOptions. May include capabilities added to them in the future. |
| All | `0xFFFFF` | All the capabilities, which are currently the ones of ProListHandler. May include capabilities added to `ListRequest` and `ListRequestHandler` implementations in the future. |

## See Also

* **Source:** *[ListRequestCapabilities.cs](https://github.com/serenity-is/Serenity/blob/fe192008ef3eb7ca797fe26e985938f11d067e66/src/core/ComponentModel/Services/ListRequestCapabilities.cs)*