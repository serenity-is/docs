[@serenity-is/corelib](../README.md) / IClassicRouter

# Interface: IClassicRouter

Defined in: [src/compat/router.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L11)

## Properties

### enabled

> **enabled**: `boolean`

Defined in: [src/compat/router.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L12)

***

### mightBeRouteRegex

> **mightBeRouteRegex**: `RegExp`

Defined in: [src/compat/router.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L17)

## Methods

### destroy()

> **destroy**(): `void`

Defined in: [src/compat/router.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L20)

#### Returns

`void`

***

### dialog()

> **dialog**(`owner`, `element`, `dialogHash`): `void`

Defined in: [src/compat/router.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L16)

#### Parameters

##### owner

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### element

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### dialogHash

() => `string`

#### Returns

`void`

***

### ignoreHashChange()

> **ignoreHashChange**(`expiration?`): `void`

Defined in: [src/compat/router.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L19)

#### Parameters

##### expiration?

`number`

#### Returns

`void`

***

### navigate()

> **navigate**(`newHash`, `tryBack?`, `silent?`): `void`

Defined in: [src/compat/router.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L13)

#### Parameters

##### newHash

`string`

##### tryBack?

`boolean`

##### silent?

`boolean`

#### Returns

`void`

***

### replace()

> **replace**(`newHash`, `tryBack?`): `void`

Defined in: [src/compat/router.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L14)

#### Parameters

##### newHash

`string`

##### tryBack?

`boolean`

#### Returns

`void`

***

### replaceLast()

> **replaceLast**(`newHash`, `tryBack?`): `void`

Defined in: [src/compat/router.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L15)

#### Parameters

##### newHash

`string`

##### tryBack?

`boolean`

#### Returns

`void`

***

### resolve()

> **resolve**(`newHash?`): `"disabled"` \| `"skipped"` \| `"shebang"` \| `"missinghandler"` \| `"calledhandler"`

Defined in: [src/compat/router.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L18)

#### Parameters

##### newHash?

`string`

#### Returns

`"disabled"` \| `"skipped"` \| `"shebang"` \| `"missinghandler"` \| `"calledhandler"`
