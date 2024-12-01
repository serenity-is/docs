[@serenity-is/corelib](../README.md) / Combobox

# Class: Combobox\<TItem\>

## Type Parameters

• **TItem** = `any`

## Constructors

### new Combobox()

> **new Combobox**\<`TItem`\>(`opt`): [`Combobox`](Combobox.md)\<`TItem`\>

#### Parameters

##### opt

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Returns

[`Combobox`](Combobox.md)\<`TItem`\>

#### Defined in

[src/ui/editors/combobox.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L57)

## Properties

### defaults

> `static` **defaults**: [`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Defined in

[src/ui/editors/combobox.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L52)

## Accessors

### container

#### Get Signature

> **get** **container**(): `HTMLElement`

##### Returns

`HTMLElement`

#### Defined in

[src/ui/editors/combobox.ts:247](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L247)

***

### isMultiple

#### Get Signature

> **get** **isMultiple**(): `boolean`

##### Returns

`boolean`

#### Defined in

[src/ui/editors/combobox.ts:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L263)

***

### type

#### Get Signature

> **get** **type**(): `"select2"`

##### Returns

`"select2"`

#### Defined in

[src/ui/editors/combobox.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L253)

## Methods

### abortInitSelection()

> **abortInitSelection**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L230)

***

### abortPendingQuery()

> **abortPendingQuery**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L217)

***

### closeDropdown()

> **closeDropdown**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:377](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L377)

***

### dispose()

> **dispose**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L238)

***

### getSelectedItem()

> **getSelectedItem**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Defined in

[src/ui/editors/combobox.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L274)

***

### getSelectedItems()

> **getSelectedItems**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Defined in

[src/ui/editors/combobox.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L284)

***

### getValue()

> **getValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/combobox.ts:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L300)

***

### getValues()

> **getValues**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/editors/combobox.ts:316](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L316)

***

### openDropdown()

> **openDropdown**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:381](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L381)

***

### setValue()

> **setValue**(`value`, `triggerChange`): `void`

#### Parameters

##### value

`string`

##### triggerChange

`boolean` = `false`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L336)

***

### setValues()

> **setValues**(`value`, `triggerChange`): `void`

#### Parameters

##### value

`string`[]

##### triggerChange

`boolean` = `false`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:368](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L368)

***

### getInstance()

> `static` **getInstance**(`el`): [`Combobox`](Combobox.md)\<`any`\>

#### Parameters

##### el

`Element` | `ArrayLike`\<`Element`\>

#### Returns

[`Combobox`](Combobox.md)\<`any`\>

#### Defined in

[src/ui/editors/combobox.ts:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L385)
