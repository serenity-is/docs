[@serenity-is/corelib](../../../../README.md) / [ScriptData](../README.md) / bindToChange

# ~~Function: bindToChange()~~

> **bindToChange**(`name`, `onChange`): `void` \| () => `void`

Defined in: [src/compat/scriptdata-compat.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/scriptdata-compat.ts#L26)

Binds a callback to the `scriptdatachange.<name>` document event.

## Parameters

### name

`string`

Dynamic script name (event namespace suffix).

### onChange

() => `void`

Callback invoked when script data for `name` changes.

## Returns

`void` \| () => `void`

An unbind function that removes the listener and clears the callback, or `void` when `document` is unavailable.
