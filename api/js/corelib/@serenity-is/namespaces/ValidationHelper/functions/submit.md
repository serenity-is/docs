[@serenity-is/corelib](../../../../README.md) / [ValidationHelper](../README.md) / submit

# Function: submit()

> **submit**(`form`, `validateBeforeSave`, `submitHandler`): `boolean`

Defined in: [src/compat/validation.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/validation.ts#L131)

Synchronously validates the form and, if valid, invokes `submitHandler` directly.
Unlike [ValidationHelper.asyncSubmit](asyncSubmit.md), this path calls `validator.form()` inline
instead of triggering a `submit` event.

## Parameters

### form

The form element or array-like wrapper containing the form.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### validateBeforeSave

() => `boolean`

Optional pre-validation callback; when it returns `false` the submit is cancelled.

### submitHandler

() => `void`

Callback invoked when the form is valid.

## Returns

`boolean`

`true` if validation passed and `submitHandler` was invoked; `false` otherwise.
