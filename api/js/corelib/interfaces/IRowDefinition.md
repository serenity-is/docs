[@serenity-is/corelib](../README.md) / IRowDefinition

# Interface: IRowDefinition

Defined in: [src/ui/datagrid/irowdefinition.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L6)

Metadata that describes a row type for grid and dialog integration.
Implementations are resolved from the row type registry and used for
permissions, identity and display name resolution.

## Properties

### concurrencyVersionProperty?

> `readonly` `optional` **concurrencyVersionProperty**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L8)

Name of the property that holds the optimistic concurrency version, if any.

***

### deletePermission?

> `readonly` `optional` **deletePermission**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L10)

Permission required to delete rows.

***

### idProperty?

> `readonly` `optional` **idProperty**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L12)

Name of the identity / primary key property.

***

### insertPermission?

> `readonly` `optional` **insertPermission**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L14)

Permission required to insert rows.

***

### isActiveProperty?

> `readonly` `optional` **isActiveProperty**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L16)

Name of the boolean property that marks a row as active.

***

### isDeletedProperty?

> `readonly` `optional` **isDeletedProperty**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L18)

Name of the boolean property that marks a row as soft-deleted.

***

### localTextPrefix?

> `readonly` `optional` **localTextPrefix**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L20)

Local text prefix for entity texts (display names, dialogs).

***

### nameProperty?

> `readonly` `optional` **nameProperty**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L22)

Name of the property used as the display / name field.

***

### readPermission?

> `readonly` `optional` **readPermission**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L24)

Permission required to read rows.

***

### undeletePermission?

> `readonly` `optional` **undeletePermission**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L26)

Permission required to undelete rows.

***

### updatePermission?

> `readonly` `optional` **updatePermission**: `string`

Defined in: [src/ui/datagrid/irowdefinition.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/irowdefinition.ts#L28)

Permission required to update rows.
