using System.Configuration;
using api;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace api
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