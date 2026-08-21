[@serenity-is/corelib](../README.md) / FilterStore

# Class: FilterStore

Defined in: [src/ui/filtering/filterstore.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L7)

Stores filter lines for a grid and builds criteria and display text from them.

## Constructors

### Constructor

> **new FilterStore**(`fields`): `FilterStore`

Defined in: [src/ui/filtering/filterstore.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L14)

Creates a filter store.

#### Parameters

##### fields

[`PropertyItem`](../interfaces/PropertyItem.md)[]

The filterable fields.

#### Returns

`FilterStore`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/filterstore.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L8)

## Methods

### add\_changed()

> **add\_changed**(`listener`): `void`

Defined in: [src/ui/filtering/filterstore.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L187)

Subscribes a listener to store changes.

#### Parameters

##### listener

(`store`) => `void`

The listener.

#### Returns

`void`

***

### get\_activeCriteria()

> **get\_activeCriteria**(): `any`[]

Defined in: [src/ui/filtering/filterstore.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L203)

Returns the active criteria for the current filter lines.

#### Returns

`any`[]

The criteria expression.

***

### get\_displayText()

> **get\_displayText**(): `string`

Defined in: [src/ui/filtering/filterstore.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L211)

Returns the display text for the current filter lines.

#### Returns

`string`

The display text.

***

### get\_fieldByName()

> **get\_fieldByName**(): `object`

Defined in: [src/ui/filtering/filterstore.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L163)

Returns the fields by name.

#### Returns

`object`

The field map.

***

### get\_fields()

> **get\_fields**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/filtering/filterstore.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L155)

Returns the filterable fields.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

The fields.

***

### get\_items()

> **get\_items**(): [`FilterLine`](../interfaces/FilterLine.md)[]

Defined in: [src/ui/filtering/filterstore.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L171)

Returns the filter lines.

#### Returns

[`FilterLine`](../interfaces/FilterLine.md)[]

The filter lines.

***

### raiseChanged()

> **raiseChanged**(): `void`

Defined in: [src/ui/filtering/filterstore.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L178)

Notifies listeners that the store changed.

#### Returns

`void`

***

### remove\_changed()

> **remove\_changed**(`listener`): `void`

Defined in: [src/ui/filtering/filterstore.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L195)

Unsubscribes a listener from store changes.

#### Parameters

##### listener

(`store`) => `void`

The listener.

#### Returns

`void`

***

### getCriteriaFor()

> `static` **getCriteriaFor**(`items`): `any`[]

Defined in: [src/ui/filtering/filterstore.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L53)

Builds a criteria expression from a list of filter lines.

#### Parameters

##### items

[`FilterLine`](../interfaces/FilterLine.md)[]

The filter lines.

#### Returns

`any`[]

The criteria expression.

***

### getDisplayTextFor()

> `static` **getDisplayTextFor**(`items`): `string`

Defined in: [src/ui/filtering/filterstore.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L110)

Builds the display text for a list of filter lines.

#### Parameters

##### items

[`FilterLine`](../interfaces/FilterLine.md)[]

The filter lines.

#### Returns

`string`

The display text.
