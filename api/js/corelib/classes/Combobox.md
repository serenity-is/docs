[@serenity-is/corelib](../README.md) / Combobox

# Class: Combobox\<TItem\>

Defined in: [src/ui/editors/combobox.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L103)

A combobox widget that provides searchable selection over a set of items.

## Type Parameters

### TItem

`TItem` = `any`

The item type.

## Constructors

### Constructor

> **new Combobox**\<`TItem`\>(`opt`): `Combobox`\<`TItem`\>

Defined in: [src/ui/editors/combobox.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L116)

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

Defined in: [src/ui/editors/combobox.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L107)

Default combobox options.

## Accessors

### container

#### Get Signature

> **get** **container**(): `HTMLElement`

Defined in: [src/ui/editors/combobox.ts:429](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L429)

Returns the combobox container element.

##### Returns

`HTMLElement`

The container element.

***

### isMultiple

#### Get Signature

> **get** **isMultiple**(): `boolean`

Defined in: [src/ui/editors/combobox.ts:453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L453)

Whether the combobox allows multiple selection.

##### Returns

`boolean`

True when multiple.

***

### selectionLoadState

#### Get Signature

> **get** **selectionLoadState**(): `"error"` \| `"loading"` \| `"idle"`

Defined in: [src/ui/editors/combobox.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L143)

Returns the current state of the initial selection load.
"idle" means there is no pending or failed load. It does not guarantee
that an item is currently selected.

##### Returns

`"error"` \| `"loading"` \| `"idle"`

***

### type

#### Get Signature

> **get** **type**(): `"select2"`

Defined in: [src/ui/editors/combobox.ts:439](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L439)

Returns the combobox provider type.

##### Returns

`"select2"`

The provider type, or null.

## Methods

### abortInitSelection()

> **abortInitSelection**(): `void`

Defined in: [src/ui/editors/combobox.ts:390](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L390)

Aborts any pending initial selection query.

#### Returns

`void`

***

### abortPendingQuery()

> **abortPendingQuery**(): `void`

Defined in: [src/ui/editors/combobox.ts:364](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L364)

Aborts any pending search query.

#### Returns

`void`

***

### closeDropdown()

> **closeDropdown**(): `void`

Defined in: [src/ui/editors/combobox.ts:602](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L602)

Closes the dropdown.

#### Returns

`void`

***

### dispose()

> **dispose**(): `void`

Defined in: [src/ui/editors/combobox.ts:415](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L415)

Disposes the combobox and cleans up its resources.

#### Returns

`void`

***

### ensureSelectionLoaded()

> **ensureSelectionLoaded**(): `Promise`\<`void`\>

Defined in: [src/ui/editors/combobox.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L159)

Waits for the initial selection to load, if necessary.

#### Returns

`Promise`\<`void`\>

A promise that resolves when the selection is loaded or rejects
if loading fails or is aborted. It resolves immediately when there is no
pending load.

***

### getSelectedItem()

> **getSelectedItem**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)

Defined in: [src/ui/editors/combobox.ts:468](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L468)

Returns the first selected item.

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)

The selected item.

***

### getSelectedItems()

> **getSelectedItems**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

Defined in: [src/ui/editors/combobox.ts:482](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L482)

Returns all selected items.

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

The selected items.

***

### getValue()

> **getValue**(): `string`

Defined in: [src/ui/editors/combobox.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L502)

Returns the current value as a comma-separated string.

#### Returns

`string`

The value.

***

### getValues()

> **getValues**(): `string`[]

Defined in: [src/ui/editors/combobox.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L522)

Returns the current values as an array.

#### Returns

`string`[]

The values.

***

### openDropdown()

> **openDropdown**(): `void`

Defined in: [src/ui/editors/combobox.ts:609](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L609)

Opens the dropdown.

#### Returns

`void`

***

### setValue()

> **setValue**(`value`, `triggerChange`): `void`

Defined in: [src/ui/editors/combobox.ts:547](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L547)

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

Defined in: [src/ui/editors/combobox.ts:590](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L590)

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

Defined in: [src/ui/editors/combobox.ts:618](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L618)

Returns the combobox instance attached to an element, or null.

#### Parameters

##### el

The element or collection.

`Element` | `ArrayLike`\<`Element`\>

#### Returns

`Combobox`

The combobox instance, or null.
