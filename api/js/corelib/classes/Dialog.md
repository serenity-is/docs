[corelib](../README.md) / Dialog

# Class: Dialog

Defined in: [src/base/dialogs.tsx:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L82)

Wrapper for different types of dialogs, including jQuery UI, Bootstrap modals, and Panels.

## Constructors

### Constructor

> **new Dialog**(`opt?`): `Dialog`

Defined in: [src/base/dialogs.tsx:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L92)

Creates a new dialog. The type of the dialog will be determined based on 
the availability of jQuery UI, Bootstrap, and the options provided.

#### Parameters

##### opt?

[`DialogOptions`](../interfaces/DialogOptions.md)

Optional configuration for the dialog

#### Returns

`Dialog`

## Properties

### defaults

> `static` **defaults**: [`DialogOptions`](../interfaces/DialogOptions.md)

Defined in: [src/base/dialogs.tsx:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L142)

Default set of dialog options

***

### messageDefaults

> `static` **messageDefaults**: [`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Defined in: [src/base/dialogs.tsx:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L156)

Default set of message dialog options

## Accessors

### result

#### Get Signature

> **get** **result**(): `string`

Defined in: [src/base/dialogs.tsx:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L185)

The result code of the button that is clicked. Also attached to the dialog element as data-dialog-result

##### Returns

`string`

***

### type

#### Get Signature

> **get** **type**(): [`DialogProviderType`](../type-aliases/DialogProviderType.md)

Defined in: [src/base/dialogs.tsx:366](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L366)

Returns the type of the dialog, or null if no dialog on the current element or if the element is null, e.g. dialog was disposed

##### Returns

[`DialogProviderType`](../type-aliases/DialogProviderType.md)

## Methods

### close()

#### Call Signature

> **close**(): `this`

Defined in: [src/base/dialogs.tsx:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L190)

Closes dialog setting the result to null

##### Returns

`this`

#### Call Signature

> **close**(`result`): `this`

Defined in: [src/base/dialogs.tsx:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L192)

Closes dialog with the result set to value

##### Parameters

###### result

`string`

##### Returns

`this`

***

### dispose()

> **dispose**(): `void`

Defined in: [src/base/dialogs.tsx:552](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L552)

Disposes the dialog, removing it from the DOM and unbinding all event handlers.

#### Returns

`void`

***

### getContentNode()

> **getContentNode**(): `HTMLElement`

Defined in: [src/base/dialogs.tsx:380](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L380)

Gets the body/content element of the dialog

#### Returns

`HTMLElement`

***

### getDialogNode()

> **getDialogNode**(): `HTMLElement`

Defined in: [src/base/dialogs.tsx:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L385)

Gets the dialog element of the dialog

#### Returns

`HTMLElement`

***

### getEventsNode()

> **getEventsNode**(): `HTMLElement`

Defined in: [src/base/dialogs.tsx:390](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L390)

Gets the node that receives events for the dialog. It's .ui-dialog-content, .modal, or .panel-body

#### Returns

`HTMLElement`

***

### getFooterNode()

> **getFooterNode**(): `HTMLElement`

Defined in: [src/base/dialogs.tsx:395](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L395)

Gets the footer element of the dialog

#### Returns

`HTMLElement`

***

### getHeaderNode()

> **getHeaderNode**(): `HTMLElement`

Defined in: [src/base/dialogs.tsx:400](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L400)

Gets the header element of the dialog

#### Returns

`HTMLElement`

***

### onClose()

> **onClose**(`handler`, `opt?`): `this`

Defined in: [src/base/dialogs.tsx:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L227)

Adds an event handler that is called when the dialog is closed. If the opt.before is true, the handler is called before the dialog is closed and
the closing can be cancelled by calling preventDefault on the event object.

#### Parameters

##### handler

(`result?`, `e?`) => `void`

The event handler function

##### opt?

Options to determine whether the handler should be called before the dialog is closed, and whether the handler should be called only once. 
The default for oneOff is true unless opt.before is true.

###### before?

`boolean`

###### oneOff?

`boolean`

#### Returns

`this`

The dialog instance

***

### onOpen()

> **onOpen**(`handler`, `opt?`): `this`

Defined in: [src/base/dialogs.tsx:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L283)

Adds an event handler that is called when the dialog is opened. If the second parameter is true, the handler is called before the dialog is opened and
the opening can be cancelled by calling preventDefault on the event object.
Note that if the dialog is not yet initialized, the first argument must be the body element of the dialog.

#### Parameters

##### handler

(`e?`) => `void`

The event handler function

##### opt?

Options to determine whether the handler should be called before the dialog is opened, and whether the handler should be called only once. 
The default for oneOff is true unless opt.before is true.

###### before?

`boolean`

###### oneOff?

`boolean`

#### Returns

`this`

The dialog instance

***

### open()

> **open**(): `Dialog`

Defined in: [src/base/dialogs.tsx:331](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L331)

Opens the dialog

#### Returns

`Dialog`

***

### title()

#### Call Signature

> **title**(): `string`

Defined in: [src/base/dialogs.tsx:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L353)

Gets the title text of the dialog

##### Returns

`string`

#### Call Signature

> **title**(`value`): `this`

Defined in: [src/base/dialogs.tsx:355](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L355)

Sets the title text of the dialog.

##### Parameters

###### value

`string`

##### Returns

`this`

***

### getInstance()

> `static` **getInstance**(`el`): `Dialog`

Defined in: [src/base/dialogs.tsx:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L177)

Gets the dialog instance for the specified element.

#### Parameters

##### el

The dialog body element (.s-Panel, .ui-dialog-content, or .modal-body) or the root element (.modal, .ui-dialog, .s-Panel)

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`Dialog`

The dialog instance, or null if the element is not a dialog.

***

### onClose()

> `static` **onClose**(`el`, `handler`, `opt?`): `void`

Defined in: [src/base/dialogs.tsx:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L252)

Adds an event handler that is called when the dialog is closed. If the opt.before is true, the handler is called before the dialog is closed and
the closing can be cancelled by calling preventDefault on the event object. Note that if the dialog is not yet initialized, the first argument must be
the body element of the dialog.

#### Parameters

##### el

The dialog body element (.s-Panel, .ui-dialog-content, or .modal-body)

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### handler

(`result?`, `e?`) => `void`

The event handler function

##### opt?

Options to determine whether the handler should be called before the dialog is closed, and whether the handler should be called only once. 
The default for oneOff is true unless opt.before is true.

###### before?

`boolean`

###### oneOff?

`boolean`

#### Returns

`void`

***

### onOpen()

> `static` **onOpen**(`el`, `handler`, `opt?`): `void`

Defined in: [src/base/dialogs.tsx:308](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L308)

Adds an event handler that is called when the dialog is opened. If the second parameter is true, the handler is called before the dialog is opened and
the opening can be cancelled by calling preventDefault on the event object. Note that if the dialog is not yet initialized, the first argument must be
the body element of the dialog.

#### Parameters

##### el

The dialog body element (.s-Panel, .ui-dialog-content, or .modal-body)

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### handler

(`e?`) => `void`

The event handler function

##### opt?

Options to determine whether the handler should be called before the dialog is opened, and whether the handler should be called only once. 
The default for oneOff is true unless opt.before is true.

###### before?

`boolean`

###### oneOff?

`boolean`

#### Returns

`void`

The dialog instance
