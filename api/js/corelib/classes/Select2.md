[corelib](../README.md) / Select2

# Class: Select2

Defined in: [src/ui/editors/select2.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L471)

## Constructors

### Constructor

> **new Select2**(`opts?`): `Select2`

Defined in: [src/ui/editors/select2.ts:475](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L475)

#### Parameters

##### opts?

[`Select2Options`](../interfaces/Select2Options.md)

#### Returns

`Select2`

## Properties

### ajaxDefaults

> `readonly` `static` **ajaxDefaults**: [`Select2AjaxOptions`](../interfaces/Select2AjaxOptions.md)

Defined in: [src/ui/editors/select2.ts:581](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L581)

***

### defaults

> `readonly` `static` **defaults**: [`Select2Options`](../interfaces/Select2Options.md)

Defined in: [src/ui/editors/select2.ts:590](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L590)

## Accessors

### container

#### Get Signature

> **get** **container**(): `HTMLElement`

Defined in: [src/ui/editors/select2.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L507)

##### Returns

`HTMLElement`

***

### data

#### Get Signature

> **get** **data**(): [`Select2Item`](../interfaces/Select2Item.md) \| [`Select2Item`](../interfaces/Select2Item.md)[]

Defined in: [src/ui/editors/select2.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L519)

##### Returns

[`Select2Item`](../interfaces/Select2Item.md) \| [`Select2Item`](../interfaces/Select2Item.md)[]

#### Set Signature

> **set** **data**(`value`): `void`

Defined in: [src/ui/editors/select2.ts:523](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L523)

##### Parameters

###### value

[`Select2Item`](../interfaces/Select2Item.md) | [`Select2Item`](../interfaces/Select2Item.md)[]

##### Returns

`void`

***

### dropdown

#### Get Signature

> **get** **dropdown**(): `HTMLElement`

Defined in: [src/ui/editors/select2.ts:511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L511)

##### Returns

`HTMLElement`

***

### isFocused

#### Get Signature

> **get** **isFocused**(): `boolean`

Defined in: [src/ui/editors/select2.ts:539](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L539)

##### Returns

`boolean`

***

### isMultiple

#### Get Signature

> **get** **isMultiple**(): `boolean`

Defined in: [src/ui/editors/select2.ts:543](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L543)

##### Returns

`boolean`

***

### opened

#### Get Signature

> **get** **opened**(): `boolean`

Defined in: [src/ui/editors/select2.ts:547](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L547)

##### Returns

`boolean`

***

### search

#### Get Signature

> **get** **search**(): `HTMLInputElement`

Defined in: [src/ui/editors/select2.ts:563](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L563)

##### Returns

`HTMLInputElement`

***

### val

#### Get Signature

> **get** **val**(): `string` \| `string`[]

Defined in: [src/ui/editors/select2.ts:567](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L567)

##### Returns

`string` \| `string`[]

#### Set Signature

> **set** **val**(`value`): `void`

Defined in: [src/ui/editors/select2.ts:571](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L571)

##### Parameters

###### value

`string` | `string`[]

##### Returns

`void`

## Methods

### close()

> **close**(): `void`

Defined in: [src/ui/editors/select2.ts:503](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L503)

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/select2.ts:515](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L515)

#### Returns

`void`

***

### disable()

> **disable**(): `void`

Defined in: [src/ui/editors/select2.ts:527](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L527)

#### Returns

`void`

***

### enable()

> **enable**(`enabled?`): `void`

Defined in: [src/ui/editors/select2.ts:531](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L531)

#### Parameters

##### enabled?

`boolean`

#### Returns

`void`

***

### focus()

> **focus**(): `void`

Defined in: [src/ui/editors/select2.ts:535](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L535)

#### Returns

`void`

***

### open()

> **open**(): `boolean`

Defined in: [src/ui/editors/select2.ts:551](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L551)

#### Returns

`boolean`

***

### positionDropdown()

> **positionDropdown**(): `void`

Defined in: [src/ui/editors/select2.ts:555](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L555)

#### Returns

`void`

***

### readonly()

> **readonly**(`value?`): `void`

Defined in: [src/ui/editors/select2.ts:559](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L559)

#### Parameters

##### value?

`boolean`

#### Returns

`void`

***

### getInstance()

> `static` **getInstance**(`el`): `Select2`

Defined in: [src/ui/editors/select2.ts:575](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L575)

#### Parameters

##### el

[`Select2Element`](../type-aliases/Select2Element.md)

#### Returns

`Select2`

***

### stripDiacritics()

> `static` **stripDiacritics**(`str`): `string`

Defined in: [src/ui/editors/select2.ts:652](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L652)

#### Parameters

##### str

`string`

#### Returns

`string`
