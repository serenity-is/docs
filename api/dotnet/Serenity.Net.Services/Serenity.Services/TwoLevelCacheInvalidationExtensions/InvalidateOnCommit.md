# TwoLevelCacheInvalidationExtensions.InvalidateOnCommit method (1 of 3)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Invalidates cached items on commit for specified row type and any related field types specified using TwoLevelCached attributes on the row type.

```csharp
public static void InvalidateOnCommit(this ITwoLevelCache cache, IUnitOfWork uow, IRow row)
```

| parameter | description |
| --- | --- |
| cache | Cache |
| uow | Unit of work |
| row | Row type |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Cache is null |

## See Also

* interface [ITwoLevelCache](../Serenity.Net.Core/../../Serenity.Abstractions/ITwoLevelCache.md)
* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [TwoLevelCacheInvalidationExtensions](../TwoLevelCacheInvalidationExtensions.md)

---

# TwoLevelCacheInvalidationExtensions.InvalidateOnCommit method (2 of 3)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Invalidates cached items related to fields class group key and any related fields types specified using TwoLevelCached attributes on the row type.

```csharp
public static void InvalidateOnCommit(this ITwoLevelCache cache, IUnitOfWork uow, 
    RowFieldsBase fields)
```

| parameter | description |
| --- | --- |
| cache | Cache |
| uow | Unit of work |
| fields | Fields type |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Cache is null |

## See Also

* interface [ITwoLevelCache](../Serenity.Net.Core/../../Serenity.Abstractions/ITwoLevelCache.md)
* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* class [RowFieldsBase](../Serenity.Net.Entity/../../Serenity.Data/RowFieldsBase.md)
* class [TwoLevelCacheInvalidationExtensions](../TwoLevelCacheInvalidationExtensions.md)

---

# TwoLevelCacheInvalidationExtensions.InvalidateOnCommit method (3 of 3)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Invalidates cached items related to a group key when the unit of work commits

```csharp
public static void InvalidateOnCommit(this ITwoLevelCache cache, IUnitOfWork uow, string groupKey)
```

| parameter | description |
| --- | --- |
| cache | Cache |
| uow | Unit of work |
| groupKey | Group key |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | cache is null |

## See Also

* interface [ITwoLevelCache](../Serenity.Net.Core/../../Serenity.Abstractions/ITwoLevelCache.md)
* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* class [TwoLevelCacheInvalidationExtensions](../TwoLevelCacheInvalidationExtensions.md)