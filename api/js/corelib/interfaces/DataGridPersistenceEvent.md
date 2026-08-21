[@serenity-is/corelib](../README.md) / DataGridPersistenceEvent

# Interface: DataGridPersistenceEvent

Defined in: [src/ui/datagrid/datagrid-persistence.ts:399](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L399)

Event arguments for grid persistence hooks (before/after persist and restore).

## Extends

- [`DataGridEvent`](DataGridEvent.md)

## Properties

### after

> **after**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:401](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L401)

Whether this is the after phase of the operation.

***

### dataGrid

> **dataGrid**: [`DataGrid`](../classes/DataGrid.md)\<`any`\>

Defined in: [src/ui/datagrid/datagrid.tsx:1862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid.tsx#L1862)

The data grid that raised the event.

#### Inherited from

[`DataGridEvent`](DataGridEvent.md).[`dataGrid`](DataGridEvent.md#datagrid)

***

### flagsArgument

> **flagsArgument**: [`GridPersistenceFlags`](GridPersistenceFlags.md)

Defined in: [src/ui/datagrid/datagrid-persistence.ts:403](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L403)

Flags passed by the caller.

***

### flagsDefault

> **flagsDefault**: [`GridPersistenceFlags`](GridPersistenceFlags.md)

Defined in: [src/ui/datagrid/datagrid-persistence.ts:405](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L405)

Default flags for the grid type.

***

### flagsToUse

> **flagsToUse**: [`GridPersistenceFlags`](GridPersistenceFlags.md)

Defined in: [src/ui/datagrid/datagrid-persistence.ts:407](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L407)

Effective flags after merging argument and defaults.

***

### persisting

> `readonly` **persisting**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:413](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L413)

True while the grid is persisting settings.

***

### restoring

> `readonly` **restoring**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:411](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L411)

True while the grid is restoring settings.

***

### settings

> **settings**: [`PersistedGridSettings`](PersistedGridSettings.md)

Defined in: [src/ui/datagrid/datagrid-persistence.ts:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L409)

Settings being persisted or restored.
