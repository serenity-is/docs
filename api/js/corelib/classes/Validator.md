[@serenity-is/corelib](../README.md) / Validator

# Class: Validator

## Constructors

### new Validator()

> **new Validator**(`form`, `options`): [`Validator`](Validator.md)

#### Parameters

##### form

`HTMLFormElement`

##### options

[`ValidatorOptions`](../interfaces/ValidatorOptions.md)

#### Returns

[`Validator`](Validator.md)

#### Defined in

[src/base/validator.tsx:528](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L528)

## Properties

### dependTypes

> **dependTypes**: `object`

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

#### Defined in

[src/base/validator.tsx:1373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1373)

***

### lastActive

> **lastActive**: [`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Defined in

[src/base/validator.tsx:512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L512)

***

### settings

> `readonly` **settings**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

#### Defined in

[src/base/validator.tsx:511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L511)

***

### autoCreateRanges

> `static` **autoCreateRanges**: `boolean` = `false`

#### Defined in

[src/base/validator.tsx:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L259)

***

### classRuleSettings

> `static` **classRuleSettings**: `Record`\<`string`, [`ValidationRules`](../type-aliases/ValidationRules.md)\>

#### Defined in

[src/base/validator.tsx:1454](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1454)

***

### defaults

> `static` **defaults**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

#### Defined in

[src/base/validator.tsx:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L261)

***

### messages

> `readonly` `static` **messages**: `Record`\<`string`, `string` \| `Function`\>

#### Defined in

[src/base/validator.tsx:341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L341)

***

### methods

> `readonly` `static` **methods**: `Record`\<`string`, [`ValidationProvider`](../type-aliases/ValidationProvider.md)\>

#### Defined in

[src/base/validator.tsx:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L363)

## Methods

### abortRequest()

> **abortRequest**(`element`): `void`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1421](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1421)

***

### check()

> **check**(`element`): `boolean`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`boolean`

#### Defined in

[src/base/validator.tsx:1090](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1090)

***

### checkForm()

> **checkForm**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/base/validator.tsx:862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L862)

***

### customDataMessage()

> **customDataMessage**(`element`, `method`): `string`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### method

`string`

#### Returns

`string`

#### Defined in

[src/base/validator.tsx:1171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1171)

***

### customMessage()

> **customMessage**(`name`, `method`): `any`

#### Parameters

##### name

`string`

##### method

`string`

#### Returns

`any`

#### Defined in

[src/base/validator.tsx:1176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1176)

***

### defaultMessage()

> **defaultMessage**(`element`, `rule`): `any`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### rule

###### rule.method

`string`

###### rule.parameters

`any`

#### Returns

`any`

#### Defined in

[src/base/validator.tsx:1191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1191)

***

### defaultShowErrors()

> **defaultShowErrors**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1226)

***

### depend()

> **depend**(`param`, `element`): `any`

#### Parameters

##### param

`any`

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`any`

#### Defined in

[src/base/validator.tsx:1385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1385)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1447](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1447)

***

### element()

> **element**(`element`): `boolean`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`boolean`

#### Defined in

[src/base/validator.tsx:870](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L870)

***

### elements()

> **elements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[src/base/validator.tsx:1013](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1013)

***

### errors()

> **errors**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[src/base/validator.tsx:1058](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1058)

***

### errorsFor()

> **errorsFor**(`element`): `HTMLElement`[]

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`HTMLElement`[]

#### Defined in

[src/base/validator.tsx:1338](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1338)

***

### findByName()

> **findByName**(`name`): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Parameters

##### name

`string`

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[src/base/validator.tsx:1369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1369)

***

### findDefined()

> **findDefined**(...`args`): `any`

#### Parameters

##### args

...`any`[]

#### Returns

`any`

#### Defined in

[src/base/validator.tsx:1182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1182)

***

### findLastActive()

> **findLastActive**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Defined in

[src/base/validator.tsx:1008](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1008)

***

### focusInvalid()

> **focusInvalid**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:990](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L990)

***

### form()

> **form**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/base/validator.tsx:851](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L851)

***

### formatAndAdd()

> **formatAndAdd**(`element`, `rule`): `void`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### rule

###### rule.method

`string`

###### rule.parameters

`any`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1213)

***

### hideErrors()

> **hideErrors**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:971](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L971)

***

### hideThese()

> **hideThese**(`errors`): `void`

#### Parameters

##### errors

`HTMLElement`[]

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:975](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L975)

***

### idOrName()

> **idOrName**(`element`): `string`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`string`

#### Defined in

[src/base/validator.tsx:1353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1353)

***

### invalidElements()

> **invalidElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[src/base/validator.tsx:1258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1258)

***

### numberOfInvalids()

> **numberOfInvalids**(): `number`

#### Returns

`number`

#### Defined in

[src/base/validator.tsx:952](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L952)

***

### prepareElement()

> **prepareElement**(`element`): `void`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1085](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1085)

***

### prepareForm()

> **prepareForm**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1080](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1080)

***

### previousValue()

> **previousValue**(`element`, `method`): `any`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### method

`string`

#### Returns

`any`

#### Defined in

[src/base/validator.tsx:1436](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1436)

***

### reset()

> **reset**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1071](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1071)

***

### resetAll()

> **resetAll**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1076](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1076)

***

### resetElements()

> **resetElements**(`elements`): `void`

#### Parameters

##### elements

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:936](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L936)

***

### resetForm()

> **resetForm**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:922](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L922)

***

### resetInternals()

> **resetInternals**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1063](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1063)

***

### showErrors()

> **showErrors**(`errors`?): `void`

#### Parameters

##### errors?

[`ValidationErrorMap`](../interfaces/ValidationErrorMap.md)

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:901](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L901)

***

### showLabel()

> **showLabel**(`element`, `message`?): `void`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### message?

`string`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1262)

***

### size()

> **size**(): `number`

#### Returns

`number`

#### Defined in

[src/base/validator.tsx:986](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L986)

***

### startRequest()

> **startRequest**(`element`): `void`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1389](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1389)

***

### stopRequest()

> **stopRequest**(`element`, `valid`): `void`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### valid

`boolean`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1397](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1397)

***

### valid()

> **valid**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/base/validator.tsx:982](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L982)

***

### validationTargetFor()

> **validationTargetFor**(`element`): [`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Defined in

[src/base/validator.tsx:1357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1357)

***

### validElements()

> **validElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[src/base/validator.tsx:1253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1253)

***

### addClassRules()

> `static` **addClassRules**(`className`, `rules`): `void`

#### Parameters

##### className

`any`

##### rules

[`ValidationRules`](../type-aliases/ValidationRules.md)

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1466](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1466)

***

### addMethod()

> `static` **addMethod**(`name`, `method`, `message`?): `void`

#### Parameters

##### name

`string`

##### method

[`ValidationProvider`](../type-aliases/ValidationProvider.md)

##### message?

`string`

#### Returns

`void`

#### Defined in

[src/base/validator.tsx:1649](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1649)

***

### attributeRules()

> `static` **attributeRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

#### Defined in

[src/base/validator.tsx:1511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1511)

***

### classRules()

> `static` **classRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

#### Defined in

[src/base/validator.tsx:1474](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1474)

***

### dataRules()

> `static` **dataRules**(`element`): `object`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`object`

#### Defined in

[src/base/validator.tsx:1547](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1547)

***

### elementValue()

> `static` **elementValue**(`element`): `string` \| `number` \| `string`[]

#### Parameters

##### element

`HTMLElement`

#### Returns

`string` \| `number` \| `string`[]

#### Defined in

[src/base/validator.tsx:695](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L695)

***

### getHighlightTarget()

> `static` **getHighlightTarget**(`el`): `HTMLElement`

#### Parameters

##### el

`HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[src/base/validator.tsx:1657](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1657)

***

### getInstance()

> `static` **getInstance**(`element`): [`Validator`](Validator.md)

#### Parameters

##### element

`Node` | `HTMLFormElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

[`Validator`](Validator.md)

#### Defined in

[src/base/validator.tsx:625](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L625)

***

### getLength()

> `static` **getLength**(`value`, `element`): `number`

#### Parameters

##### value

[`ValidationValue`](../type-aliases/ValidationValue.md)

##### element

`HTMLElement`

#### Returns

`number`

#### Defined in

[src/base/validator.tsx:677](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L677)

***

### isCheckOrRadio()

> `static` **isCheckOrRadio**(`element`): `element is HTMLInputElement`

#### Parameters

##### element

`Node`

#### Returns

`element is HTMLInputElement`

#### Defined in

[src/base/validator.tsx:673](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L673)

***

### isContentEditable()

> `static` **isContentEditable**(`element`): `boolean`

#### Parameters

##### element

`HTMLElement`

#### Returns

`boolean`

#### Defined in

[src/base/validator.tsx:690](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L690)

***

### isValidatableElement()

> `static` **isValidatableElement**(`element`): `element is ValidatableElement`

Checks if `element` is validatable (`input`, `select`, `textarea`).

#### Parameters

##### element

`EventTarget`

The element to check.

#### Returns

`element is ValidatableElement`

`true` if validatable, otherwise `false`.

#### Defined in

[src/base/validator.tsx:669](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L669)

***

### normalizeAttributeRule()

> `static` **normalizeAttributeRule**(`rules`, `type`, `method`, `value`): `void`

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

#### Defined in

[src/base/validator.tsx:1488](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1488)

***

### normalizeRules()

> `static` **normalizeRules**(`rules`, `element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

#### Parameters

##### rules

[`ValidationRules`](../type-aliases/ValidationRules.md)

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

#### Defined in

[src/base/validator.tsx:1576](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1576)

***

### optional()

> `static` **optional**(`element`): `""` \| `"dependency-mismatch"`

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

`""` \| `"dependency-mismatch"`

#### Defined in

[src/base/validator.tsx:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L254)

***

### rules()

> `static` **rules**(`element`, `command`?, `argument`?): `Record`\<`string`, `any`\>

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

##### command?

`"remove"` | `"add"`

##### argument?

`any`

#### Returns

`Record`\<`string`, `any`\>

#### Defined in

[src/base/validator.tsx:776](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L776)

***

### staticRules()

> `static` **staticRules**(`element`): [`ValidationRules`](../type-aliases/ValidationRules.md)

#### Parameters

##### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidationRules`](../type-aliases/ValidationRules.md)

#### Defined in

[src/base/validator.tsx:1565](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L1565)

***

### valid()

> `static` **valid**(`element`): `boolean`

#### Parameters

##### element

`HTMLFormElement` | [`ValidatableElement`](../interfaces/ValidatableElement.md) | `ArrayLike`\<[`ValidatableElement`](../interfaces/ValidatableElement.md)\>

#### Returns

`boolean`

#### Defined in

[src/base/validator.tsx:761](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L761)
