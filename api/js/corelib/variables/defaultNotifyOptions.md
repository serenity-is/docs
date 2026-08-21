[@serenity-is/corelib](../README.md) / defaultNotifyOptions

# Variable: defaultNotifyOptions

> **defaultNotifyOptions**: [`ToastrOptions`](../type-aliases/ToastrOptions.md)

Defined in: [src/base/notify.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/notify.ts#L14)

Default options applied to every toast notification.
Individual calls may override these via their `options` argument.

## Remarks

Mutate this object to change application-wide notification defaults (e.g. timeout or position).

## Example

```ts
defaultNotifyOptions.timeOut = 3000;
defaultNotifyOptions.positionClass = "toast-top-right";
```
