[@serenity-is/corelib](../README.md) / warning

# Function: ~~warning()~~

> **warning**(`message`, `options`?): `Partial`\<[`Dialog`](../classes/Dialog.md)\>

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

use warningDialog

## See

MessageDialogOptions

## Example

```ts
warningDialog("Something is odd!");
```

## Defined in

[src/q/dialogs-compat.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs-compat.ts#L16)
