[serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / isDefaultPrevented

# Function: isDefaultPrevented()

> **isDefaultPrevented**(`event`): `boolean`

Defined in: [src/base/fluent.ts:634](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L634)

Checks if the event's preventDefault method is called. This is for compatibility with jQuery which
has a non-standard isDefaultPrevented method.

## Parameters

### event

The event object

#### defaultPrevented?

`boolean`

#### isDefaultPrevented?

() => `boolean`

## Returns

`boolean`

True if preventDefault is called.
