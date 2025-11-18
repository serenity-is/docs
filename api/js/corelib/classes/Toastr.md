[@serenity-is/corelib](../README.md) / Toastr

# Class: Toastr

Defined in: [src/base/toastr2.tsx:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L85)

## Constructors

### Constructor

> **new Toastr**(`options?`): `Toastr`

Defined in: [src/base/toastr2.tsx:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L94)

#### Parameters

##### options?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Returns

`Toastr`

## Properties

### options

> **options**: [`ToastrOptions`](../type-aliases/ToastrOptions.md)

Defined in: [src/base/toastr2.tsx:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L92)

## Methods

### clear()

> **clear**(`options?`): `void`

Defined in: [src/base/toastr2.tsx:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L181)

#### Parameters

##### options?

[`ToastContainerOptions`](../type-aliases/ToastContainerOptions.md)

#### Returns

`void`

***

### error()

> **error**(`message?`, `title?`, `opt?`): `HTMLElement`

Defined in: [src/base/toastr2.tsx:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L110)

#### Parameters

##### message?

[`RenderableContent`](../type-aliases/RenderableContent.md)

##### title?

[`RenderableContent`](../type-aliases/RenderableContent.md)

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Returns

`HTMLElement`

***

### getContainer()

> **getContainer**(`options?`, `create?`): `HTMLElement`

Defined in: [src/base/toastr2.tsx:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L100)

#### Parameters

##### options?

[`ToastContainerOptions`](../type-aliases/ToastContainerOptions.md)

##### create?

`boolean` = `false`

#### Returns

`HTMLElement`

***

### info()

> **info**(`message?`, `title?`, `opt?`): `HTMLElement`

Defined in: [src/base/toastr2.tsx:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L137)

#### Parameters

##### message?

[`RenderableContent`](../type-aliases/RenderableContent.md)

##### title?

[`RenderableContent`](../type-aliases/RenderableContent.md)

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Returns

`HTMLElement`

***

### publish()

> **publish**(`args`): `void`

Defined in: [src/base/toastr2.tsx:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L154)

#### Parameters

##### args

`Toastr`

#### Returns

`void`

***

### removeToast()

> **removeToast**(`toastElement`, `options?`): `void`

Defined in: [src/base/toastr2.tsx:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L170)

#### Parameters

##### toastElement

`HTMLElement`

##### options?

[`ToastContainerOptions`](../type-aliases/ToastContainerOptions.md)

#### Returns

`void`

***

### subscribe()

> **subscribe**(`callback`): `void`

Defined in: [src/base/toastr2.tsx:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L150)

#### Parameters

##### callback

(`response`) => `void`

#### Returns

`void`

***

### success()

> **success**(`message?`, `title?`, `opt?`): `HTMLElement`

Defined in: [src/base/toastr2.tsx:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L128)

#### Parameters

##### message?

[`RenderableContent`](../type-aliases/RenderableContent.md)

##### title?

[`RenderableContent`](../type-aliases/RenderableContent.md)

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Returns

`HTMLElement`

***

### warning()

> **warning**(`message?`, `title?`, `opt?`): `HTMLElement`

Defined in: [src/base/toastr2.tsx:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L119)

#### Parameters

##### message?

[`RenderableContent`](../type-aliases/RenderableContent.md)

##### title?

[`RenderableContent`](../type-aliases/RenderableContent.md)

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Returns

`HTMLElement`
