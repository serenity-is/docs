[@serenity-is/corelib](../README.md) / RangeValidationRule

# Class: RangeValidationRule

Defined in: [src/ui/helpers/builtinvalidationrules.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L27)

Requires a value between a minimum and a maximum, both included: numbers, or texts like dates in the ISO format.

## Extends

- [`ValidationRule`](ValidationRule.md)

## Constructors

### Constructor

> **new RangeValidationRule**(): `RangeValidationRule`

#### Returns

`RangeValidationRule`

#### Inherited from

[`ValidationRule`](ValidationRule.md).[`constructor`](ValidationRule.md#constructor)

## Properties

### defaultText

> **defaultText**: `string` = `"Please enter a value between {0} and {1}."`

Defined in: [src/ui/helpers/builtinvalidationrules.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L30)

The text of the message for when its key has no text, e.g. the English one.

#### Overrides

[`ValidationRule`](ValidationRule.md).[`defaultText`](ValidationRule.md#defaulttext)

***

### textKey

> **textKey**: `string` = `"Validation.Range"`

Defined in: [src/ui/helpers/builtinvalidationrules.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L29)

The local text key of the message of the rule, which can have the parameters of the rule as `{0}`, `{1}`, used when
the attribute gives no message of its own.

#### Overrides

[`ValidationRule`](ValidationRule.md).[`textKey`](ValidationRule.md#textkey)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/helpers/builtinvalidationrules.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L28)

#### Overrides

[`ValidationRule`](ValidationRule.md).[`[typeInfo]`](ValidationRule.md#typeinfo)

## Methods

### check()

> **check**(`value`, `params`): `boolean`

Defined in: [src/ui/helpers/builtinvalidationrules.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L32)

Checks a value by the rule. It is not called for an empty value, i.e. null, an empty string or an empty list, as
being required is a rule of its own.

#### Parameters

##### value

`any`

The value, e.g. a number for a decimal editor, or a text.

##### params

`any`[]

The parameters of the rule, as the server sends them.

#### Returns

`boolean`

Whether the value is valid.

#### Overrides

[`ValidationRule`](ValidationRule.md).[`check`](ValidationRule.md#check)

***

### getDefaultText()

> **getDefaultText**(`params`): `string`

Defined in: [src/base/validationrule.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L59)

Gets the text of the message for when its key has no text, by default [defaultText](ValidationRule.md#defaulttext).

#### Parameters

##### params

`any`

The parameters of the rule.

#### Returns

`string`

#### Inherited from

[`ValidationRule`](ValidationRule.md).[`getDefaultText`](ValidationRule.md#getdefaulttext)

***

### getMessageArgs()

> **getMessageArgs**(`params`): `any`[]

Defined in: [src/base/validationrule.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L67)

Gets what the message has as `{0}`, `{1}` and so on, by default the parameters of the rule.

#### Parameters

##### params

`any`

The parameters of the rule.

#### Returns

`any`[]

#### Inherited from

[`ValidationRule`](ValidationRule.md).[`getMessageArgs`](ValidationRule.md#getmessageargs)

***

### getTextKey()

> **getTextKey**(`params`): `string`

Defined in: [src/base/validationrule.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L51)

Gets the local text key of the message, by default [textKey](ValidationRule.md#textkey), which a rule can choose by its parameters, e.g.
a length rule by whether it has a minimum.

#### Parameters

##### params

`any`

The parameters of the rule.

#### Returns

`string`

#### Inherited from

[`ValidationRule`](ValidationRule.md).[`getTextKey`](ValidationRule.md#gettextkey)

***

### registerRule()

> `protected` `static` **registerRule**\<`TypeName`\>(`typeName`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/base/validationrule.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L75)

Registers a rule class by its type key, e.g. `this.registerRule("MyApp.")` for `MyApp.EvenValidationRule`.

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

The full name of the type, or its namespace ending with a dot.

#### Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

#### Inherited from

[`ValidationRule`](ValidationRule.md).[`registerRule`](ValidationRule.md#registerrule)
