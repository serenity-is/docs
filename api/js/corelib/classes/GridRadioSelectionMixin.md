[@serenity-is/corelib](../README.md) / GridRadioSelectionMixin

# Class: GridRadioSelectionMixin

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L19)

A mixin that adds single (radio) row selection behavior to a data grid.

## Constructors

### Constructor

> **new GridRadioSelectionMixin**(`grid`, `options?`): `GridRadioSelectionMixin`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L33)

Creates a new GridRadioSelectionMixin for the given grid.

#### Parameters

##### grid

[`IDataGrid`](../interfaces/IDataGrid.md)

The data grid to attach the mixin to.

##### options?

[`GridRadioSelectionMixinOptions`](../interfaces/GridRadioSelectionMixinOptions.md)

Optional mixin options.

#### Returns

`GridRadioSelectionMixin`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L21)

## Methods

### clear()

> **clear**(): `void`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L72)

Clears the current selection.

#### Returns

`void`

***

### getSelectedAsInt32()

> **getSelectedAsInt32**(): `number`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L101)

Returns the selected key parsed as a 32-bit integer, or null if none is selected.

#### Returns

`number`

The selected key as an int32, or null.

***

### getSelectedAsInt64()

> **getSelectedAsInt64**(): `number`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L117)

Returns the selected key parsed as a 64-bit integer, or null if none is selected.

#### Returns

`number`

The selected key as an int64, or null.

***

### getSelectedKey()

> **getSelectedKey**(): `string`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L88)

Returns the key of the currently selected item, or null if none is selected.

#### Returns

`string`

The selected key, or null.

***

### resetCheckedAndRefresh()

> **resetCheckedAndRefresh**(): `void`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L79)

Clears the current selection and refreshes the grid view.

#### Returns

`void`

***

### setSelectedKey()

> **setSelectedKey**(`key`): `void`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L133)

Selects the item with the given key, clearing any previous selection.

#### Parameters

##### key

`string`

The key of the item to select.

#### Returns

`void`

***

### createSelectColumn()

> `static` **createSelectColumn**(`getMixin`, `columnOptions?`): `Column`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L144)

Creates a radio select column for the grid.

#### Parameters

##### getMixin

() => `GridRadioSelectionMixin`

A function that returns the mixin instance.

##### columnOptions?

`Partial`\<`Column`\>

Optional column options to merge into the select column.

#### Returns

`Column`

The select column definition.
