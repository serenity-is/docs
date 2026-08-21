[@serenity-is/corelib](../README.md) / validatorAbortHandler

# Function: validatorAbortHandler()

> **validatorAbortHandler**(`validator`): `void`

Defined in: [src/compat/validation.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/validation.ts#L9)

Abort handler that disables further validation submission for the given validator.
Clears `settings.abortHandler` and replaces `settings.submitHandler` with a no-op that returns `false`.
Intended for use as `ValidatorOptions.abortHandler` during async form submission flows.

## Parameters

### validator

[`Validator`](../classes/Validator.md)

The [Validator](../classes/Validator.md) instance whose settings should be reset to abort state.

## Returns

`void`
