[@serenity-is/corelib](../README.md) / Dialog

# Class: Dialog

Wrapper for different types of dialogs, including jQuery UI, Bootstrap modals, and Panels.

## Constructors

### new Dialog()

> **new Dialog**(`opt`?): [`Dialog`](Dialog.md)

Creates a new dialog. The type of the dialog will be determined based on 
the availability of jQuery UI, Bootstrap, and the options provided.

#### Parameters

##### opt?

[`DialogOptions`](../interfaces/DialogOptions.md)

Optional configuration for the dialog

#### Returns

[`Dialog`](Dialog.md)

#### Defined in

[src/base/dialogs.tsx:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L91)

## Properties

### defaults

> `static` **defaults**: [`DialogOptions`](../interfaces/DialogOptions.md)

Default set of dialog options

#### Defined in

[src/base/dialogs.tsx:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L141)

***

### messageDefaults

> `static` **messageDefaults**: [`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Default set of message dialog options

#### Defined in

[src/base/dialogs.tsx:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L155)

## Accessors

### result

#### Get Signature

> **get** **result**(): `string`

The result code of the button that is clicked. Also attached to the dialog element as data-dialog-result

##### Returns

`string`

#### Defined in

[src/base/dialogs.tsx:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L184)

***

### type

#### Get Signature

> **get** **type**(): [`DialogProviderType`](../type-aliases/DialogProviderType.md)

Returns the type of the dialog, or null if no dialog on the current element or if the element is null, e.g. dialog was disposed

##### Returns

[`DialogProviderType`](../type-aliases/DialogProviderType.md)

#### Defined in

[src/base/dialogs.tsx:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L365)

## Methods

### close()

#### Call Signature

> **close**(): `this`

Closes dialog setting the result to null

##### Returns

`this`

##### Defined in

[src/base/dialogs.tsx:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L189)

#### Call Signature

> **close**(`result`): `this`

Closes dialog with the result set to value

##### Parameters

###### result

`string`

##### Returns

`this`

##### Defined in

[src/base/dialogs.tsx:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L191)

***

### dispose()

> **dispose**(): `void`

Disposes the dialog, removing it from the DOM and unbinding all event handlers.

#### Returns

`void`

#### Defined in

[src/base/dialogs.tsx:551](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L551)

***

### getContentNode()

> **getContentNode**(): `HTMLElement`

Gets the body/content element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[src/base/dialogs.tsx:379](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L379)

***

### getDialogNode()

> **getDialogNode**(): `HTMLElement`

Gets the dialog element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[src/base/dialogs.tsx:384](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L384)

***

### getEventsNode()

> **getEventsNode**(): `HTMLElement`

Gets the node that receives events for the dialog. It's .ui-dialog-content, .modal, or .panel-body

#### Returns

`HTMLElement`

#### Defined in

[src/base/dialogs.tsx:389](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L389)

***

### getFooterNode()

> **getFooterNode**(): `HTMLElement`

Gets the footer element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[src/base/dialogs.tsx:394](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L394)

***

### getHeaderNode()

> **getHeaderNode**(): `HTMLElement`

Gets the header element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[src/base/dialogs.tsx:399](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L399)

***

### onClose()

> **onClose**(`handler`, `opt`?): `this`

Adds an event handler that is called when the dialog is closed. If the opt.before is true, the handler is called before the dialog is closed and
the closing can be cancelled by calling preventDefault on the event object.

#### Parameters

##### handler

(`result`?, `e`?) => `void`

The event handler function

##### opt?

Options to determine whether the handler should be called before the dialog is closed, and whether the handler should be called only once. 
The default for oneOff is true unless opt.before is true.

###### opt.before

`boolean`

###### opt.oneOff

`boolean`

#### Returns

`this`

The dialog instance

#### Defined in

[src/base/dialogs.tsx:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L226)

***

### onOpen()

> **onOpen**(`handler`, `opt`?): `this`

Adds an event handler that is called when the dialog is opened. If the second parameter is true, the handler is called before the dialog is opened and
the opening can be cancelled by calling preventDefault on the event object.
Note that if the dialog is not yet initialized, the first argument must be the body element of the dialog.

#### Parameters

##### handler

(`e`?) => `void`

The event handler function

##### opt?

Options to determine whether the handler should be called before the dialog is opened, and whether the handler should be called only once. 
The default for oneOff is true unless opt.before is true.

###### opt.before

`boolean`

###### opt.oneOff

`boolean`

#### Returns

`this`

The dialog instance

#### Defined in

[src/base/dialogs.tsx:282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L282)

***

### open()

> **open**(): [`Dialog`](Dialog.md)

Opens the dialog

#### Returns

[`Dialog`](Dialog.md)

#### Defined in

[src/base/dialogs.tsx:330](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L330)

***

### title()

#### Call Signature

> **title**(): `string`

Gets the title text of the dialog

##### Returns

`string`

##### Defined in

[src/base/dialogs.tsx:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L352)

#### Call Signature

> **title**(`value`): `this`

Sets the title text of the dialog.

##### Parameters

###### value

`string`

##### Returns

`this`

##### Defined in

[src/base/dialogs.tsx:354](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L354)

***

### getInstance()

> `static` **getInstance**(`el`): [`Dialog`](Dialog.md)

Gets the dialog instance for the specified element.

#### Parameters

##### el

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

[`Dialog`](Dialog.md)

The dialog instance, or null if the element is not a dialog.

#### Defined in

[src/base/dialogs.tsx:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L176)

***

### onClose()

> `static` **onClose**(`el`, `handler`, `opt`?): `void`

Adds an event handler that is called when the dialog is closed. If the opt.before is true, the handler is called before the dialog is closed and
the closing can be cancelled by calling preventDefault on the event object. Note that if the dialog is not yet initialized, the first argument must be
the body element of the dialog.

#### Parameters

##### el

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### handler

(`result`?, `e`?) => `void`

The event handler function

##### opt?

Options to determine whether the handler should be called before the dialog is closed, and whether the handler should be called only once. 
The default for oneOff is true unless opt.before is true.

###### opt.before

`boolean`

###### opt.oneOff

`boolean`

#### Returns

`void`

#### Defined in

[src/base/dialogs.tsx:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L251)

***

### onOpen()

> `static` **onOpen**(`el`, `handler`, `opt`?): `void`

Adds an event handler that is called when the dialog is opened. If the second parameter is true, the handler is called before the dialog is opened and
the opening can be cancelled by calling preventDefault on the event object. Note that if the dialog is not yet initialized, the first argument must be
the body element of the dialog.

#### Parameters

##### el

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### handler

(`e`?) => `void`

The event handler function

##### opt?

Options to determine whether the handler should be called before the dialog is opened, and whether the handler should be called only once. 
The default for oneOff is true unless opt.before is true.

###### opt.before

`boolean`

###### opt.oneOff

`boolean`

#### Returns

`void`

The dialog instance

#### Defined in

[src/base/dialogs.tsx:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L307)
