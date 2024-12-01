[@serenity-is/corelib](../README.md) / ValidatorOptions

# Interface: ValidatorOptions

## Properties

### debug?

> `optional` **debug**: `boolean`

True for logging debug info

#### Defined in

[src/base/validator.tsx:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L60)

***

### errorClass?

> `optional` **errorClass**: `string`

Use this class to create error labels, to look for existing error labels and to add it to invalid elements.

default: "error"

#### Defined in

[src/base/validator.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L67)

***

### errorElement?

> `optional` **errorElement**: `string`

Use this element type to create error messages and to look for existing error messages. The default, "label",
has the advantage of creating a meaningful link between error message and invalid field using the for attribute (which is always used, regardless of element type).

default: "label"

#### Defined in

[src/base/validator.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L75)

***

### focusInvalid?

> `optional` **focusInvalid**: `boolean`

Focus the last active or first invalid element on submit via validator.focusInvalid(). The last active element is the one
that had focus when the form was submitted, avoiding stealing its focus. If there was no element focused, the first one
in the form gets it, unless this option is turned off.

default: true

#### Defined in

[src/base/validator.tsx:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L91)

***

### ignore?

> `optional` **ignore**: `string`

Elements to ignore when validating, simply filtering them out. CSS not-method is used, therefore everything that is
accepted by not() can be passed as this option. Inputs of type submit and reset are always ignored, so are disabled elements.

#### Defined in

[src/base/validator.tsx:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L104)

***

### messages?

> `optional` **messages**: `Record`\<`string`, `string`\>

Key/value pairs defining custom messages. Key is the name of an element, value the message to display for that element. Instead
of a plain message, another map with specific messages for each rule can be used. Overrides the title attribute of an element or
the default message for the method (in that order). Each message can be a String or a Callback. The callback is called in the scope
of the validator, with the rule's parameters as the first argument and the element as the second, and must return a String to display
as the message.

default: the default message for the method used

#### Defined in

[src/base/validator.tsx:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L120)

***

### normalizer()?

> `optional` **normalizer**: (`val`, `element`) => `string`

#### Parameters

##### val

[`ValidationValue`](../type-aliases/ValidationValue.md)

##### element

[`ValidatableElement`](ValidatableElement.md)

#### Returns

`string`

#### Defined in

[src/base/validator.tsx:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L122)

***

### onclick?

> `optional` **onclick**: `boolean` \| [`ValidateEventDelegate`](../type-aliases/ValidateEventDelegate.md)

Boolean or Function. Validate checkboxes and radio buttons on click. Set to false to disable.

Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

#### Defined in

[src/base/validator.tsx:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L130)

***

### onfocusin?

> `optional` **onfocusin**: [`ValidateEventDelegate`](../type-aliases/ValidateEventDelegate.md)

Function. Validate elements when user focuses in. If omitted hides all other fields marked as invalid.

Set to a custom Function to decide for yourself when to run validation.

#### Defined in

[src/base/validator.tsx:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L137)

***

### onfocusout?

> `optional` **onfocusout**: [`ValidateEventDelegate`](../type-aliases/ValidateEventDelegate.md)

Boolean or Function. Validate elements (except checkboxes/radio buttons) on blur. If nothing is entered, all rules are skipped, except when the field was already marked as invalid.

Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

#### Defined in

[src/base/validator.tsx:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L145)

***

### onkeyup?

> `optional` **onkeyup**: [`ValidateEventDelegate`](../type-aliases/ValidateEventDelegate.md)

Boolean or Function. Validate elements on keyup. As long as the field is not marked as invalid, nothing happens.
Otherwise, all rules are checked on each key up event. Set to false to disable.

Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

#### Defined in

[src/base/validator.tsx:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L154)

***

### onsubmit?

> `optional` **onsubmit**: `boolean`

Validate the form on submit. Set to false to use only other events for validation.
Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

default: true

#### Defined in

[src/base/validator.tsx:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L163)

***

### pendingClass?

> `optional` **pendingClass**: `string`

Pending class
default: "pending"

#### Defined in

[src/base/validator.tsx:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L169)

***

### rules?

> `optional` **rules**: [`ValidationRulesMap`](ValidationRulesMap.md)

A custom message display handler. Gets the map of errors as the first argument and an array of errors as the second,
called in the context of the validator object. The arguments contain only those elements currently validated,
which can be a single element when doing validation onblur/keyup. You can trigger (in addition to your own messages)
the default behaviour by calling this.defaultShowErrors().

#### Defined in

[src/base/validator.tsx:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L177)

***

### success?

> `optional` **success**: `string` \| (`label`, `validatedInput`) => `void`

String or Function. If specified, the error label is displayed to show a valid element. If a String is given, it is added as
a class to the label. If a Function is given, it is called with the label and the validated input (as a DOM element).
The label can be used to add a text like "ok!".

#### Defined in

[src/base/validator.tsx:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L200)

***

### validClass?

> `optional` **validClass**: `string`

This class is added to an element after it was validated and considered valid.

default: "valid"

#### Defined in

[src/base/validator.tsx:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L214)

## Methods

### abortHandler()?

> `optional` **abortHandler**(`validator`): `void`

#### Parameters

##### validator

[`Validator`](../classes/Validator.md)

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L187)

***

### errorPlacement()?

> `optional` **errorPlacement**(`error`, `element`, `validator`): `void`

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

#### Defined in

[src/base/validator.tsx:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L82)

***

### highlight()?

> `optional` **highlight**(`element`, `errorClass`, `validClass`): `void`

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

#### Defined in

[src/base/validator.tsx:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L98)

***

### invalidHandler()?

> `optional` **invalidHandler**(`event`, `validator`): `void`

Callback for custom code when an invalid form is submitted. Called with an event object as the first argument, and the validator
as in the second.

#### Parameters

##### event

`Event`

##### validator

[`Validator`](../classes/Validator.md)

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L110)

***

### showErrors()?

> `optional` **showErrors**(`errorMap`, `errorList`, `validator`): `void`

A custom message display handler. Gets the map of errors as the first argument and an array of errors as the second,
called in the context of the validator object. The arguments contain only those elements currently validated, which can
be a single element when doing validation onblur/keyup. You can trigger (in addition to your own messages) the default
behaviour by calling this.defaultShowErrors().

#### Parameters

##### errorMap

[`ValidationErrorMap`](ValidationErrorMap.md)

##### errorList

[`ValidationErrorList`](../type-aliases/ValidationErrorList.md)

##### validator

[`Validator`](../classes/Validator.md)

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L185)

***

### submitHandler()?

> `optional` **submitHandler**(`form`, `event`, `validator`): `boolean` \| `void`

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

#### Defined in

[src/base/validator.tsx:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L193)

***

### unhighlight()?

> `optional` **unhighlight**(`element`, `errorClass`, `validClass`, `validator`): `void`

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

#### Defined in

[src/base/validator.tsx:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L207)
