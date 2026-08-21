[@serenity-is/corelib](../README.md) / AutoNumericOptions

# Interface: AutoNumericOptions

Defined in: [src/ui/editors/autonumeric.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L23)

Options controlling AutoNumeric formatting, parsing and display behavior.

## Properties

### aDec?

> `optional` **aDec**: `string`

Defined in: [src/ui/editors/autonumeric.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L29)

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

Defined in: [src/ui/editors/autonumeric.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L45)

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

Defined in: [src/ui/editors/autonumeric.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L39)

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

Defined in: [src/ui/editors/autonumeric.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L50)

allowed numeric values
please do not modify

#### Default

```ts
'0123456789'
```

***

### aPad?

> `optional` **aPad**: `boolean`

Defined in: [src/ui/editors/autonumeric.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L77)

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

Defined in: [src/ui/editors/autonumeric.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L64)

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

Defined in: [src/ui/editors/autonumeric.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L69)

allowed currency symbol
Must be in quotes aSign: '$', a space is allowed aSign: '$ '

#### Default

```ts
''
```

***

### dGroup?

> `optional` **dGroup**: `string`

Defined in: [src/ui/editors/autonumeric.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L84)

digital grouping for the thousand separator used in Format
dGroup: '2', results in 99,99,99,999 common in India for values less than 1 billion and greater than -1 billion
dGroup: '3', results in 999,999,999 default
dGroup: '4', results in 9999,9999,9999 used in some Asian countries

#### Default

```ts
'3'
```

***

### lZero?

> `optional` **lZero**: `string`

Defined in: [src/ui/editors/autonumeric.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L93)

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

Defined in: [src/ui/editors/autonumeric.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L99)

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

Defined in: [src/ui/editors/autonumeric.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L114)

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

Defined in: [src/ui/editors/autonumeric.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L120)

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

Defined in: [src/ui/editors/autonumeric.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L130)

placement of currency sign
for prefix pSign: 'p',
for suffix pSign: 's',

#### Default

```ts
'p'
```

***

### vMax?

> `optional` **vMax**: `any`

Defined in: [src/ui/editors/autonumeric.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L144)

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

Defined in: [src/ui/editors/autonumeric.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L150)

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

Defined in: [src/ui/editors/autonumeric.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L157)

Displayed on empty string
wEmpty: 'empty', - input can be blank
wEmpty: 'zero', - displays zero
wEmpty: 'sign', - displays the currency sign

#### Default

```ts
'empty'
```
