[corelib](../README.md) / Validator

# Class: Validator

Defined in: [src/base/validator.tsx:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L259)

## Constructors

### Constructor

> **new Validator**(`form`, `options`): `Validator`

Defined in: [src/base/validator.tsx:552](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L552)

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

Defined in: [src/base/validator.tsx:1398](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1398)

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

Defined in: [src/base/validator.tsx:536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L536)

***

### settings

> `readonly` **settings**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Defined in: [src/base/validator.tsx:535](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L535)

***

### autoCreateRanges

> `static` **autoCreateRanges**: `boolean` = `false`

Defined in: [src/base/validator.tsx:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L267)

***

### classRuleSettings

> `static` **classRuleSettings**: `Record`\<`string`, [`ValidationRules`](../type-aliases/ValidationRules.md)\>

Defined in: [src/base/validator.tsx:1479](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1479)

***

### defaults

> `static` **defaults**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Defined in: [src/base/validator.tsx:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L269)

***

### messages

> `readonly` `static` **messages**: `Record`\<`string`, `string` \| `Function`\>

Defined in: [src/base/validator.tsx:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L357)

***

### methods

> `readonly` `static` **methods**: `Record`\<`string`, [`ValidationProvider`](../type-aliases/ValidationProvider.md)\>

Defined in: [src/base/validator.tsx:379](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L379)

## Methods

### abortRequest()

> **abortRequest**(`element`): `void`

Defined in: [src/base/validator.tsx:1446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1446)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

***

### check()

> **check**(`element`): `boolean`

Defined in: [src/base/validator.tsx:1114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1114)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`boolean`

***

### checkForm()

> **checkForm**(): `boolean`

Defined in: [src/base/validator.tsx:888](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L888)

#### Returns

`boolean`

***

### customDataMessage()

> **customDataMessage**(`element`, `method`): `string`

Defined in: [src/base/validator.tsx:1195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1195)

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

Defined in: [src/base/validator.tsx:1200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1200)

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

Defined in: [src/base/validator.tsx:1215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1215)

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

Defined in: [src/base/validator.tsx:1250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1250)

#### Returns

`void`

***

### depend()

> **depend**(`param`, `element`): `any`

Defined in: [src/base/validator.tsx:1410](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1410)

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

Defined in: [src/base/validator.tsx:1472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1472)

#### Returns

`void`

***

### element()

> **element**(`element`): `boolean`

Defined in: [src/base/validator.tsx:896](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L896)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`boolean`

***

### elements()

> **elements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1037](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1037)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### errors()

> **errors**(): `HTMLElement`[]

Defined in: [src/base/validator.tsx:1082](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1082)

#### Returns

`HTMLElement`[]

***

### errorsFor()

> **errorsFor**(`element`): `HTMLElement`[]

Defined in: [src/base/validator.tsx:1363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1363)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`HTMLElement`[]

***

### findByName()

> **findByName**(`name`): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1394](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1394)

#### Parameters

##### name

`string`

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### findDefined()

> **findDefined**(...`args`): `any`

Defined in: [src/base/validator.tsx:1206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1206)

#### Parameters

##### args

...`any`[]

#### Returns

`any`

***

### findLastActive()

> **findLastActive**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)

Defined in: [src/base/validator.tsx:1032](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1032)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

***

### focusInvalid()

> **focusInvalid**(): `void`

Defined in: [src/base/validator.tsx:1014](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1014)

#### Returns

`void`

***

### form()

> **form**(): `boolean`

Defined in: [src/base/validator.tsx:877](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L877)

#### Returns

`boolean`

***

### formatAndAdd()

> **formatAndAdd**(`element`, `rule`): `void`

Defined in: [src/base/validator.tsx:1237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1237)

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

Defined in: [src/base/validator.tsx:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L995)

#### Returns

`void`

***

### hideThese()

> **hideThese**(`errors`): `void`

Defined in: [src/base/validator.tsx:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L999)

#### Parameters

##### errors

`HTMLElement`[]

#### Returns

`void`

***

### idOrName()

> **idOrName**(`element`): `string`

Defined in: [src/base/validator.tsx:1378](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1378)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`string`

***

### invalidElements()

> **invalidElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1282)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### numberOfInvalids()

> **numberOfInvalids**(): `number`

Defined in: [src/base/validator.tsx:977](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L977)

#### Returns

`number`

***

### prepareElement()

> **prepareElement**(`element`): `void`

Defined in: [src/base/validator.tsx:1109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1109)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

***

### prepareForm()

> **prepareForm**(): `void`

Defined in: [src/base/validator.tsx:1104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1104)

#### Returns

`void`

***

### previousValue()

> **previousValue**(`element`, `method`): `any`

Defined in: [src/base/validator.tsx:1461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1461)

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

Defined in: [src/base/validator.tsx:1095](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1095)

#### Returns

`void`

***

### resetAll()

> **resetAll**(): `void`

Defined in: [src/base/validator.tsx:1100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1100)

#### Returns

`void`

***

### resetElements()

> **resetElements**(`elements`): `void`

Defined in: [src/base/validator.tsx:961](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L961)

#### Parameters

##### elements

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

`void`

***

### resetForm()

> **resetForm**(): `void`

Defined in: [src/base/validator.tsx:947](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L947)

#### Returns

`void`

***

### resetInternals()

> **resetInternals**(): `void`

Defined in: [src/base/validator.tsx:1087](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1087)

#### Returns

`void`

***

### showErrors()

> **showErrors**(`errors?`): `void`

Defined in: [src/base/validator.tsx:926](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L926)

#### Parameters

##### errors?

[`ValidationErrorMap`](../interfaces/ValidationErrorMap.md)

#### Returns

`void`

***

### showLabel()

> **showLabel**(`element`, `message?`): `void`

Defined in: [src/base/validator.tsx:1286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1286)

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

Defined in: [src/base/validator.tsx:1010](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1010)

#### Returns

`number`

***

### startRequest()

> **startRequest**(`element`): `void`

Defined in: [src/base/validator.tsx:1414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1414)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

***

### stopRequest()

> **stopRequest**(`element`, `valid`): `void`

Defined in: [src/base/validator.tsx:1422](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1422)

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

Defined in: [src/base/validator.tsx:1006](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1006)

#### Returns

`boolean`

***

### validationTargetFor()

> **validationTargetFor**(`element`): [`ValidatableElement`](../interfaces/ValidatableElement.md)

Defined in: [src/base/validator.tsx:1382](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1382)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

***

### validElements()

> **validElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1277)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### addClassRules()

> `static` **addClassRules**(`className`, `rules`): `void`

Defined in: [src/base/validator.tsx:1491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1491)

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

Defined in: [src/base/validator.tsx:1691](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1691)

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

Defined in: [src/base/validator.tsx:1675](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1675)

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

Defined in: [src/base/validator.tsx:1536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1536)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### classRules()

> `static` **classRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:1499](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1499)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### dataRules()

> `static` **dataRules**(`element`): `object`

Defined in: [src/base/validator.tsx:1573](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1573)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`object`

***

### elementValue()

> `static` **elementValue**(`element`): `any`

Defined in: [src/base/validator.tsx:719](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L719)

#### Parameters

##### element

`HTMLElement`

#### Returns

`any`

***

### getHighlightTarget()

> `static` **getHighlightTarget**(`el`): `HTMLElement`

Defined in: [src/base/validator.tsx:1683](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1683)

#### Parameters

##### el

`HTMLElement`

#### Returns

`HTMLElement`

***

### getInstance()

> `static` **getInstance**(`element`): `Validator`

Defined in: [src/base/validator.tsx:649](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L649)

#### Parameters

##### element

`Node` | `HTMLFormElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`Validator`

***

### getLength()

> `static` **getLength**(`value`, `element`): `number`

Defined in: [src/base/validator.tsx:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L701)

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

Defined in: [src/base/validator.tsx:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L697)

#### Parameters

##### element

`Node`

#### Returns

`element is HTMLInputElement`

***

### isContentEditable()

> `static` **isContentEditable**(`element`): `boolean`

Defined in: [src/base/validator.tsx:714](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L714)

#### Parameters

##### element

`HTMLElement`

#### Returns

`boolean`

***

### isValidatableElement()

> `static` **isValidatableElement**(`element`): `element is ValidatableElement`

Defined in: [src/base/validator.tsx:693](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L693)

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

Defined in: [src/base/validator.tsx:1513](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1513)

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

Defined in: [src/base/validator.tsx:1602](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1602)

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

Defined in: [src/base/validator.tsx:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L261)

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

Defined in: [src/base/validator.tsx:1705](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1705)

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

Defined in: [src/base/validator.tsx:801](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L801)

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

Defined in: [src/base/validator.tsx:1591](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1591)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### valid()

> `static` **valid**(`element`): `boolean`

Defined in: [src/base/validator.tsx:786](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L786)

#### Parameters

##### element

`HTMLFormElement` | [`ValidatableElement`](../interfaces/ValidatableElement.md) | `ArrayLike`\<[`ValidatableElement`](../interfaces/ValidatableElement.md)\>

#### Returns

`boolean`
