[@serenity-is/domwise](../README.md) / BasicClassList

# Interface: BasicClassList()

Defined in: [types/basic-types.d.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L16)

A class list manager created by `useClassList`. It wraps a `DOMTokenList`
and provides a subset of the native `classList` API (`add`, `remove`,
`toggle`, `contains`, `size`, `value`). It can also be used as a JSX prop
hook to reactively bind the `class` attribute; see [useClassList](../functions/useClassList.md).

## Extends

- [`PropHook`](PropHook.md)\<`Element`\>

> **BasicClassList**(): `DOMTokenList`

Defined in: [types/basic-types.d.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L18)

Returns the underlying `DOMTokenList` (detached before binding, live after).

## Returns

`DOMTokenList`

## Properties

### size

> `readonly` **size**: `number`

Defined in: [types/basic-types.d.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L20)

Number of tokens in the list.

***

### value

> `readonly` **value**: `string`

Defined in: [types/basic-types.d.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L22)

Space-separated string of all tokens (mirrors `DOMTokenList.value`).

## Methods

### \[initPropHookSymbol\]()

> **\[initPropHookSymbol\]**(`node`, `propName`): `void`

Defined in: [src/prop-hook.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/prop-hook.ts#L14)

#### Parameters

##### node

`Element`

##### propName

`string`

#### Returns

`void`

#### Inherited from

[`PropHook`](PropHook.md).[`[initPropHookSymbol]`](PropHook.md#initprophooksymbol)

***

### add()

> **add**(...`tokens`): `void`

Defined in: [types/basic-types.d.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L27)

Adds one or more tokens to the list. Duplicate tokens are ignored.

#### Parameters

##### tokens

...`string`[]

Class names to add.

#### Returns

`void`

***

### contains()

> **contains**(`token`): `boolean`

Defined in: [types/basic-types.d.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L44)

Checks whether the list contains the given token.

#### Parameters

##### token

`string`

Class name to test.

#### Returns

`boolean`

`true` if the token is present.

***

### remove()

> **remove**(...`tokens`): `void`

Defined in: [types/basic-types.d.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L32)

Removes one or more tokens from the list.

#### Parameters

##### tokens

...`string`[]

Class names to remove.

#### Returns

`void`

***

### toggle()

> **toggle**(`token`, `force?`): `void`

Defined in: [types/basic-types.d.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L38)

Toggles a token, optionally forcing the presence or absence.

#### Parameters

##### token

`string`

Class name to toggle.

##### force?

`boolean`

When provided, forces add (`true`) or remove (`false`).

#### Returns

`void`
