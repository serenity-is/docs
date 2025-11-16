[serenity-is/corelib](../README.md) / Combobox

# Class: Combobox\<TItem\>

Defined in: [src/ui/editors/combobox.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L49)

## Type Parameters

### TItem

`TItem` = `any`

## Constructors

### Constructor

> **new Combobox**\<`TItem`\>(`opt`): `Combobox`\<`TItem`\>

Defined in: [src/ui/editors/combobox.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L57)

#### Parameters

##### opt

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)

#### Returns

`Combobox`\<`TItem`\>

## Properties

### defaults

> `static` **defaults**: [`ComboboxOptions`](../interfaces/ComboboxOptions.md)

Defined in: [src/ui/editors/combobox.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L52)

## Accessors

### container

#### Get Signature

> **get** **container**(): `HTMLElement`

Defined in: [src/ui/editors/combobox.ts:247](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L247)

##### Returns

`HTMLElement`

***

### isMultiple

#### Get Signature

> **get** **isMultiple**(): `boolean`

Defined in: [src/ui/editors/combobox.ts:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L263)

##### Returns

`boolean`

***

### type

#### Get Signature

> **get** **type**(): `"select2"`

Defined in: [src/ui/editors/combobox.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L253)

##### Returns

`"select2"`

## Methods

### abortInitSelection()

> **abortInitSelection**(): `void`

Defined in: [src/ui/editors/combobox.ts:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L230)

#### Returns

`void`

***

### abortPendingQuery()

> **abortPendingQuery**(): `void`

Defined in: [src/ui/editors/combobox.ts:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L217)

#### Returns

`void`

***

### closeDropdown()

> **closeDropdown**(): `void`

Defined in: [src/ui/editors/combobox.ts:377](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L377)

#### Returns

`void`

***

### dispose()

> **dispose**(): `void`

Defined in: [src/ui/editors/combobox.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L238)

#### Returns

`void`

***

### getSelectedItem()

> **getSelectedItem**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)

Defined in: [src/ui/editors/combobox.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L274)

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)

***

### getSelectedItems()

> **getSelectedItems**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

Defined in: [src/ui/editors/combobox.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L284)

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

***

### getValue()

> **getValue**(): `string`

Defined in: [src/ui/editors/combobox.ts:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L300)

#### Returns

`string`

***

### getValues()

> **getValues**(): `string`[]

Defined in: [src/ui/editors/combobox.ts:316](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L316)

#### Returns

`string`[]

***

### openDropdown()

> **openDropdown**(): `void`

Defined in: [src/ui/editors/combobox.ts:381](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L381)

#### Returns

`void`

***

### setValue()

> **setValue**(`value`, `triggerChange`): `void`

Defined in: [src/ui/editors/combobox.ts:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L336)

#### Parameters

##### value

`string`

##### triggerChange

`boolean` = `false`

#### Returns

`void`

***

### setValues()

> **setValues**(`value`, `triggerChange`): `void`

Defined in: [src/ui/editors/combobox.ts:368](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L368)

#### Parameters

##### value

`string`[]

##### triggerChange

`boolean` = `false`

#### Returns

`void`

***

### getInstance()

> `static` **getInstance**(`el`): `Combobox`

Defined in: [src/ui/editors/combobox.ts:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L385)

#### Parameters

##### el

`Element` | `ArrayLike`\<`Element`\>

#### Returns

`Combobox`
