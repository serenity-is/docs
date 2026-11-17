[@serenity-is/corelib](../README.md) / ValidationRule

# Abstract Class: ValidationRule

Defined in: [src/base/validationrule.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L26)

The base of a validation rule that the forms check, for the fields whose properties have a validation attribute on the
server with the type key of the rule as its rule name, e.g. `Serenity.Pro.DataSources.DefinitionCodeValidationRule`. It is
found by its key in the type registry, see ValidationRuleTypeRegistry, so implementing LazyLoadInclude lets it be loaded on
demand by the forms that use it, wherever they are, instead of being imported by them.

## Example

```ts
export class EvenValidationRule extends ValidationRule implements LazyLoadInclude {
    static override [Symbol.typeInfo] = this.registerRule("MyApp.");
    override textKey = "Validation.Even";
    override defaultText = "Please enter an even number.";
    check(value: any) { return Number(value) % 2 === 0; }
}
```

## Extended by

- [`RangeValidationRule`](RangeValidationRule.md)
- [`LengthValidationRule`](LengthValidationRule.md)
- [`PatternValidationRule`](PatternValidationRule.md)
- [`EmailValidationRule`](EmailValidationRule.md)
- [`UrlValidationRule`](UrlValidationRule.md)
- [`CompareValidationRule`](CompareValidationRule.md)

## Constructors

### Constructor

> **new ValidationRule**(): `ValidationRule`

#### Returns

`ValidationRule`

## Properties

### defaultText?

> `optional` **defaultText**: `string` = `"Please enter a valid value."`

Defined in: [src/base/validationrule.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L34)

The text of the message for when its key has no text, e.g. the English one.

***

### textKey

> **textKey**: `string` = `"Validation.Invalid"`

Defined in: [src/base/validationrule.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L31)

The local text key of the message of the rule, which can have the parameters of the rule as `{0}`, `{1}`, used when
the attribute gives no message of its own.

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/base/validationrule.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L84)

## Methods

### check()

> `abstract` **check**(`value`, `params`, `context`): `boolean`

Defined in: [src/base/validationrule.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L44)

Checks a value by the rule. It is not called for an empty value, i.e. null, an empty string or an empty list, as
being required is a rule of its own.

#### Parameters

##### value

`any`

The value, e.g. a number for a decimal editor, or a text.

##### params

`any`

The parameters of the rule, as the server sends them.

##### context

[`ValidationRuleContext`](../interfaces/ValidationRuleContext.md)

The element and the other fields.

#### Returns

`boolean`

Whether the value is valid.

***

### getDefaultText()

> **getDefaultText**(`params`): `string`

Defined in: [src/base/validationrule.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L59)

Gets the text of the message for when its key has no text, by default [defaultText](#defaulttext).

#### Parameters

##### params

`any`

The parameters of the rule.

#### Returns

`string`

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

***

### getTextKey()

> **getTextKey**(`params`): `string`

Defined in: [src/base/validationrule.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L51)

Gets the local text key of the message, by default [textKey](#textkey), which a rule can choose by its parameters, e.g.
a length rule by whether it has a minimum.

#### Parameters

##### params

`any`

The parameters of the rule.

#### Returns

`string`

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
