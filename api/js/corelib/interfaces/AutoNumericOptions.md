[@serenity-is/corelib](../README.md) / AutoNumericOptions

# Interface: AutoNumericOptions

Defined in: [src/ui/editors/autonumeric.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L40)

## Properties

### aDec?

> `optional` **aDec**: `string`

Defined in: [src/ui/editors/autonumeric.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L46)

allowed decimal separator characters
period "full stop" = '.'
comma = ','

#### Default

```ts
'.'
```

***

### aForm?

> `optional` **aForm**: `boolean`

Defined in: [src/ui/editors/autonumeric.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L62)

determine if the default value will be formatted on page ready.
true = automatically formats the default value on page ready
false = will not format the default value

#### Default

```ts
true
```

***

### altDec?

> `optional` **altDec**: `string`

Defined in: [src/ui/editors/autonumeric.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L56)

allow to declare alternative decimal separator which is automatically replaced by aDec
developed for countries the use a comma ',' as the decimal character
and have keyboards\numeric pads that have a period 'full stop' as the decimal characters (Spain is an example)

#### Default

```ts
null
```

***

### aNum?

> `optional` **aNum**: `string`

Defined in: [src/ui/editors/autonumeric.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L67)

allowed numeric values
please do not modify

#### Default

```ts
'0123456789'
```

***

### aPad?

> `optional` **aPad**: `boolean`

Defined in: [src/ui/editors/autonumeric.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L94)

controls decimal padding
aPad: true - always Pad decimals with zeros
aPad: false - does not pad with zeros.
aPad: `some number` - pad decimals with zero to number different from mDec
thanks to Jonas Johansson for the suggestion

#### Default

```ts
true
```

***

### aSep?

> `optional` **aSep**: `string`

Defined in: [src/ui/editors/autonumeric.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L81)

allowed thousand separator characters
comma = ','
period "full stop" = '.'
apostrophe is escaped = '\''
space = ' '
none = ''
NOTE: do not use numeric characters

#### Default

```ts
','
```

***

### aSign?

> `optional` **aSign**: `string`

Defined in: [src/ui/editors/autonumeric.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L86)

allowed currency symbol
Must be in quotes aSign: '$', a space is allowed aSign: '$ '

#### Default

```ts
''
```

***

### dGroup?

> `optional` **dGroup**: `string`

Defined in: [src/ui/editors/autonumeric.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L101)

digital grouping for the thousand separator used in Format
dGroup: '2', results in 99,99,99,999 common in India for values less than 1 billion and greater than -1 billion
dGroup: '3', results in 999,999,999 default
dGroup: '4', results in 9999,9999,9999 used in some Asian countries

#### Default

```ts
'3'
```

***

### holder?

> `optional` **holder**: `any`

Defined in: [src/ui/editors/autonumeric.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L103)

internal

***

### lZero?

> `optional` **lZero**: `string`

Defined in: [src/ui/editors/autonumeric.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L110)

controls leading zero behavior
lZero: 'allow', - allows leading zeros to be entered. Zeros will be truncated when entering additional digits. On focusout zeros will be deleted.
lZero: 'deny', - allows only one leading zero on values less than one
lZero: 'keep', - allows leading zeros to be entered. on fousout zeros will be retained.

#### Default

```ts
'allow'
```

***

### mDec?

> `optional` **mDec**: `number`

Defined in: [src/ui/editors/autonumeric.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L116)

max number of decimal places = used to override decimal places set by the vMin & vMax values
value must be enclosed in quotes example mDec: '3',
This can also set the value via a call back function mDec: 'css:#

#### Default

```ts
null
```

***

### mRound?

> `optional` **mRound**: `string`

Defined in: [src/ui/editors/autonumeric.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L131)

method used for rounding
mRound: 'S', Round-Half-Up Symmetric (default)
mRound: 'A', Round-Half-Up Asymmetric
mRound: 's', Round-Half-Down Symmetric (lower case s)
mRound: 'a', Round-Half-Down Asymmetric (lower case a)
mRound: 'B', Round-Half-Even "Bankers Rounding"
mRound: 'U', Round Up "Round-Away-From-Zero"
mRound: 'D', Round Down "Round-Toward-Zero" - same as truncate
mRound: 'C', Round to Ceiling "Toward Positive Infinity"
mRound: 'F', Round to Floor "Toward Negative Infinity"

#### Default

```ts
'S'
```

***

### nBracket?

> `optional` **nBracket**: `string`

Defined in: [src/ui/editors/autonumeric.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L137)

places brackets on negative value -$ 999.99 to (999.99)
visible only when the field does NOT have focus the left and right symbols should be enclosed in quotes and separated by a comma
nBracket: null, nBracket: '(,)', nBracket: '[,]', nBracket: '<,>' or nBracket: '{,}'

#### Default

```ts
null
```

***

### pSign?

> `optional` **pSign**: `string`

Defined in: [src/ui/editors/autonumeric.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L147)

placement of currency sign
for prefix pSign: 'p',
for suffix pSign: 's',

#### Default

```ts
'p'
```

***

### runOnce?

> `optional` **runOnce**: `boolean`

Defined in: [src/ui/editors/autonumeric.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L149)

internal

***

### vMax?

> `optional` **vMax**: `any`

Defined in: [src/ui/editors/autonumeric.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L161)

maximum possible value
value must be enclosed in quotes and use the period for the decimal point
value must be larger than vMin

#### Default

```ts
'9999999999999.99'
```

***

### vMin?

> `optional` **vMin**: `any`

Defined in: [src/ui/editors/autonumeric.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L167)

minimum possible value
value must be enclosed in quotes and use the period for the decimal point
value must be smaller than vMax

#### Default

```ts
'0.00'
```

***

### wEmpty?

> `optional` **wEmpty**: `string`

Defined in: [src/ui/editors/autonumeric.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L174)

Displayed on empty string
wEmpty: 'empty', - input can be blank
wEmpty: 'zero', - displays zero
wEmpty: 'sign', - displays the currency sign

#### Default

```ts
'empty'
```
