[@serenity-is/corelib](../README.md) / ValidatorOptions

# Interface: ValidatorOptions

Defined in: [src/base/validator.tsx:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L90)

Configuration for a [Validator](../classes/Validator.md) instance. Mirrors jQuery Validation plugin options
with Serenity-specific extensions.

## Properties

### debug?

> `optional` **debug**: `boolean`

Defined in: [src/base/validator.tsx:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L92)

When `true` enables debug logging and prevents form submit.

***

### errorClass?

> `optional` **errorClass**: `string`

Defined in: [src/base/validator.tsx:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L99)

Use this class to create error labels, to look for existing error labels and to add it to invalid elements.

default: "error"

***

### errorElement?

> `optional` **errorElement**: `string`

Defined in: [src/base/validator.tsx:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L107)

Use this element type to create error messages and to look for existing error messages. The default, "label",
has the advantage of creating a meaningful link between error message and invalid field using the for attribute (which is always used, regardless of element type).

default: "label"

***

### focusInvalid?

> `optional` **focusInvalid**: `boolean`

Defined in: [src/base/validator.tsx:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L123)

Focus the last active or first invalid element on submit via validator.focusInvalid(). The last active element is the one
that had focus when the form was submitted, avoiding stealing its focus. If there was no element focused, the first one
in the form gets it, unless this option is turned off.

default: true

***

### ignore?

> `optional` **ignore**: `string`

Defined in: [src/base/validator.tsx:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L136)

Elements to ignore when validating, simply filtering them out. CSS not-method is used, therefore everything that is
accepted by not() can be passed as this option. Inputs of type submit and reset are always ignored, so are disabled elements.

***

### messages?

> `optional` **messages**: `Record`\<`string`, `string` \| `Record`\<`string`, `string`\>\>

Defined in: [src/base/validator.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L157)

Key/value pairs defining custom messages. Key is the name of an element, value is the message to display for that element. Instead
of a plain message, another map with specific messages for each rule can be used. Overrides the title attribute of an element or
the default message for the method (in that order). Each message can be a String or a Callback. The callback is called in the scope
of the validator, with the rule's parameters as the first argument and the element as the second, and must return a String to display
as the message.

default: the default message for the method used

***

### normalizer()?

> `optional` **normalizer**: (`val`, `element`) => `string`

Defined in: [src/base/validator.tsx:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L165)

Optional normalizer that transforms the raw field value before validation.

#### Parameters

##### val

[`ValidationValue`](../type-aliases/ValidationValue.md)

Raw field value.

##### element

[`ValidatableElement`](ValidatableElement.md)

Element being validated.

#### Returns

`string`

Normalized string value.

***

### onclick?

> `optional` **onclick**: `boolean` \| [`ValidateEventDelegate`](../type-aliases/ValidateEventDelegate.md)

Defined in: [src/base/validator.tsx:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L173)

Boolean or Function. Validate checkboxes and radio buttons on click. Set to false to disable.

Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

***

### onfocusin?

> `optional` **onfocusin**: [`ValidateEventDelegate`](../type-aliases/ValidateEventDelegate.md)

Defined in: [src/base/validator.tsx:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L180)

Function. Validate elements when user focuses in. If omitted hides all other fields marked as invalid.

Set to a custom Function to decide for yourself when to run validation.

***

### onfocusout?

> `optional` **onfocusout**: [`ValidateEventDelegate`](../type-aliases/ValidateEventDelegate.md)

Defined in: [src/base/validator.tsx:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L188)

Boolean or Function. Validate elements (except checkboxes/radio buttons) on blur. If nothing is entered, all rules are skipped, except when the field was already marked as invalid.

Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

***

### onkeyup?

> `optional` **onkeyup**: [`ValidateEventDelegate`](../type-aliases/ValidateEventDelegate.md)

Defined in: [src/base/validator.tsx:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L197)

Boolean or Function. Validate elements on keyup. As long as the field is not marked as invalid, nothing happens.
Otherwise, all rules are checked on each key up event. Set to false to disable.

Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

***

### onsubmit?

> `optional` **onsubmit**: `boolean`

Defined in: [src/base/validator.tsx:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L206)

Validate the form on submit. Set to false to use only other events for validation.
Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

default: true

***

### pendingClass?

> `optional` **pendingClass**: `string`

Defined in: [src/base/validator.tsx:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L212)

CSS class applied to elements with a pending async validation.
default: `"pending"`

***

### rules?

> `optional` **rules**: [`ValidationRulesMap`](ValidationRulesMap.md)

Defined in: [src/base/validator.tsx:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L217)

Static rule definitions keyed by field name.

***

### success?

> `optional` **success**: `string` \| (`label`, `validatedInput`) => `void`

Defined in: [src/base/validator.tsx:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L245)

String or Function. If specified, the error label is displayed to show a valid element. If a String is given, it is added as
a class to the label. If a Function is given, it is called with the label and the validated input (as a DOM element).
The label can be used to add a text like "ok!".

***

### validClass?

> `optional` **validClass**: `string`

Defined in: [src/base/validator.tsx:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L259)

This class is added to an element after it was validated and considered valid.

default: "valid"

## Methods

### abortHandler()?

> `optional` **abortHandler**(`validator`): `void`

Defined in: [src/base/validator.tsx:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L232)

Called when a pending async validation is aborted (e.g. due to form reset or re-validation).

#### Parameters

##### validator

[`Validator`](../classes/Validator.md)

Owning validator instance.

#### Returns

`void`

***

### errorPlacement()?

> `optional` **errorPlacement**(`error`, `element`, `validator`): `void`

Defined in: [src/base/validator.tsx:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L114)

Customize placement of created error labels. First argument: The created error label. Second argument: The invalid element.

default: Places the error label after the invalid element

#### Parameters

##### error

`HTMLElement`

##### element

[`ValidatableElement`](ValidatableElement.md)

##### validator

[`Validator`](../classes/Validator.md)

#### Returns

`void`

***

### highlight()?

> `optional` **highlight**(`element`, `errorClass`, `validClass`): `void`

Defined in: [src/base/validator.tsx:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L130)

How to highlight invalid fields. Override to decide which fields and how to highlight.

default: Adds errorClass (see the option) to the element

#### Parameters

##### element

[`ValidatableElement`](ValidatableElement.md)

##### errorClass

`string`

##### validClass

`string`

#### Returns

`void`

***

### invalidHandler()?

> `optional` **invalidHandler**(`event`, `validator`): `void`

Defined in: [src/base/validator.tsx:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L147)

Callback invoked when an invalid form is submitted.

#### Parameters

##### event

`Event`

Submit / invalid-form event.

##### validator

[`Validator`](../classes/Validator.md)

Owning validator instance.

#### Returns

`void`

***

### showErrors()?

> `optional` **showErrors**(`errorMap`, `errorList`, `validator`): `void`

Defined in: [src/base/validator.tsx:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L226)

Custom error display handler. Receives the current error map and list.
Call `this.defaultShowErrors()` to run the built-in display logic in addition to custom handling.

#### Parameters

##### errorMap

[`ValidationErrorMap`](ValidationErrorMap.md)

Map of field name to error message.

##### errorList

[`ValidationErrorList`](../type-aliases/ValidationErrorList.md)

Ordered list of validation failures.

##### validator

[`Validator`](../classes/Validator.md)

Owning validator instance.

#### Returns

`void`

***

### submitHandler()?

> `optional` **submitHandler**(`form`, `event`, `validator`): `boolean` \| `void`

Defined in: [src/base/validator.tsx:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L238)

Callback for handling the actual submit when the form is valid. Gets the form and the event object. Replaces the default submit.
The right place to submit a form via Ajax after it is validated.

#### Parameters

##### form

`HTMLFormElement`

##### event

`Event`

##### validator

[`Validator`](../classes/Validator.md)

#### Returns

`boolean` \| `void`

***

### unhighlight()?

> `optional` **unhighlight**(`element`, `errorClass`, `validClass`, `validator`): `void`

Defined in: [src/base/validator.tsx:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L252)

Called to revert changes made by option highlight, same arguments as highlight.

default: Removes the errorClass

#### Parameters

##### element

[`ValidatableElement`](ValidatableElement.md)

##### errorClass

`string`

##### validClass

`string`

##### validator

[`Validator`](../classes/Validator.md)

#### Returns

`void`
