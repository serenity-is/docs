[corelib](../README.md) / alert

# ~~Variable: alert()~~

> `const` **alert**: (`message`, `options?`) => `Partial`\<[`Dialog`](../classes/Dialog.md)\> = `alertDialog`

Defined in: [src/compat/dialogs-compat.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/dialogs-compat.ts#L4)

Displays an alert dialog

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

The message to display

### options?

[`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Additional options.

## Returns

`Partial`\<[`Dialog`](../classes/Dialog.md)\>

## See

AlertOptions

## Example

```ts
alertDialog("An error occured!"); }
```

## Deprecated

use alertDialog
