# 如何使用 Active Directory 或 LDAP 进行身份验证？

Serene 1.8.12+ 有一些基本的 ActiveDirectory / LDAP 集成示例。

若要启用它们，你必须在 web.config 配置为两者之一。

如果要启用 ActiveDirectory，则需要在 appSetting 添加 `ActiveDirectory` 键，内容如下：

```xml
<add key="ActiveDirectory" 
     value="{ Domain: 'youractivedirectorydomain' }" />
```

> 如果该配置在你的 Active Directory 服务器中不能工作，你则需要修改 *ActiveDirectoryService* 类。

当 AD 用户第一次尝试登录，Serene 使用配置的域对用户进行身份认证，检索用户详细信息并把具有类型`目录（directory）`的用户插入到用户（users）表。

AD 密码使用哈希算法加密，并且缓存用户信息一小时，所以用户可以在一小时内不用密码就可使用缓存凭据登录。 

在那之后，尝试从 AD 更新用户信息。如果发生错误，将允许用户使用缓存凭据登录。

这些细节可以在 AuthenticationService 类中查看并修改。 


若要启用 LDAP 身份认证（使用 OpenLDAP 测试），你需要在 web.config 的 appSetting 节点添加 `LDAP` 键：

```xml
<add key="LDAP" 
     value="{ 
        Host: '123.124.125.126', 
        Port: 389, 
        DistinguishedName: 'dc=yourdomain, dc=com', 
        Username: 'cn=someuserthatcanreadldap,ou=groupofthatuser,
                   dc=yourdomain,dc=com', 
        Password: 'passwordofthatuser'
     }" 
/>
```

> 再次，有许多不同  LDAP 服务器配置，所以如果你的配置不能正常工作，你可能需要修改 *LdapDirectoryService* 类。