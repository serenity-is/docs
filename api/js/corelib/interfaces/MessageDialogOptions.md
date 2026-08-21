[@serenity-is/corelib](../README.md) / MessageDialogOptions

# Interface: MessageDialogOptions

Defined in: [src/base/dialogs.tsx:990](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L990)

Options for helper message dialogs (`alertDialog`, `confirmDialog`, etc.).

## Remarks

Extends [DialogOptions](DialogOptions.md) with message-specific rendering flags.

## Extends

- [`DialogOptions`](DialogOptions.md)

## Extended by

- [`ConfirmDialogOptions`](ConfirmDialogOptions.md)

## Properties

### autoDispose?

> `optional` **autoDispose**: `boolean`

Defined in: [src/base/dialogs.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L57)

When `true`, [Dialog.dispose](../classes/Dialog.md#dispose) is called automatically on close.

#### Default Value

`true`

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`autoDispose`](DialogOptions.md#autodispose)

***

### autoOpen?

> `optional` **autoOpen**: `boolean`

Defined in: [src/base/dialogs.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L59)

When `true`, the dialog opens immediately after construction.

#### Default Value

`true`

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`autoOpen`](DialogOptions.md#autoopen)

***

### backdrop?

> `optional` **backdrop**: `boolean` \| `"static"`

Defined in: [src/base/dialogs.tsx:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L61)

Backdrop behavior for Bootstrap modals; `"static"` prevents closing on outside click.

#### Default Value

`false`

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`backdrop`](DialogOptions.md#backdrop)

***

### buttons?

> `optional` **buttons**: [`DialogButton`](DialogButton.md)[]

Defined in: [src/base/dialogs.tsx:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L63)

Buttons rendered in the dialog footer.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`buttons`](DialogOptions.md#buttons)

***

### centered?

> `optional` **centered**: `boolean`

Defined in: [src/base/dialogs.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L65)

Vertically centers a Bootstrap modal via `modal-dialog-centered`.

#### Default Value

`true`

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`centered`](DialogOptions.md#centered)

***

### closeButton?

> `optional` **closeButton**: `boolean`

Defined in: [src/base/dialogs.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L67)

Whether to render the header close (`×` / `btn-close`) button.

#### Default Value

`true`

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`closeButton`](DialogOptions.md#closebutton)

***

### closeOnEscape?

> `optional` **closeOnEscape**: `boolean`

Defined in: [src/base/dialogs.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L69)

Whether pressing <kbd>Escape</kbd> closes the dialog. Message dialogs default to `true`.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`closeOnEscape`](DialogOptions.md#closeonescape)

***

### dialogClass?

> `optional` **dialogClass**: `string`

Defined in: [src/base/dialogs.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L71)

Extra CSS class(es) added to the root dialog element (`.modal`, `.ui-dialog`, or `.s-Panel`).

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`dialogClass`](DialogOptions.md#dialogclass)

***

### element?

> `optional` **element**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`element`) => `void`

Defined in: [src/base/dialogs.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L73)

Body element or a callback that populates the freshly created body element. Array-like values are treated as the content node.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`element`](DialogOptions.md#element)

***

### fade?

> `optional` **fade**: `boolean`

Defined in: [src/base/dialogs.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L75)

Enables fade animation for Bootstrap modals.

#### Default Value

`false` for message dialogs, `true` otherwise

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`fade`](DialogOptions.md#fade)

***

### fullScreen?

> `optional` **fullScreen**: `boolean` \| `"sm-down"` \| `"md-down"` \| `"lg-down"` \| `"xl-down"` \| `"xxl-down"`

Defined in: [src/base/dialogs.tsx:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L77)

Applies a `modal-fullscreen[-{breakpoint}-down]` class. Only effective for Bootstrap modals.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`fullScreen`](DialogOptions.md#fullscreen)

***

### ~~htmlEncode?~~

> `optional` **htmlEncode**: `boolean`

Defined in: [src/base/dialogs.tsx:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L995)

Whether to HTML-encode string messages.

#### Default Value

`true`

#### Deprecated

Prefer passing a `RenderableContent` node or pre-sanitized HTML. When `false`, the string is sanitized via `sanitizeHtml`.

***

### modal?

> `optional` **modal**: `boolean`

Defined in: [src/base/dialogs.tsx:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L79)

jQuery UI `modal` flag. Retained for backward compatibility; does not affect Bootstrap modals.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`modal`](DialogOptions.md#modal)

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

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`onClose`](DialogOptions.md#onclose)

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

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`onOpen`](DialogOptions.md#onopen)

***

### preferBSModal?

> `optional` **preferBSModal**: `boolean`

Defined in: [src/base/dialogs.tsx:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L85)

When both providers are available, prefer Bootstrap modal over jQuery UI dialog.

#### Default Value

`true`

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`preferBSModal`](DialogOptions.md#preferbsmodal)

***

### preferPanel?

> `optional` **preferPanel**: `boolean`

Defined in: [src/base/dialogs.tsx:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L87)

Force inline panel mode even when modal / jQuery UI providers are available.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`preferPanel`](DialogOptions.md#preferpanel)

***

### preWrap?

> `optional` **preWrap**: `boolean`

Defined in: [src/base/dialogs.tsx:1000](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1000)

Whether to preserve line breaks via `white-space: pre-wrap` on the message container.

#### Default Value

`true`

#### Remarks

Only applied when the message is a string; element messages manage their own styling.

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

[`DialogOptions`](DialogOptions.md)

The resolved dialog options.

#### Returns

`any`

Provider-specific options object.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`providerOptions`](DialogOptions.md#provideroptions)

***

### scrollable?

> `optional` **scrollable**: `boolean`

Defined in: [src/base/dialogs.tsx:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L91)

Makes the Bootstrap modal body scrollable via `modal-dialog-scrollable`.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`scrollable`](DialogOptions.md#scrollable)

***

### size?

> `optional` **size**: `"sm"` \| `"md"` \| `"lg"` \| `"xl"`

Defined in: [src/base/dialogs.tsx:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L93)

Bootstrap modal size.

#### Default Value

`"lg"` for regular dialogs, `"md"` for message dialogs

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`size`](DialogOptions.md#size)

***

### title?

> `optional` **title**: `string`

Defined in: [src/base/dialogs.tsx:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L95)

Title text shown in the dialog header.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`title`](DialogOptions.md#title)

***

### width?

> `optional` **width**: `number`

Defined in: [src/base/dialogs.tsx:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L97)

Initial width in pixels; only used by the jQuery UI dialog provider.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`width`](DialogOptions.md#width)
