[serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / eventProp

# Function: eventProp()

> **eventProp**(`event`, `prop`): `any`

Defined in: [src/base/fluent.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L648)

Tries to read a property from the event, or event.originalEvent, or event.detail. It is designed
for compatibility with the way jQuery wraps original event under originalEvent property, that
causes custom properties to be not available in the event object.

## Parameters

### event

`any`

The event object

### prop

`string`

The property name

## Returns

`any`

The property value
