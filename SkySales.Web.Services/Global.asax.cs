using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SkySales.Web.Services
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //lo primero que se ejecuta al arrancar la aplicación
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //la primera vez que inicias sessión
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //por cada request. Podemos usar esto para filtrar lo que nos viene en la request
            
            //tmb para comprimir/descomprimir archivos, i.e.: fotos
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            //tmb se usaría para mirar si tienes token, usuario, password
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //esto se ejecutará para cada exception que se lance en la aplicación
            //podríamos usarlo para tener el control de errores centralizado aquí
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //cuando cierro sesión
        }

        protected void Application_End(object sender, EventArgs e)
        {
            //cuando acaba la aplicación
        }
    }
}