[@serenity-is/corelib](../README.md) / LengthValidationRule

# Class: LengthValidationRule

Defined in: [src/ui/helpers/builtinvalidationrules.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L38)

Requires the length of a text, or of a list, to be between a minimum and a maximum, the parameters being `[min, max]`.

## Extends

- [`ValidationRule`](ValidationRule.md)

## Constructors

### Constructor

> **new LengthValidationRule**(): `LengthValidationRule`

#### Returns

`LengthValidationRule`

#### Inherited from

[`ValidationRule`](ValidationRule.md).[`constructor`](ValidationRule.md#constructor)

## Properties

### defaultText

> **defaultText**: `string` = `"Please enter no more than {0} characters."`

Defined in: [src/ui/helpers/builtinvalidationrules.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L41)

The text of the message for when its key has no text, e.g. the English one.

#### Overrides

[`ValidationRule`](ValidationRule.md).[`defaultText`](ValidationRule.md#defaulttext)

***

### textKey

> **textKey**: `string` = `"Validation.MaxLength"`

Defined in: [src/ui/helpers/builtinvalidationrules.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L40)

The local text key of the message of the rule, which can have the parameters of the rule as `{0}`, `{1}`, used when
the attribute gives no message of its own.

#### Overrides

[`ValidationRule`](ValidationRule.md).[`textKey`](ValidationRule.md#textkey)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/helpers/builtinvalidationrules.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L39)

#### Overrides

[`ValidationRule`](ValidationRule.md).[`[typeInfo]`](ValidationRule.md#typeinfo)

## Methods

### check()

> **check**(`value`, `params`): `boolean`

Defined in: [src/ui/helpers/builtinvalidationrules.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L43)

Checks a value by the rule. It is not called for an empty value, i.e. null, an empty string or an empty list, as
being required is a rule of its own.

#### Parameters

##### value

`any`

The value, e.g. a number for a decimal editor, or a text.

##### params

\[`number`, `number`\]

The parameters of the rule, as the server sends them.

#### Returns

`boolean`

Whether the value is valid.

#### Overrides

[`ValidationRule`](ValidationRule.md).[`check`](ValidationRule.md#check)

***

### getDefaultText()

> **getDefaultText**(`params`): `string`

Defined in: [src/ui/helpers/builtinvalidationrules.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L52)

Gets the text of the message for when its key has no text, by default [defaultText](ValidationRule.md#defaulttext).

#### Parameters

##### params

\[`number`, `number`\]

The parameters of the rule.

#### Returns

`string`

#### Overrides

[`ValidationRule`](ValidationRule.md).[`getDefaultText`](ValidationRule.md#getdefaulttext)

***

### getMessageArgs()

> **getMessageArgs**(`params`): `any`[]

Defined in: [src/ui/helpers/builtinvalidationrules.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L57)

Gets what the message has as `{0}`, `{1}` and so on, by default the parameters of the rule.

#### Parameters

##### params

\[`number`, `number`\]

The parameters of the rule.

#### Returns

`any`[]

#### Overrides

[`ValidationRule`](ValidationRule.md).[`getMessageArgs`](ValidationRule.md#getmessageargs)

***

### getTextKey()

> **getTextKey**(`params`): `string`

Defined in: [src/ui/helpers/builtinvalidationrules.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/builtinvalidationrules.ts#L48)

Gets the local text key of the message, by default [textKey](ValidationRule.md#textkey), which a rule can choose by its parameters, e.g.
a length rule by whether it has a minimum.

#### Parameters

##### params

\[`number`, `number`\]

The parameters of the rule.

#### Returns

`string`

#### Overrides

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
