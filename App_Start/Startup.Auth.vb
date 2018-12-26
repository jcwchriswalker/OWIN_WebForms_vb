Imports System
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.Owin.Security.DataProtection
Imports Microsoft.Owin.Host.SystemWeb
Imports Owin

Partial Public Class Startup

    Public Sub ConfigureAuth(app As IAppBuilder)
        app.UseCookieAuthentication(New CookieAuthenticationOptions With
            {
                .AuthenticationType = "ApplicationCookie",
                .LoginPath = New PathString("/Login.aspx")
            })
    End Sub

End Class

