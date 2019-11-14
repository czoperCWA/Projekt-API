using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Microsoft.Extensions.Configuration;
using Swizzer.Web.Infrustructure.Extensions;

namespace Swizzer.Web.Infrustructure.SQL
{
    public class SqlModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;
        public SqlModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void Load(ContainerBuilder builder)
        {
            var settings = _configuration.GetSettings<SqlSettings>();
            builder.RegisterInstance(settings)
                   .AsSelf()
                   .SingleInstance();
            builder.RegisterType<SwizzerContext>()
                   .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
