[@serenity-is/corelib](../README.md) / Select2

# Class: Select2

## Constructors

### new Select2()

> **new Select2**(`opts`?): [`Select2`](Select2.md)

#### Parameters

##### opts?

[`Select2Options`](../interfaces/Select2Options.md)

#### Returns

[`Select2`](Select2.md)

#### Defined in

[src/ui/editors/select2.ts:482](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L482)

## Properties

### ajaxDefaults

> `readonly` `static` **ajaxDefaults**: [`Select2AjaxOptions`](../interfaces/Select2AjaxOptions.md)

#### Defined in

[src/ui/editors/select2.ts:588](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L588)

***

### defaults

> `readonly` `static` **defaults**: [`Select2Options`](../interfaces/Select2Options.md)

#### Defined in

[src/ui/editors/select2.ts:597](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L597)

## Accessors

### container

#### Get Signature

> **get** **container**(): `HTMLElement`

##### Returns

`HTMLElement`

#### Defined in

[src/ui/editors/select2.ts:514](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L514)

***

### data

#### Get Signature

> **get** **data**(): [`Select2Item`](../interfaces/Select2Item.md) \| [`Select2Item`](../interfaces/Select2Item.md)[]

##### Returns

[`Select2Item`](../interfaces/Select2Item.md) \| [`Select2Item`](../interfaces/Select2Item.md)[]

#### Set Signature

> **set** **data**(`value`): `void`

##### Parameters

###### value

[`Select2Item`](../interfaces/Select2Item.md) | [`Select2Item`](../interfaces/Select2Item.md)[]

##### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:526](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L526)

***

### dropdown

#### Get Signature

> **get** **dropdown**(): `HTMLElement`

##### Returns

`HTMLElement`

#### Defined in

[src/ui/editors/select2.ts:518](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L518)

***

### isFocused

#### Get Signature

> **get** **isFocused**(): `boolean`

##### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:546](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L546)

***

### isMultiple

#### Get Signature

> **get** **isMultiple**(): `boolean`

##### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:550](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L550)

***

### opened

#### Get Signature

> **get** **opened**(): `boolean`

##### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:554](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L554)

***

### search

#### Get Signature

> **get** **search**(): `HTMLInputElement`

##### Returns

`HTMLInputElement`

#### Defined in

[src/ui/editors/select2.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L570)

***

### val

#### Get Signature

> **get** **val**(): `string` \| `string`[]

##### Returns

`string` \| `string`[]

#### Set Signature

> **set** **val**(`value`): `void`

##### Parameters

###### value

`string` | `string`[]

##### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L574)

## Methods

### close()

> **close**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L510)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L522)

***

### disable()

> **disable**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:534](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L534)

***

### enable()

> **enable**(`enabled`?): `void`

#### Parameters

##### enabled?

`boolean`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:538](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L538)

***

### focus()

> **focus**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:542](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L542)

***

### open()

> **open**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:558](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L558)

***

### positionDropdown()

> **positionDropdown**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:562](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L562)

***

### readonly()

> **readonly**(`value`?): `void`

#### Parameters

##### value?

`boolean`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L566)

***

### getInstance()

> `static` **getInstance**(`el`): [`Select2`](Select2.md)

#### Parameters

##### el

[`Select2Element`](../type-aliases/Select2Element.md)

#### Returns

[`Select2`](Select2.md)

#### Defined in

[src/ui/editors/select2.ts:582](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L582)

***

### stripDiacritics()

> `static` **stripDiacritics**(`str`): `string`

#### Parameters

##### str

`string`

#### Returns

`string`

#### Defined in

[src/ui/editors/select2.ts:659](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L659)
