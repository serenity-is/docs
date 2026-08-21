[@serenity-is/corelib](../README.md) / PersistedGridColumn

# Interface: PersistedGridColumn

Defined in: [src/ui/datagrid/datagrid-persistence.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L36)

Persisted state for a single grid column.

## Properties

### id

> **id**: `string`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L38)

Column identifier (matches Column.id).

***

### pin?

> `optional` **pin**: `false` \| `"start"` \| `"end"`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L46)

Frozen / pinned state of the column.

***

### sort?

> `optional` **sort**: `number`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L42)

Sort order and direction; positive for ascending, negative for descending.

***

### visible?

> `optional` **visible**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L44)

Whether the column is visible.

***

### width?

> `optional` **width**: `number`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L40)

Persisted width in pixels.
