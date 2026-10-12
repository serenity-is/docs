[@serenity-is/corelib](../README.md) / CriteriaOperator

# Enumeration: CriteriaOperator

Defined in: [src/base/criteria.ts:1009](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1009)

String constants for every operator that can appear in a Serenity criteria expression.

## Remarks

Values match the wire-format tokens accepted by the server (e.g. `"="`, `"like"`,
`"is null"`). Exposed also as [Criteria.Operator](../@serenity-is/namespaces/Criteria/variables/Operator.md) for convenience.

## Enumeration Members

### and

> **and**: `"and"`

Defined in: [src/base/criteria.ts:1021](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1021)

Logical AND (`and`).

***

### eq

> **eq**: `"="`

Defined in: [src/base/criteria.ts:1027](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1027)

Equality (`=`).

***

### exists

> **exists**: `"exists"`

Defined in: [src/base/criteria.ts:1019](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1019)

EXISTS (`exists`).

***

### ge

> **ge**: `">="`

Defined in: [src/base/criteria.ts:1033](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1033)

Greater than or equal (`>=`).

***

### gt

> **gt**: `">"`

Defined in: [src/base/criteria.ts:1031](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1031)

Greater than (`>`).

***

### in

> **in**: `"in"`

Defined in: [src/base/criteria.ts:1039](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1039)

IN (`in`).

***

### isNotNull

> **isNotNull**: `"is not null"`

Defined in: [src/base/criteria.ts:1017](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1017)

IS NOT NULL (`is not null`).

***

### isNull

> **isNull**: `"is null"`

Defined in: [src/base/criteria.ts:1015](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1015)

IS NULL (`is null`).

***

### le

> **le**: `"<="`

Defined in: [src/base/criteria.ts:1037](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1037)

Less than or equal (`<=`).

***

### like

> **like**: `"like"`

Defined in: [src/base/criteria.ts:1043](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1043)

LIKE (`like`).

***

### lt

> **lt**: `"<"`

Defined in: [src/base/criteria.ts:1035](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1035)

Less than (`<`).

***

### ne

> **ne**: `"!="`

Defined in: [src/base/criteria.ts:1029](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1029)

Not equal (`!=`).

***

### not

> **not**: `"not"`

Defined in: [src/base/criteria.ts:1013](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1013)

Logical NOT (`not`).

***

### notIn

> **notIn**: `"not in"`

Defined in: [src/base/criteria.ts:1041](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1041)

NOT IN (`not in`).

***

### notLike

> **notLike**: `"not like"`

Defined in: [src/base/criteria.ts:1045](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1045)

NOT LIKE (`not like`).

***

### or

> **or**: `"or"`

Defined in: [src/base/criteria.ts:1023](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1023)

Logical OR (`or`).

***

### paren

> **paren**: `"()"`

Defined in: [src/base/criteria.ts:1011](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1011)

Parentheses grouping `()` .

***

### xor

> **xor**: `"xor"`

Defined in: [src/base/criteria.ts:1025](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1025)

Logical XOR (`xor`).
