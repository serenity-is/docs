[@serenity-is/corelib](../README.md) / alert

# Function: ~~alert()~~

> **alert**(`message`, `options`?): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

## Parameters

### message

`string`

The message to display

### options?

[`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Additional options.

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

## Deprecated

use alertDialog

## See

AlertOptions

## Example

```ts
alertDialog("An error occured!"); }
```

## Defined in

[src/q/dialogs-compat.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs-compat.ts#L4)
