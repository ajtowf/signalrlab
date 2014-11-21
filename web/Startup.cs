using System.Configuration;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using web;

[assembly: OwinStartup(typeof(Startup))]
namespace web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.DependencyResolver.UseSqlServer(
                ConfigurationManager.ConnectionStrings["signalrlab"].ConnectionString);
            app.MapSignalR();
        }
    }
}