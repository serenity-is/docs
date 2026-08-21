[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / off

# Function: off()

Removes an event listener (implementation).

## Param

Target element.

## Param

Event type; may include a `.namespace`.

## Param

Specific callback to remove.

## Param

Delegated handler to remove.

## Call Signature

> **off**\<`K`\>(`element`, `type`, `listener?`): `void`

Defined in: [src/base/fluent.ts:610](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L610)

Removes an event listener (or all listeners for a namespaced type).

### Type Parameters

#### K

`K` *extends* keyof `HTMLElementEventMap`

### Parameters

#### element

`EventTarget`

Target element.

#### type

`K`

Event type; may include a `.namespace`. When only a namespace is handled, all matching listeners are removed.

#### listener?

(`this`, `ev`) => `any`

Specific callback to remove. When omitted, all listeners for `type` are removed.

### Returns

`void`

`void`.

## Call Signature

> **off**(`element`, `type`, `listener?`): `void`

Defined in: [src/base/fluent.ts:618](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L618)

Removes an event listener.

### Parameters

#### element

`EventTarget`

Target element.

#### type

`string`

Event type; may include a `.namespace`.

#### listener?

`EventListener`

Specific callback to remove. When omitted, all listeners for `type` are removed.

### Returns

`void`

`void`.

## Call Signature

> **off**(`element`, `type`, `selector?`, `delegationHandler?`): `void`

Defined in: [src/base/fluent.ts:627](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L627)

Removes a delegated event listener.

### Parameters

#### element

`EventTarget`

Target element.

#### type

`string`

Event type; may include a `.namespace`.

#### selector?

`string`

Delegation selector used when the listener was added.

#### delegationHandler?

`Function`

Delegated handler to remove.

### Returns

`void`

`void`.
