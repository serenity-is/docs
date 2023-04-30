[@serenity-is/sleekgrid](../README.md) / EventEmitter

# Class: EventEmitter<TArgs, TEventData\>

A simple publisher-subscriber implementation.

## Type parameters

| Name | Type |
| :------ | :------ |
| `TArgs` | `any` |
| `TEventData` | extends [`IEventData`](../interfaces/IEventData.md) = [`IEventData`](../interfaces/IEventData.md) |

## Table of contents

### Constructors

- [constructor](EventEmitter.md#constructor)

### Properties

- [\_handlers](EventEmitter.md#_handlers)

### Methods

- [clear](EventEmitter.md#clear)
- [notify](EventEmitter.md#notify)
- [subscribe](EventEmitter.md#subscribe)
- [unsubscribe](EventEmitter.md#unsubscribe)

## Constructors

### constructor

• **new EventEmitter**<`TArgs`, `TEventData`\>()

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TArgs` | `any` |
| `TEventData` | extends [`IEventData`](../interfaces/IEventData.md) = [`IEventData`](../interfaces/IEventData.md) |

## Properties

### \_handlers

• `Private` **\_handlers**: [`EventListener`](../README.md#eventlistener)<`TArgs`, `TEventData`\>[] = `[]`

#### Defined in

[core/event.ts:60](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L60)

## Methods

### clear

▸ **clear**(): `void`

#### Returns

`void`

#### Defined in

[core/event.ts:110](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L110)

___

### notify

▸ **notify**(`args?`, `e?`, `scope?`): `any`

Fires an event notifying all subscribers.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `args?` | `any` | {Object} Additional data object to be passed to all handlers. |
| `e?` | `TEventData` | {EventData} Optional. An <code>EventData</code> object to be passed to all handlers. For DOM events, an existing W3C/jQuery event object can be passed in. |
| `scope?` | `object` | {Object} Optional. The scope ("this") within which the handler will be executed. If not specified, the scope will be set to the <code>Event</code> instance. |

#### Returns

`any`

#### Defined in

[core/event.ts:98](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L98)

___

### subscribe

▸ **subscribe**(`fn`): `void`

Adds an event handler to be called when the event is fired.
<p>Event handler will receive two arguments - an <code>EventData</code> and the <code>data</code>
object the event was fired with.<p>

**`Method`**

subscribe

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `fn` | [`EventListener`](../README.md#eventlistener)<`TArgs`, `TEventData`\> | {Function} Event handler. |

#### Returns

`void`

#### Defined in

[core/event.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L69)

___

### unsubscribe

▸ **unsubscribe**(`fn`): `void`

Removes an event handler added with <code>subscribe(fn)</code>.

**`Method`**

unsubscribe

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `fn` | [`EventListener`](../README.md#eventlistener)<`TArgs`, `TEventData`\> | {Function} Event handler to be removed. |

#### Returns

`void`

#### Defined in

[core/event.ts:78](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L78)
