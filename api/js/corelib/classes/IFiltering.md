[@serenity-is/corelib](../README.md) / IFiltering

# Abstract Class: IFiltering

Defined in: [src/ui/filtering/ifiltering.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L8)

Interface for filtering handlers that build criteria and editors for a field.

## Constructors

### Constructor

> **new IFiltering**(): `IFiltering`

#### Returns

`IFiltering`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/ifiltering.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L9)

## Methods

### createEditor()

> **createEditor**(): `void`

Defined in: [src/ui/filtering/ifiltering.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L17)

Creates the editor for the current operator.

#### Returns

`void`

***

### get\_container()

> **get\_container**(): `HTMLElement`

Defined in: [src/ui/filtering/ifiltering.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L31)

Returns the container element for the editor.

#### Returns

`HTMLElement`

***

### get\_field()

> **get\_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/filtering/ifiltering.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L27)

Returns the field being filtered.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

***

### get\_operator()

> **get\_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

Defined in: [src/ui/filtering/ifiltering.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L35)

Returns the current operator.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

***

### getCriteria()

> **getCriteria**(): `CriteriaWithText`

Defined in: [src/ui/filtering/ifiltering.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L19)

Returns the criteria and display text for the current operator.

#### Returns

`CriteriaWithText`

***

### getOperators()

> **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/ifiltering.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L21)

Returns the operators supported by this filtering handler.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

***

### loadState()

> **loadState**(`state`): `void`

Defined in: [src/ui/filtering/ifiltering.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L23)

Loads persisted state into the editor.

#### Parameters

##### state

`any`

#### Returns

`void`

***

### saveState()

> **saveState**(): `any`

Defined in: [src/ui/filtering/ifiltering.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L25)

Saves the editor state for persistence.

#### Returns

`any`

***

### set\_container()

> **set\_container**(`value`): `void`

Defined in: [src/ui/filtering/ifiltering.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L33)

Sets the container element for the editor.

#### Parameters

##### value

`HTMLElement`

#### Returns

`void`

***

### set\_field()

> **set\_field**(`value`): `void`

Defined in: [src/ui/filtering/ifiltering.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L29)

Sets the field being filtered.

#### Parameters

##### value

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

***

### set\_operator()

> **set\_operator**(`value`): `void`

Defined in: [src/ui/filtering/ifiltering.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L37)

Sets the current operator.

#### Parameters

##### value

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

`void`
