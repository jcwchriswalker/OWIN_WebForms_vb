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

    ' For more information on configuring authentication, please visit https://go.microsoft.com/fwlink/?LinkId=301883
    Public Sub ConfigureAuthSFO(app As IAppBuilder)
        ' need to add UserManager into owin, because this Is used in cookie invalidation
        app.UseCookieAuthentication(New CookieAuthenticationOptions With
            {
                .AuthenticationType = "ApplicationCookie",
                .LoginPath = New PathString("/Login.aspx")
            })
    End Sub

End Class

