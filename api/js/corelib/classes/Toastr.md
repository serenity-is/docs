[@serenity-is/corelib](../README.md) / Toastr

# Class: Toastr

## Constructors

### new Toastr()

> **new Toastr**(`options`?): [`Toastr`](Toastr.md)

#### Parameters

##### options?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Returns

[`Toastr`](Toastr.md)

#### Defined in

[src/base/toastr2.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L95)

## Properties

### options

> **options**: [`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Defined in

[src/base/toastr2.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L93)

## Methods

### clear()

> **clear**(`options`?): `void`

#### Parameters

##### options?

[`ToastContainerOptions`](../type-aliases/ToastContainerOptions.md)

#### Returns

`void`

#### Defined in

[src/base/toastr2.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L204)

***

### error()

> **error**(`message`?, `title`?, `opt`?): `HTMLElement`

#### Parameters

##### message?

`string`

##### title?

`string`

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Returns

`HTMLElement`

#### Defined in

[src/base/toastr2.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L121)

***

### getContainer()

> **getContainer**(`options`?, `create`?): `HTMLElement`

#### Parameters

##### options?

[`ToastContainerOptions`](../type-aliases/ToastContainerOptions.md)

##### create?

`boolean` = `false`

#### Returns

`HTMLElement`

#### Defined in

[src/base/toastr2.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L101)

***

### info()

> **info**(`message`?, `title`?, `opt`?): `HTMLElement`

#### Parameters

##### message?

`string`

##### title?

`string`

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Returns

`HTMLElement`

#### Defined in

[src/base/toastr2.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L160)

***

### publish()

> **publish**(`args`): `void`

#### Parameters

##### args

[`Toastr`](Toastr.md)

#### Returns

`void`

#### Defined in

[src/base/toastr2.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L177)

***

### removeToast()

> **removeToast**(`toastElement`, `options`?): `void`

#### Parameters

##### toastElement

`HTMLElement`

##### options?

[`ToastContainerOptions`](../type-aliases/ToastContainerOptions.md)

#### Returns

`void`

#### Defined in

[src/base/toastr2.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L193)

***

### subscribe()

> **subscribe**(`callback`): `void`

#### Parameters

##### callback

(`response`) => `void`

#### Returns

`void`

#### Defined in

[src/base/toastr2.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L173)

***

### success()

> **success**(`message`?, `title`?, `opt`?): `HTMLElement`

#### Parameters

##### message?

`string`

##### title?

`string`

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Returns

`HTMLElement`

#### Defined in

[src/base/toastr2.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L147)

***

### warning()

> **warning**(`message`?, `title`?, `opt`?): `HTMLElement`

#### Parameters

##### message?

`string`

##### title?

`string`

##### opt?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

#### Returns

`HTMLElement`

#### Defined in

[src/base/toastr2.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L134)
