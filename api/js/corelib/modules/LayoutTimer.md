[@serenity-is/corelib](../README.md) / LayoutTimer

# Namespace: LayoutTimer

## Table of contents

### Functions

- [off](LayoutTimer.md#off)
- [onHeightChange](LayoutTimer.md#onheightchange)
- [onShown](LayoutTimer.md#onshown)
- [onSizeChange](LayoutTimer.md#onsizechange)
- [onWidthChange](LayoutTimer.md#onwidthchange)
- [store](LayoutTimer.md#store)
- [trigger](LayoutTimer.md#trigger)

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

[src/q/layouttimer.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L126)

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

[src/q/layouttimer.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L118)

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

[src/q/layouttimer.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L122)

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

[src/q/layouttimer.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L98)

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

[src/q/layouttimer.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L114)

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

[src/q/layouttimer.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L73)

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

[src/q/layouttimer.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/layouttimer.ts#L86)
