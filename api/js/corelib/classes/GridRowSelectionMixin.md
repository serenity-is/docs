[@serenity-is/corelib](../README.md) / GridRowSelectionMixin

# Class: GridRowSelectionMixin

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L22)

A mixin that adds multi (checkbox) row selection behavior to a data grid,
including a select-all header checkbox.

## Constructors

### Constructor

> **new GridRowSelectionMixin**(`grid`, `options?`): `GridRowSelectionMixin`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L36)

Creates a new GridRowSelectionMixin for the given grid.

#### Parameters

##### grid

[`IDataGrid`](../interfaces/IDataGrid.md)

The data grid to attach the mixin to.

##### options?

[`GridRowSelectionMixinOptions`](../interfaces/GridRowSelectionMixinOptions.md)

Optional mixin options.

#### Returns

`GridRowSelectionMixin`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L24)

## Methods

### clear()

> **clear**(): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L128)

Clears the current selection.

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L51)

Detaches the mixin from the grid and cleans up event subscriptions.

#### Returns

`void`

***

### getSelectedAsInt32()

> **getSelectedAsInt32**(): `number`[]

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L166)

Returns the selected keys parsed as 32-bit integers.

#### Returns

`number`[]

The selected keys as int32 values.

***

### getSelectedAsInt64()

> **getSelectedAsInt64**(): `number`[]

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L176)

Returns the selected keys parsed as 64-bit integers.

#### Returns

`number`[]

The selected keys as int64 values.

***

### getSelectedKeys()

> **getSelectedKeys**(): `string`[]

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L158)

Returns the keys of the currently selected items.

#### Returns

`string`[]

The selected keys.

***

### resetCheckedAndRefresh()

> **resetCheckedAndRefresh**(): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L136)

Clears the current selection and refreshes the grid view.

#### Returns

`void`

***

### selectKeys()

> **selectKeys**(`keys`): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L146)

Selects the items with the given keys, keeping any existing selection.

#### Parameters

##### keys

`string`[]

The keys of the items to select.

#### Returns

`void`

***

### setSelectedKeys()

> **setSelectedKeys**(`keys`): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L186)

Replaces the current selection with the items having the given keys.

#### Parameters

##### keys

`string`[]

The keys of the items to select.

#### Returns

`void`

***

### updateSelectAll()

> **updateSelectAll**(): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L112)

Updates the checked state of the select-all header button based on the
current selection.

#### Returns

`void`

***

### createSelectColumn()

> `static` **createSelectColumn**(`getMixin`, `columnOptions?`): `Column`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L207)

Creates a checkbox select column for the grid, including a select-all header.

#### Parameters

##### getMixin

() => `GridRowSelectionMixin`

A function that returns the mixin instance.

##### columnOptions?

`Partial`\<`Column`\>

Optional column options to merge into the select column.

#### Returns

`Column`

The select column definition.
