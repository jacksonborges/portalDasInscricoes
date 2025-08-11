using Microsoft.EntityFrameworkCore;
using PortalDasInscricoes.Business.Util;
using PortalDasInscricoes.Repository.Context;

namespace portalDasInscricoes
{
    public static class DependencyInjection
    {
        public static WebApplicationBuilder ConfigureDI(this WebApplicationBuilder builder)
        {
            Settings.IS_DESENV = builder.Configuration["Ambiente"] == "2";

            builder.Services.AddDbContext<DbPortalDasIncricoesContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("PortalDasInscricoesConnectionString")));
           
            return builder;
        }

        public static async Task<WebApplication> ConfigureSettingsAsync(this WebApplication webApplication)
        {
            using (var serviceScope = webApplication.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
            }

            return webApplication;
        }
    }
}

