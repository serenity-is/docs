[@serenity-is/corelib](../README.md) / DialogButton

# Interface: DialogButton

Defined in: [src/base/dialogs.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L17)

Options that describe a single button rendered in a [Dialog](../classes/Dialog.md) footer.

## Remarks

Buttons are rendered as Bootstrap `btn` or jQuery UI button elements depending
on the active dialog provider. When [DialogButton.result](#result) is set and the
click handler does not cancel the event, the dialog automatically closes with
that result code.

## Properties

### click()?

> `optional` **click**: (`e`) => `false` \| `void` \| `Promise`\<`false` \| `void`\>

Defined in: [src/base/dialogs.tsx:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L29)

Click handler invoked when the button is activated.

#### Parameters

##### e

`MouseEvent`

The originating mouse event.

#### Returns

`false` \| `void` \| `Promise`\<`false` \| `void`\>

`false` to prevent the automatic close, or a `Promise` that resolves to `false` to cancel asynchronously.

***

### cssClass?

> `optional` **cssClass**: `string`

Defined in: [src/base/dialogs.tsx:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L31)

Additional CSS class(es) added to the button element (e.g. `"btn-primary"`, `"btn-danger"`).

***

### hint?

> `optional` **hint**: `string`

Defined in: [src/base/dialogs.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L21)

Tooltip / `title` attribute shown on hover.

***

### icon?

> `optional` **icon**: [`IconClassName`](../type-aliases/IconClassName.md)

Defined in: [src/base/dialogs.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L23)

Optional icon displayed before the text; resolved via [iconClassName](../functions/iconClassName.md).

***

### result?

> `optional` **result**: `string`

Defined in: [src/base/dialogs.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L37)

Result code assigned to the dialog when this button is clicked.
The value is stored in `dataset.dialogResult` and passed to `onClose` handlers.
If set and the click handler does not call `preventDefault()` / return `false`, the dialog closes automatically.

***

### text?

> `optional` **text**: `string`

Defined in: [src/base/dialogs.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L19)

Visible caption rendered inside the button. Defaults to a localized value when created via helper factories.
