[@serenity-is/corelib](../README.md) / Validator

# Class: Validator

Defined in: [src/base/validator.tsx:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L307)

Form validation engine inspired by jQuery Validation and ASP.NET client validation.
Manages rules, messages, error display, and async pending state for a single form.

## Constructors

### Constructor

> **new Validator**(`form`, `options`): `Validator`

Defined in: [src/base/validator.tsx:621](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L621)

Creates a validator for a form and wires up submit / focus / key handlers.

#### Parameters

##### form

`HTMLFormElement`

Form element to validate.

##### options

[`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Validator options merged over [Validator.defaults](#defaults).

#### Returns

`Validator`

## Properties

### dependTypes

> **dependTypes**: `object`

Defined in: [src/base/validator.tsx:1643](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1643)

Handlers for depend-type checks used by [Validator.depend](#depend).

#### boolean()

> **boolean**: (`param`) => `any`

##### Parameters

###### param

`any`

##### Returns

`any`

#### function()

> **function**: (`param`, `element`) => `any`

##### Parameters

###### param

`any`

###### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### Returns

`any`

#### string()

> **string**: (`param`, `element`) => `boolean`

##### Parameters

###### param

`any`

###### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### Returns

`boolean`

***

### lastActive

> **lastActive**: [`ValidatableElement`](../interfaces/ValidatableElement.md)

Defined in: [src/base/validator.tsx:600](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L600)

Last element that received focus, used by [Validator.focusInvalid](#focusinvalid).

***

### settings

> `readonly` **settings**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Defined in: [src/base/validator.tsx:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L598)

Effective settings for this validator instance (merged defaults + constructor options).

***

### autoCreateRanges

> `static` **autoCreateRanges**: `boolean` = `false`

Defined in: [src/base/validator.tsx:322](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L322)

When `true` automatically combines `min`+`max` into `range` and `minlength`+`maxlength` into `rangelength` during rule normalization.

***

### classRuleSettings

> `static` **classRuleSettings**: `Record`\<`string`, [`ValidationRules`](../type-aliases/ValidationRules.md)\>

Defined in: [src/base/validator.tsx:1753](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1753)

CSS-class to rule mapping (e.g. `"required"` → `{ required: true }`).

***

### defaults

> `static` **defaults**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Defined in: [src/base/validator.tsx:325](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L325)

Default options applied to every new validator instance.

***

### excludedModifierKeys

> `readonly` `static` **excludedModifierKeys**: `Set`\<`string`\>

Defined in: [src/base/validator.tsx:2065](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L2065)

Modifier / navigation keys that should not trigger `onkeyup` re-validation.

***

### messages

> `readonly` `static` **messages**: `Record`\<`string`, `string` \| `Function`\>

Defined in: [src/base/validator.tsx:418](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L418)

Default messages keyed by validation method name. Values may be translation keys or functions.

***

### methods

> `readonly` `static` **methods**: `Record`\<`string`, [`ValidationProvider`](../type-aliases/ValidationProvider.md)\>

Defined in: [src/base/validator.tsx:441](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L441)

Built-in validation methods keyed by rule name. Extend via [Validator.addMethod](#addmethod).

## Methods

### abortRequest()

> **abortRequest**(`element`): `void`

Defined in: [src/base/validator.tsx:1710](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1710)

Aborts a pending async request for an element, if any.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Element whose pending request should be aborted.

#### Returns

`void`

***

### check()

> **check**(`element`): `boolean`

Defined in: [src/base/validator.tsx:1293](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1293)

Runs all applicable validation rules for an element.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Element to check.

#### Returns

`boolean`

`true` if valid, `false` if invalid, or `undefined` for dependency mismatch.

***

### checkForm()

> **checkForm**(): `boolean`

Defined in: [src/base/validator.tsx:1005](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1005)

Validates all elements in the form without updating the display.

#### Returns

`boolean`

`true` if all elements are valid.

***

### customDataMessage()

> **customDataMessage**(`element`, `method`): `string`

Defined in: [src/base/validator.tsx:1380](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1380)

Gets a custom message from HTML5 `data-msg*` attributes for an element/method.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Source element.

##### method

`string`

Validation method name.

#### Returns

`string`

The data message, if present.

***

### customMessage()

> **customMessage**(`name`, `method`): `any`

Defined in: [src/base/validator.tsx:1391](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1391)

Gets a custom message from `settings.messages` for a field/method.

#### Parameters

##### name

`string`

Field name.

##### method

`string`

Validation method name.

#### Returns

`any`

The configured message, if present.

***

### defaultMessage()

> **defaultMessage**(`element`, `rule`): `any`

Defined in: [src/base/validator.tsx:1417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1417)

Resolves the default error message for a rule, checking custom messages, data attributes, and [Validator.messages](#messages).

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

##### rule

Rule descriptor with method and parameters.

###### method

`string`

###### parameters?

`any`

#### Returns

`any`

The resolved message string.

***

### defaultShowErrors()

> **defaultShowErrors**(): `void`

Defined in: [src/base/validator.tsx:1458](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1458)

Default error display: highlights invalid elements, shows labels, and hides stale errors.

#### Returns

`void`

***

### depend()

> **depend**(`param`, `element`): `any`

Defined in: [src/base/validator.tsx:1661](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1661)

Evaluates whether a dependency condition is met.

#### Parameters

##### param

`any`

Boolean, selector string, or function.

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Context element.

#### Returns

`any`

`true` if the dependency is satisfied.

***

### destroy()

> **destroy**(): `void`

Defined in: [src/base/validator.tsx:1745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1745)

Cleans up event handlers and removes the validator instance from the form.

#### Returns

`void`

***

### element()

> **element**(`element`): `boolean`

Defined in: [src/base/validator.tsx:1018](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1018)

Validates a single element and updates error display.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Element to validate.

#### Returns

`boolean`

`true` if the element is valid.

***

### elements()

> **elements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1199)

Gets all validatable elements in the form that have rules and are not ignored.

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Array of elements to validate.

***

### errors()

> **errors**(): `HTMLElement`[]

Defined in: [src/base/validator.tsx:1248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1248)

Gets existing error label elements in the form.

#### Returns

`HTMLElement`[]

Array of error label elements.

***

### errorsFor()

> **errorsFor**(`element`): `HTMLElement`[]

Defined in: [src/base/validator.tsx:1591](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1591)

Gets error labels associated with an element via `for` attribute or `aria-describedby`.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

#### Returns

`HTMLElement`[]

Matching error label elements.

***

### findByName()

> **findByName**(`name`): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1638](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1638)

Finds all elements in the form with the given name.

#### Parameters

##### name

`string`

Field name to search for.

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Matching elements.

***

### findDefined()

> **findDefined**(...`args`): `any`

Defined in: [src/base/validator.tsx:1402](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1402)

Returns the first defined argument, allowing empty strings.

#### Parameters

##### args

...`any`[]

Values to test in order.

#### Returns

`any`

The first non-`undefined` value.

***

### findLastActive()

> **findLastActive**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)

Defined in: [src/base/validator.tsx:1190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1190)

Finds the last active element among current errors, if it is still invalid.

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

The last active invalid element, or falsy if none.

***

### focusInvalid()

> **focusInvalid**(): `void`

Defined in: [src/base/validator.tsx:1168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1168)

Focuses the last active invalid element or the first invalid element.
Honors `abortHandler` and `focusInvalid` settings.

#### Returns

`void`

***

### form()

> **form**(): `boolean`

Defined in: [src/base/validator.tsx:990](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L990)

Validates the entire form, updates error state, and shows errors.

#### Returns

`boolean`

`true` if the form is valid.

***

### formatAndAdd()

> **formatAndAdd**(`element`, `rule`): `void`

Defined in: [src/base/validator.tsx:1444](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1444)

Formats the error message for a failed rule and records it in the error map/list.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Element that failed.

##### rule

Rule that failed.

###### method

`string`

###### parameters

`any`

#### Returns

`void`

***

### hideErrors()

> **hideErrors**(): `void`

Defined in: [src/base/validator.tsx:1133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1133)

Hides currently tracked error labels.

#### Returns

`void`

***

### hideThese()

> **hideThese**(`errors`): `void`

Defined in: [src/base/validator.tsx:1141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1141)

Hides a set of error labels.

#### Parameters

##### errors

`HTMLElement`[]

Error label elements to hide.

#### Returns

`void`

***

### idOrName()

> **idOrName**(`element`): `string`

Defined in: [src/base/validator.tsx:1612](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1612)

Gets the identifier used for error label association (`name` for radio/checkbox, otherwise `id` or `name`).

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

#### Returns

`string`

The identifier string.

***

### invalidElements()

> **invalidElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1500](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1500)

Gets elements that are currently invalid.

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Invalid elements.

***

### numberOfInvalids()

> **numberOfInvalids**(): `number`

Defined in: [src/base/validator.tsx:1114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1114)

Gets the count of currently invalid fields.

#### Returns

`number`

Number of invalid entries.

***

### prepareElement()

> **prepareElement**(`element`): `void`

Defined in: [src/base/validator.tsx:1283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1283)

Prepares state for validating a single element.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Element to prepare for.

#### Returns

`void`

***

### prepareForm()

> **prepareForm**(): `void`

Defined in: [src/base/validator.tsx:1274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1274)

Prepares state for a full form validation pass.

#### Returns

`void`

***

### previousValue()

> **previousValue**(`element`, `method`): `any`

Defined in: [src/base/validator.tsx:1731](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1731)

Gets or creates the cached previous value for a remote validation method.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

##### method

`string`

Validation method name (defaults to `"remote"`).

#### Returns

`any`

The cached previous value object.

***

### reset()

> **reset**(): `void`

Defined in: [src/base/validator.tsx:1263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1263)

Resets internal state and clears the current element list.

#### Returns

`void`

***

### resetAll()

> **resetAll**(): `void`

Defined in: [src/base/validator.tsx:1269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1269)

Resets all validation state including displayed errors.

#### Returns

`void`

***

### resetElements()

> **resetElements**(`elements`): `void`

Defined in: [src/base/validator.tsx:1094](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1094)

Resets visual validation state for a set of elements.

#### Parameters

##### elements

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Elements to reset.

#### Returns

`void`

***

### resetForm()

> **resetForm**(): `void`

Defined in: [src/base/validator.tsx:1076](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1076)

Resets form validation state, hides errors, and clears `aria-invalid` attributes.

#### Returns

`void`

***

### resetInternals()

> **resetInternals**(): `void`

Defined in: [src/base/validator.tsx:1254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1254)

Resets internal error tracking without touching the DOM.

#### Returns

`void`

***

### showErrors()

> **showErrors**(`errors?`): `void`

Defined in: [src/base/validator.tsx:1052](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1052)

Displays validation errors, merging optional additional errors into the current state.

#### Parameters

##### errors?

[`ValidationErrorMap`](../interfaces/ValidationErrorMap.md)

Optional additional error map to merge before display.

#### Returns

`void`

***

### showLabel()

> **showLabel**(`element`, `message?`): `void`

Defined in: [src/base/validator.tsx:1509](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1509)

Creates or updates the error label for an element.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

##### message?

`string`

Error message; when omitted shows the success state if configured.

#### Returns

`void`

***

### size()

> **size**(): `number`

Defined in: [src/base/validator.tsx:1160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1160)

Gets the number of current validation errors.

#### Returns

`number`

Error count.

***

### startRequest()

> **startRequest**(`element`): `void`

Defined in: [src/base/validator.tsx:1669](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1669)

Marks an async validation request as pending for an element.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Element with a pending remote check.

#### Returns

`void`

***

### stopRequest()

> **stopRequest**(`element`, `valid`): `void`

Defined in: [src/base/validator.tsx:1682](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1682)

Clears a pending async request and triggers form submit / invalid-form handling as needed.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Element whose request completed.

##### valid

`boolean`

Whether the async result was valid.

#### Returns

`void`

***

### valid()

> **valid**(): `boolean`

Defined in: [src/base/validator.tsx:1152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1152)

Whether there are currently no validation errors.

#### Returns

`boolean`

`true` if valid.

***

### validationTargetFor()

> **validationTargetFor**(`element`): [`ValidatableElement`](../interfaces/ValidatableElement.md)

Defined in: [src/base/validator.tsx:1621](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1621)

Resolves the actual element to validate (first member of a radio/checkbox group, filtered by `ignore`).

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Source element.

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

The validation target, or `undefined` if filtered out.

***

### validElements()

> **validElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1491)

Gets elements among Validator.currentElements that are currently valid.

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Valid elements.

***

### addClassRules()

> `static` **addClassRules**(`className`, `rules`): `void`

Defined in: [src/base/validator.tsx:1770](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1770)

Adds validation rules associated with a CSS class.

#### Parameters

##### className

`any`

Class name or map of class names to rules.

##### rules

[`ValidationRules`](../type-aliases/ValidationRules.md)

Rules to associate when `className` is a string.

#### Returns

`void`

***

### addCustomRule()

> `static` **addCustomRule**(`element`, `rule`, `uniqueName?`): `void`

Defined in: [src/base/validator.tsx:2023](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L2023)

Adds a custom validation callback for an element. Multiple callbacks can be registered under distinct `uniqueName` keys.

#### Parameters

##### element

Target element or array-like collection (first element is used).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### rule

(`input`) => `string`

Callback returning an error message string when invalid, or `null`/`undefined` when valid.

##### uniqueName?

`string`

Optional key to allow independent removal; defaults to `""`.

#### Returns

`void`

***

### addMethod()

> `static` **addMethod**(`name`, `method`, `message?`): `void`

Defined in: [src/base/validator.tsx:1993](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1993)

Registers a new validation method.

#### Parameters

##### name

`string`

Method / rule name.

##### method

[`ValidationProvider`](../type-aliases/ValidationProvider.md)

Validation function.

##### message?

`string`

Optional default error message for the method.

#### Returns

`void`

***

### attributeRules()

> `static` **attributeRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:1832](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1832)

Gets rules derived from HTML attributes (e.g. `required`, `minlength`, `type`).

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

Attribute-derived rules.

***

### classRules()

> `static` **classRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:1783](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1783)

Gets rules derived from the element's CSS classes.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

Rules inferred from classes.

***

### dataRules()

> `static` **dataRules**(`element`): `any`

Defined in: [src/base/validator.tsx:1874](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1874)

Gets rules derived from `data-rule-*` attributes.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

#### Returns

`any`

Data-attribute rules.

***

### elementValue()

> `static` **elementValue**(`element`): `any`

Defined in: [src/base/validator.tsx:816](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L816)

Extracts the current value from a form element, normalizing special cases
(radio / checkbox groups, number inputs, file inputs, contenteditable).

#### Parameters

##### element

`HTMLElement`

Source element.

#### Returns

`any`

The extracted value (`string`, `number`, `string[]`, or `null`).

***

### getHighlightTarget()

> `static` **getHighlightTarget**(`el`): `HTMLElement`

Defined in: [src/base/validator.tsx:2007](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L2007)

Gets the element that should be highlighted for validation feedback.
Checks `data-vx-highlight`, hidden `textarea` editors, and `select2-offscreen`.

#### Parameters

##### el

`HTMLElement`

Source form element.

#### Returns

`HTMLElement`

The highlight target element, or `undefined` if none.

***

### getInstance()

> `static` **getInstance**(`element`): `Validator`

Defined in: [src/base/validator.tsx:723](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L723)

Gets the validator instance associated with a form or an element inside a form.

#### Parameters

##### element

Form element, form-associated element, or array-like collection.

`Node` | `HTMLFormElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`Validator`

The validator instance, or `null` if not found.

***

### getLength()

> `static` **getLength**(`value`, `element`): `number`

Defined in: [src/base/validator.tsx:787](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L787)

Gets the logical length of a value for `minlength` / `maxlength` checks.
Handles selects, checkbox groups, and plain strings.

#### Parameters

##### value

[`ValidationValue`](../type-aliases/ValidationValue.md)

Raw field value.

##### element

`HTMLElement`

Source element (used for select / checkbox groups).

#### Returns

`number`

Length of the value.

***

### isCheckOrRadio()

> `static` **isCheckOrRadio**(`element`): `element is HTMLInputElement`

Defined in: [src/base/validator.tsx:776](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L776)

Whether the element is a checkbox or radio input.

#### Parameters

##### element

`Node`

Element to test.

#### Returns

`element is HTMLInputElement`

`true` if checkbox or radio.

***

### isContentEditable()

> `static` **isContentEditable**(`element`): `boolean`

Defined in: [src/base/validator.tsx:805](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L805)

Whether the element is content-editable.

#### Parameters

##### element

`HTMLElement`

Element to test.

#### Returns

`boolean`

`true` if `contenteditable` is set and not `"false"`.

***

### isValidatableElement()

> `static` **isValidatableElement**(`element`): `element is ValidatableElement`

Defined in: [src/base/validator.tsx:767](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L767)

Checks if `element` is validatable (`input`, `select`, `textarea`).

#### Parameters

##### element

`EventTarget`

The element to check.

#### Returns

`element is ValidatableElement`

`true` if validatable, otherwise `false`.

***

### normalizeAttributeRule()

> `static` **normalizeAttributeRule**(`rules`, `type`, `method`, `value`): `void`

Defined in: [src/base/validator.tsx:1804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1804)

Normalizes a single attribute rule value (e.g. coercing `min`/`max`/`step` to numbers).

#### Parameters

##### rules

[`ValidationRules`](../type-aliases/ValidationRules.md)

Rules object to mutate.

##### type

`string`

Element `type` attribute.

##### method

`string`

Rule method name.

##### value

[`ValidationValue`](../type-aliases/ValidationValue.md)

Raw attribute value.

#### Returns

`void`

***

### normalizeRules()

> `static` **normalizeRules**(`rules`, `element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:1914](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1914)

Normalizes a merged rules object: handles `depends`, coerces numeric params, and optionally auto-creates ranges.

#### Parameters

##### rules

[`ValidationRules`](../type-aliases/ValidationRules.md)

Raw merged rules.

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

Normalized rules.

***

### optional()

> `static` **optional**(`element`, `value?`): `""` \| `"dependency-mismatch"`

Defined in: [src/base/validator.tsx:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L315)

Checks whether a field is optional (not required and empty).

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Element to test.

##### value?

[`ValidationValue`](../type-aliases/ValidationValue.md)

Optional explicit value; when omitted the element's current value is used.

#### Returns

`""` \| `"dependency-mismatch"`

Truthy optional marker or falsy when required / non-empty; `"dependency-mismatch"` when the required rule is absent and value is empty.

***

### removeCustomRule()

> `static` **removeCustomRule**(`element`, `uniqueName`): `void`

Defined in: [src/base/validator.tsx:2048](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L2048)

Removes a custom validation callback previously added with [Validator.addCustomRule](#addcustomrule).

#### Parameters

##### element

Target element or array-like collection.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### uniqueName

`string`

Key under which the rule was registered.

#### Returns

`void`

***

### rules()

> `static` **rules**(`element`, `command?`, `argument?`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:910](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L910)

Gets or mutates the validation rules for an element.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

##### command?

`"add"` to add rules, `"remove"` to remove rules, or omitted to read.

`"remove"` | `"add"`

##### argument?

`any`

Rules to add or space-separated method names to remove.

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

The aggregated rules (or removed rules when `command` is `"remove"`).

***

### staticRules()

> `static` **staticRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:1897](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1897)

Gets rules from the validator's static `settings.rules` for the element's name.

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Target element.

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

Static rules object.

***

### valid()

> `static` **valid**(`element`): `boolean`

Defined in: [src/base/validator.tsx:888](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L888)

Validates a form or a single element using its associated validator.

#### Parameters

##### element

Form or field element (or array-like collection; first element is used).

`HTMLFormElement` | [`ValidatableElement`](../interfaces/ValidatableElement.md) | `ArrayLike`\<[`ValidatableElement`](../interfaces/ValidatableElement.md)\>

#### Returns

`boolean`

`true` if valid, `false` otherwise (or `false` if no validator is found).
