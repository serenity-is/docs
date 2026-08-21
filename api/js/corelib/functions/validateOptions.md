[@serenity-is/corelib](../README.md) / validateOptions

# Function: validateOptions()

> **validateOptions**(`options?`): [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Defined in: [src/compat/validation.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/validation.ts#L25)

Merges caller-supplied [ValidatorOptions](../interfaces/ValidatorOptions.md) with Serenity's default validation behaviour.
Default handlers include: generic `errorPlacement` that targets `data-vx-id` / `.field` containers,
a `submitHandler` that prevents native submit, an `invalidHandler` that shows FormValidationTexts.InvalidFormMessage,
expands collapsed categories/tabs and shows a tooltip on the first error, and a `success` handler that marks labels as `checked`.
Caller options override the defaults via `Object.assign`.

## Parameters

### options?

[`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Optional overrides to merge on top of the defaults.

## Returns

[`ValidatorOptions`](../interfaces/ValidatorOptions.md)

A new [ValidatorOptions](../interfaces/ValidatorOptions.md) object with defaults applied.
