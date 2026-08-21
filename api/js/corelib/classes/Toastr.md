[@serenity-is/corelib](../README.md) / Toastr

# Class: Toastr

Defined in: [src/base/toastr2.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L113)

Toast notification manager. Provides `success` / `info` / `warning` / `error`
helpers, container management, and duplicate suppression. A singleton instance
is exported as the default export; custom instances can be constructed with
overriding [ToastrOptions](../type-aliases/ToastrOptions.md).

## Constructors

### Constructor

> **new Toastr**(`options?`): `Toastr`

Defined in: [src/base/toastr2.tsx:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L127)

Creates a new Toastr instance.

#### Parameters

##### options?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

Options merged over the global defaults / parent instance options.

#### Returns

`Toastr`

## Properties

### options

> **options**: [`ToastrOptions`](../type-aliases/ToastrOptions.md)

Defined in: [src/base/toastr2.tsx:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L121)

Effective options for this instance (merged from defaults and constructor overrides).

## Methods

### clear()

> **clear**(`options?`): `void`

Defined in: [src/base/toastr2.tsx:265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L265)

Clears all toasts from the container.

#### Parameters

##### options?

[`ToastContainerOptions`](../type-aliases/ToastContainerOptions.md)

Optional container options to resolve which container to clear.

#### Returns

`void`

***

### error()

> **error**(`message?`, `title?`, `opt?`): `HTMLElement`

Defined in: [src/base/toastr2.tsx:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L156)

Shows an error toast.

#### Parameters

##### message?

[`RenderableContent`](../type-aliases/RenderableContent.md)

Message content for the toast.

##### title?

[`RenderableContent`](../type-aliases/RenderableContent.md)

Optional title content.

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

Per-toast options that override instance defaults.

#### Returns

`HTMLElement`

The created toast element, or `null` if suppressed as a duplicate.

***

### getContainer()

> **getContainer**(`options?`, `create?`): `HTMLElement`

Defined in: [src/base/toastr2.tsx:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L139)

Gets the toast container element, optionally creating it.

#### Parameters

##### options?

[`ToastContainerOptions`](../type-aliases/ToastContainerOptions.md)

Container options that override instance defaults when resolving `containerId` / `target` / `positionClass`.

##### create?

`boolean` = `false`

When `true` creates the container if it does not exist.

#### Returns

`HTMLElement`

The container element, or `null` if not found and `create` is `false`.

***

### info()

> **info**(`message?`, `title?`, `opt?`): `HTMLElement`

Defined in: [src/base/toastr2.tsx:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L204)

Shows an info toast.

#### Parameters

##### message?

[`RenderableContent`](../type-aliases/RenderableContent.md)

Message content for the toast.

##### title?

[`RenderableContent`](../type-aliases/RenderableContent.md)

Optional title content.

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

Per-toast options that override instance defaults.

#### Returns

`HTMLElement`

The created toast element, or `null` if suppressed as a duplicate.

***

### publish()

> **publish**(`args`): `void`

Defined in: [src/base/toastr2.tsx:229](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L229)

Publishes a toast lifecycle event to the subscriber.

#### Parameters

##### args

`Toastr`

Toast state payload.

#### Returns

`void`

***

### removeToast()

> **removeToast**(`toastElement`, `options?`): `void`

Defined in: [src/base/toastr2.tsx:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L250)

Removes a single toast element from the DOM and cleans up the container if empty.

#### Parameters

##### toastElement

`HTMLElement`

The toast element to remove.

##### options?

[`ToastContainerOptions`](../type-aliases/ToastContainerOptions.md)

Optional container options used to locate the container for cleanup.

#### Returns

`void`

***

### subscribe()

> **subscribe**(`callback`): `void`

Defined in: [src/base/toastr2.tsx:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L221)

Subscribes to toast lifecycle events.

#### Parameters

##### callback

(`response`) => `void`

Function invoked with toast state on show / hide.

#### Returns

`void`

***

### success()

> **success**(`message?`, `title?`, `opt?`): `HTMLElement`

Defined in: [src/base/toastr2.tsx:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L188)

Shows a success toast.

#### Parameters

##### message?

[`RenderableContent`](../type-aliases/RenderableContent.md)

Message content for the toast.

##### title?

[`RenderableContent`](../type-aliases/RenderableContent.md)

Optional title content.

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

Per-toast options that override instance defaults.

#### Returns

`HTMLElement`

The created toast element, or `null` if suppressed as a duplicate.

***

### warning()

> **warning**(`message?`, `title?`, `opt?`): `HTMLElement`

Defined in: [src/base/toastr2.tsx:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L172)

Shows a warning toast.

#### Parameters

##### message?

[`RenderableContent`](../type-aliases/RenderableContent.md)

Message content for the toast.

##### title?

[`RenderableContent`](../type-aliases/RenderableContent.md)

Optional title content.

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

Per-toast options that override instance defaults.

#### Returns

`HTMLElement`

The created toast element, or `null` if suppressed as a duplicate.
