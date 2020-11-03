using System;
using LoginAuth.Areas.Identity.Data;
using LoginAuth.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LoginAuth.Areas.Identity.IdentityHostingStartup))]
namespace LoginAuth.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LoginAuthContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LoginAuthContextConnection")));

                services.AddDefaultIdentity<LoginAuthUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<LoginAuthContext>();
            });
        }
    }
}