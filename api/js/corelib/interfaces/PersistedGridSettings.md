[@serenity-is/corelib](../README.md) / PersistedGridSettings

# Interface: PersistedGridSettings

Defined in: [src/ui/datagrid/datagrid-persistence.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L52)

Snapshot of grid state that can be persisted and later restored.

## Properties

### columns?

> `optional` **columns**: [`PersistedGridColumn`](PersistedGridColumn.md)[]

Defined in: [src/ui/datagrid/datagrid-persistence.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L56)

Column state (order, width, visibility, pinning, sort).

***

### filterItems?

> `optional` **filterItems**: [`FilterLine`](FilterLine.md)[]

Defined in: [src/ui/datagrid/datagrid-persistence.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L58)

Advanced filter panel items.

***

### flags?

> `optional` **flags**: [`GridPersistenceFlags`](GridPersistenceFlags.md)

Defined in: [src/ui/datagrid/datagrid-persistence.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L54)

Flags that indicate which parts of the settings were persisted.

***

### includeDeleted?

> `optional` **includeDeleted**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L68)

Whether the include-deleted toggle was pressed.

***

### quickFilters?

> `optional` **quickFilters**: `object`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L60)

Quick filter widget states keyed by field name.

#### Index Signature

\[`key`: `string`\]: `any`

***

### quickFilterText?

> `optional` **quickFilterText**: `string`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L62)

Concatenated display text for active quick filters.

***

### quickSearchField?

> `optional` **quickSearchField**: [`QuickSearchField`](QuickSearchField.md)

Defined in: [src/ui/datagrid/datagrid-persistence.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L64)

Field selected in the quick search input.

***

### quickSearchText?

> `optional` **quickSearchText**: `string`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L66)

Text entered in the quick search input.
