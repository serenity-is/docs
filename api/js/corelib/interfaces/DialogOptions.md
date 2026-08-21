[@serenity-is/corelib](../README.md) / DialogOptions

# Interface: DialogOptions

Defined in: [src/base/dialogs.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L55)

Options that configure a [Dialog](../classes/Dialog.md) instance across all providers.

## Remarks

The dialog provider is chosen automatically from [DialogOptions.preferPanel](#preferpanel),
[DialogOptions.preferBSModal](#preferbsmodal), and feature detection (`hasBSModal()` / `hasUIDialog()`).
Provider-specific options can be injected via [DialogOptions.providerOptions](#provideroptions).

## Extended by

- [`MessageDialogOptions`](MessageDialogOptions.md)

## Properties

### autoDispose?

> `optional` **autoDispose**: `boolean`

Defined in: [src/base/dialogs.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L57)

When `true`, [Dialog.dispose](../classes/Dialog.md#dispose) is called automatically on close.

#### Default Value

`true`

***

### autoOpen?

> `optional` **autoOpen**: `boolean`

Defined in: [src/base/dialogs.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L59)

When `true`, the dialog opens immediately after construction.

#### Default Value

`true`

***

### backdrop?

> `optional` **backdrop**: `boolean` \| `"static"`

Defined in: [src/base/dialogs.tsx:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L61)

Backdrop behavior for Bootstrap modals; `"static"` prevents closing on outside click.

#### Default Value

`false`

***

### buttons?

> `optional` **buttons**: [`DialogButton`](DialogButton.md)[]

Defined in: [src/base/dialogs.tsx:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L63)

Buttons rendered in the dialog footer.

***

### centered?

> `optional` **centered**: `boolean`

Defined in: [src/base/dialogs.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L65)

Vertically centers a Bootstrap modal via `modal-dialog-centered`.

#### Default Value

`true`

***

### closeButton?

> `optional` **closeButton**: `boolean`

Defined in: [src/base/dialogs.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L67)

Whether to render the header close (`×` / `btn-close`) button.

#### Default Value

`true`

***

### closeOnEscape?

> `optional` **closeOnEscape**: `boolean`

Defined in: [src/base/dialogs.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L69)

Whether pressing <kbd>Escape</kbd> closes the dialog. Message dialogs default to `true`.

***

### dialogClass?

> `optional` **dialogClass**: `string`

Defined in: [src/base/dialogs.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L71)

Extra CSS class(es) added to the root dialog element (`.modal`, `.ui-dialog`, or `.s-Panel`).

***

### element?

> `optional` **element**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`element`) => `void`

Defined in: [src/base/dialogs.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L73)

Body element or a callback that populates the freshly created body element. Array-like values are treated as the content node.

***

### fade?

> `optional` **fade**: `boolean`

Defined in: [src/base/dialogs.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L75)

Enables fade animation for Bootstrap modals.

#### Default Value

`false` for message dialogs, `true` otherwise

***

### fullScreen?

> `optional` **fullScreen**: `boolean` \| `"sm-down"` \| `"md-down"` \| `"lg-down"` \| `"xl-down"` \| `"xxl-down"`

Defined in: [src/base/dialogs.tsx:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L77)

Applies a `modal-fullscreen[-{breakpoint}-down]` class. Only effective for Bootstrap modals.

***

### modal?

> `optional` **modal**: `boolean`

Defined in: [src/base/dialogs.tsx:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L79)

jQuery UI `modal` flag. Retained for backward compatibility; does not affect Bootstrap modals.

***

### onClose()?

> `optional` **onClose**: (`result`, `e?`) => `void`

Defined in: [src/base/dialogs.tsx:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L83)

Callback invoked after the dialog is closed, receiving the result code.

#### Parameters

##### result

`string`

##### e?

`Event`

#### Returns

`void`

***

### onOpen()?

> `optional` **onOpen**: (`e?`) => `void`

Defined in: [src/base/dialogs.tsx:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L81)

Callback invoked after the dialog is opened.

#### Parameters

##### e?

`Event`

#### Returns

`void`

***

### preferBSModal?

> `optional` **preferBSModal**: `boolean`

Defined in: [src/base/dialogs.tsx:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L85)

When both providers are available, prefer Bootstrap modal over jQuery UI dialog.

#### Default Value

`true`

***

### preferPanel?

> `optional` **preferPanel**: `boolean`

Defined in: [src/base/dialogs.tsx:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L87)

Force inline panel mode even when modal / jQuery UI providers are available.

***

### providerOptions()?

> `optional` **providerOptions**: (`type`, `opt`) => `any`

Defined in: [src/base/dialogs.tsx:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L89)

Returns provider-specific options merged into the underlying call (Bootstrap modal options or jQuery UI dialog options).

#### Parameters

##### type

[`DialogProviderType`](../type-aliases/DialogProviderType.md)

Resolved provider type.

##### opt

`DialogOptions`

The resolved dialog options.

#### Returns

`any`

Provider-specific options object.

***

### scrollable?

> `optional` **scrollable**: `boolean`

Defined in: [src/base/dialogs.tsx:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L91)

Makes the Bootstrap modal body scrollable via `modal-dialog-scrollable`.

***

### size?

> `optional` **size**: `"sm"` \| `"md"` \| `"lg"` \| `"xl"`

Defined in: [src/base/dialogs.tsx:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L93)

Bootstrap modal size.

#### Default Value

`"lg"` for regular dialogs, `"md"` for message dialogs

***

### title?

> `optional` **title**: `string`

Defined in: [src/base/dialogs.tsx:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L95)

Title text shown in the dialog header.

***

### width?

> `optional` **width**: `number`

Defined in: [src/base/dialogs.tsx:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L97)

Initial width in pixels; only used by the jQuery UI dialog provider.
