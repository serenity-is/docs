[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](corelib_q.md) / LayoutTimer

# Namespace: LayoutTimer

[corelib/q](corelib_q.md).LayoutTimer

## Table of contents

### Functions

- [off](corelib_q.LayoutTimer.md#off)
- [onHeightChange](corelib_q.LayoutTimer.md#onheightchange)
- [onShown](corelib_q.LayoutTimer.md#onshown)
- [onSizeChange](corelib_q.LayoutTimer.md#onsizechange)
- [onWidthChange](corelib_q.LayoutTimer.md#onwidthchange)
- [store](corelib_q.LayoutTimer.md#store)
- [trigger](corelib_q.LayoutTimer.md#trigger)

## Functions

### off

▸ **off**(`key`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `number` |

#### Returns

`number`

#### Defined in

[src/q/layouttimer.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#line&#x3D;124)

___

### onHeightChange

▸ **onHeightChange**(`element`, `handler`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | () => `HTMLElement` |
| `handler` | () => `void` |

#### Returns

`number`

#### Defined in

[src/q/layouttimer.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#line&#x3D;116)

___

### onShown

▸ **onShown**(`element`, `handler`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | () => `HTMLElement` |
| `handler` | () => `void` |

#### Returns

`number`

#### Defined in

[src/q/layouttimer.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#line&#x3D;120)

___

### onSizeChange

▸ **onSizeChange**(`element`, `handler`, `width?`, `height?`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | () => `HTMLElement` |
| `handler` | () => `void` |
| `width?` | `boolean` |
| `height?` | `boolean` |

#### Returns

`number`

#### Defined in

[src/q/layouttimer.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#line&#x3D;96)

___

### onWidthChange

▸ **onWidthChange**(`element`, `handler`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | () => `HTMLElement` |
| `handler` | () => `void` |

#### Returns

`number`

#### Defined in

[src/q/layouttimer.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#line&#x3D;112)

___

### store

▸ **store**(`key`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `number` |

#### Returns

`void`

#### Defined in

[src/q/layouttimer.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#line&#x3D;71)

___

### trigger

▸ **trigger**(`key`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `number` |

#### Returns

`void`

#### Defined in

[src/q/layouttimer.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#line&#x3D;84)
