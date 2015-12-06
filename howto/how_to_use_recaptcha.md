# How To: Use Recaptcha

To use Recaptcha in login form, follow these steps:

> Requires Serenity 1.8.5+

> You might also use it for another form, but this is just a sample for login.

First, you need to register a new site for Recaptcha at:

> https://www.google.com/recaptcha/admin

Once you have your site key, and secret key, enter them in web.config/appSettings section:

```xml
<add key="Recaptcha" value="{ 
    SiteKey: '6LeIxAcTAAAAAJcZVRqyHh71UMIEGNQ_MXjiZKhI', 
    SecretKey: '6LeIxAcTAAAAAGG-vFI1TnRWxMZNFuojJ4WifJWe' }" />
```

> The keys listed above are only for testing purposes. Never use them in production.

Edit LoginForm.cs to add a Recaptcha property:

```cs
public class LoginForm
{
    [Placeholder("default username is 'admin'")]
    public String Username { get; set; }
    [PasswordEditor, Placeholder("default password for admin user is 'serenity'"), Required(true)]
    public String Password { get; set; }
    [DisplayName(""), Recaptcha]
    public string Recaptcha { get; set; }
}
```

Edit LoginRequest.cs to add a Recaptcha property:

```
public class LoginRequest : ServiceRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Recaptcha { get; set; }
}
```

Edit Login method under AccountPage.cs to validate the captcha server side:


```cs
[HttpPost, JsonFilter]
public Result<ServiceResponse> Login(LoginRequest request)
{
    return this.ExecuteMethod(() =>
    {
        request.CheckNotNull();

        if (string.IsNullOrEmpty(request.Username))
            throw new ArgumentNullException("username");

        var username = request.Username;

        // just add line below
        Serenity.Web.RecaptchaValidation.Validate(request.Recaptcha);
        
        if (WebSecurityHelper.Authenticate(ref username, request.Password, false))
            return new ServiceResponse();

        throw new ValidationError("AuthenticationError",
            Texts.Validation.AuthenticationError);
    });
}
```