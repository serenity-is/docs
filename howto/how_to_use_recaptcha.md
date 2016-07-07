# 如何使用验证码？

要在登录窗体中使用验证码，请按照这些步骤操作：

> 要求 Serenity 1.8.5+ 

> 你可能在其他窗体也使用验证码功能，但这里以登录为例。

首先，你需要到 Recaptcha 注册一个新网站：

> https://www.google.com/recaptcha/admin

一旦你有了站点密钥（site key）和 安全密钥（secret key），就可在 web.config/appSettings 中配置：

```xml
<add key="Recaptcha" value="{ 
    SiteKey: '6LeIxAcTAAAAAJcZVRqyHh71UMIEGNQ_MXjiZKhI', 
    SecretKey: '6LeIxAcTAAAAAGG-vFI1TnRWxMZNFuojJ4WifJWe' }" />
```

> 上面列出的密钥仅供测试，请不要将其应用到实际产品。

编辑 LoginForm.cs，并添加 Recaptcha 属性：

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

编辑 LoginRequest.cs，并添加 Recaptcha 属性：

```
public class LoginRequest : ServiceRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Recaptcha { get; set; }
}
```

编辑 AccountPage.cs 的 Login 方法，在此对验证码进行验证：


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