[@serenity-is/corelib](../README.md) / Validator

# Class: Validator

Defined in: [src/base/validator.tsx:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L260)

## Constructors

### Constructor

> **new Validator**(`form`, `options`): `Validator`

Defined in: [src/base/validator.tsx:557](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L557)

#### Parameters

##### form

`HTMLFormElement`

##### options

[`ValidatorOptions`](../interfaces/ValidatorOptions.md)

#### Returns

`Validator`

## Properties

### dependTypes

> **dependTypes**: `object`

Defined in: [src/base/validator.tsx:1406](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1406)

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

Defined in: [src/base/validator.tsx:541](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L541)

***

### settings

> `readonly` **settings**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Defined in: [src/base/validator.tsx:540](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L540)

***

### autoCreateRanges

> `static` **autoCreateRanges**: `boolean` = `false`

Defined in: [src/base/validator.tsx:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L268)

***

### classRuleSettings

> `static` **classRuleSettings**: `Record`\<`string`, [`ValidationRules`](../type-aliases/ValidationRules.md)\>

Defined in: [src/base/validator.tsx:1487](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1487)

***

### defaults

> `static` **defaults**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Defined in: [src/base/validator.tsx:270](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L270)

***

### excludedModifierKeys

> `readonly` `static` **excludedModifierKeys**: `Set`\<`string`\>

Defined in: [src/base/validator.tsx:1737](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1737)

***

### messages

> `readonly` `static` **messages**: `Record`\<`string`, `string` \| `Function`\>

Defined in: [src/base/validator.tsx:362](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L362)

***

### methods

> `readonly` `static` **methods**: `Record`\<`string`, [`ValidationProvider`](../type-aliases/ValidationProvider.md)\>

Defined in: [src/base/validator.tsx:384](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L384)

## Methods

### abortRequest()

> **abortRequest**(`element`): `void`

Defined in: [src/base/validator.tsx:1454](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1454)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

***

### check()

> **check**(`element`): `boolean`

Defined in: [src/base/validator.tsx:1119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1119)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`boolean`

***

### checkForm()

> **checkForm**(): `boolean`

Defined in: [src/base/validator.tsx:893](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L893)

#### Returns

`boolean`

***

### customDataMessage()

> **customDataMessage**(`element`, `method`): `string`

Defined in: [src/base/validator.tsx:1200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1200)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### method

`string`

#### Returns

`string`

***

### customMessage()

> **customMessage**(`name`, `method`): `any`

Defined in: [src/base/validator.tsx:1205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1205)

#### Parameters

##### name

`string`

##### method

`string`

#### Returns

`any`

***

### defaultMessage()

> **defaultMessage**(`element`, `rule`): `any`

Defined in: [src/base/validator.tsx:1220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1220)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### rule

###### method

`string`

###### parameters?

`any`

#### Returns

`any`

***

### defaultShowErrors()

> **defaultShowErrors**(): `void`

Defined in: [src/base/validator.tsx:1255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1255)

#### Returns

`void`

***

### depend()

> **depend**(`param`, `element`): `any`

Defined in: [src/base/validator.tsx:1418](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1418)

#### Parameters

##### param

`any`

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`any`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/base/validator.tsx:1480](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1480)

#### Returns

`void`

***

### element()

> **element**(`element`): `boolean`

Defined in: [src/base/validator.tsx:901](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L901)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`boolean`

***

### elements()

> **elements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1042](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1042)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### errors()

> **errors**(): `HTMLElement`[]

Defined in: [src/base/validator.tsx:1087](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1087)

#### Returns

`HTMLElement`[]

***

### errorsFor()

> **errorsFor**(`element`): `HTMLElement`[]

Defined in: [src/base/validator.tsx:1370](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1370)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`HTMLElement`[]

***

### findByName()

> **findByName**(`name`): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1402](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1402)

#### Parameters

##### name

`string`

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### findDefined()

> **findDefined**(...`args`): `any`

Defined in: [src/base/validator.tsx:1211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1211)

#### Parameters

##### args

...`any`[]

#### Returns

`any`

***

### findLastActive()

> **findLastActive**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)

Defined in: [src/base/validator.tsx:1037](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1037)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

***

### focusInvalid()

> **focusInvalid**(): `void`

Defined in: [src/base/validator.tsx:1019](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1019)

#### Returns

`void`

***

### form()

> **form**(): `boolean`

Defined in: [src/base/validator.tsx:882](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L882)

#### Returns

`boolean`

***

### formatAndAdd()

> **formatAndAdd**(`element`, `rule`): `void`

Defined in: [src/base/validator.tsx:1242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1242)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### rule

###### method

`string`

###### parameters

`any`

#### Returns

`void`

***

### hideErrors()

> **hideErrors**(): `void`

Defined in: [src/base/validator.tsx:1000](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1000)

#### Returns

`void`

***

### hideThese()

> **hideThese**(`errors`): `void`

Defined in: [src/base/validator.tsx:1004](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1004)

#### Parameters

##### errors

`HTMLElement`[]

#### Returns

`void`

***

### idOrName()

> **idOrName**(`element`): `string`

Defined in: [src/base/validator.tsx:1386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1386)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`string`

***

### invalidElements()

> **invalidElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1289)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### numberOfInvalids()

> **numberOfInvalids**(): `number`

Defined in: [src/base/validator.tsx:982](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L982)

#### Returns

`number`

***

### prepareElement()

> **prepareElement**(`element`): `void`

Defined in: [src/base/validator.tsx:1114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1114)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

***

### prepareForm()

> **prepareForm**(): `void`

Defined in: [src/base/validator.tsx:1109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1109)

#### Returns

`void`

***

### previousValue()

> **previousValue**(`element`, `method`): `any`

Defined in: [src/base/validator.tsx:1469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1469)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### method

`string`

#### Returns

`any`

***

### reset()

> **reset**(): `void`

Defined in: [src/base/validator.tsx:1100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1100)

#### Returns

`void`

***

### resetAll()

> **resetAll**(): `void`

Defined in: [src/base/validator.tsx:1105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1105)

#### Returns

`void`

***

### resetElements()

> **resetElements**(`elements`): `void`

Defined in: [src/base/validator.tsx:966](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L966)

#### Parameters

##### elements

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

`void`

***

### resetForm()

> **resetForm**(): `void`

Defined in: [src/base/validator.tsx:952](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L952)

#### Returns

`void`

***

### resetInternals()

> **resetInternals**(): `void`

Defined in: [src/base/validator.tsx:1092](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1092)

#### Returns

`void`

***

### showErrors()

> **showErrors**(`errors?`): `void`

Defined in: [src/base/validator.tsx:931](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L931)

#### Parameters

##### errors?

[`ValidationErrorMap`](../interfaces/ValidationErrorMap.md)

#### Returns

`void`

***

### showLabel()

> **showLabel**(`element`, `message?`): `void`

Defined in: [src/base/validator.tsx:1293](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1293)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### message?

`string`

#### Returns

`void`

***

### size()

> **size**(): `number`

Defined in: [src/base/validator.tsx:1015](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1015)

#### Returns

`number`

***

### startRequest()

> **startRequest**(`element`): `void`

Defined in: [src/base/validator.tsx:1422](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1422)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

***

### stopRequest()

> **stopRequest**(`element`, `valid`): `void`

Defined in: [src/base/validator.tsx:1430](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1430)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### valid

`boolean`

#### Returns

`void`

***

### valid()

> **valid**(): `boolean`

Defined in: [src/base/validator.tsx:1011](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1011)

#### Returns

`boolean`

***

### validationTargetFor()

> **validationTargetFor**(`element`): [`ValidatableElement`](../interfaces/ValidatableElement.md)

Defined in: [src/base/validator.tsx:1390](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1390)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

***

### validElements()

> **validElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1284)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### addClassRules()

> `static` **addClassRules**(`className`, `rules`): `void`

Defined in: [src/base/validator.tsx:1499](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1499)

#### Parameters

##### className

`any`

##### rules

[`ValidationRules`](../type-aliases/ValidationRules.md)

#### Returns

`void`

***

### addCustomRule()

> `static` **addCustomRule**(`element`, `rule`, `uniqueName?`): `void`

Defined in: [src/base/validator.tsx:1701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1701)

#### Parameters

##### element

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### rule

(`input`) => `string`

##### uniqueName?

`string`

#### Returns

`void`

***

### addMethod()

> `static` **addMethod**(`name`, `method`, `message?`): `void`

Defined in: [src/base/validator.tsx:1683](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1683)

#### Parameters

##### name

`string`

##### method

[`ValidationProvider`](../type-aliases/ValidationProvider.md)

##### message?

`string`

#### Returns

`void`

***

### attributeRules()

> `static` **attributeRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:1544](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1544)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### classRules()

> `static` **classRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:1507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1507)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### dataRules()

> `static` **dataRules**(`element`): `object`

Defined in: [src/base/validator.tsx:1581](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1581)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`object`

***

### elementValue()

> `static` **elementValue**(`element`): `any`

Defined in: [src/base/validator.tsx:724](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L724)

#### Parameters

##### element

`HTMLElement`

#### Returns

`any`

***

### getHighlightTarget()

> `static` **getHighlightTarget**(`el`): `HTMLElement`

Defined in: [src/base/validator.tsx:1691](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1691)

#### Parameters

##### el

`HTMLElement`

#### Returns

`HTMLElement`

***

### getInstance()

> `static` **getInstance**(`element`): `Validator`

Defined in: [src/base/validator.tsx:654](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L654)

#### Parameters

##### element

`Node` | `HTMLFormElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`Validator`

***

### getLength()

> `static` **getLength**(`value`, `element`): `number`

Defined in: [src/base/validator.tsx:706](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L706)

#### Parameters

##### value

[`ValidationValue`](../type-aliases/ValidationValue.md)

##### element

`HTMLElement`

#### Returns

`number`

***

### isCheckOrRadio()

> `static` **isCheckOrRadio**(`element`): `element is HTMLInputElement`

Defined in: [src/base/validator.tsx:702](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L702)

#### Parameters

##### element

`Node`

#### Returns

`element is HTMLInputElement`

***

### isContentEditable()

> `static` **isContentEditable**(`element`): `boolean`

Defined in: [src/base/validator.tsx:719](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L719)

#### Parameters

##### element

`HTMLElement`

#### Returns

`boolean`

***

### isValidatableElement()

> `static` **isValidatableElement**(`element`): `element is ValidatableElement`

Defined in: [src/base/validator.tsx:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L698)

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

Defined in: [src/base/validator.tsx:1521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1521)

#### Parameters

##### rules

[`ValidationRules`](../type-aliases/ValidationRules.md)

##### type

`string`

##### method

`string`

##### value

[`ValidationValue`](../type-aliases/ValidationValue.md)

#### Returns

`void`

***

### normalizeRules()

> `static` **normalizeRules**(`rules`, `element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:1610](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1610)

#### Parameters

##### rules

[`ValidationRules`](../type-aliases/ValidationRules.md)

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### optional()

> `static` **optional**(`element`, `value?`): `""` \| `"dependency-mismatch"`

Defined in: [src/base/validator.tsx:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L262)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### value?

[`ValidationValue`](../type-aliases/ValidationValue.md)

#### Returns

`""` \| `"dependency-mismatch"`

***

### removeCustomRule()

> `static` **removeCustomRule**(`element`, `uniqueName`): `void`

Defined in: [src/base/validator.tsx:1721](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1721)

#### Parameters

##### element

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### uniqueName

`string`

#### Returns

`void`

***

### rules()

> `static` **rules**(`element`, `command?`, `argument?`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:806](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L806)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### command?

`"remove"` | `"add"`

##### argument?

`any`

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### staticRules()

> `static` **staticRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:1599](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1599)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### valid()

> `static` **valid**(`element`): `boolean`

Defined in: [src/base/validator.tsx:791](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L791)

#### Parameters

##### element

`HTMLFormElement` | [`ValidatableElement`](../interfaces/ValidatableElement.md) | `ArrayLike`\<[`ValidatableElement`](../interfaces/ValidatableElement.md)\>

#### Returns

`boolean`
