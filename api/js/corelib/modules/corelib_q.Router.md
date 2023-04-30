[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](corelib_q.md) / Router

# Namespace: Router

[corelib/q](corelib_q.md).Router

## Table of contents

### Variables

- [enabled](corelib_q.Router.md#enabled)

### Functions

- [dialog](corelib_q.Router.md#dialog)
- [navigate](corelib_q.Router.md#navigate)
- [replace](corelib_q.Router.md#replace)
- [replaceLast](corelib_q.Router.md#replacelast)
- [resolve](corelib_q.Router.md#resolve)

## Variables

### enabled

• **enabled**: `boolean` = `true`

#### Defined in

[src/q/router.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L19)

## Functions

### dialog

▸ **dialog**(`owner`, `element`, `hash`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `owner` | `JQuery` |
| `element` | `JQuery` |
| `hash` | () => `string` |

#### Returns

`void`

#### Defined in

[src/q/router.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L140)

___

### navigate

▸ **navigate**(`hash`, `tryBack?`, `silent?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `hash` | `string` |
| `tryBack?` | `boolean` |
| `silent?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/router.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L25)

___

### replace

▸ **replace**(`hash`, `tryBack?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `hash` | `string` |
| `tryBack?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/router.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L53)

___

### replaceLast

▸ **replaceLast**(`hash`, `tryBack?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `hash` | `string` |
| `tryBack?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/router.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L57)

___

### resolve

▸ **resolve**(`hash?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `hash?` | `string` |

#### Returns

`void`

#### Defined in

[src/q/router.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L149)
