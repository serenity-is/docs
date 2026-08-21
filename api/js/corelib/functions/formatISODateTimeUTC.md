[@serenity-is/corelib](../README.md) / formatISODateTimeUTC

# Function: formatISODateTimeUTC()

> **formatISODateTimeUTC**(`d`): `string`

Defined in: [src/base/formatting.ts:855](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L855)

Formats a date as an ISO 8601 UTC timestamp (`yyyy-MM-ddTHH:mm:ss.sssZ`).

## Parameters

### d

`Date`

Date to format. `null` / `undefined` yields `""`.

## Returns

`string`

The UTC ISO string with zero-padded components, or `""` for nullish input.
