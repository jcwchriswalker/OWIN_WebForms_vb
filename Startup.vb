Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Owin

<Assembly: OwinStartupAttribute(GetType(Startup))>

Partial Public Class Startup
    Public Sub Configuration(app As IAppBuilder)
        '  ConfigureAuth(app)
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
        .LoginPath = New PathString("/Login.aspx")})
    End Sub
End Class