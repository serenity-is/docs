[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / eventProp

# Function: eventProp()

> **eventProp**(`event`, `prop`): `any`

Defined in: [src/base/fluent.ts:811](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L811)

Reads a property from the event, falling back to wrapped/original event containers.

## Parameters

### event

`any`

Event object, potentially jQuery-wrapped (`originalEvent`, `nativeEvent`).

### prop

`string`

Property name to read.

## Returns

`any`

The property value, or `undefined` when not found. Lookup order: `event[prop]` → `event.nativeEvent[prop]` → `event.originalEvent[prop]` / `event.nativeEvent.originalEvent[prop]` → `event.detail[prop]`.
