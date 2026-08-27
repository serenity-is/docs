# Web Security

This page covers the web-layer security helpers Serenity ships for template applications: **reCAPTCHA** (bot protection on public forms), **data-protector tokens** (for links like email confirmation / password reset), the **membership provider** helper, and **Content Security Policy** (CSP) support. The core permission/user model is covered in [Authentication & Authorization](authorization.md).

## reCAPTCHA

Serenity provides server-side reCAPTCHA integration for public forms such as sign-up. It uses Google reCAPTCHA **V2** keys.

### Configuration

[RecaptchaSettings](../api/dotnet/Serenity.Net.Core/Serenity.Web/RecaptchaSettings.md) holds the keys, bound from the `Recaptcha` configuration section (via `[DefaultSectionKey]`):

```json
{
  "Recaptcha": {
    "SiteKey": "your-site-key",
    "SecretKey": "your-secret-key"
  }
}
```

Get the keys from the [Google reCAPTCHA admin](https://www.google.com/recaptcha/admin/) — generate keys for V2, not V3.

### The [Recaptcha] editor

[RecaptchaAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/RecaptchaAttribute.md) marks a form property to use the `Recaptcha` editor type. In the template's `SignUpForm`:

```cs
[FormScript("Membership.SignUp")]
public class SignUpForm
{
    // ...
    // make sure you have configured Recaptcha:SiteKey and Recaptcha:SecretKey in appsettings.json
    [DisplayName(""), Recaptcha]
    public string Recaptcha { get; set; }
}
```

[RecaptchaPropertyProcessor](../api/dotnet/Serenity.Net.Web/Serenity.Web/RecaptchaPropertyProcessor.md) is a `PropertyProcessor` that runs when the form script is generated. It passes the configured `SiteKey` to the client-side editor via the `siteKey` editor parameter. If neither `SiteKey` nor `SecretKey` is configured, it hides the field and disables it (so the form still works without reCAPTCHA configured).

### Server-side validation

[RecaptchaValidation](../api/dotnet/Serenity.Net.Web/Serenity.Web/RecaptchaValidation.md) validates the token the client sends back. `Validate(secretKey, token, localizer)` posts the token to Google's `siteverify` endpoint and throws a `ValidationError` (code `Recaptcha`) if the token is empty or verification fails.

The template's sign-up action calls it only when reCAPTCHA is configured:

```cs
[HttpPost, JsonRequest]
public Result<SignUpResponse> SignUp(SignUpRequest request,
    [FromServices] IEmailSender emailSender,
    // ...
    [FromServices] IOptions<RecaptchaSettings> recaptchaOptions,
    // ...
)
{
    return this.UseConnection("Default", connection =>
    {
        ArgumentNullException.ThrowIfNull(request);

        if (!string.IsNullOrEmpty(recaptchaOptions?.Value?.SiteKey) ||
            !string.IsNullOrEmpty(recaptchaOptions?.Value?.SecretKey))
        {
            RecaptchaValidation.Validate(recaptchaOptions.Value.SecretKey, request.Recaptcha, Localizer);
        }
        // ...
    });
}
```

## Data-Protector Tokens

[DataProtectorBinaryTokenExtensions](../api/dotnet/Serenity.Net.Web/Serenity/DataProtectorBinaryTokenExtensions.md) extends ASP.NET Core's `IDataProtector` to create and read tokens that carry binary data:

- `ProtectBinary(callback)` — writes a token with a `BinaryWriter` (via the callback), protects it with the data protector, and returns it as a base64-url-encoded string.
- `UnprotectBinary(token)` — decodes and unprotects the token, returning a `BinaryReader` over the decrypted data.

These are used for one-time tokens in links — for example, email confirmation or password reset links that carry a user ID and an expiry. The token is opaque to the client and tamper-proof (it is encrypted/signed by the data protector).

## SiteMembershipProvider

[SiteMembershipProvider](../api/dotnet/Serenity.Net.Web/Serenity.Web.Providers/SiteMembershipProvider.md) is a legacy name — it used to be a membership provider but now only contains a single helper:

```cs
public static string ComputeSHA512(string s)
```

It computes the SHA512 hash of a string and returns it as base64 with padding stripped. It is used for hashing values that need a stable, non-reversible digest (e.g. comparing tokens or keys) without storing them in plain text.

## Content Security Policy (CSP)

Serenity's CSP support lives in `HtmlCspExtensions` — the `CspNonce()`, `AddCspDirective()`, and `GetCspDirective()` helpers that generate per-request nonces and build the CSP header/meta tag. These are documented with the layout helpers in [Script & CSS Bundling](script-bundling.md).

## See Also

- [Authentication & Authorization](authorization.md) — permissions, users, and the security service abstractions
- [Script & CSS Bundling](script-bundling.md) — CSP helpers (`HtmlCspExtensions`), nonces, and layout rendering
- [Antivirus Scan](../av.md) — ClamAV upload scanning
- [Feature Toggles](feature-toggles.md) — gating features behind toggles