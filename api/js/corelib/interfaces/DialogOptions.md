[@serenity-is/corelib](../README.md) / DialogOptions

# Interface: DialogOptions

Options that apply to all dialog types

## Extended by

- [`MessageDialogOptions`](MessageDialogOptions.md)

## Properties

### autoDispose?

> `optional` **autoDispose**: `boolean`

Auto dispose dialog on close, default is true

#### Defined in

[src/base/dialogs.tsx:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L35)

***

### autoOpen?

> `optional` **autoOpen**: `boolean`

True to auto open dialog

#### Defined in

[src/base/dialogs.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L37)

***

### backdrop?

> `optional` **backdrop**: `boolean` \| `"static"`

Backdrop type, static to make it modal, e.g. can't be closed by clicking outside

#### Defined in

[src/base/dialogs.tsx:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L39)

***

### buttons?

> `optional` **buttons**: [`DialogButton`](DialogButton.md)[]

List of buttons to show on the dialog

#### Defined in

[src/base/dialogs.tsx:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L41)

***

### centered?

> `optional` **centered**: `boolean`

Vertically center modal

#### Defined in

[src/base/dialogs.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L43)

***

### closeButton?

> `optional` **closeButton**: `boolean`

Show close button, default is true

#### Defined in

[src/base/dialogs.tsx:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L45)

***

### closeOnEscape?

> `optional` **closeOnEscape**: `boolean`

Close dialog on escape key. Default is true for message dialogs.

#### Defined in

[src/base/dialogs.tsx:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L47)

***

### dialogClass?

> `optional` **dialogClass**: `string`

CSS class to use for all dialog types. Is added to the top ui-dialog, panel or modal element

#### Defined in

[src/base/dialogs.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L49)

***

### element?

> `optional` **element**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`element`) => `void`

Dialog content/body element, or callback that will populate the content element

#### Defined in

[src/base/dialogs.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L51)

***

### fade?

> `optional` **fade**: `boolean`

Enable / disable animation. Default is false for message dialogs, true for other dialogs

#### Defined in

[src/base/dialogs.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L53)

***

### fullScreen?

> `optional` **fullScreen**: `boolean` \| `"sm-down"` \| `"md-down"` \| `"lg-down"` \| `"xl-down"` \| `"xxl-down"`

Sets one of modal-fullscreen{-...-down} classes. Only used for bootstrap modals

#### Defined in

[src/base/dialogs.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L55)

***

### modal?

> `optional` **modal**: `boolean`

Modal option for jQuery UI dialog compatibility only. Not to be confused with Bootstrap modal.

#### Defined in

[src/base/dialogs.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L57)

***

### onClose()?

> `optional` **onClose**: (`result`, `e`?) => `void`

Event handler that is called when dialog is closed

#### Parameters

##### result

`string`

##### e?

`Event`

#### Returns

`void`

#### Defined in

[src/base/dialogs.tsx:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L61)

***

### onOpen()?

> `optional` **onOpen**: (`e`?) => `void`

Event handler that is called when dialog is opened

#### Parameters

##### e?

`Event`

#### Returns

`void`

#### Defined in

[src/base/dialogs.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L59)

***

### preferBSModal?

> `optional` **preferBSModal**: `boolean`

Prefer Bootstrap modals to jQuery UI dialogs when both are available

#### Defined in

[src/base/dialogs.tsx:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L63)

***

### preferPanel?

> `optional` **preferPanel**: `boolean`

Prefer Panel even when Modal / jQuery UI is available

#### Defined in

[src/base/dialogs.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L65)

***

### providerOptions()?

> `optional` **providerOptions**: (`type`, `opt`) => `any`

Callback to get options specific to the dialog provider type

#### Parameters

##### type

[`DialogProviderType`](../type-aliases/DialogProviderType.md)

##### opt

[`DialogOptions`](DialogOptions.md)

#### Returns

`any`

#### Defined in

[src/base/dialogs.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L67)

***

### scrollable?

> `optional` **scrollable**: `boolean`

Scrollable, sets content of the modal to scrollable, only for Bootstrap

#### Defined in

[src/base/dialogs.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L69)

***

### size?

> `optional` **size**: `"sm"` \| `"md"` \| `"lg"` \| `"xl"`

Size. Default is null for (500px) message dialogs, lg for normal dialogs

#### Defined in

[src/base/dialogs.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L71)

***

### title?

> `optional` **title**: `string`

Dialog title

#### Defined in

[src/base/dialogs.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L73)

***

### width?

> `optional` **width**: `number`

Only used for jQuery UI dialogs for backwards compatibility

#### Defined in

[src/base/dialogs.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L75)
