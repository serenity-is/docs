# CaptureLogConsts.UntilMax field

Gets the maximum value for the ValidUntil column.

```csharp
public static readonly DateTime UntilMax;
```

## Remarks

Stored as UTC. When used with a capture log row whose ValidUntil field has a different DateTimeKind, normalize it with DateTimeKind) (which keeps the clock) so the stored value and the close-active comparison stay identical.

## See Also

* class [CaptureLogConsts](../CaptureLogConsts.md)