# How To: Authenticate With Active Directory or LDAP

Serene 1.8.12+ has some basic ActiveDirectory / LDAP integration samples.

To enable them, you have to fill one of web.config settings.

For ActiveDirectory add a appSetting key `ActiveDirectory` with contents like below:

```xml
<add key="ActiveDirectory" 
     value="{ Domain: 'youractivedirectorydomain' }" />
```

> If this doesn't work for your Active Directory server out of the box, you might have to modify *ActiveDirectoryService* class.

When a AD user tries to login first time, Serene authenticates user with this domain, retrieves user details and inserts a user with type `directory` into users table.

AD password hash and user information is cached for one hour, so for one hour user can login with cached credentials, without even hitting AD. 

After that, user information is tried to be updated from AD. If an error occurs, user will be allowed to login with cached credentials.

These details can be seen and modified in AuthenticationService class.


To enable LDAP authentication (tested with OpenLDAP) you need to add a appSetting key `LDAP` to web.config:

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

> Again, there are many different configurations of LDAP servers out there, so if this doesn't work for you, you might have to modify *LdapDirectoryService* class.