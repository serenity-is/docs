[@serenity-is/corelib](../README.md) / CriteriaOperator

# Enumeration: CriteriaOperator

Defined in: [src/base/criteria.ts:803](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L803)

String constants for every operator that can appear in a Serenity criteria expression.

## Remarks

Values match the wire-format tokens accepted by the server (e.g. `"="`, `"like"`,
`"is null"`). Exposed also as [Criteria.Operator](../@serenity-is/namespaces/Criteria/variables/Operator.md) for convenience.

## Enumeration Members

### and

> **and**: `"and"`

Defined in: [src/base/criteria.ts:815](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L815)

Logical AND (`and`).

***

### eq

> **eq**: `"="`

Defined in: [src/base/criteria.ts:821](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L821)

Equality (`=`).

***

### exists

> **exists**: `"exists"`

Defined in: [src/base/criteria.ts:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L813)

EXISTS (`exists`).

***

### ge

> **ge**: `">="`

Defined in: [src/base/criteria.ts:827](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L827)

Greater than or equal (`>=`).

***

### gt

> **gt**: `">"`

Defined in: [src/base/criteria.ts:825](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L825)

Greater than (`>`).

***

### in

> **in**: `"in"`

Defined in: [src/base/criteria.ts:833](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L833)

IN (`in`).

***

### isNotNull

> **isNotNull**: `"is not null"`

Defined in: [src/base/criteria.ts:811](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L811)

IS NOT NULL (`is not null`).

***

### isNull

> **isNull**: `"is null"`

Defined in: [src/base/criteria.ts:809](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L809)

IS NULL (`is null`).

***

### le

> **le**: `"<="`

Defined in: [src/base/criteria.ts:831](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L831)

Less than or equal (`<=`).

***

### like

> **like**: `"like"`

Defined in: [src/base/criteria.ts:837](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L837)

LIKE (`like`).

***

### lt

> **lt**: `"<"`

Defined in: [src/base/criteria.ts:829](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L829)

Less than (`<`).

***

### ne

> **ne**: `"!="`

Defined in: [src/base/criteria.ts:823](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L823)

Not equal (`!=`).

***

### not

> **not**: `"not"`

Defined in: [src/base/criteria.ts:807](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L807)

Logical NOT (`not`).

***

### notIn

> **notIn**: `"not in"`

Defined in: [src/base/criteria.ts:835](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L835)

NOT IN (`not in`).

***

### notLike

> **notLike**: `"not like"`

Defined in: [src/base/criteria.ts:839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L839)

NOT LIKE (`not like`).

***

### or

> **or**: `"or"`

Defined in: [src/base/criteria.ts:817](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L817)

Logical OR (`or`).

***

### paren

> **paren**: `"()"`

Defined in: [src/base/criteria.ts:805](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L805)

Parentheses grouping `()` .

***

### xor

> **xor**: `"xor"`

Defined in: [src/base/criteria.ts:819](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L819)

Logical XOR (`xor`).
