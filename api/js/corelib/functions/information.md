[@serenity-is/corelib](../README.md) / information

# Function: ~~information()~~

> **information**(`message`, `onOk`?, `options`?): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

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

use informationDialog

## See

ConfirmOptions

## Example

```ts
informationDialog("Operation complete", () => { 
    // do something when OK is clicked
}
```

## Defined in

[src/q/dialogs-compat.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs-compat.ts#L10)
