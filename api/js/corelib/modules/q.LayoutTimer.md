[@serenity-is](../README.md) / [Modules](../modules.md) / [q](q.md) / LayoutTimer

# Namespace: LayoutTimer

[q](q.md).LayoutTimer

## Table of contents

### Functions

- [off](q.LayoutTimer.md#off)
- [onHeightChange](q.LayoutTimer.md#onheightchange)
- [onShown](q.LayoutTimer.md#onshown)
- [onSizeChange](q.LayoutTimer.md#onsizechange)
- [onWidthChange](q.LayoutTimer.md#onwidthchange)
- [store](q.LayoutTimer.md#store)
- [trigger](q.LayoutTimer.md#trigger)

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

[src/q/layouttimer.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L124)

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

[src/q/layouttimer.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L116)

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

[src/q/layouttimer.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L120)

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

[src/q/layouttimer.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L96)

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

[src/q/layouttimer.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L112)

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

[src/q/layouttimer.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L71)

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

[src/q/layouttimer.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L84)
