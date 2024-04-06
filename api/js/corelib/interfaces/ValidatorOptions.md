[@serenity-is/corelib](../README.md) / ValidatorOptions

# Interface: ValidatorOptions

## Table of contents

### Properties

- [debug](ValidatorOptions.md#debug)
- [errorClass](ValidatorOptions.md#errorclass)
- [errorElement](ValidatorOptions.md#errorelement)
- [focusInvalid](ValidatorOptions.md#focusinvalid)
- [ignore](ValidatorOptions.md#ignore)
- [messages](ValidatorOptions.md#messages)
- [normalizer](ValidatorOptions.md#normalizer)
- [onclick](ValidatorOptions.md#onclick)
- [onfocusin](ValidatorOptions.md#onfocusin)
- [onfocusout](ValidatorOptions.md#onfocusout)
- [onkeyup](ValidatorOptions.md#onkeyup)
- [onsubmit](ValidatorOptions.md#onsubmit)
- [pendingClass](ValidatorOptions.md#pendingclass)
- [rules](ValidatorOptions.md#rules)
- [success](ValidatorOptions.md#success)
- [validClass](ValidatorOptions.md#validclass)

### Methods

- [abortHandler](ValidatorOptions.md#aborthandler)
- [errorPlacement](ValidatorOptions.md#errorplacement)
- [highlight](ValidatorOptions.md#highlight)
- [invalidHandler](ValidatorOptions.md#invalidhandler)
- [showErrors](ValidatorOptions.md#showerrors)
- [submitHandler](ValidatorOptions.md#submithandler)
- [unhighlight](ValidatorOptions.md#unhighlight)

## Properties

### debug

• `Optional` **debug**: `boolean`

True for logging debug info

#### Defined in

[src/base/validator.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L60)

___

### errorClass

• `Optional` **errorClass**: `string`

Use this class to create error labels, to look for existing error labels and to add it to invalid elements.

default: "error"

#### Defined in

[src/base/validator.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L67)

___

### errorElement

• `Optional` **errorElement**: `string`

Use this element type to create error messages and to look for existing error messages. The default, "label",
has the advantage of creating a meaningful link between error message and invalid field using the for attribute (which is always used, regardless of element type).

default: "label"

#### Defined in

[src/base/validator.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L75)

___

### focusInvalid

• `Optional` **focusInvalid**: `boolean`

Focus the last active or first invalid element on submit via validator.focusInvalid(). The last active element is the one
that had focus when the form was submitted, avoiding stealing its focus. If there was no element focused, the first one
in the form gets it, unless this option is turned off.

default: true

#### Defined in

[src/base/validator.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L91)

___

### ignore

• `Optional` **ignore**: `string`

Elements to ignore when validating, simply filtering them out. CSS not-method is used, therefore everything that is
accepted by not() can be passed as this option. Inputs of type submit and reset are always ignored, so are disabled elements.

#### Defined in

[src/base/validator.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L104)

___

### messages

• `Optional` **messages**: `Record`\<`string`, `string`\>

Key/value pairs defining custom messages. Key is the name of an element, value the message to display for that element. Instead
of a plain message, another map with specific messages for each rule can be used. Overrides the title attribute of an element or
the default message for the method (in that order). Each message can be a String or a Callback. The callback is called in the scope
of the validator, with the rule's parameters as the first argument and the element as the second, and must return a String to display
as the message.

default: the default message for the method used

#### Defined in

[src/base/validator.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L120)

___

### normalizer

• `Optional` **normalizer**: (`val`: [`ValidationValue`](../README.md#validationvalue), `element`: [`ValidatableElement`](ValidatableElement.md)) => `string`

#### Type declaration

▸ (`val`, `element`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `val` | [`ValidationValue`](../README.md#validationvalue) |
| `element` | [`ValidatableElement`](ValidatableElement.md) |

##### Returns

`string`

#### Defined in

[src/base/validator.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L122)

___

### onclick

• `Optional` **onclick**: `boolean` \| [`ValidateEventDelegate`](../README.md#validateeventdelegate)

Boolean or Function. Validate checkboxes and radio buttons on click. Set to false to disable.

Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

#### Defined in

[src/base/validator.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L130)

___

### onfocusin

• `Optional` **onfocusin**: [`ValidateEventDelegate`](../README.md#validateeventdelegate)

Function. Validate elements when user focuses in. If omitted hides all other fields marked as invalid.

Set to a custom Function to decide for yourself when to run validation.

#### Defined in

[src/base/validator.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L137)

___

### onfocusout

• `Optional` **onfocusout**: [`ValidateEventDelegate`](../README.md#validateeventdelegate)

Boolean or Function. Validate elements (except checkboxes/radio buttons) on blur. If nothing is entered, all rules are skipped, except when the field was already marked as invalid.

Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

#### Defined in

[src/base/validator.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L145)

___

### onkeyup

• `Optional` **onkeyup**: [`ValidateEventDelegate`](../README.md#validateeventdelegate)

Boolean or Function. Validate elements on keyup. As long as the field is not marked as invalid, nothing happens.
Otherwise, all rules are checked on each key up event. Set to false to disable.

Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

#### Defined in

[src/base/validator.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L154)

___

### onsubmit

• `Optional` **onsubmit**: `boolean`

Validate the form on submit. Set to false to use only other events for validation.
Set to a Function to decide for yourself when to run validation.
A boolean true is not a valid value.

default: true

#### Defined in

[src/base/validator.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L163)

___

### pendingClass

• `Optional` **pendingClass**: `string`

Pending class
default: "pending"

#### Defined in

[src/base/validator.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L169)

___

### rules

• `Optional` **rules**: [`ValidationRulesMap`](ValidationRulesMap.md)

A custom message display handler. Gets the map of errors as the first argument and an array of errors as the second,
called in the context of the validator object. The arguments contain only those elements currently validated,
which can be a single element when doing validation onblur/keyup. You can trigger (in addition to your own messages)
the default behaviour by calling this.defaultShowErrors().

#### Defined in

[src/base/validator.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L177)

___

### success

• `Optional` **success**: `string` \| (`label`: `HTMLElement`, `validatedInput`: [`ValidatableElement`](ValidatableElement.md)) => `void`

String or Function. If specified, the error label is displayed to show a valid element. If a String is given, it is added as
a class to the label. If a Function is given, it is called with the label and the validated input (as a DOM element).
The label can be used to add a text like "ok!".

#### Defined in

[src/base/validator.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L200)

___

### validClass

• `Optional` **validClass**: `string`

This class is added to an element after it was validated and considered valid.

default: "valid"

#### Defined in

[src/base/validator.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L214)

## Methods

### abortHandler

▸ **abortHandler**(`validator`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `validator` | [`Validator`](../classes/Validator.md) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L187)

___

### errorPlacement

▸ **errorPlacement**(`error`, `element`, `validator`): `void`

Customize placement of created error labels. First argument: The created error label. Second argument: The invalid element.

default: Places the error label after the invalid element

#### Parameters

| Name | Type |
| :------ | :------ |
| `error` | `HTMLElement` |
| `element` | [`ValidatableElement`](ValidatableElement.md) |
| `validator` | [`Validator`](../classes/Validator.md) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L82)

___

### highlight

▸ **highlight**(`element`, `errorClass`, `validClass`): `void`

How to highlight invalid fields. Override to decide which fields and how to highlight.

default: Adds errorClass (see the option) to the element

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](ValidatableElement.md) |
| `errorClass` | `string` |
| `validClass` | `string` |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L98)

___

### invalidHandler

▸ **invalidHandler**(`event`, `validator`): `void`

Callback for custom code when an invalid form is submitted. Called with an event object as the first argument, and the validator
as in the second.

#### Parameters

| Name | Type |
| :------ | :------ |
| `event` | `Event` |
| `validator` | [`Validator`](../classes/Validator.md) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L110)

___

### showErrors

▸ **showErrors**(`errorMap`, `errorList`, `validator`): `void`

A custom message display handler. Gets the map of errors as the first argument and an array of errors as the second,
called in the context of the validator object. The arguments contain only those elements currently validated, which can
be a single element when doing validation onblur/keyup. You can trigger (in addition to your own messages) the default
behaviour by calling this.defaultShowErrors().

#### Parameters

| Name | Type |
| :------ | :------ |
| `errorMap` | [`ValidationErrorMap`](ValidationErrorMap.md) |
| `errorList` | [`ValidationErrorList`](../README.md#validationerrorlist) |
| `validator` | [`Validator`](../classes/Validator.md) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L185)

___

### submitHandler

▸ **submitHandler**(`form`, `event`, `validator`): `boolean` \| `void`

Callback for handling the actual submit when the form is valid. Gets the form and the event object. Replaces the default submit.
The right place to submit a form via Ajax after it is validated.

#### Parameters

| Name | Type |
| :------ | :------ |
| `form` | `HTMLFormElement` |
| `event` | `Event` |
| `validator` | [`Validator`](../classes/Validator.md) |

#### Returns

`boolean` \| `void`

#### Defined in

[src/base/validator.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L193)

___

### unhighlight

▸ **unhighlight**(`element`, `errorClass`, `validClass`, `validator`): `void`

Called to revert changes made by option highlight, same arguments as highlight.

default: Removes the errorClass

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](ValidatableElement.md) |
| `errorClass` | `string` |
| `validClass` | `string` |
| `validator` | [`Validator`](../classes/Validator.md) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L207)
