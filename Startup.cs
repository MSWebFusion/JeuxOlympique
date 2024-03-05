using JeuxOlympique.Models;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection.Emit;
using System.Web.Services.Description;

[assembly: OwinStartupAttribute(typeof(JeuxOlympique.Startup))]
namespace JeuxOlympique
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }

   
}
