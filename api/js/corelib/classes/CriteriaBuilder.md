[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / CriteriaBuilder

# Class: CriteriaBuilder

CriteriaBuilder is a class that allows to build unary or binary criteria with completion support.

## Hierarchy

- `Array`

  ↳ **`CriteriaBuilder`**

## Table of contents

### Constructors

- [constructor](CriteriaBuilder.md#constructor)

### Properties

- [length](CriteriaBuilder.md#length)
- [[species]](CriteriaBuilder.md#[species])

### Methods

- [[iterator]](CriteriaBuilder.md#[iterator])
- [[unscopables]](CriteriaBuilder.md#[unscopables])
- [bw](CriteriaBuilder.md#bw)
- [concat](CriteriaBuilder.md#concat)
- [contains](CriteriaBuilder.md#contains)
- [copyWithin](CriteriaBuilder.md#copywithin)
- [endsWith](CriteriaBuilder.md#endswith)
- [entries](CriteriaBuilder.md#entries)
- [eq](CriteriaBuilder.md#eq)
- [every](CriteriaBuilder.md#every)
- [fill](CriteriaBuilder.md#fill)
- [filter](CriteriaBuilder.md#filter)
- [find](CriteriaBuilder.md#find)
- [findIndex](CriteriaBuilder.md#findindex)
- [forEach](CriteriaBuilder.md#foreach)
- [ge](CriteriaBuilder.md#ge)
- [gt](CriteriaBuilder.md#gt)
- [in](CriteriaBuilder.md#in)
- [indexOf](CriteriaBuilder.md#indexof)
- [isNotNull](CriteriaBuilder.md#isnotnull)
- [isNull](CriteriaBuilder.md#isnull)
- [join](CriteriaBuilder.md#join)
- [keys](CriteriaBuilder.md#keys)
- [lastIndexOf](CriteriaBuilder.md#lastindexof)
- [le](CriteriaBuilder.md#le)
- [like](CriteriaBuilder.md#like)
- [lt](CriteriaBuilder.md#lt)
- [map](CriteriaBuilder.md#map)
- [ne](CriteriaBuilder.md#ne)
- [notIn](CriteriaBuilder.md#notin)
- [notLike](CriteriaBuilder.md#notlike)
- [pop](CriteriaBuilder.md#pop)
- [push](CriteriaBuilder.md#push)
- [reduce](CriteriaBuilder.md#reduce)
- [reduceRight](CriteriaBuilder.md#reduceright)
- [reverse](CriteriaBuilder.md#reverse)
- [shift](CriteriaBuilder.md#shift)
- [slice](CriteriaBuilder.md#slice)
- [some](CriteriaBuilder.md#some)
- [sort](CriteriaBuilder.md#sort)
- [splice](CriteriaBuilder.md#splice)
- [startsWith](CriteriaBuilder.md#startswith)
- [toLocaleString](CriteriaBuilder.md#tolocalestring)
- [toString](CriteriaBuilder.md#tostring)
- [unshift](CriteriaBuilder.md#unshift)
- [values](CriteriaBuilder.md#values)
- [from](CriteriaBuilder.md#from)
- [isArray](CriteriaBuilder.md#isarray)
- [of](CriteriaBuilder.md#of)

## Constructors

### constructor

• **new CriteriaBuilder**(`arrayLength?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `arrayLength?` | `number` |

#### Inherited from

Array.constructor

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1485

## Properties

### length

• **length**: `number`

Gets or sets the length of the array. This is a number one higher than the highest index in the array.

#### Inherited from

Array.length

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1304

___

### [species]

▪ `Static` `Readonly` **[species]**: `ArrayConstructor`

#### Inherited from

Array.[species]

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.symbol.wellknown.d.ts:314

## Methods

### [iterator]

▸ **[iterator]**(): `IterableIterator`<`any`\>

Iterator

#### Returns

`IterableIterator`<`any`\>

#### Inherited from

Array.[iterator]

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.iterable.d.ts:60

___

### [unscopables]

▸ **[unscopables]**(): `Object`

Returns an object whose properties have the value 'true'
when they will be absent when used in a 'with' statement.

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `copyWithin` | `boolean` |
| `entries` | `boolean` |
| `fill` | `boolean` |
| `find` | `boolean` |
| `findIndex` | `boolean` |
| `keys` | `boolean` |
| `values` | `boolean` |

#### Inherited from

Array.[unscopables]

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.symbol.wellknown.d.ts:99

___

### bw

▸ **bw**(`fromInclusive`, `toInclusive`): `any`[]

Creates a between criteria.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `fromInclusive` | `any` | from value |
| `toInclusive` | `any` | to value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L10)

___

### concat

▸ **concat**(`...items`): `any`[]

Combines two or more arrays.
This method returns a new array without modifying any existing arrays.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `...items` | `ConcatArray`<`any`\>[] | Additional arrays and/or items to add to the end of the array. |

#### Returns

`any`[]

#### Inherited from

Array.concat

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1328

▸ **concat**(`...items`): `any`[]

Combines two or more arrays.
This method returns a new array without modifying any existing arrays.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `...items` | `any`[] | Additional arrays and/or items to add to the end of the array. |

#### Returns

`any`[]

#### Inherited from

Array.concat

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1334

___

### contains

▸ **contains**(`value`): `any`[]

Creates a contains criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` | contains value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L18)

___

### copyWithin

▸ **copyWithin**(`target`, `start`, `end?`): [`CriteriaBuilder`](CriteriaBuilder.md)

Returns the this object after copying a section of the array identified by start and end
to the same array starting at position target

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `target` | `number` | If target is negative, it is treated as length+target where length is the length of the array. |
| `start` | `number` | If start is negative, it is treated as length+start. If end is negative, it is treated as length+end. |
| `end?` | `number` | If not specified, length of the this object is used as its default value. |

#### Returns

[`CriteriaBuilder`](CriteriaBuilder.md)

#### Inherited from

Array.copyWithin

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.core.d.ts:64

___

### endsWith

▸ **endsWith**(`value`): `any`[]

Creates a endsWith criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` | endsWith value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L26)

___

### entries

▸ **entries**(): `IterableIterator`<[`number`, `any`]\>

Returns an iterable of key, value pairs for every entry in the array

#### Returns

`IterableIterator`<[`number`, `any`]\>

#### Inherited from

Array.entries

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.iterable.d.ts:65

___

### eq

▸ **eq**(`value`): `any`[]

Creates an equal (=) criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | equal value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L34)

___

### every

▸ **every**<`S`\>(`predicate`, `thisArg?`): this is S[]

Determines whether all the members of an array satisfy the specified test.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `S` | extends `any` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `predicate` | (`value`: `any`, `index`: `number`, `array`: `any`[]) => value is S | A function that accepts up to three arguments. The every method calls the predicate function for each element in the array until the predicate returns a value which is coercible to the Boolean value false, or until the end of the array. |
| `thisArg?` | `any` | An object to which the this keyword can refer in the predicate function. If thisArg is omitted, undefined is used as the this value. |

#### Returns

this is S[]

#### Inherited from

Array.every

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1411

▸ **every**(`predicate`, `thisArg?`): `boolean`

Determines whether all the members of an array satisfy the specified test.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `predicate` | (`value`: `any`, `index`: `number`, `array`: `any`[]) => `unknown` | A function that accepts up to three arguments. The every method calls the predicate function for each element in the array until the predicate returns a value which is coercible to the Boolean value false, or until the end of the array. |
| `thisArg?` | `any` | An object to which the this keyword can refer in the predicate function. If thisArg is omitted, undefined is used as the this value. |

#### Returns

`boolean`

#### Inherited from

Array.every

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1420

___

### fill

▸ **fill**(`value`, `start?`, `end?`): [`CriteriaBuilder`](CriteriaBuilder.md)

Changes all array elements from `start` to `end` index to a static `value` and returns the modified array

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | value to fill array section with |
| `start?` | `number` | index to start filling the array at. If start is negative, it is treated as length+start where length is the length of the array. |
| `end?` | `number` | index to stop filling the array at. If end is negative, it is treated as length+end. |

#### Returns

[`CriteriaBuilder`](CriteriaBuilder.md)

#### Inherited from

Array.fill

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.core.d.ts:53

___

### filter

▸ **filter**<`S`\>(`predicate`, `thisArg?`): `S`[]

Returns the elements of an array that meet the condition specified in a callback function.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `S` | extends `any` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `predicate` | (`value`: `any`, `index`: `number`, `array`: `any`[]) => value is S | A function that accepts up to three arguments. The filter method calls the predicate function one time for each element in the array. |
| `thisArg?` | `any` | An object to which the this keyword can refer in the predicate function. If thisArg is omitted, undefined is used as the this value. |

#### Returns

`S`[]

#### Inherited from

Array.filter

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1447

▸ **filter**(`predicate`, `thisArg?`): `any`[]

Returns the elements of an array that meet the condition specified in a callback function.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `predicate` | (`value`: `any`, `index`: `number`, `array`: `any`[]) => `unknown` | A function that accepts up to three arguments. The filter method calls the predicate function one time for each element in the array. |
| `thisArg?` | `any` | An object to which the this keyword can refer in the predicate function. If thisArg is omitted, undefined is used as the this value. |

#### Returns

`any`[]

#### Inherited from

Array.filter

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1453

___

### find

▸ **find**<`S`\>(`predicate`, `thisArg?`): `S`

Returns the value of the first element in the array where predicate is true, and undefined
otherwise.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `S` | extends `any` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `predicate` | (`this`: `void`, `value`: `any`, `index`: `number`, `obj`: `any`[]) => value is S | find calls predicate once for each element of the array, in ascending order, until it finds one where predicate returns true. If such an element is found, find immediately returns that element value. Otherwise, find returns undefined. |
| `thisArg?` | `any` | If provided, it will be used as the this value for each invocation of predicate. If it is not provided, undefined is used instead. |

#### Returns

`S`

#### Inherited from

Array.find

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.core.d.ts:31

▸ **find**(`predicate`, `thisArg?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `predicate` | (`value`: `any`, `index`: `number`, `obj`: `any`[]) => `unknown` |
| `thisArg?` | `any` |

#### Returns

`any`

#### Inherited from

Array.find

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.core.d.ts:32

___

### findIndex

▸ **findIndex**(`predicate`, `thisArg?`): `number`

Returns the index of the first element in the array where predicate is true, and -1
otherwise.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `predicate` | (`value`: `any`, `index`: `number`, `obj`: `any`[]) => `unknown` | find calls predicate once for each element of the array, in ascending order, until it finds one where predicate returns true. If such an element is found, findIndex immediately returns that element index. Otherwise, findIndex returns -1. |
| `thisArg?` | `any` | If provided, it will be used as the this value for each invocation of predicate. If it is not provided, undefined is used instead. |

#### Returns

`number`

#### Inherited from

Array.findIndex

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.core.d.ts:43

___

### forEach

▸ **forEach**(`callbackfn`, `thisArg?`): `void`

Performs the specified action for each element in an array.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `callbackfn` | (`value`: `any`, `index`: `number`, `array`: `any`[]) => `void` | A function that accepts up to three arguments. forEach calls the callbackfn function one time for each element in the array. |
| `thisArg?` | `any` | An object to which the this keyword can refer in the callbackfn function. If thisArg is omitted, undefined is used as the this value. |

#### Returns

`void`

#### Inherited from

Array.forEach

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1435

___

### ge

▸ **ge**(`value`): `any`[]

Creates a greater than or equal criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | greater than or equal value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L50)

___

### gt

▸ **gt**(`value`): `any`[]

Creates a greater than criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | greater than value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L42)

___

### in

▸ **in**(`values`): `any`[]

Creates a in criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `values` | `any`[] | in values |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L58)

___

### indexOf

▸ **indexOf**(`searchElement`, `fromIndex?`): `number`

Returns the index of the first occurrence of a value in an array, or -1 if it is not present.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `searchElement` | `any` | The value to locate in the array. |
| `fromIndex?` | `number` | The array index at which to begin the search. If fromIndex is omitted, the search starts at index 0. |

#### Returns

`number`

#### Inherited from

Array.indexOf

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1396

___

### isNotNull

▸ **isNotNull**(): `any`[]

Creates a IS NOT NULL criteria

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L72)

___

### isNull

▸ **isNull**(): `any`[]

Creates a IS NULL criteria

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L65)

___

### join

▸ **join**(`separator?`): `string`

Adds all the elements of an array into a string, separated by the specified separator string.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `separator?` | `string` | A string used to separate one element of the array from the next in the resulting string. If omitted, the array elements are separated with a comma. |

#### Returns

`string`

#### Inherited from

Array.join

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1339

___

### keys

▸ **keys**(): `IterableIterator`<`number`\>

Returns an iterable of keys in the array

#### Returns

`IterableIterator`<`number`\>

#### Inherited from

Array.keys

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.iterable.d.ts:70

___

### lastIndexOf

▸ **lastIndexOf**(`searchElement`, `fromIndex?`): `number`

Returns the index of the last occurrence of a specified value in an array, or -1 if it is not present.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `searchElement` | `any` | The value to locate in the array. |
| `fromIndex?` | `number` | The array index at which to begin searching backward. If fromIndex is omitted, the search starts at the last index in the array. |

#### Returns

`number`

#### Inherited from

Array.lastIndexOf

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1402

___

### le

▸ **le**(`value`): `any`[]

Creates a less than or equal to criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | less than or equal to value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L80)

___

### like

▸ **like**(`value`): `any`[]

Creates a LIKE criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | like value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L104)

___

### lt

▸ **lt**(`value`): `any`[]

Creates a less than criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | less than value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L88)

___

### map

▸ **map**<`U`\>(`callbackfn`, `thisArg?`): `U`[]

Calls a defined callback function on each element of an array, and returns an array that contains the results.

#### Type parameters

| Name |
| :------ |
| `U` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `callbackfn` | (`value`: `any`, `index`: `number`, `array`: `any`[]) => `U` | A function that accepts up to three arguments. The map method calls the callbackfn function one time for each element in the array. |
| `thisArg?` | `any` | An object to which the this keyword can refer in the callbackfn function. If thisArg is omitted, undefined is used as the this value. |

#### Returns

`U`[]

#### Inherited from

Array.map

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1441

___

### ne

▸ **ne**(`value`): `any`[]

Creates a not equal criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | not equal value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L96)

___

### notIn

▸ **notIn**(`values`): `any`[]

Creates a NOT IN criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `values` | `any`[] | array of NOT IN values |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L120)

___

### notLike

▸ **notLike**(`value`): `any`[]

Creates a NOT LIKE criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | not like value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L128)

___

### pop

▸ **pop**(): `any`

Removes the last element from an array and returns it.
If the array is empty, undefined is returned and the array is not modified.

#### Returns

`any`

#### Inherited from

Array.pop

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1317

___

### push

▸ **push**(`...items`): `number`

Appends new elements to the end of an array, and returns the new length of the array.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `...items` | `any`[] | New elements to add to the array. |

#### Returns

`number`

#### Inherited from

Array.push

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1322

___

### reduce

▸ **reduce**(`callbackfn`): `any`

Calls the specified callback function for all the elements in an array. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `callbackfn` | (`previousValue`: `any`, `currentValue`: `any`, `currentIndex`: `number`, `array`: `any`[]) => `any` | A function that accepts up to four arguments. The reduce method calls the callbackfn function one time for each element in the array. |

#### Returns

`any`

#### Inherited from

Array.reduce

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1459

▸ **reduce**(`callbackfn`, `initialValue`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callbackfn` | (`previousValue`: `any`, `currentValue`: `any`, `currentIndex`: `number`, `array`: `any`[]) => `any` |
| `initialValue` | `any` |

#### Returns

`any`

#### Inherited from

Array.reduce

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1460

▸ **reduce**<`U`\>(`callbackfn`, `initialValue`): `U`

Calls the specified callback function for all the elements in an array. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.

#### Type parameters

| Name |
| :------ |
| `U` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `callbackfn` | (`previousValue`: `U`, `currentValue`: `any`, `currentIndex`: `number`, `array`: `any`[]) => `U` | A function that accepts up to four arguments. The reduce method calls the callbackfn function one time for each element in the array. |
| `initialValue` | `U` | If initialValue is specified, it is used as the initial value to start the accumulation. The first call to the callbackfn function provides this value as an argument instead of an array value. |

#### Returns

`U`

#### Inherited from

Array.reduce

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1466

___

### reduceRight

▸ **reduceRight**(`callbackfn`): `any`

Calls the specified callback function for all the elements in an array, in descending order. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `callbackfn` | (`previousValue`: `any`, `currentValue`: `any`, `currentIndex`: `number`, `array`: `any`[]) => `any` | A function that accepts up to four arguments. The reduceRight method calls the callbackfn function one time for each element in the array. |

#### Returns

`any`

#### Inherited from

Array.reduceRight

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1472

▸ **reduceRight**(`callbackfn`, `initialValue`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callbackfn` | (`previousValue`: `any`, `currentValue`: `any`, `currentIndex`: `number`, `array`: `any`[]) => `any` |
| `initialValue` | `any` |

#### Returns

`any`

#### Inherited from

Array.reduceRight

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1473

▸ **reduceRight**<`U`\>(`callbackfn`, `initialValue`): `U`

Calls the specified callback function for all the elements in an array, in descending order. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.

#### Type parameters

| Name |
| :------ |
| `U` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `callbackfn` | (`previousValue`: `U`, `currentValue`: `any`, `currentIndex`: `number`, `array`: `any`[]) => `U` | A function that accepts up to four arguments. The reduceRight method calls the callbackfn function one time for each element in the array. |
| `initialValue` | `U` | If initialValue is specified, it is used as the initial value to start the accumulation. The first call to the callbackfn function provides this value as an argument instead of an array value. |

#### Returns

`U`

#### Inherited from

Array.reduceRight

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1479

___

### reverse

▸ **reverse**(): `any`[]

Reverses the elements in an array in place.
This method mutates the array and returns a reference to the same array.

#### Returns

`any`[]

#### Inherited from

Array.reverse

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1344

___

### shift

▸ **shift**(): `any`

Removes the first element from an array and returns it.
If the array is empty, undefined is returned and the array is not modified.

#### Returns

`any`

#### Inherited from

Array.shift

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1349

___

### slice

▸ **slice**(`start?`, `end?`): `any`[]

Returns a copy of a section of an array.
For both start and end, a negative index can be used to indicate an offset from the end of the array.
For example, -2 refers to the second to last element of the array.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `start?` | `number` | The beginning index of the specified portion of the array. If start is undefined, then the slice begins at index 0. |
| `end?` | `number` | The end index of the specified portion of the array. This is exclusive of the element at the index 'end'. If end is undefined, then the slice extends to the end of the array. |

#### Returns

`any`[]

#### Inherited from

Array.slice

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1359

___

### some

▸ **some**(`predicate`, `thisArg?`): `boolean`

Determines whether the specified callback function returns true for any element of an array.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `predicate` | (`value`: `any`, `index`: `number`, `array`: `any`[]) => `unknown` | A function that accepts up to three arguments. The some method calls the predicate function for each element in the array until the predicate returns a value which is coercible to the Boolean value true, or until the end of the array. |
| `thisArg?` | `any` | An object to which the this keyword can refer in the predicate function. If thisArg is omitted, undefined is used as the this value. |

#### Returns

`boolean`

#### Inherited from

Array.some

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1429

___

### sort

▸ **sort**(`compareFn?`): [`CriteriaBuilder`](CriteriaBuilder.md)

Sorts an array in place.
This method mutates the array and returns a reference to the same array.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `compareFn?` | (`a`: `any`, `b`: `any`) => `number` | Function used to determine the order of the elements. It is expected to return a negative value if the first argument is less than the second argument, zero if they're equal, and a positive value otherwise. If omitted, the elements are sorted in ascending, ASCII character order. ```ts [11,2,22,1].sort((a, b) => a - b) ``` |

#### Returns

[`CriteriaBuilder`](CriteriaBuilder.md)

#### Inherited from

Array.sort

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1370

___

### splice

▸ **splice**(`start`, `deleteCount?`): `any`[]

Removes elements from an array and, if necessary, inserts new elements in their place, returning the deleted elements.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `start` | `number` | The zero-based location in the array from which to start removing elements. |
| `deleteCount?` | `number` | The number of elements to remove. |

#### Returns

`any`[]

An array containing the elements that were deleted.

#### Inherited from

Array.splice

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1377

▸ **splice**(`start`, `deleteCount`, `...items`): `any`[]

Removes elements from an array and, if necessary, inserts new elements in their place, returning the deleted elements.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `start` | `number` | The zero-based location in the array from which to start removing elements. |
| `deleteCount` | `number` | The number of elements to remove. |
| `...items` | `any`[] | Elements to insert into the array in place of the deleted elements. |

#### Returns

`any`[]

An array containing the elements that were deleted.

#### Inherited from

Array.splice

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1385

___

### startsWith

▸ **startsWith**(`value`): `any`[]

Creates a STARTS WITH criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` | startsWith value |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L112)

___

### toLocaleString

▸ **toLocaleString**(): `string`

Returns a string representation of an array. The elements are converted to string using their toLocaleString methods.

#### Returns

`string`

#### Inherited from

Array.toLocaleString

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1312

___

### toString

▸ **toString**(): `string`

Returns a string representation of an array.

#### Returns

`string`

#### Inherited from

Array.toString

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1308

___

### unshift

▸ **unshift**(`...items`): `number`

Inserts new elements at the start of an array, and returns the new length of the array.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `...items` | `any`[] | Elements to insert at the start of the array. |

#### Returns

`number`

#### Inherited from

Array.unshift

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1390

___

### values

▸ **values**(): `IterableIterator`<`any`\>

Returns an iterable of values in the array

#### Returns

`IterableIterator`<`any`\>

#### Inherited from

Array.values

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.iterable.d.ts:75

___

### from

▸ `Static` **from**<`T`\>(`arrayLike`): `T`[]

Creates an array from an array-like object.

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `arrayLike` | `ArrayLike`<`T`\> | An array-like object to convert to an array. |

#### Returns

`T`[]

#### Inherited from

Array.from

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.core.d.ts:72

▸ `Static` **from**<`T`, `U`\>(`arrayLike`, `mapfn`, `thisArg?`): `U`[]

Creates an array from an iterable object.

#### Type parameters

| Name |
| :------ |
| `T` |
| `U` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `arrayLike` | `ArrayLike`<`T`\> | An array-like object to convert to an array. |
| `mapfn` | (`v`: `T`, `k`: `number`) => `U` | A mapping function to call on every element of the array. |
| `thisArg?` | `any` | Value of 'this' used to invoke the mapfn. |

#### Returns

`U`[]

#### Inherited from

Array.from

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.core.d.ts:80

▸ `Static` **from**<`T`\>(`iterable`): `T`[]

Creates an array from an iterable object.

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `iterable` | `Iterable`<`T`\> \| `ArrayLike`<`T`\> | An iterable object to convert to an array. |

#### Returns

`T`[]

#### Inherited from

Array.from

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.iterable.d.ts:83

▸ `Static` **from**<`T`, `U`\>(`iterable`, `mapfn`, `thisArg?`): `U`[]

Creates an array from an iterable object.

#### Type parameters

| Name |
| :------ |
| `T` |
| `U` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `iterable` | `Iterable`<`T`\> \| `ArrayLike`<`T`\> | An iterable object to convert to an array. |
| `mapfn` | (`v`: `T`, `k`: `number`) => `U` | A mapping function to call on every element of the array. |
| `thisArg?` | `any` | Value of 'this' used to invoke the mapfn. |

#### Returns

`U`[]

#### Inherited from

Array.from

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.iterable.d.ts:91

___

### isArray

▸ `Static` **isArray**(`arg`): arg is any[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `arg` | `any` |

#### Returns

arg is any[]

#### Inherited from

Array.isArray

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es5.d.ts:1491

___

### of

▸ `Static` **of**<`T`\>(`...items`): `T`[]

Returns a new array from a set of elements.

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `...items` | `T`[] | A set of elements to include in the new array object. |

#### Returns

`T`[]

#### Inherited from

Array.of

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@4.9.3/node_modules/typescript/lib/lib.es2015.core.d.ts:86
