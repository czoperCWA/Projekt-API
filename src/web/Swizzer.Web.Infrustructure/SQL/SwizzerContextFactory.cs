using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;
using Swizzer.Web.Infrustructure.Extensions;
using Microsoft.EntityFrameworkCore.Design;

namespace Swizzer.Web.Infrustructure.SQL
{
    public class SwizzerContextFactory : IDesignTimeDbContextFactory<SwizzerContext>
    {
        public SwizzerContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var sqlSettings = configuration.GetSettings<SqlSettings>();
            return new SwizzerContext(sqlSettings);
        }
    }
}
