[@serenity-is/corelib](../../../../README.md) / [ValidationHelper](../README.md) / asyncSubmit

# Function: asyncSubmit()

> **asyncSubmit**(`form`, `validateBeforeSave`, `submitHandler`): `boolean`

Defined in: [src/compat/validation.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/validation.ts#L104)

Initiates an asynchronous submit flow: validates the form (if `validateBeforeSave` allows),
then triggers a `submit` event so the validator's `submitHandler` invokes `submitHandler`.
Sets `abortHandler` to allow cancellation via [validatorAbortHandler](../../../../functions/validatorAbortHandler.md).

## Parameters

### form

The form element or array-like wrapper containing the form.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### validateBeforeSave

() => `boolean`

Optional pre-validation callback; when it returns `false` the submit is cancelled.

### submitHandler

() => `void`

Callback invoked by the validator's `submitHandler` after validation passes.

## Returns

`boolean`

`true` if the submit was initiated; `false` if aborted or pre-validation failed.
