[@serenity-is/corelib](../README.md) / MessageDialogOptions

# Interface: MessageDialogOptions

Options that apply to all message dialog types

## Extends

- [`DialogOptions`](DialogOptions.md)

## Extended by

- [`ConfirmDialogOptions`](ConfirmDialogOptions.md)

## Properties

### autoDispose?

> `optional` **autoDispose**: `boolean`

Auto dispose dialog on close, default is true

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`autoDispose`](DialogOptions.md#autodispose)

#### Defined in

[src/base/dialogs.tsx:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L35)

***

### autoOpen?

> `optional` **autoOpen**: `boolean`

True to auto open dialog

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`autoOpen`](DialogOptions.md#autoopen)

#### Defined in

[src/base/dialogs.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L37)

***

### backdrop?

> `optional` **backdrop**: `boolean` \| `"static"`

Backdrop type, static to make it modal, e.g. can't be closed by clicking outside

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`backdrop`](DialogOptions.md#backdrop)

#### Defined in

[src/base/dialogs.tsx:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L39)

***

### buttons?

> `optional` **buttons**: [`DialogButton`](DialogButton.md)[]

List of buttons to show on the dialog

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`buttons`](DialogOptions.md#buttons)

#### Defined in

[src/base/dialogs.tsx:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L41)

***

### centered?

> `optional` **centered**: `boolean`

Vertically center modal

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`centered`](DialogOptions.md#centered)

#### Defined in

[src/base/dialogs.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L43)

***

### closeButton?

> `optional` **closeButton**: `boolean`

Show close button, default is true

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`closeButton`](DialogOptions.md#closebutton)

#### Defined in

[src/base/dialogs.tsx:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L45)

***

### closeOnEscape?

> `optional` **closeOnEscape**: `boolean`

Close dialog on escape key. Default is true for message dialogs.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`closeOnEscape`](DialogOptions.md#closeonescape)

#### Defined in

[src/base/dialogs.tsx:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L47)

***

### dialogClass?

> `optional` **dialogClass**: `string`

CSS class to use for all dialog types. Is added to the top ui-dialog, panel or modal element

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`dialogClass`](DialogOptions.md#dialogclass)

#### Defined in

[src/base/dialogs.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L49)

***

### element?

> `optional` **element**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`element`) => `void`

Dialog content/body element, or callback that will populate the content element

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`element`](DialogOptions.md#element)

#### Defined in

[src/base/dialogs.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L51)

***

### fade?

> `optional` **fade**: `boolean`

Enable / disable animation. Default is false for message dialogs, true for other dialogs

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`fade`](DialogOptions.md#fade)

#### Defined in

[src/base/dialogs.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L53)

***

### fullScreen?

> `optional` **fullScreen**: `boolean` \| `"sm-down"` \| `"md-down"` \| `"lg-down"` \| `"xl-down"` \| `"xxl-down"`

Sets one of modal-fullscreen{-...-down} classes. Only used for bootstrap modals

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`fullScreen`](DialogOptions.md#fullscreen)

#### Defined in

[src/base/dialogs.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L55)

***

### htmlEncode?

> `optional` **htmlEncode**: `boolean`

HTML encode the message, default is true

#### Defined in

[src/base/dialogs.tsx:895](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L895)

***

### modal?

> `optional` **modal**: `boolean`

Modal option for jQuery UI dialog compatibility only. Not to be confused with Bootstrap modal.

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`modal`](DialogOptions.md#modal)

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

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`onClose`](DialogOptions.md#onclose)

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

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`onOpen`](DialogOptions.md#onopen)

#### Defined in

[src/base/dialogs.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L59)

***

### preferBSModal?

> `optional` **preferBSModal**: `boolean`

Prefer Bootstrap modals to jQuery UI dialogs when both are available

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`preferBSModal`](DialogOptions.md#preferbsmodal)

#### Defined in

[src/base/dialogs.tsx:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L63)

***

### preferPanel?

> `optional` **preferPanel**: `boolean`

Prefer Panel even when Modal / jQuery UI is available

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`preferPanel`](DialogOptions.md#preferpanel)

#### Defined in

[src/base/dialogs.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L65)

***

### preWrap?

> `optional` **preWrap**: `boolean`

Wrap the message in a `<pre>` element, so that line endings are preserved, default is true

#### Defined in

[src/base/dialogs.tsx:897](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L897)

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

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`providerOptions`](DialogOptions.md#provideroptions)

#### Defined in

[src/base/dialogs.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L67)

***

### scrollable?

> `optional` **scrollable**: `boolean`

Scrollable, sets content of the modal to scrollable, only for Bootstrap

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`scrollable`](DialogOptions.md#scrollable)

#### Defined in

[src/base/dialogs.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L69)

***

### size?

> `optional` **size**: `"sm"` \| `"md"` \| `"lg"` \| `"xl"`

Size. Default is null for (500px) message dialogs, lg for normal dialogs

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`size`](DialogOptions.md#size)

#### Defined in

[src/base/dialogs.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L71)

***

### title?

> `optional` **title**: `string`

Dialog title

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`title`](DialogOptions.md#title)

#### Defined in

[src/base/dialogs.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L73)

***

### width?

> `optional` **width**: `number`

Only used for jQuery UI dialogs for backwards compatibility

#### Inherited from

[`DialogOptions`](DialogOptions.md).[`width`](DialogOptions.md#width)

#### Defined in

[src/base/dialogs.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L75)
