[@serenity-is/corelib](../README.md) / Dialog

# Class: Dialog

Defined in: [src/base/dialogs.tsx:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L117)

Unified wrapper over jQuery UI dialogs, Bootstrap modals, and Serenity inline panels.

## Remarks

Provider selection is automatic: `preferPanel` wins, otherwise jQuery UI vs. Bootstrap
is chosen via [hasUIDialog](../functions/hasUIDialog.md), [hasBSModal](../functions/hasBSModal.md), and `preferBSModal`.
Lifecycle events (`panel*`, `dialog*`, `show.bs.modal` / `hide.bs.modal`) are normalized
so that [Dialog.onOpen](#onopen-2) / [Dialog.onClose](#onclose-2) work uniformly across providers.

## Example

```ts
const dlg = new Dialog({
  title: "Hello",
  element: el => el.append("Content"),
  buttons: [okDialogButton(), cancelDialogButton()]
});
dlg.onClose(result => console.log(result));
```

## Constructors

### Constructor

> **new Dialog**(`opt?`): `Dialog`

Defined in: [src/base/dialogs.tsx:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L130)

Creates a new dialog.

#### Parameters

##### opt?

[`DialogOptions`](../interfaces/DialogOptions.md)

Configuration for the dialog; merged over [Dialog.defaults](#defaults).

#### Returns

`Dialog`

#### Remarks

The concrete provider (panel / jQuery UI / Bootstrap) is resolved from availability
and `preferPanel` / `preferBSModal` flags.

## Properties

### defaults

> `static` **defaults**: [`DialogOptions`](../interfaces/DialogOptions.md)

Defined in: [src/base/dialogs.tsx:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L180)

Default options applied to every Dialog before caller-supplied `opt` is merged.

***

### messageDefaults

> `static` **messageDefaults**: [`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

Defined in: [src/base/dialogs.tsx:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L194)

Default options applied to helper message dialogs (`alertDialog`, `confirmDialog`, etc.).

## Accessors

### result

#### Get Signature

> **get** **result**(): `string`

Defined in: [src/base/dialogs.tsx:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L227)

Result code of the last button that closed the dialog.

##### Remarks

Mirrors `element.dataset.dialogResult`; survives disposal via the fallback field.

##### Returns

`string`

The result string (e.g. `"ok"`, `"yes"`, `"cancel"`) or `null`/`undefined` when not yet closed.

***

### type

#### Get Signature

> **get** **type**(): [`DialogProviderType`](../type-aliases/DialogProviderType.md)

Defined in: [src/base/dialogs.tsx:422](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L422)

Identifies the backing provider for this instance.

##### Returns

[`DialogProviderType`](../type-aliases/DialogProviderType.md)

`"bsmodal"`, `"uidialog"`, or `"panel"`, or `null` when the element is not attached or the dialog was disposed.

## Methods

### close()

#### Call Signature

> **close**(): `this`

Defined in: [src/base/dialogs.tsx:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L232)

Closes the dialog and reports a `null` result.

##### Returns

`this`

The dialog instance for chaining.

#### Call Signature

> **close**(`result`): `this`

Defined in: [src/base/dialogs.tsx:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L238)

Closes the dialog with an explicit result code.

##### Parameters

###### result

`string`

Value stored in `dataset.dialogResult` and passed to `onClose` handlers.

##### Returns

`this`

The dialog instance for chaining.

***

### dispose()

> **dispose**(): `void`

Defined in: [src/base/dialogs.tsx:625](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L625)

Disposes the dialog, removing it from the DOM and unbinding event handlers.

#### Returns

`void`

#### Remarks

Handles all three providers: destroys a jQuery UI dialog, disposes a Bootstrap modal instance, or removes the panel markup. Falls back to plain DOM removal when no library is present. Safe to call multiple times.

***

### getContentNode()

> **getContentNode**(): `HTMLElement`

Defined in: [src/base/dialogs.tsx:439](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L439)

Gets the body / content node of the dialog (`.modal-body`, `.panel-body`, or `.ui-dialog-content`).

#### Returns

`HTMLElement`

The content element, or the raw `el` supplied at construction.

***

### getDialogNode()

> **getDialogNode**(): `HTMLElement`

Defined in: [src/base/dialogs.tsx:447](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L447)

Gets the root dialog element (`.modal`, `.ui-dialog`, or `.s-Panel`).

#### Returns

`HTMLElement`

The root element, or `null` when not found.

***

### getEventsNode()

> **getEventsNode**(): `HTMLElement`

Defined in: [src/base/dialogs.tsx:455](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L455)

Gets the node that receives open/close lifecycle events (`.modal`, `.panel-body`, or `.ui-dialog-content`).

#### Returns

`HTMLElement`

The events node, or a fallback lookup via the root element.

***

### getFooterNode()

> **getFooterNode**(): `HTMLElement`

Defined in: [src/base/dialogs.tsx:463](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L463)

Gets the footer element (`.modal-footer`, `.panel-footer`, or `.ui-dialog-footer`), if present.

#### Returns

`HTMLElement`

The footer element or `null` when there is none.

***

### getHeaderNode()

> **getHeaderNode**(): `HTMLElement`

Defined in: [src/base/dialogs.tsx:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L471)

Gets the header element (`.modal-header`, `.panel-titlebar`, or `.ui-dialog-titlebar`), if present.

#### Returns

`HTMLElement`

The header element or `null` when there is none.

***

### onClose()

> **onClose**(`handler`, `opt?`): `this`

Defined in: [src/base/dialogs.tsx:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L273)

Subscribes to the dialog close event.

#### Parameters

##### handler

(`result?`, `e?`) => `void`

Callback invoked with the dialog result and the close event. Call `preventDefault()` on the event to cancel closing when `opt.before` is `true`.

##### opt?

Subscription options.

###### before?

`boolean`

When `true`, listens to the cancellable *before-close* event (`panelbeforeclose` / `dialogbeforeclose` / `hide.bs.modal`).

###### oneOff?

`boolean`

When `true`, the handler is removed after the first invocation. Defaults to `true` unless `before` is `true`.

#### Returns

`this`

The dialog instance for chaining.

***

### onOpen()

> **onOpen**(`handler`, `opt?`): `this`

Defined in: [src/base/dialogs.tsx:327](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L327)

Subscribes to the dialog open event.

#### Parameters

##### handler

(`e?`) => `void`

Callback invoked when the dialog is opened; `preventDefault()` cancels the open when `opt.before` is `true`.

##### opt?

Subscription options.

###### before?

`boolean`

When `true`, listens to the cancellable *before-open* event (`panelbeforeopen` / `dialogbeforeopen` / `show.bs.modal`).

###### oneOff?

`boolean`

Auto-remove after first invocation. Defaults to `true` unless `before` is `true`.

#### Returns

`this`

The dialog instance for chaining.

***

### open()

> **open**(): `Dialog`

Defined in: [src/base/dialogs.tsx:377](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L377)

Opens the dialog.

#### Returns

`Dialog`

The dialog instance for chaining.

#### Remarks

Dispatches the provider-specific show command (`openPanel`, `jQuery.dialog("open")`, or `bootstrap.Modal.show`).

***

### title()

#### Call Signature

> **title**(): `string`

Defined in: [src/base/dialogs.tsx:402](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L402)

Gets the current title text of the dialog.

##### Returns

`string`

The header title text, or `undefined` when the dialog has no header.

#### Call Signature

> **title**(`value`): `this`

Defined in: [src/base/dialogs.tsx:408](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L408)

Sets the title text of the dialog.

##### Parameters

###### value

`string`

New title text to display in the header.

##### Returns

`this`

The dialog instance for chaining.

***

### getInstance()

> `static` **getInstance**(`el`): `Dialog`

Defined in: [src/base/dialogs.tsx:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L215)

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

Defined in: [src/base/dialogs.tsx:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L297)

Static helper that subscribes to the close event for a dialog element that may not yet be instantiated.

#### Parameters

##### el

Dialog body element (`.s-Panel`, `.ui-dialog-content`, or `.modal-body`) or an array-like wrapper.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### handler

(`result?`, `e?`) => `void`

Callback invoked with the dialog result and the close event; `preventDefault()` cancels the close when `opt.before` is `true`.

##### opt?

Subscription options.

###### before?

`boolean`

Listen to the cancellable *before-close* event.

###### oneOff?

`boolean`

Auto-remove after first invocation. Defaults to `true` unless `before` is `true`.

#### Returns

`void`

***

### onOpen()

> `static` **onOpen**(`el`, `handler`, `opt?`): `void`

Defined in: [src/base/dialogs.tsx:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L350)

Static helper that subscribes to the open event for a dialog element that may not yet be instantiated.

#### Parameters

##### el

Dialog body element (`.s-Panel`, `.ui-dialog-content`, or `.modal-body`) or an array-like wrapper.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### handler

(`e?`) => `void`

Callback invoked when the dialog is opened; `preventDefault()` cancels the open when `opt.before` is `true`.

##### opt?

Subscription options.

###### before?

`boolean`

Listen to the cancellable *before-open* event.

###### oneOff?

`boolean`

Auto-remove after first invocation. Defaults to `true` unless `before` is `true`.

#### Returns

`void`
