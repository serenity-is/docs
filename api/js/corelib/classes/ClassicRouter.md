[@serenity-is/corelib](../README.md) / ClassicRouter

# Class: ClassicRouter

Defined in: [src/compat/router.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L25)

## Implements

- [`IClassicRouter`](../interfaces/IClassicRouter.md)

## Constructors

### Constructor

> **new ClassicRouter**(): `ClassicRouter`

Defined in: [src/compat/router.ts:383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L383)

#### Returns

`ClassicRouter`

## Properties

### enabled

> **enabled**: `boolean` = `true`

Defined in: [src/compat/router.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L33)

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`enabled`](../interfaces/IClassicRouter.md#enabled)

***

### mightBeRouteRegex

> **mightBeRouteRegex**: `RegExp`

Defined in: [src/compat/router.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L185)

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`mightBeRouteRegex`](../interfaces/IClassicRouter.md#mightberouteregex)

## Methods

### destroy()

> **destroy**(): `void`

Defined in: [src/compat/router.ts:401](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L401)

#### Returns

`void`

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`destroy`](../interfaces/IClassicRouter.md#destroy)

***

### dialog()

> **dialog**(`owner`, `element`, `dialogHash`): `void`

Defined in: [src/compat/router.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L171)

#### Parameters

##### owner

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### element

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### dialogHash

() => `string`

#### Returns

`void`

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`dialog`](../interfaces/IClassicRouter.md#dialog)

***

### ignoreHashChange()

> **ignoreHashChange**(`expiration?`): `void`

Defined in: [src/compat/router.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L309)

#### Parameters

##### expiration?

`number`

#### Returns

`void`

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`ignoreHashChange`](../interfaces/IClassicRouter.md#ignorehashchange)

***

### navigate()

> **navigate**(`newHash`, `tryBack?`, `silent?`): `void`

Defined in: [src/compat/router.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L39)

#### Parameters

##### newHash

`string`

##### tryBack?

`boolean`

##### silent?

`boolean`

#### Returns

`void`

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`navigate`](../interfaces/IClassicRouter.md#navigate)

***

### replace()

> **replace**(`newHash`, `tryBack?`): `void`

Defined in: [src/compat/router.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L66)

#### Parameters

##### newHash

`string`

##### tryBack?

`boolean`

#### Returns

`void`

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`replace`](../interfaces/IClassicRouter.md#replace)

***

### replaceLast()

> **replaceLast**(`newHash`, `tryBack?`): `void`

Defined in: [src/compat/router.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L70)

#### Parameters

##### newHash

`string`

##### tryBack?

`boolean`

#### Returns

`void`

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`replaceLast`](../interfaces/IClassicRouter.md#replacelast)

***

### resolve()

> **resolve**(`newHash?`): `"disabled"` \| `"skipped"` \| `"shebang"` \| `"missinghandler"` \| `"calledhandler"`

Defined in: [src/compat/router.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L187)

#### Parameters

##### newHash?

`string`

#### Returns

`"disabled"` \| `"skipped"` \| `"shebang"` \| `"missinghandler"` \| `"calledhandler"`

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`resolve`](../interfaces/IClassicRouter.md#resolve)
