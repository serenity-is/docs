[@serenity-is/corelib](../README.md) / Validator

# Class: Validator

## Table of contents

### Constructors

- [constructor](Validator.md#constructor)

### Properties

- [dependTypes](Validator.md#dependtypes)
- [lastActive](Validator.md#lastactive)
- [settings](Validator.md#settings)
- [autoCreateRanges](Validator.md#autocreateranges)
- [classRuleSettings](Validator.md#classrulesettings)
- [defaults](Validator.md#defaults)
- [messages](Validator.md#messages)
- [methods](Validator.md#methods)

### Methods

- [abortRequest](Validator.md#abortrequest)
- [check](Validator.md#check)
- [checkForm](Validator.md#checkform)
- [customDataMessage](Validator.md#customdatamessage)
- [customMessage](Validator.md#custommessage)
- [defaultMessage](Validator.md#defaultmessage)
- [defaultShowErrors](Validator.md#defaultshowerrors)
- [depend](Validator.md#depend)
- [destroy](Validator.md#destroy)
- [element](Validator.md#element)
- [elements](Validator.md#elements)
- [errors](Validator.md#errors)
- [errorsFor](Validator.md#errorsfor)
- [findByName](Validator.md#findbyname)
- [findDefined](Validator.md#finddefined)
- [findLastActive](Validator.md#findlastactive)
- [focusInvalid](Validator.md#focusinvalid)
- [form](Validator.md#form)
- [formatAndAdd](Validator.md#formatandadd)
- [hideErrors](Validator.md#hideerrors)
- [hideThese](Validator.md#hidethese)
- [idOrName](Validator.md#idorname)
- [invalidElements](Validator.md#invalidelements)
- [numberOfInvalids](Validator.md#numberofinvalids)
- [prepareElement](Validator.md#prepareelement)
- [prepareForm](Validator.md#prepareform)
- [previousValue](Validator.md#previousvalue)
- [reset](Validator.md#reset)
- [resetAll](Validator.md#resetall)
- [resetElements](Validator.md#resetelements)
- [resetForm](Validator.md#resetform)
- [resetInternals](Validator.md#resetinternals)
- [showErrors](Validator.md#showerrors)
- [showLabel](Validator.md#showlabel)
- [size](Validator.md#size)
- [startRequest](Validator.md#startrequest)
- [stopRequest](Validator.md#stoprequest)
- [valid](Validator.md#valid)
- [validElements](Validator.md#validelements)
- [validationTargetFor](Validator.md#validationtargetfor)
- [addClassRules](Validator.md#addclassrules)
- [addMethod](Validator.md#addmethod)
- [attributeRules](Validator.md#attributerules)
- [classRules](Validator.md#classrules)
- [dataRules](Validator.md#datarules)
- [elementValue](Validator.md#elementvalue)
- [getHighlightTarget](Validator.md#gethighlighttarget)
- [getInstance](Validator.md#getinstance)
- [getLength](Validator.md#getlength)
- [isCheckOrRadio](Validator.md#ischeckorradio)
- [isContentEditable](Validator.md#iscontenteditable)
- [isValidatableElement](Validator.md#isvalidatableelement)
- [normalizeAttributeRule](Validator.md#normalizeattributerule)
- [normalizeRules](Validator.md#normalizerules)
- [optional](Validator.md#optional)
- [rules](Validator.md#rules)
- [staticRules](Validator.md#staticrules)
- [valid](Validator.md#valid-1)

## Constructors

### constructor

• **new Validator**(`form`, `options`): [`Validator`](Validator.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `form` | `HTMLFormElement` |
| `options` | [`ValidatorOptions`](../interfaces/ValidatorOptions.md) |

#### Returns

[`Validator`](Validator.md)

#### Defined in

[src/base/validator.ts:528](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L528)

## Properties

### dependTypes

• **dependTypes**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `boolean` | (`param`: `any`) => `any` |
| `function` | (`param`: `any`, `element`: [`ValidatableElement`](../interfaces/ValidatableElement.md)) => `any` |
| `string` | (`param`: `any`, `element`: [`ValidatableElement`](../interfaces/ValidatableElement.md)) => `boolean` |

#### Defined in

[src/base/validator.ts:1376](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1376)

___

### lastActive

• **lastActive**: [`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Defined in

[src/base/validator.ts:512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L512)

___

### settings

• `Readonly` **settings**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

#### Defined in

[src/base/validator.ts:511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L511)

___

### autoCreateRanges

▪ `Static` **autoCreateRanges**: `boolean` = `false`

#### Defined in

[src/base/validator.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L259)

___

### classRuleSettings

▪ `Static` **classRuleSettings**: `Record`\<`string`, [`ValidationRules`](../README.md#validationrules)\>

#### Defined in

[src/base/validator.ts:1457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1457)

___

### defaults

▪ `Static` **defaults**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

#### Defined in

[src/base/validator.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L261)

___

### messages

▪ `Static` `Readonly` **messages**: `Record`\<`string`, `string` \| `Function`\>

#### Defined in

[src/base/validator.ts:341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L341)

___

### methods

▪ `Static` `Readonly` **methods**: `Record`\<`string`, [`ValidationProvider`](../README.md#validationprovider)\>

#### Defined in

[src/base/validator.ts:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L363)

## Methods

### abortRequest

▸ **abortRequest**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1424](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1424)

___

### check

▸ **check**(`element`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`boolean`

#### Defined in

[src/base/validator.ts:1093](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1093)

___

### checkForm

▸ **checkForm**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/base/validator.ts:865](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L865)

___

### customDataMessage

▸ **customDataMessage**(`element`, `method`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |
| `method` | `string` |

#### Returns

`string`

#### Defined in

[src/base/validator.ts:1174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1174)

___

### customMessage

▸ **customMessage**(`name`, `method`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `method` | `string` |

#### Returns

`any`

#### Defined in

[src/base/validator.ts:1179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1179)

___

### defaultMessage

▸ **defaultMessage**(`element`, `rule`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |
| `rule` | `Object` |
| `rule.method` | `string` |
| `rule.parameters?` | `any` |

#### Returns

`any`

#### Defined in

[src/base/validator.ts:1194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1194)

___

### defaultShowErrors

▸ **defaultShowErrors**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1229](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1229)

___

### depend

▸ **depend**(`param`, `element`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `param` | `any` |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`any`

#### Defined in

[src/base/validator.ts:1388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1388)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1450)

___

### element

▸ **element**(`element`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`boolean`

#### Defined in

[src/base/validator.ts:873](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L873)

___

### elements

▸ **elements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[src/base/validator.ts:1016](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1016)

___

### errors

▸ **errors**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[src/base/validator.ts:1061](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1061)

___

### errorsFor

▸ **errorsFor**(`element`): `HTMLElement`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`HTMLElement`[]

#### Defined in

[src/base/validator.ts:1341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1341)

___

### findByName

▸ **findByName**(`name`): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[src/base/validator.ts:1372](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1372)

___

### findDefined

▸ **findDefined**(`...args`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `...args` | `any`[] |

#### Returns

`any`

#### Defined in

[src/base/validator.ts:1185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1185)

___

### findLastActive

▸ **findLastActive**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Defined in

[src/base/validator.ts:1011](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1011)

___

### focusInvalid

▸ **focusInvalid**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.ts:993](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L993)

___

### form

▸ **form**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/base/validator.ts:854](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L854)

___

### formatAndAdd

▸ **formatAndAdd**(`element`, `rule`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |
| `rule` | `Object` |
| `rule.method` | `string` |
| `rule.parameters` | `any` |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1216](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1216)

___

### hideErrors

▸ **hideErrors**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.ts:974](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L974)

___

### hideThese

▸ **hideThese**(`errors`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `errors` | `HTMLElement`[] |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:978](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L978)

___

### idOrName

▸ **idOrName**(`element`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`string`

#### Defined in

[src/base/validator.ts:1356](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1356)

___

### invalidElements

▸ **invalidElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[src/base/validator.ts:1261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1261)

___

### numberOfInvalids

▸ **numberOfInvalids**(): `number`

#### Returns

`number`

#### Defined in

[src/base/validator.ts:955](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L955)

___

### prepareElement

▸ **prepareElement**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1088](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1088)

___

### prepareForm

▸ **prepareForm**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1083](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1083)

___

### previousValue

▸ **previousValue**(`element`, `method`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |
| `method` | `string` |

#### Returns

`any`

#### Defined in

[src/base/validator.ts:1439](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1439)

___

### reset

▸ **reset**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1074](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1074)

___

### resetAll

▸ **resetAll**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1079](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1079)

___

### resetElements

▸ **resetElements**(`elements`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `elements` | [`ValidatableElement`](../interfaces/ValidatableElement.md)[] |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:939](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L939)

___

### resetForm

▸ **resetForm**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.ts:925](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L925)

___

### resetInternals

▸ **resetInternals**(): `void`

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1066](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1066)

___

### showErrors

▸ **showErrors**(`errors?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `errors?` | [`ValidationErrorMap`](../interfaces/ValidationErrorMap.md) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:904](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L904)

___

### showLabel

▸ **showLabel**(`element`, `message?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |
| `message?` | `string` |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1265)

___

### size

▸ **size**(): `number`

#### Returns

`number`

#### Defined in

[src/base/validator.ts:989](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L989)

___

### startRequest

▸ **startRequest**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1392](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1392)

___

### stopRequest

▸ **stopRequest**(`element`, `valid`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |
| `valid` | `boolean` |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1400](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1400)

___

### valid

▸ **valid**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/base/validator.ts:985](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L985)

___

### validElements

▸ **validElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[src/base/validator.ts:1256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1256)

___

### validationTargetFor

▸ **validationTargetFor**(`element`): [`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Defined in

[src/base/validator.ts:1360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1360)

___

### addClassRules

▸ **addClassRules**(`className`, `rules`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `className` | `any` |
| `rules` | [`ValidationRules`](../README.md#validationrules) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1469)

___

### addMethod

▸ **addMethod**(`name`, `method`, `message?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `method` | [`ValidationProvider`](../README.md#validationprovider) |
| `message?` | `string` |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1652](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1652)

___

### attributeRules

▸ **attributeRules**(`element`): [`ValidationRules`](../README.md#validationrules)

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

[`ValidationRules`](../README.md#validationrules)

#### Defined in

[src/base/validator.ts:1514](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1514)

___

### classRules

▸ **classRules**(`element`): [`ValidationRules`](../README.md#validationrules)

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

[`ValidationRules`](../README.md#validationrules)

#### Defined in

[src/base/validator.ts:1477](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1477)

___

### dataRules

▸ **dataRules**(`element`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`Object`

#### Defined in

[src/base/validator.ts:1550](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1550)

___

### elementValue

▸ **elementValue**(`element`): `string` \| `number` \| `string`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLElement` |

#### Returns

`string` \| `number` \| `string`[]

#### Defined in

[src/base/validator.ts:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L698)

___

### getHighlightTarget

▸ **getHighlightTarget**(`el`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `HTMLElement` |

#### Returns

`HTMLElement`

#### Defined in

[src/base/validator.ts:1660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1660)

___

### getInstance

▸ **getInstance**(`element`): [`Validator`](Validator.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `Node` \| `HTMLFormElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

[`Validator`](Validator.md)

#### Defined in

[src/base/validator.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L628)

___

### getLength

▸ **getLength**(`value`, `element`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`ValidationValue`](../README.md#validationvalue) |
| `element` | `HTMLElement` |

#### Returns

`number`

#### Defined in

[src/base/validator.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L680)

___

### isCheckOrRadio

▸ **isCheckOrRadio**(`element`): element is HTMLInputElement

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `Node` |

#### Returns

element is HTMLInputElement

#### Defined in

[src/base/validator.ts:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L676)

___

### isContentEditable

▸ **isContentEditable**(`element`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLElement` |

#### Returns

`boolean`

#### Defined in

[src/base/validator.ts:693](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L693)

___

### isValidatableElement

▸ **isValidatableElement**(`element`): element is ValidatableElement

Checks if `element` is validatable (`input`, `select`, `textarea`).

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `EventTarget` | The element to check. |

#### Returns

element is ValidatableElement

`true` if validatable, otherwise `false`.

#### Defined in

[src/base/validator.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L672)

___

### normalizeAttributeRule

▸ **normalizeAttributeRule**(`rules`, `type`, `method`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rules` | [`ValidationRules`](../README.md#validationrules) |
| `type` | `string` |
| `method` | `string` |
| `value` | [`ValidationValue`](../README.md#validationvalue) |

#### Returns

`void`

#### Defined in

[src/base/validator.ts:1491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1491)

___

### normalizeRules

▸ **normalizeRules**(`rules`, `element`): [`ValidationRules`](../README.md#validationrules)

#### Parameters

| Name | Type |
| :------ | :------ |
| `rules` | [`ValidationRules`](../README.md#validationrules) |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

[`ValidationRules`](../README.md#validationrules)

#### Defined in

[src/base/validator.ts:1579](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1579)

___

### optional

▸ **optional**(`element`): ``""`` \| ``"dependency-mismatch"``

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

``""`` \| ``"dependency-mismatch"``

#### Defined in

[src/base/validator.ts:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L254)

___

### rules

▸ **rules**(`element`, `command?`, `argument?`): `Record`\<`string`, `any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |
| `command?` | ``"remove"`` \| ``"add"`` |
| `argument?` | `any` |

#### Returns

`Record`\<`string`, `any`\>

#### Defined in

[src/base/validator.ts:779](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L779)

___

### staticRules

▸ **staticRules**(`element`): [`ValidationRules`](../README.md#validationrules)

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

[`ValidationRules`](../README.md#validationrules)

#### Defined in

[src/base/validator.ts:1568](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L1568)

___

### valid

▸ **valid**(`element`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLFormElement` \| [`ValidatableElement`](../interfaces/ValidatableElement.md) \| `ArrayLike`\<[`ValidatableElement`](../interfaces/ValidatableElement.md)\> |

#### Returns

`boolean`

#### Defined in

[src/base/validator.ts:764](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.ts#L764)
