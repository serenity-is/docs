[@serenity-is/corelib](../README.md) / success

# Function: ~~success()~~

> **success**(`message`, `onOk`?, `options`?): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

## Parameters

### message

`string`

The message to display

### onOk?

() => `void`

Callback for OK button click

### options?

[`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Additional options.

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

## Deprecated

use successDialog

## See

MessageDialogOptions

## Example

```ts
successDialog("Operation complete", () => { 
    // do something when OK is clicked
}
```

## Defined in

[src/q/dialogs-compat.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs-compat.ts#L13)
