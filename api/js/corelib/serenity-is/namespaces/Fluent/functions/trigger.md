[serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / trigger

# Function: trigger()

> **trigger**(`element`, `type`, `args?`): `Event` & `object`

Defined in: [src/base/fluent.ts:485](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L485)

Triggers a specified event on the element.

## Parameters

### element

`EventTarget`

The target element

### type

`string`

The type of the event to trigger.

### args?

`any`

Optional. An object that specifies event-specific initialization properties.

## Returns

`Event` & `object`

The event object. Use Fluent.isDefaultPrevented the check if preventDefault is called.
