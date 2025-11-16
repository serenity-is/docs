[corelib](../README.md) / ConfirmDialogOptions

# Interface: ConfirmDialogOptions

Defined in: [src/base/dialogs.tsx:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L999)

Additional options for confirm dialog

## Extends

- [`MessageDialogOptions`](MessageDialogOptions.md)

## Properties

### autoDispose?

> `optional` **autoDispose**: `boolean`

Defined in: [src/base/dialogs.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L36)

Auto dispose dialog on close, default is true

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`autoDispose`](MessageDialogOptions.md#autodispose)

***

### autoOpen?

> `optional` **autoOpen**: `boolean`

Defined in: [src/base/dialogs.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L38)

True to auto open dialog

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`autoOpen`](MessageDialogOptions.md#autoopen)

***

### backdrop?

> `optional` **backdrop**: `boolean` \| `"static"`

Defined in: [src/base/dialogs.tsx:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L40)

Backdrop type, static to make it modal, e.g. can't be closed by clicking outside

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`backdrop`](MessageDialogOptions.md#backdrop)

***

### buttons?

> `optional` **buttons**: [`DialogButton`](DialogButton.md)[]

Defined in: [src/base/dialogs.tsx:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L42)

List of buttons to show on the dialog

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`buttons`](MessageDialogOptions.md#buttons)

***

### cancelButton?

> `optional` **cancelButton**: `boolean`

Defined in: [src/base/dialogs.tsx:1001](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1001)

True to also add a cancel button

***

### centered?

> `optional` **centered**: `boolean`

Defined in: [src/base/dialogs.tsx:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L44)

Vertically center modal

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`centered`](MessageDialogOptions.md#centered)

***

### closeButton?

> `optional` **closeButton**: `boolean`

Defined in: [src/base/dialogs.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L46)

Show close button, default is true

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`closeButton`](MessageDialogOptions.md#closebutton)

***

### closeOnEscape?

> `optional` **closeOnEscape**: `boolean`

Defined in: [src/base/dialogs.tsx:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L48)

Close dialog on escape key. Default is true for message dialogs.

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`closeOnEscape`](MessageDialogOptions.md#closeonescape)

***

### dialogClass?

> `optional` **dialogClass**: `string`

Defined in: [src/base/dialogs.tsx:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L50)

CSS class to use for all dialog types. Is added to the top ui-dialog, panel or modal element

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`dialogClass`](MessageDialogOptions.md#dialogclass)

***

### element?

> `optional` **element**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`element`) => `void`

Defined in: [src/base/dialogs.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L52)

Dialog content/body element, or callback that will populate the content element

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`element`](MessageDialogOptions.md#element)

***

### fade?

> `optional` **fade**: `boolean`

Defined in: [src/base/dialogs.tsx:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L54)

Enable / disable animation. Default is false for message dialogs, true for other dialogs

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`fade`](MessageDialogOptions.md#fade)

***

### fullScreen?

> `optional` **fullScreen**: `boolean` \| `"sm-down"` \| `"md-down"` \| `"lg-down"` \| `"xl-down"` \| `"xxl-down"`

Defined in: [src/base/dialogs.tsx:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L56)

Sets one of modal-fullscreen{-...-down} classes. Only used for bootstrap modals

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`fullScreen`](MessageDialogOptions.md#fullscreen)

***

### ~~htmlEncode?~~

> `optional` **htmlEncode**: `boolean`

Defined in: [src/base/dialogs.tsx:902](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L902)

#### Deprecated

HTML encode the message, default is true

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`htmlEncode`](MessageDialogOptions.md#htmlencode)

***

### modal?

> `optional` **modal**: `boolean`

Defined in: [src/base/dialogs.tsx:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L58)

Modal option for jQuery UI dialog compatibility only. Not to be confused with Bootstrap modal.

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`modal`](MessageDialogOptions.md#modal)

***

### onCancel()?

> `optional` **onCancel**: () => `void`

Defined in: [src/base/dialogs.tsx:1003](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1003)

Event handler for cancel button click

#### Returns

`void`

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

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`onClose`](MessageDialogOptions.md#onclose)

***

### onNo()?

> `optional` **onNo**: () => `void`

Defined in: [src/base/dialogs.tsx:1005](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L1005)

Event handler for no button click

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

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`onOpen`](MessageDialogOptions.md#onopen)

***

### preferBSModal?

> `optional` **preferBSModal**: `boolean`

Defined in: [src/base/dialogs.tsx:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L64)

Prefer Bootstrap modals to jQuery UI dialogs when both are available

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`preferBSModal`](MessageDialogOptions.md#preferbsmodal)

***

### preferPanel?

> `optional` **preferPanel**: `boolean`

Defined in: [src/base/dialogs.tsx:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L66)

Prefer Panel even when Modal / jQuery UI is available

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`preferPanel`](MessageDialogOptions.md#preferpanel)

***

### preWrap?

> `optional` **preWrap**: `boolean`

Defined in: [src/base/dialogs.tsx:904](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L904)

Wrap the message in a `<pre>` element, so that line endings are preserved, default is true

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`preWrap`](MessageDialogOptions.md#prewrap)

***

### providerOptions()?

> `optional` **providerOptions**: (`type`, `opt`) => `any`

Defined in: [src/base/dialogs.tsx:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L68)

Callback to get options specific to the dialog provider type

#### Parameters

##### type

[`DialogProviderType`](../type-aliases/DialogProviderType.md)

##### opt

[`DialogOptions`](DialogOptions.md)

#### Returns

`any`

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`providerOptions`](MessageDialogOptions.md#provideroptions)

***

### scrollable?

> `optional` **scrollable**: `boolean`

Defined in: [src/base/dialogs.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L70)

Scrollable, sets content of the modal to scrollable, only for Bootstrap

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`scrollable`](MessageDialogOptions.md#scrollable)

***

### size?

> `optional` **size**: `"sm"` \| `"md"` \| `"lg"` \| `"xl"`

Defined in: [src/base/dialogs.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L72)

Size. Default is null for (500px) message dialogs, lg for normal dialogs

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`size`](MessageDialogOptions.md#size)

***

### title?

> `optional` **title**: `string`

Defined in: [src/base/dialogs.tsx:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L74)

Dialog title

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`title`](MessageDialogOptions.md#title)

***

### width?

> `optional` **width**: `number`

Defined in: [src/base/dialogs.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L76)

Only used for jQuery UI dialogs for backwards compatibility

#### Inherited from

[`MessageDialogOptions`](MessageDialogOptions.md).[`width`](MessageDialogOptions.md#width)
