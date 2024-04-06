[@serenity-is/sleekgrid](../README.md) / EventSubscriber

# Class: EventSubscriber\<TArgs, TEventData\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TArgs` | `any` |
| `TEventData` | extends [`IEventData`](../interfaces/IEventData.md) = [`IEventData`](../interfaces/IEventData.md) |

## Table of contents

### Constructors

- [constructor](EventSubscriber.md#constructor)

### Methods

- [subscribe](EventSubscriber.md#subscribe)
- [unsubscribe](EventSubscriber.md#unsubscribe)
- [unsubscribeAll](EventSubscriber.md#unsubscribeall)

## Constructors

### constructor

• **new EventSubscriber**\<`TArgs`, `TEventData`\>(): [`EventSubscriber`](EventSubscriber.md)\<`TArgs`, `TEventData`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TArgs` | `any` |
| `TEventData` | extends [`IEventData`](../interfaces/IEventData.md) = [`IEventData`](../interfaces/IEventData.md) |

#### Returns

[`EventSubscriber`](EventSubscriber.md)\<`TArgs`, `TEventData`\>

## Methods

### subscribe

▸ **subscribe**(`event`, `handler`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `event` | [`EventEmitter`](EventEmitter.md)\<`TArgs`, `TEventData`\> |
| `handler` | (`e`: `TEventData`, `args`: `TArgs`) => `void` |

#### Returns

`this`

#### Defined in

[core/event.ts:121](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L121)

___

### unsubscribe

▸ **unsubscribe**(`event`, `handler`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `event` | [`EventEmitter`](EventEmitter.md)\<`TArgs`, `TEventData`\> |
| `handler` | (`e`: `TEventData`, `args`: `TArgs`) => `void` |

#### Returns

`this`

#### Defined in

[core/event.ts:131](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L131)

___

### unsubscribeAll

▸ **unsubscribeAll**(): [`EventSubscriber`](EventSubscriber.md)\<`TArgs`, `TEventData`\>

#### Returns

[`EventSubscriber`](EventSubscriber.md)\<`TArgs`, `TEventData`\>

#### Defined in

[core/event.ts:145](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L145)
