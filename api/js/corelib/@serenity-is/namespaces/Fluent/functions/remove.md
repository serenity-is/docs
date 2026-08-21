[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / remove

# Function: remove()

> **remove**(`element`): `void`

Defined in: [src/base/fluent.ts:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L697)

Removes the element from the DOM, clearing Fluent event handlers and firing `disposing` notifications for the element and its descendants.

## Parameters

### element

`Element`

Element to remove. No-op when `null` / `undefined`.

## Returns

`void`

`void`.
