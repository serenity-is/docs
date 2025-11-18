[@serenity-is/corelib](../README.md) / DialogOptions

# Interface: DialogOptions

Defined in: [src/base/dialogs.tsx:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L34)

Options that apply to all dialog types

## Extended by

- [`MessageDialogOptions`](MessageDialogOptions.md)

## Properties

### autoDispose?

> `optional` **autoDispose**: `boolean`

Defined in: [src/base/dialogs.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L36)

Auto dispose dialog on close, default is true

***

### autoOpen?

> `optional` **autoOpen**: `boolean`

Defined in: [src/base/dialogs.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L38)

True to auto open dialog

***

### backdrop?

> `optional` **backdrop**: `boolean` \| `"static"`

Defined in: [src/base/dialogs.tsx:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L40)

Backdrop type, static to make it modal, e.g. can't be closed by clicking outside

***

### buttons?

> `optional` **buttons**: [`DialogButton`](DialogButton.md)[]

Defined in: [src/base/dialogs.tsx:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L42)

List of buttons to show on the dialog

***

### centered?

> `optional` **centered**: `boolean`

Defined in: [src/base/dialogs.tsx:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L44)

Vertically center modal

***

### closeButton?

> `optional` **closeButton**: `boolean`

Defined in: [src/base/dialogs.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L46)

Show close button, default is true

***

### closeOnEscape?

> `optional` **closeOnEscape**: `boolean`

Defined in: [src/base/dialogs.tsx:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L48)

Close dialog on escape key. Default is true for message dialogs.

***

### dialogClass?

> `optional` **dialogClass**: `string`

Defined in: [src/base/dialogs.tsx:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L50)

CSS class to use for all dialog types. Is added to the top ui-dialog, panel or modal element

***

### element?

> `optional` **element**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`element`) => `void`

Defined in: [src/base/dialogs.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L52)

Dialog content/body element, or callback that will populate the content element

***

### fade?

> `optional` **fade**: `boolean`

Defined in: [src/base/dialogs.tsx:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L54)

Enable / disable animation. Default is false for message dialogs, true for other dialogs

***

### fullScreen?

> `optional` **fullScreen**: `boolean` \| `"sm-down"` \| `"md-down"` \| `"lg-down"` \| `"xl-down"` \| `"xxl-down"`

Defined in: [src/base/dialogs.tsx:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L56)

Sets one of modal-fullscreen{-...-down} classes. Only used for bootstrap modals

***

### modal?

> `optional` **modal**: `boolean`

Defined in: [src/base/dialogs.tsx:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L58)

Modal option for jQuery UI dialog compatibility only. Not to be confused with Bootstrap modal.

***

### onClose()?

> `optional` **onClose**: (`result`, `e?`) => `void`

Defined in: [src/base/dialogs.tsx:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L62)

Event handler that is called when dialog is closed

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

Defined in: [src/base/dialogs.tsx:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L60)

Event handler that is called when dialog is opened

#### Parameters

##### e?

`Event`

#### Returns

`void`

***

### preferBSModal?

> `optional` **preferBSModal**: `boolean`

Defined in: [src/base/dialogs.tsx:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L64)

Prefer Bootstrap modals to jQuery UI dialogs when both are available

***

### preferPanel?

> `optional` **preferPanel**: `boolean`

Defined in: [src/base/dialogs.tsx:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L66)

Prefer Panel even when Modal / jQuery UI is available

***

### providerOptions()?

> `optional` **providerOptions**: (`type`, `opt`) => `any`

Defined in: [src/base/dialogs.tsx:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L68)

Callback to get options specific to the dialog provider type

#### Parameters

##### type

[`DialogProviderType`](../type-aliases/DialogProviderType.md)

##### opt

`DialogOptions`

#### Returns

`any`

***

### scrollable?

> `optional` **scrollable**: `boolean`

Defined in: [src/base/dialogs.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L70)

Scrollable, sets content of the modal to scrollable, only for Bootstrap

***

### size?

> `optional` **size**: `"sm"` \| `"md"` \| `"lg"` \| `"xl"`

Defined in: [src/base/dialogs.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L72)

Size. Default is null for (500px) message dialogs, lg for normal dialogs

***

### title?

> `optional` **title**: `string`

Defined in: [src/base/dialogs.tsx:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L74)

Dialog title

***

### width?

> `optional` **width**: `number`

Defined in: [src/base/dialogs.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L76)

Only used for jQuery UI dialogs for backwards compatibility
