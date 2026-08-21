[@serenity-is/corelib](../README.md) / Combobox

# Class: Combobox\<TItem\>

Defined in: [src/ui/editors/combobox.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L92)

A combobox widget that provides searchable selection over a set of items.

## Type Parameters

### TItem

`TItem` = `any`

The item type.

## Constructors

### Constructor

> **new Combobox**\<`TItem`\>(`opt`): `Combobox`\<`TItem`\>

Defined in: [src/ui/editors/combobox.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L105)

Creates a combobox.

#### Parameters

##### opt

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)

Combobox options.

#### Returns

`Combobox`\<`TItem`\>

## Properties

### defaults

> `static` **defaults**: [`ComboboxOptions`](../interfaces/ComboboxOptions.md)

Defined in: [src/ui/editors/combobox.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L96)

Default combobox options.

## Accessors

### container

#### Get Signature

> **get** **container**(): `HTMLElement`

Defined in: [src/ui/editors/combobox.ts:313](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L313)

Returns the combobox container element.

##### Returns

`HTMLElement`

The container element.

***

### isMultiple

#### Get Signature

> **get** **isMultiple**(): `boolean`

Defined in: [src/ui/editors/combobox.ts:337](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L337)

Whether the combobox allows multiple selection.

##### Returns

`boolean`

True when multiple.

***

### type

#### Get Signature

> **get** **type**(): `"select2"`

Defined in: [src/ui/editors/combobox.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L323)

Returns the combobox provider type.

##### Returns

`"select2"`

The provider type, or null.

## Methods

### abortInitSelection()

> **abortInitSelection**(): `void`

Defined in: [src/ui/editors/combobox.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L289)

Aborts any pending initial selection query.

#### Returns

`void`

***

### abortPendingQuery()

> **abortPendingQuery**(): `void`

Defined in: [src/ui/editors/combobox.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L273)

Aborts any pending search query.

#### Returns

`void`

***

### closeDropdown()

> **closeDropdown**(): `void`

Defined in: [src/ui/editors/combobox.ts:480](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L480)

Closes the dropdown.

#### Returns

`void`

***

### dispose()

> **dispose**(): `void`

Defined in: [src/ui/editors/combobox.ts:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L300)

Disposes the combobox and cleans up its resources.

#### Returns

`void`

***

### getSelectedItem()

> **getSelectedItem**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)

Defined in: [src/ui/editors/combobox.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L352)

Returns the first selected item.

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)

The selected item.

***

### getSelectedItems()

> **getSelectedItems**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

Defined in: [src/ui/editors/combobox.ts:366](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L366)

Returns all selected items.

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

The selected items.

***

### getValue()

> **getValue**(): `string`

Defined in: [src/ui/editors/combobox.ts:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L386)

Returns the current value as a comma-separated string.

#### Returns

`string`

The value.

***

### getValues()

> **getValues**(): `string`[]

Defined in: [src/ui/editors/combobox.ts:406](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L406)

Returns the current values as an array.

#### Returns

`string`[]

The values.

***

### openDropdown()

> **openDropdown**(): `void`

Defined in: [src/ui/editors/combobox.ts:487](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L487)

Opens the dropdown.

#### Returns

`void`

***

### setValue()

> **setValue**(`value`, `triggerChange`): `void`

Defined in: [src/ui/editors/combobox.ts:431](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L431)

Sets the current value.

#### Parameters

##### value

`string`

The value to set.

##### triggerChange

`boolean` = `false`

When true, triggers a change event.

#### Returns

`void`

***

### setValues()

> **setValues**(`value`, `triggerChange`): `void`

Defined in: [src/ui/editors/combobox.ts:468](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L468)

Sets the current values.

#### Parameters

##### value

`string`[]

The values to set.

##### triggerChange

`boolean` = `false`

When true, triggers a change event.

#### Returns

`void`

***

### getInstance()

> `static` **getInstance**(`el`): `Combobox`

Defined in: [src/ui/editors/combobox.ts:496](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L496)

Returns the combobox instance attached to an element, or null.

#### Parameters

##### el

The element or collection.

`Element` | `ArrayLike`\<`Element`\>

#### Returns

`Combobox`

The combobox instance, or null.
