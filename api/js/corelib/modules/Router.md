[@serenity-is/corelib](../README.md) / Router

# Namespace: Router

## Table of contents

### Variables

- [enabled](Router.md#enabled)

### Functions

- [dialog](Router.md#dialog)
- [navigate](Router.md#navigate)
- [replace](Router.md#replace)
- [replaceLast](Router.md#replacelast)
- [resolve](Router.md#resolve)

## Variables

### enabled

• **enabled**: `boolean` = `true`

#### Defined in

[src/q/router.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L17)

## Functions

### dialog

▸ **dialog**(`owner`, `element`, `dialogHash`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `owner` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `element` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `dialogHash` | () => `string` |

#### Returns

`void`

#### Defined in

[src/q/router.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L156)

___

### navigate

▸ **navigate**(`newHash`, `tryBack?`, `silent?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `newHash` | `string` |
| `tryBack?` | `boolean` |
| `silent?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/router.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L23)

___

### replace

▸ **replace**(`newHash`, `tryBack?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `newHash` | `string` |
| `tryBack?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/router.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L50)

___

### replaceLast

▸ **replaceLast**(`newHash`, `tryBack?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `newHash` | `string` |
| `tryBack?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/router.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L54)

___

### resolve

▸ **resolve**(`newHash?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `newHash?` | `string` |

#### Returns

`void`

#### Defined in

[src/q/router.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/router.ts#L170)
