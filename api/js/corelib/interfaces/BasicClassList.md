[@serenity-is/corelib](../README.md) / BasicClassList

# Interface: BasicClassList()

Defined in: [../domwise/dist/index.d.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L14)

A class list manager created by `useClassList`. It wraps a `DOMTokenList`
and provides a subset of the native `classList` API (`add`, `remove`,
`toggle`, `contains`, `size`, `value`). It can also be used as a JSX prop
hook to reactively bind the `class` attribute; see [useClassList](../functions/useClassList.md).

## Extends

- [`PropHook`](PropHook.md)\<`Element`\>

> **BasicClassList**(): `DOMTokenList`

Defined in: [../domwise/dist/index.d.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L16)

Returns the underlying `DOMTokenList` (detached before binding, live after).

## Returns

`DOMTokenList`

## Properties

### size

> `readonly` **size**: `number`

Defined in: [../domwise/dist/index.d.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L18)

Number of tokens in the list.

***

### value

> `readonly` **value**: `string`

Defined in: [../domwise/dist/index.d.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L20)

Space-separated string of all tokens (mirrors `DOMTokenList.value`).

## Methods

### \[initPropHookSymbol\]()

> **\[initPropHookSymbol\]**(`node`, `propName`): `void`

Defined in: [../domwise/dist/index.d.ts:3102](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L3102)

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

Defined in: [../domwise/dist/index.d.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L25)

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

Defined in: [../domwise/dist/index.d.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L43)

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

Defined in: [../domwise/dist/index.d.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L30)

Removes one or more tokens from the list.

#### Parameters

##### tokens

...`string`[]

Class names to remove.

#### Returns

`void`

***

### toggle()

> **toggle**(`token`, `force?`): `boolean`

Defined in: [../domwise/dist/index.d.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L37)

Toggles a token, optionally forcing the presence or absence.

#### Parameters

##### token

`string`

Class name to toggle.

##### force?

`boolean`

When provided, forces add (`true`) or remove (`false`).

#### Returns

`boolean`

`true` if the token is now present, otherwise `false`.
