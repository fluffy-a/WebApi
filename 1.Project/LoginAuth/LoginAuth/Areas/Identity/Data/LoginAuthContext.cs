using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginAuth.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Azure.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Outlook;
using Microsoft.VisualStudio.Services.Account;
using Account = Microsoft.VisualStudio.Services.Account.Account;

namespace LoginAuth.Data
{
    public class LoginAuthContext : IdentityDbContext<LoginAuthUser>
    {
        public LoginAuthContext(DbContextOptions<LoginAuthContext> options)
            : base(options)
        {
        }
       




        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
