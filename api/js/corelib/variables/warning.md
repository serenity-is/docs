[@serenity-is/corelib](../README.md) / warning

# ~~Variable: warning()~~

> `const` **warning**: (`message`, `options?`) => `Partial`\<[`Dialog`](../classes/Dialog.md)\> = `warningDialog`

Defined in: [src/compat/dialogs-compat.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/dialogs-compat.ts#L16)

Display a warning dialog

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

MessageDialogOptions

## Example

```ts
warningDialog("Something is odd!");
```

## Deprecated

use warningDialog
