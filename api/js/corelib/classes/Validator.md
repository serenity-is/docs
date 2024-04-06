[@serenity-is/corelib](../README.md) / Validator

# Class: Validator

## Table of contents

### Constructors

- [constructor](Validator.md#constructor)

### Properties

- [cancelSubmit](Validator.md#cancelsubmit)
- [currentElements](Validator.md#currentelements)
- [currentForm](Validator.md#currentform)
- [dependTypes](Validator.md#dependtypes)
- [errorList](Validator.md#errorlist)
- [errorMap](Validator.md#errormap)
- [formSubmitted](Validator.md#formsubmitted)
- [init](Validator.md#init)
- [invalid](Validator.md#invalid)
- [lastActive](Validator.md#lastactive)
- [pending](Validator.md#pending)
- [pendingRequest](Validator.md#pendingrequest)
- [settings](Validator.md#settings)
- [submitButton](Validator.md#submitbutton)
- [submitted](Validator.md#submitted)
- [successList](Validator.md#successlist)
- [toHide](Validator.md#tohide)
- [toShow](Validator.md#toshow)
- [autoCreateRanges](Validator.md#autocreateranges)
- [classRuleSettings](Validator.md#classrulesettings)
- [defaults](Validator.md#defaults)
- [messages](Validator.md#messages)
- [methods](Validator.md#methods)
- [objectLength](Validator.md#objectlength)

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

[../base/dist/index.d.ts:1882](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1882)

## Properties

### cancelSubmit

• `Private` **cancelSubmit**: `any`

#### Defined in

[../base/dist/index.d.ts:1868](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1868)

___

### currentElements

• `Private` **currentElements**: `any`

#### Defined in

[../base/dist/index.d.ts:1869](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1869)

___

### currentForm

• `Private` **currentForm**: `any`

#### Defined in

[../base/dist/index.d.ts:1870](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1870)

___

### dependTypes

• **dependTypes**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `boolean` | (`param`: `any`) => `any` |
| `function` | (`param`: `any`, `element`: [`ValidatableElement`](../interfaces/ValidatableElement.md)) => `any` |
| `string` | (`param`: `any`, `element`: [`ValidatableElement`](../interfaces/ValidatableElement.md)) => `boolean` |

#### Defined in

[../base/dist/index.d.ts:1938](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1938)

___

### errorList

• `Private` **errorList**: `any`

#### Defined in

[../base/dist/index.d.ts:1872](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1872)

___

### errorMap

• `Private` **errorMap**: `any`

#### Defined in

[../base/dist/index.d.ts:1871](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1871)

___

### formSubmitted

• `Private` **formSubmitted**: `any`

#### Defined in

[../base/dist/index.d.ts:1873](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1873)

___

### init

• `Private` **init**: `any`

#### Defined in

[../base/dist/index.d.ts:1884](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1884)

___

### invalid

• `Private` **invalid**: `any`

#### Defined in

[../base/dist/index.d.ts:1877](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1877)

___

### lastActive

• **lastActive**: [`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Defined in

[../base/dist/index.d.ts:1867](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1867)

___

### pending

• `Private` **pending**: `any`

#### Defined in

[../base/dist/index.d.ts:1878](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1878)

___

### pendingRequest

• `Private` **pendingRequest**: `any`

#### Defined in

[../base/dist/index.d.ts:1876](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1876)

___

### settings

• `Readonly` **settings**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

#### Defined in

[../base/dist/index.d.ts:1866](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1866)

___

### submitButton

• `Private` **submitButton**: `any`

#### Defined in

[../base/dist/index.d.ts:1875](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1875)

___

### submitted

• `Private` **submitted**: `any`

#### Defined in

[../base/dist/index.d.ts:1874](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1874)

___

### successList

• `Private` **successList**: `any`

#### Defined in

[../base/dist/index.d.ts:1879](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1879)

___

### toHide

• `Private` **toHide**: `any`

#### Defined in

[../base/dist/index.d.ts:1880](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1880)

___

### toShow

• `Private` **toShow**: `any`

#### Defined in

[../base/dist/index.d.ts:1881](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1881)

___

### autoCreateRanges

▪ `Static` **autoCreateRanges**: `boolean`

#### Defined in

[../base/dist/index.d.ts:1862](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1862)

___

### classRuleSettings

▪ `Static` **classRuleSettings**: `Record`\<`string`, `ValidationRules`\>

#### Defined in

[../base/dist/index.d.ts:1949](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1949)

___

### defaults

▪ `Static` **defaults**: [`ValidatorOptions`](../interfaces/ValidatorOptions.md)

#### Defined in

[../base/dist/index.d.ts:1863](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1863)

___

### messages

▪ `Static` `Readonly` **messages**: `Record`\<`string`, `string` \| `Function`\>

#### Defined in

[../base/dist/index.d.ts:1864](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1864)

___

### methods

▪ `Static` `Readonly` **methods**: `Record`\<`string`, [`ValidationProvider`](../README.md#validationprovider)\>

#### Defined in

[../base/dist/index.d.ts:1865](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1865)

___

### objectLength

▪ `Static` `Private` **objectLength**: `any`

#### Defined in

[../base/dist/index.d.ts:1904](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1904)

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

[../base/dist/index.d.ts:1946](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1946)

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

[../base/dist/index.d.ts:1918](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1918)

___

### checkForm

▸ **checkForm**(): `boolean`

#### Returns

`boolean`

#### Defined in

[../base/dist/index.d.ts:1898](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1898)

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

[../base/dist/index.d.ts:1919](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1919)

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

[../base/dist/index.d.ts:1920](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1920)

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

[../base/dist/index.d.ts:1922](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1922)

___

### defaultShowErrors

▸ **defaultShowErrors**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1930](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1930)

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

[../base/dist/index.d.ts:1943](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1943)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1948](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1948)

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

[../base/dist/index.d.ts:1899](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1899)

___

### elements

▸ **elements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[../base/dist/index.d.ts:1911](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1911)

___

### errors

▸ **errors**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[../base/dist/index.d.ts:1912](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1912)

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

[../base/dist/index.d.ts:1934](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1934)

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

[../base/dist/index.d.ts:1937](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1937)

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

[../base/dist/index.d.ts:1921](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1921)

___

### findLastActive

▸ **findLastActive**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)

#### Defined in

[../base/dist/index.d.ts:1910](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1910)

___

### focusInvalid

▸ **focusInvalid**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1909](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1909)

___

### form

▸ **form**(): `boolean`

#### Returns

`boolean`

#### Defined in

[../base/dist/index.d.ts:1897](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1897)

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

[../base/dist/index.d.ts:1926](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1926)

___

### hideErrors

▸ **hideErrors**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1905](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1905)

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

[../base/dist/index.d.ts:1906](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1906)

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

[../base/dist/index.d.ts:1935](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1935)

___

### invalidElements

▸ **invalidElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[../base/dist/index.d.ts:1932](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1932)

___

### numberOfInvalids

▸ **numberOfInvalids**(): `number`

#### Returns

`number`

#### Defined in

[../base/dist/index.d.ts:1903](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1903)

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

[../base/dist/index.d.ts:1917](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1917)

___

### prepareForm

▸ **prepareForm**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1916](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1916)

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

[../base/dist/index.d.ts:1947](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1947)

___

### reset

▸ **reset**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1914](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1914)

___

### resetAll

▸ **resetAll**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1915](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1915)

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

[../base/dist/index.d.ts:1902](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1902)

___

### resetForm

▸ **resetForm**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1901](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1901)

___

### resetInternals

▸ **resetInternals**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1913](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1913)

___

### showErrors

▸ **showErrors**(`errors?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `errors?` | `ValidationErrorMap` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1900](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1900)

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

[../base/dist/index.d.ts:1933](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1933)

___

### size

▸ **size**(): `number`

#### Returns

`number`

#### Defined in

[../base/dist/index.d.ts:1908](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1908)

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

[../base/dist/index.d.ts:1944](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1944)

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

[../base/dist/index.d.ts:1945](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1945)

___

### valid

▸ **valid**(): `boolean`

#### Returns

`boolean`

#### Defined in

[../base/dist/index.d.ts:1907](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1907)

___

### validElements

▸ **validElements**(): [`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Returns

[`ValidatableElement`](../interfaces/ValidatableElement.md)[]

#### Defined in

[../base/dist/index.d.ts:1931](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1931)

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

[../base/dist/index.d.ts:1936](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1936)

___

### addClassRules

▸ **addClassRules**(`className`, `rules`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `className` | `any` |
| `rules` | `ValidationRules` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1950](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1950)

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

[../base/dist/index.d.ts:1957](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1957)

___

### attributeRules

▸ **attributeRules**(`element`): `ValidationRules`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`ValidationRules`

#### Defined in

[../base/dist/index.d.ts:1953](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1953)

___

### classRules

▸ **classRules**(`element`): `ValidationRules`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`ValidationRules`

#### Defined in

[../base/dist/index.d.ts:1951](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1951)

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

[../base/dist/index.d.ts:1954](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1954)

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

[../base/dist/index.d.ts:1894](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1894)

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

[../base/dist/index.d.ts:1958](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1958)

___

### getInstance

▸ **getInstance**(`element`): [`Validator`](Validator.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `Node` \| `ArrayLike`\<`HTMLElement`\> \| `HTMLFormElement` |

#### Returns

[`Validator`](Validator.md)

#### Defined in

[../base/dist/index.d.ts:1883](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1883)

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

[../base/dist/index.d.ts:1892](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1892)

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

[../base/dist/index.d.ts:1891](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1891)

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

[../base/dist/index.d.ts:1893](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1893)

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

[../base/dist/index.d.ts:1890](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1890)

___

### normalizeAttributeRule

▸ **normalizeAttributeRule**(`rules`, `type`, `method`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rules` | `ValidationRules` |
| `type` | `string` |
| `method` | `string` |
| `value` | [`ValidationValue`](../README.md#validationvalue) |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1952](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1952)

___

### normalizeRules

▸ **normalizeRules**(`rules`, `element`): `ValidationRules`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rules` | `ValidationRules` |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`ValidationRules`

#### Defined in

[../base/dist/index.d.ts:1956](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1956)

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

[../base/dist/index.d.ts:1861](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1861)

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

[../base/dist/index.d.ts:1896](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1896)

___

### staticRules

▸ **staticRules**(`element`): `ValidationRules`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ValidatableElement`](../interfaces/ValidatableElement.md) |

#### Returns

`ValidationRules`

#### Defined in

[../base/dist/index.d.ts:1955](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1955)

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

[../base/dist/index.d.ts:1895](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1895)
