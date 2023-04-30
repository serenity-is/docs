[@serenity-is/sleekgrid](../README.md) / EventSubscriber

# Class: EventSubscriber<TArgs, TEventData\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TArgs` | `any` |
| `TEventData` | extends [`IEventData`](../interfaces/IEventData.md) = [`IEventData`](../interfaces/IEventData.md) |

## Table of contents

### Constructors

- [constructor](EventSubscriber.md#constructor)

### Properties

- [\_handlers](EventSubscriber.md#_handlers)

### Methods

- [subscribe](EventSubscriber.md#subscribe)
- [unsubscribe](EventSubscriber.md#unsubscribe)
- [unsubscribeAll](EventSubscriber.md#unsubscribeall)

## Constructors

### constructor

• **new EventSubscriber**<`TArgs`, `TEventData`\>()

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TArgs` | `any` |
| `TEventData` | extends [`IEventData`](../interfaces/IEventData.md) = [`IEventData`](../interfaces/IEventData.md) |

## Properties

### \_handlers

• `Private` **\_handlers**: `EventSubscriberEntry`<`TArgs`, `TEventData`\>[] = `[]`

#### Defined in

[core/event.ts:121](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L121)

## Methods

### subscribe

▸ **subscribe**(`event`, `handler`): [`EventSubscriber`](EventSubscriber.md)<`TArgs`, `TEventData`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `event` | [`EventEmitter`](EventEmitter.md)<`TArgs`, `TEventData`\> |
| `handler` | [`EventListener`](../README.md#eventlistener)<`TArgs`, `TEventData`\> |

#### Returns

[`EventSubscriber`](EventSubscriber.md)<`TArgs`, `TEventData`\>

#### Defined in

[core/event.ts:123](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L123)

___

### unsubscribe

▸ **unsubscribe**(`event`, `handler`): [`EventSubscriber`](EventSubscriber.md)<`TArgs`, `TEventData`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `event` | [`EventEmitter`](EventEmitter.md)<`TArgs`, `TEventData`\> |
| `handler` | [`EventListener`](../README.md#eventlistener)<`TArgs`, `TEventData`\> |

#### Returns

[`EventSubscriber`](EventSubscriber.md)<`TArgs`, `TEventData`\>

#### Defined in

[core/event.ts:133](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L133)

___

### unsubscribeAll

▸ **unsubscribeAll**(): [`EventSubscriber`](EventSubscriber.md)<`TArgs`, `TEventData`\>

#### Returns

[`EventSubscriber`](EventSubscriber.md)<`TArgs`, `TEventData`\>

#### Defined in

[core/event.ts:147](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L147)
