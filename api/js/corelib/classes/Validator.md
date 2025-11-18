[@serenity-is/corelib](../README.md) / Validator

# Class: Validator

Defined in: [src/base/validator.tsx:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L259)

## Constructors

### Constructor

> **new Validator**(`form`, `options`): `Validator`

Defined in: [src/base/validator.tsx:556](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L556)

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

Defined in: [src/base/validator.tsx:1402](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1402)

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

Defined in: [src/base/validator.tsx:540](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L540)

***

### settings

> `readonly` **settings**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Defined in: [src/base/validator.tsx:539](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L539)

***

### autoCreateRanges

> `static` **autoCreateRanges**: `boolean` = `false`

Defined in: [src/base/validator.tsx:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L267)

***

### classRuleSettings

> `static` **classRuleSettings**: `Record`\<`string`, [`ValidationRules`](../type-aliases/ValidationRules.md)\>

Defined in: [src/base/validator.tsx:1483](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1483)

***

### defaults

> `static` **defaults**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

Defined in: [src/base/validator.tsx:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L269)

***

### excludedModifierKeys

> `readonly` `static` **excludedModifierKeys**: `Set`\<`string`\>

Defined in: [src/base/validator.tsx:1727](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1727)

***

### messages

> `readonly` `static` **messages**: `Record`\<`string`, `string` \| `Function`\>

Defined in: [src/base/validator.tsx:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L361)

***

### methods

> `readonly` `static` **methods**: `Record`\<`string`, [`ValidationProvider`](../type-aliases/ValidationProvider.md)\>

Defined in: [src/base/validator.tsx:383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L383)

## Methods

### abortRequest()

> **abortRequest**(`element`): `void`

Defined in: [src/base/validator.tsx:1450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1450)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

***

### check()

> **check**(`element`): `boolean`

Defined in: [src/base/validator.tsx:1118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1118)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`boolean`

***

### checkForm()

> **checkForm**(): `boolean`

Defined in: [src/base/validator.tsx:892](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L892)

#### Returns

`boolean`

***

### customDataMessage()

> **customDataMessage**(`element`, `method`): `string`

Defined in: [src/base/validator.tsx:1199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1199)

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

Defined in: [src/base/validator.tsx:1204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1204)

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

Defined in: [src/base/validator.tsx:1219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1219)

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

Defined in: [src/base/validator.tsx:1254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1254)

#### Returns

`void`

***

### depend()

> **depend**(`param`, `element`): `any`

Defined in: [src/base/validator.tsx:1414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1414)

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

Defined in: [src/base/validator.tsx:1476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1476)

#### Returns

`void`

***

### element()

> **element**(`element`): `boolean`

Defined in: [src/base/validator.tsx:900](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L900)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`boolean`

***

### elements()

> **elements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1041](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1041)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### errors()

> **errors**(): `HTMLElement`[]

Defined in: [src/base/validator.tsx:1086](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1086)

#### Returns

`HTMLElement`[]

***

### errorsFor()

> **errorsFor**(`element`): `HTMLElement`[]

Defined in: [src/base/validator.tsx:1367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1367)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`HTMLElement`[]

***

### findByName()

> **findByName**(`name`): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1398](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1398)

#### Parameters

##### name

`string`

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### findDefined()

> **findDefined**(...`args`): `any`

Defined in: [src/base/validator.tsx:1210](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1210)

#### Parameters

##### args

...`any`[]

#### Returns

`any`

***

### findLastActive()

> **findLastActive**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)

Defined in: [src/base/validator.tsx:1036](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1036)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

***

### focusInvalid()

> **focusInvalid**(): `void`

Defined in: [src/base/validator.tsx:1018](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1018)

#### Returns

`void`

***

### form()

> **form**(): `boolean`

Defined in: [src/base/validator.tsx:881](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L881)

#### Returns

`boolean`

***

### formatAndAdd()

> **formatAndAdd**(`element`, `rule`): `void`

Defined in: [src/base/validator.tsx:1241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1241)

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

Defined in: [src/base/validator.tsx:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L999)

#### Returns

`void`

***

### hideThese()

> **hideThese**(`errors`): `void`

Defined in: [src/base/validator.tsx:1003](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1003)

#### Parameters

##### errors

`HTMLElement`[]

#### Returns

`void`

***

### idOrName()

> **idOrName**(`element`): `string`

Defined in: [src/base/validator.tsx:1382](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1382)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`string`

***

### invalidElements()

> **invalidElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1286)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### numberOfInvalids()

> **numberOfInvalids**(): `number`

Defined in: [src/base/validator.tsx:981](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L981)

#### Returns

`number`

***

### prepareElement()

> **prepareElement**(`element`): `void`

Defined in: [src/base/validator.tsx:1113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1113)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

***

### prepareForm()

> **prepareForm**(): `void`

Defined in: [src/base/validator.tsx:1108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1108)

#### Returns

`void`

***

### previousValue()

> **previousValue**(`element`, `method`): `any`

Defined in: [src/base/validator.tsx:1465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1465)

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

Defined in: [src/base/validator.tsx:1099](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1099)

#### Returns

`void`

***

### resetAll()

> **resetAll**(): `void`

Defined in: [src/base/validator.tsx:1104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1104)

#### Returns

`void`

***

### resetElements()

> **resetElements**(`elements`): `void`

Defined in: [src/base/validator.tsx:965](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L965)

#### Parameters

##### elements

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

`void`

***

### resetForm()

> **resetForm**(): `void`

Defined in: [src/base/validator.tsx:951](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L951)

#### Returns

`void`

***

### resetInternals()

> **resetInternals**(): `void`

Defined in: [src/base/validator.tsx:1091](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1091)

#### Returns

`void`

***

### showErrors()

> **showErrors**(`errors?`): `void`

Defined in: [src/base/validator.tsx:930](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L930)

#### Parameters

##### errors?

[`ValidationErrorMap`](../interfaces/ValidationErrorMap.md)

#### Returns

`void`

***

### showLabel()

> **showLabel**(`element`, `message?`): `void`

Defined in: [src/base/validator.tsx:1290](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1290)

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

Defined in: [src/base/validator.tsx:1014](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1014)

#### Returns

`number`

***

### startRequest()

> **startRequest**(`element`): `void`

Defined in: [src/base/validator.tsx:1418](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1418)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

***

### stopRequest()

> **stopRequest**(`element`, `valid`): `void`

Defined in: [src/base/validator.tsx:1426](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1426)

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

Defined in: [src/base/validator.tsx:1010](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1010)

#### Returns

`boolean`

***

### validationTargetFor()

> **validationTargetFor**(`element`): [`ValidatableElement`](../interfaces/ValidatableElement.md)

Defined in: [src/base/validator.tsx:1386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1386)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

***

### validElements()

> **validElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

Defined in: [src/base/validator.tsx:1281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1281)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

***

### addClassRules()

> `static` **addClassRules**(`className`, `rules`): `void`

Defined in: [src/base/validator.tsx:1495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1495)

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

Defined in: [src/base/validator.tsx:1697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1697)

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

Defined in: [src/base/validator.tsx:1679](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1679)

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

Defined in: [src/base/validator.tsx:1540](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1540)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### classRules()

> `static` **classRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

Defined in: [src/base/validator.tsx:1503](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1503)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### dataRules()

> `static` **dataRules**(`element`): `object`

Defined in: [src/base/validator.tsx:1577](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1577)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`object`

***

### elementValue()

> `static` **elementValue**(`element`): `any`

Defined in: [src/base/validator.tsx:723](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L723)

#### Parameters

##### element

`HTMLElement`

#### Returns

`any`

***

### getHighlightTarget()

> `static` **getHighlightTarget**(`el`): `HTMLElement`

Defined in: [src/base/validator.tsx:1687](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1687)

#### Parameters

##### el

`HTMLElement`

#### Returns

`HTMLElement`

***

### getInstance()

> `static` **getInstance**(`element`): `Validator`

Defined in: [src/base/validator.tsx:653](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L653)

#### Parameters

##### element

`Node` | `HTMLFormElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`Validator`

***

### getLength()

> `static` **getLength**(`value`, `element`): `number`

Defined in: [src/base/validator.tsx:705](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L705)

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

Defined in: [src/base/validator.tsx:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L701)

#### Parameters

##### element

`Node`

#### Returns

`element is HTMLInputElement`

***

### isContentEditable()

> `static` **isContentEditable**(`element`): `boolean`

Defined in: [src/base/validator.tsx:718](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L718)

#### Parameters

##### element

`HTMLElement`

#### Returns

`boolean`

***

### isValidatableElement()

> `static` **isValidatableElement**(`element`): `element is ValidatableElement`

Defined in: [src/base/validator.tsx:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L697)

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

Defined in: [src/base/validator.tsx:1517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1517)

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

Defined in: [src/base/validator.tsx:1606](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1606)

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

Defined in: [src/base/validator.tsx:1711](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1711)

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

Defined in: [src/base/validator.tsx:805](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L805)

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

Defined in: [src/base/validator.tsx:1595](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1595)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

***

### valid()

> `static` **valid**(`element`): `boolean`

Defined in: [src/base/validator.tsx:790](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L790)

#### Parameters

##### element

`HTMLFormElement` | [`ValidatableElement`](../interfaces/ValidatableElement.md) | `ArrayLike`\<[`ValidatableElement`](../interfaces/ValidatableElement.md)\>

#### Returns

`boolean`
